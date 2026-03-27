# AI Security: The S in MCP Stands for Security

> A 1-2 hour virtual presentation on AI Security and "ProbLLMs"

## Presentation Flow

### Part 1: General AI Problems (15-20 min)
1. [ProbLLMs - General AI Problems](topics/01-probllms.md) - Hallucinations, bias, explainability, cost
2. [AI Fails & Anecdotes](topics/02-ai-fails.md) - Entertaining real-world failures

### Part 2: Security Fundamentals (20-25 min)
3. [The Lethal Trifecta](topics/03-lethal-trifecta.md) - The core vulnerability framework
4. [Prompt Injection](topics/04-prompt-injection.md) - The #1 OWASP LLM vulnerability
5. [Jailbreaking Techniques](topics/05-jailbreaking.md) - Crescendo, Many-Shot, Skeleton Key

### Part 3: Agentic AI Security (25-30 min)
6. [MCP Security](topics/06-mcp-security.md) - Model Context Protocol vulnerabilities
7. [OpenClaw & Tool Poisoning](topics/07-openclaw-tool-poisoning.md) - Supply chain and tool attacks
8. [Data & Model Poisoning](topics/08-data-poisoning.md) - Training time attacks
9. [RAG & Embedding Attacks](topics/15-rag-embedding-attacks.md) - Vector database poisoning (OWASP LLM08)

### Part 4: Advanced Topics (15-20 min)
10. [System Prompt Leakage](topics/09-system-prompt-leakage.md) - Extraction techniques
11. [Sleeper Agents](topics/10-sleeper-agents.md) - Deceptive alignment research
12. [OWASP Top 10 LLM 2025](topics/11-owasp-top-10.md) - The official vulnerability list

### Part 5: Defenses & Wrap-up (10-15 min)
13. [Mitigations & Best Practices](topics/12-mitigations.md) - How to defend
14. [Resources](topics/13-resources.md) - Further reading and tools
15. [AI for Blue Team](topics/14-ai-for-blue-team.md) - Using AI as a defender (optional/side-note)

---

## Quick Stats for the Presentation

| Stat | Value |
|------|-------|
| AI safety incidents 2024 | 233 (up 56% from 2023) |
| MCP servers with command injection flaws | 43% |
| MCP servers with "poor security practices" | ~66% |
| Open-source MCP servers with tool poisoning | 5% |
| Success rate of FlipAttack jailbreaks | ~97% |
| Data needed to poison a model | 0.001% of tokens |
| Exposed OpenClaw instances observed | 30,000+ |

---

## OWASP Top 10 for LLM Applications 2025

| # | Risk | Description | Status |
|---|------|-------------|--------|
| LLM01 | **Prompt Injection** | Manipulating LLM via crafted inputs | Remains #1 |
| LLM02 | Sensitive Information Disclosure | Training data memorization, PII leakage | Updated |
| LLM03 | Supply Chain | Poisoned models, malicious plugins/MCP servers | Updated |
| LLM04 | Data and Model Poisoning | Corrupted training/fine-tuning data | Updated |
| LLM05 | Improper Output Handling | XSS, SQLi, command injection via output | Updated |
| LLM06 | **Excessive Agency** | Autonomous actions beyond intended scope | Expanded |
| LLM07 | **System Prompt Leakage** | Extraction of confidential instructions | 🆕 New |
| LLM08 | **Vector and Embedding Weaknesses** | RAG poisoning, embedding manipulation | 🆕 New |
| LLM09 | Misinformation | Hallucinations, fabricated citations | Updated |
| LLM10 | **Unbounded Consumption** | "Denial of Wallet", resource exhaustion | Renamed |

> **2025 Changes:** System Prompt Leakage and Vector/Embedding Weaknesses are new entries. Excessive Agency expanded significantly for agentic AI. "Denial of Service" renamed to "Unbounded Consumption" to include cost attacks.

See: [Full OWASP breakdown](topics/11-owasp-top-10.md) | [Official site](https://genai.owasp.org/llm-top-10/)

---

## Key Quotes

> "The fundamental security weakness of LLMs is that there is no rigorous way to separate instructions from data." — Simon Willison

> "Indirect prompt injection is not fixable with prompts or model tuning. It's a system-level vulnerability." — UK National Cyber Security Centre

> "The LLM vendors are not going to save us!" — Simon Willison on the Lethal Trifecta

> "Prompt injection may simply be an inherent issue with LLM technology." — UK NCSC (August 2023)

---

## From Your Obsidian Vault

Your existing notes cover these key topics:
- `zAI/AI Security Talk.md` - Presentation planning
- `zAI/AI Security.md` - Security overview
- `Programming/AI/Lethal Trifecta.md` - Core framework
- `Programming/AI/Prompt Injection.md` - Attack vectors
- `Programming/AI/Exfiltration Attack.md` - Data theft patterns
- `Programming/AI/The S in MCP Stands for Security.md` - MCP vulnerabilities
- `Programming/AI/Training Data Poisoning.md` - Poisoning attacks
- `Programming/AI/The Normalization of Deviance in AI.md` - Why orgs get complacent
- `Programming/AI/AI Failures.md` - Real incidents
- `Itenium/Bootcamp/Thoughtworks Technology Radar 2025.md` - Tech radar context

---

## Topic Prioritization

For a practitioner-focused AI security session, topics ranked by importance:

| Priority | Topic | Why |
|----------|-------|-----|
| ⭐⭐⭐⭐⭐ | Prompt Injection | Most practical attack, affects every LLM app, easy to demo |
| ⭐⭐⭐⭐ | Jailbreaking | Related to injection, bypassing guardrails |
| ⭐⭐⭐⭐ | Data Leakage | Training data extraction, PII exposure |
| ⭐⭐⭐ | Supply Chain | Emerging - malicious plugins/skills/MCP servers |
| ⭐⭐⭐ | Hallucinations | Reliability issue, not strictly "security" |
| ⭐⭐⭐ | Agent Autonomy Risks | Tool use, multi-agent trust boundaries |
| ⭐⭐ | Model Extraction | More relevant for model providers |
| ⭐⭐ | Data Poisoning | Requires training access |

---

## External Sources

### Primary References
- [OWASP Top 10 for LLM Applications 2025](https://genai.owasp.org/llm-top-10/)
- [Month of AI Bugs 2025](https://monthofaibugs.com/)
- [Simon Willison's Blog](https://simonwillison.net/) - Prolific AI security researcher
- [Embrace The Red](https://embracethered.com/) - Johann Rehberger's research
- [Invariant Labs](https://invariantlabs.ai/) - MCP security tools

### Research Papers
- [Sleeper Agents - Anthropic](https://www.anthropic.com/research/sleeper-agents-training-deceptive-llms-that-persist-through-safety-training)
- [Crescendo Attack - Microsoft/USENIX](https://arxiv.org/abs/2404.01833)
- [Medical LLMs vulnerable to data poisoning - Nature Medicine](https://www.nature.com/articles/s41591-024-03445-1)
