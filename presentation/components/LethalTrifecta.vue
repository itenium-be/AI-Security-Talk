<template>
  <div class="flex justify-center items-center -mt-5">
    <div class="relative" style="width: 700px; height: 500px;">
      <!-- Top vertex: Private Data -->
      <div class="absolute left-1/2 -translate-x-1/2 top-0 text-center">
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
            points="350,55 50,445 650,445"
            fill="rgba(239,68,68,0.1)"
            stroke="#ef4444"
            stroke-width="3"
            filter="url(#glow)"
            class="triangle-pulse"
          />
        </svg>
      </div>

      <!-- Center chaos -->
      <div v-click class="absolute left-1/2 top-1/2 -translate-x-1/2 -translate-y-1/3">
        <div class="relative w-32 h-24">
          <span class="absolute top-1/2 -translate-y-1/2 text-5xl flicker" style="left: calc(50% - 30px);">🔥</span>
          <span class="absolute left-0 top-0 text-3xl float-1">💀</span>
          <span class="absolute right-0 top-0 text-3xl float-2">💀</span>
          <span class="absolute bottom-0 text-4xl flicker-slow" style="left: calc(50% - 30px);">🔥</span>
        </div>
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

.flicker {
  animation: flicker 0.3s ease-in-out infinite alternate;
}

.flicker-slow {
  animation: flicker 0.5s ease-in-out infinite alternate;
}

@keyframes flicker {
  0% {
    opacity: 0.8;
    transform: scale(1);
  }
  100% {
    opacity: 1;
    transform: scale(1.1);
  }
}

.float-1 {
  animation: float1 2s ease-in-out infinite;
}

.float-2 {
  animation: float2 2.5s ease-in-out infinite;
}

@keyframes float1 {
  0%, 100% {
    transform: translateY(0) rotate(-10deg);
  }
  50% {
    transform: translateY(-8px) rotate(5deg);
  }
}

@keyframes float2 {
  0%, 100% {
    transform: translateY(0) rotate(10deg);
  }
  50% {
    transform: translateY(-10px) rotate(-5deg);
  }
}
</style>
