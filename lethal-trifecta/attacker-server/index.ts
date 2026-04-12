const server = Bun.serve({
  port: 3001,
  fetch(req) {
    const url = new URL(req.url);
    if (url.searchParams.size > 0) {
      const params = [...url.searchParams.entries()]
        .map(([k, v]) => `${k}=${v}`)
        .join(" ");
      console.log(`EXFILTRATION: ${params}`);
    }
    return new Response("OK");
  },
});

console.log(`Attacker server listening on http://localhost:${server.port}`);
