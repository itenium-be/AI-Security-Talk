<template>
  <div class="flex justify-center items-center mt-8">
    <div class="relative" style="width: 550px; height: 420px;">
      <!-- Top vertex: Private Data -->
      <div v-click class="absolute left-1/2 -translate-x-1/2 top-0 text-center">
        <div class="bg-white/90 backdrop-blur rounded-xl p-3 border border-gray-300 text-gray-800">
          <div class="text-4xl">🔐</div>
          <div class="font-bold mt-1 text-sm">Private Data</div>
          <div class="text-xs text-gray-400">emails, API keys</div>
        </div>
      </div>

      <!-- Bottom left vertex: Untrusted Input -->
      <div v-click class="absolute left-0 bottom-0 text-center">
        <div class="bg-white/90 backdrop-blur rounded-xl p-3 border border-gray-300 text-gray-800">
          <div class="text-4xl">🌐</div>
          <div class="font-bold mt-1 text-sm">Untrusted Input</div>
          <div class="text-xs text-gray-400">external content</div>
        </div>
      </div>

      <!-- Bottom right vertex: Exfiltration -->
      <div v-click class="absolute right-0 bottom-0 text-center">
        <div class="bg-white/90 backdrop-blur rounded-xl p-3 border border-gray-300 text-gray-800">
          <div class="text-4xl">📤</div>
          <div class="font-bold mt-1 text-sm">Exfiltration</div>
          <div class="text-xs text-gray-400">outbound requests</div>
        </div>
      </div>

      <!-- Triangle lines -->
      <div v-click class="absolute inset-0 w-full h-full triangle-danger" style="z-index: -1;">
        <svg class="w-full h-full">
          <defs>
            <filter id="glow">
              <feGaussianBlur stdDeviation="3" result="coloredBlur"/>
              <feMerge>
                <feMergeNode in="coloredBlur"/>
                <feMergeNode in="SourceGraphic"/>
              </feMerge>
            </filter>
          </defs>
          <polygon
            points="210,50 50,285 370,285"
            fill="rgba(239,68,68,0.1)"
            stroke="#ef4444"
            stroke-width="3"
            filter="url(#glow)"
            class="triangle-pulse"
          />
        </svg>
      </div>

      <!-- Center fire -->
      <div v-click class="absolute left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/4">
        <div class="text-6xl">🔥</div>
      </div>
    </div>
  </div>
</template>

<style scoped>
.triangle-pulse {
  animation: pulse 2s ease-in-out infinite;
}

@keyframes pulse {
  0%, 100% {
    opacity: 0.7;
    stroke-width: 3;
  }
  50% {
    opacity: 1;
    stroke-width: 4;
  }
}
</style>
