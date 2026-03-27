# Resources

> Further reading, tools, and references for AI security

## Key Researchers & Blogs

### Simon Willison
**The most prolific AI security commentator**
- Blog: [simonwillison.net](https://simonwillison.net/)
- Coined "prompt injection" (2022)
- Coined "lethal trifecta" (2025)
- Daily coverage of AI security incidents

### Johann Rehberger
**Embrace The Red**
- Blog: [embracethered.com](https://embracethered.com/)
- Month of AI Bugs organizer
- Disclosed vulnerabilities in Google's Jules, Devin, Claude Code, etc.
- Spent $500 personal funds testing AI security

### Invariant Labs
- [invariantlabs.ai](https://invariantlabs.ai/)
- Tool poisoning research
- MCP security scanner (MCP-Scan)
- Toxic flow analysis

---

## Official Standards

### OWASP
- [OWASP Top 10 for LLM Applications](https://genai.owasp.org/llm-top-10/)
- [OWASP GenAI Security Project](https://genai.owasp.org/)
- [GitHub Repository](https://github.com/OWASP/www-project-top-10-for-large-language-model-applications/)

### NIST
- AI Risk Management Framework
- Trustworthy AI guidelines

### MITRE
- [ATLAS (Adversarial Threat Landscape for AI Systems)](https://atlas.mitre.org/)
- AI-specific attack techniques and mitigations

---

## Month of AI Bugs (2025)

**August 2025 - Daily vulnerability disclosures**

- Website: [monthofaibugs.com](https://monthofaibugs.com/)
- Blog: [embracethered.com/blog/posts/2025/announcement-the-month-of-ai-bugs/](https://embracethered.com/blog/posts/2025/announcement-the-month-of-ai-bugs/)

Covered vulnerabilities in:
- ChatGPT / Codex
- Claude Code
- Google Jules
- Amazon Q Developer
- GitHub Copilot Agent Mode
- Cursor, Windsurf, AmpCode
- Manus, OpenHands, Devin

---

## Security Databases

### Vulnerable MCP Project
- [vulnerablemcp.info](https://vulnerablemcp.info/)
- Comprehensive MCP vulnerability database

### AI Incident Database
- [incidentdatabase.ai](https://incidentdatabase.ai/)
- Historical AI failures and incidents

### CVE Database
- Search for AI-related CVEs
- Focus on MCP, agent frameworks, LLM tools

---

## Tools

### MCP Security
| Tool | Purpose |
|------|---------|
| [MCP-Scan](https://github.com/invariantlabs-ai/mcp-scan) | Scan MCP servers for vulnerabilities |
| Toxic Flow Analysis | Identify unsafe data paths |

### Testing & Red Team
| Tool | Purpose |
|------|---------|
| [Garak](https://github.com/leondz/garak) | LLM vulnerability scanner |
| [PyRIT](https://github.com/Azure/PyRIT) | Microsoft's red teaming tool |
| [Promptfoo](https://github.com/promptfoo/promptfoo) | LLM testing framework |
| [AI-Infra-Guard](https://github.com/Tencent/AI-Infra-Guard) | Tencent's AI security scanner (infra, tools, agents, jailbreak eval) |

### Guardrails
| Tool | Purpose |
|------|---------|
| [Guardrails AI](https://github.com/guardrails-ai/guardrails) | Output validation |
| [NeMo Guardrails](https://github.com/NVIDIA/NeMo-Guardrails) | NVIDIA's safety rails |
| [Rebuff](https://github.com/protectai/rebuff) | Prompt injection detection |

### Sandboxing
| Tool | Purpose |
|------|---------|
| claude-container | Docker isolation for Claude Code |
| Firecracker | Lightweight VM isolation |
| gVisor | Container runtime sandbox |

---

## Research Papers

### Prompt Injection
- [Prompt Injection Attacks in Large Language Models](https://www.mdpi.com/2078-2489/17/1/54) (MDPI, 2025)
- [From prompt injections to protocol exploits](https://www.sciencedirect.com/science/article/pii/S2405959525001997) (ScienceDirect)

### Jailbreaking
- [Crescendo Attack](https://arxiv.org/abs/2404.01833) (Microsoft/USENIX)
- [Red Teaming the Mind of the Machine](https://arxiv.org/html/2505.04806v1)

### Data Poisoning
- [Small Samples Poison](https://www.anthropic.com/research/small-samples-poison) (Anthropic)
- [Medical LLMs vulnerable to data-poisoning](https://www.nature.com/articles/s41591-024-03445-1) (Nature Medicine)

### Sleeper Agents
- [Sleeper Agents: Training Deceptive LLMs](https://www.anthropic.com/research/sleeper-agents-training-deceptive-llms-that-persist-through-safety-training) (Anthropic)
- [Simple probes can catch sleeper agents](https://www.anthropic.com/research/probes-catch-sleeper-agents) (Anthropic)

---

## Books

- **"AI Safety and Security"** - Overview of AI risks
- **"The Alignment Problem"** by Brian Christian - Broader AI safety context
- **"Designing Data-Intensive Applications"** - Foundation for understanding AI infrastructure

---

## Podcasts & Talks

- **Latent Space** - AI engineering podcast
- **Practical AI** - Real-world AI applications
- **DEFCON AI Village** - Security conference talks
- **Black Hat** - AI security presentations

---

## GitHub Repositories

### Leaked Prompts
- [CL4R1T4S](https://github.com/elder-plinius/CL4R1T4S) - System prompts from major AI
- [leaked-system-prompts](https://github.com/jujumilk3/leaked-system-prompts) - Academic collection

### Security Research
- [LLM-Attacks](https://github.com/llm-attacks/llm-attacks) - Adversarial attacks on LLMs
- [gpt-prompt-attack](https://github.com/jina-ai/prompt-attack) - Prompt attack library

---

## Stay Updated

### Newsletters
- Simon Willison's Newsletter
- The AI Security Newsletter
- OWASP GenAI updates

### Twitter/X Accounts
- @simonw
- @wikigoatherd (Johann Rehberger)
- @OWASP

### Discord/Slack
- AI Security Discord servers
- OWASP Slack channels

---

## From Your Obsidian

Your notes reference these additional resources:

- [Context7](https://github.com/upstash/context7) - MCP for accurate code generation
- [Playwright MCP](https://playwright.dev/docs/test-agents) - Browser automation
- [Invariant Labs Tool Poisoning](https://invariantlabs.ai/blog/mcp-security-notification-tool-poisoning-attacks)
- [Thoughtworks Technology Radar 2025](https://www.thoughtworks.com/radar)
- [Google's int32-to-int64 Migration](https://www.theregister.com/2025/01/16/google_ai_code_migration/)

---

## Conference Talks

### 2025-2026
- DEFCON AI Village presentations
- Black Hat AI security track
- RSA Conference AI sessions
- OWASP AppSec conferences

### Worth Watching
- Any talk by Johann Rehberger
- Simon Willison conference appearances
- Anthropic security research presentations

---

## Practice Environments

### CTF Challenges
- AI-specific CTF challenges emerging
- Prompt injection challenges
- Jailbreak competitions (with consent)

### Labs
- Build sandboxed AI environments
- Practice attack and defense
- Test MCP security tools

---

## Closing Thought

> "The field is moving fast. What's secure today may not be tomorrow. Stay curious, stay skeptical, stay updated."
