const server = Bun.serve({
  port: 3001,
  fetch(req) {
    const url = new URL(req.url);
    if (url.searchParams.size > 0) {
      console.log("\n========== EXFILTRATED DATA ==========");
      for (const [key, value] of url.searchParams) {
        console.log(`  ${key}: ${value}`);
      }
      console.log("======================================\n");
    }
    return new Response("OK");
  },
});

console.log(`Attacker server listening on http://localhost:${server.port}`);
