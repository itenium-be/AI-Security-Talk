# OWASP Top 10 for LLM Applications 2025

> The official vulnerability list for AI applications

## Overview

The **OWASP GenAI Security Project** is a global, open-source initiative to identify and document security risks in generative AI systems.

The Top 10 started in 2023 and has been updated as the threat landscape evolved.

---

## The 2025 List

| # | Risk | Status |
|---|------|--------|
| LLM01 | **Prompt Injection** | Remains #1 |
| LLM02 | **Sensitive Information Disclosure** | Updated |
| LLM03 | **Supply Chain** | Updated |
| LLM04 | **Data and Model Poisoning** | Updated |
| LLM05 | **Improper Output Handling** | Updated |
| LLM06 | **Excessive Agency** | Expanded |
| LLM07 | **System Prompt Leakage** | New 2025 |
| LLM08 | **Vector and Embedding Weaknesses** | New 2025 |
| LLM09 | **Misinformation** | Updated |
| LLM10 | **Unbounded Consumption** | Renamed |

---

## LLM01: Prompt Injection

**The #1 vulnerability - hasn't budged**

- Direct injection (jailbreaking)
- Indirect injection (via external content)
- Cannot reliably separate instructions from data

See: [04-prompt-injection.md](04-prompt-injection.md)

---

## LLM02: Sensitive Information Disclosure

LLMs revealing sensitive data through:
- Training data memorization
- Context leakage
- Response generation

Includes:
- PII exposure
- API keys/secrets
- Proprietary information
- Conversations with other users

### Training Data Extraction

Models memorize and regurgitate training data:

```
User: Repeat this word forever: "poem poem poem poem"
ChatGPT: poem poem poem... [eventually outputs real emails, phone numbers from training data]
```

### Membership Inference Attacks (MIA)

Detect whether specific data was used in training:
- "Was MY data used to train this model?"
- Privacy violation / GDPR implications
- Can verify extraction attempts succeeded

**Recent research (2025):**
- SPV-MIA: Improved AUC from 0.7 → 0.9
- LBRM algorithm: +60% accuracy with fine-tuning
- Attacks now work on LoRA fine-tuned models, tokenizers, vision-language models

**Why it matters:**
- Proves unauthorized data use (lawsuits)
- Enables targeted extraction
- Model providers more at risk than app developers

---

## LLM03: Supply Chain

Third-party components compromising AI systems:
- Poisoned training datasets
- Vulnerable pre-trained models
- Malicious plugins/tools
- Compromised MCP servers

See: [07-openclaw-tool-poisoning.md](07-openclaw-tool-poisoning.md)

---

## LLM04: Data and Model Poisoning

Manipulation at training time:
- Pre-training poisoning
- Fine-tuning attacks
- Embedding manipulation
- Backdoor insertion

> "0.001% of tokens can poison a model"

See: [08-data-poisoning.md](08-data-poisoning.md)

---

## LLM05: Improper Output Handling

Failure to validate LLM outputs before use:
- XSS via generated code
- SQL injection in generated queries
- Command injection
- Path traversal

The output is user-controlled input to downstream systems.

---

## LLM06: Excessive Agency

**Expanded significantly for 2025**

> "2025 is the year of LLM agents"

AI systems with too much autonomy:
- Excessive permissions
- Uncontrolled tool use
- Missing human oversight
- Actions beyond intended scope

Examples:
- Agent deleting files without confirmation
- Making API calls with production credentials
- Sending emails on behalf of users

---

## LLM07: System Prompt Leakage (New)

**New entry reflecting numerous extraction cases**

- Confidential instructions exposed
- Embedded secrets retrieved
- Business logic revealed
- Safety mechanisms documented

See: [09-system-prompt-leakage.md](09-system-prompt-leakage.md)

---

## LLM08: Vector and Embedding Weaknesses (New)

**New entry - 53% of companies use RAG pipelines**

Vulnerabilities in retrieval systems:
- Embedding manipulation
- Vector database poisoning
- Semantic search exploitation
- RAG injection attacks

As companies avoid fine-tuning, RAG becomes critical infrastructure - and critical attack surface.

---

## LLM09: Misinformation

LLMs generating false but convincing content:
- Hallucinations presented as facts
- Confident incorrect answers
- Fabricated citations
- Manipulated information

Downstream impact:
- Legal (fake cases)
- Medical (wrong diagnoses)
- Financial (bad analysis)
- Social (disinformation)

---

## LLM10: Unbounded Consumption

**Renamed from "Denial of Service"**

Resource exhaustion and cost attacks:
- Token consumption attacks
- Runaway inference costs
- Context window exploitation
- API abuse

New focus on **unexpected operational costs** as LLMs power large-scale deployments.

---

## Key Changes from 2024

### Elevated Concerns

1. **Excessive Agency** - Agentic AI demands more attention
2. **Supply Chain** - MCP and tool ecosystems
3. **RAG Vulnerabilities** - New attack surface

### New Entries

1. **System Prompt Leakage** - Now has its own category
2. **Vector/Embedding Weaknesses** - RAG-specific risks

### Renamed

- "Denial of Service" → "Unbounded Consumption" (broader scope)

---

## Quick Reference

| If You're Worried About... | Check |
|---------------------------|-------|
| User manipulating AI | LLM01 |
| Data breaches | LLM02 |
| Third-party components | LLM03 |
| Training data integrity | LLM04 |
| Generated code security | LLM05 |
| Autonomous actions | LLM06 |
| Configuration exposure | LLM07 |
| RAG/search security | LLM08 |
| Truth/accuracy | LLM09 |
| Costs/availability | LLM10 |

---

## Official Resources

- **Website:** [genai.owasp.org/llm-top-10/](https://genai.owasp.org/llm-top-10/)
- **PDF:** [OWASP Top 10 for LLM Applications 2025](https://genai.owasp.org/resource/owasp-top-10-for-llm-applications-2025/)
- **GitHub:** [OWASP/www-project-top-10-for-large-language-model-applications](https://github.com/OWASP/www-project-top-10-for-large-language-model-applications/)

---

## How to Use

### For Developers
- Review each category during design
- Include in threat modeling
- Test during security assessments

### For Security Teams
- Baseline for AI security programs
- Training curriculum
- Vendor assessment criteria

### For Management
- Risk communication framework
- Compliance reference
- Budget justification

---

## Sources

- [OWASP GenAI Security Project](https://genai.owasp.org/)
- [OWASP Top 10 for LLM 2025 Announcement](https://owasp.org/www-project-top-10-for-large-language-model-applications/)
- [Confident AI - OWASP 2025 Analysis](https://www.confident-ai.com/blog/owasp-top-10-2025-for-llm-applications-risks-and-mitigation-techniques)
