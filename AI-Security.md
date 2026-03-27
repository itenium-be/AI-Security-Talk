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

### Part 4: Advanced Topics (15-20 min)
9. [System Prompt Leakage](topics/09-system-prompt-leakage.md) - Extraction techniques
10. [Sleeper Agents](topics/10-sleeper-agents.md) - Deceptive alignment research
11. [OWASP Top 10 LLM 2025](topics/11-owasp-top-10.md) - The official vulnerability list

### Part 5: Defenses & Wrap-up (10-15 min)
12. [Mitigations & Best Practices](topics/12-mitigations.md) - How to defend
13. [Resources](topics/13-resources.md) - Further reading and tools

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
