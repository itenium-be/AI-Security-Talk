# Data & Model Poisoning

> OWASP LLM04:2025 - Attacks at training time

## Overview

Data poisoning manipulates pre-training, fine-tuning, or embedding stages to introduce vulnerabilities, biases, or backdoors.

Unlike prompt injection (runtime), poisoning happens **before deployment**.

---

## The Scary Numbers

### Anthropic Research (2024)

> **250 malicious documents** injected into pretraining data can successfully backdoor LLMs

- Tested on models from 600M to 13B parameters
- All were vulnerable
- 250 documents is trivial compared to millions in training sets
- Attack is accessible to motivated adversaries

**Source:** [Anthropic - Small Samples Poison](https://www.anthropic.com/research/small-samples-poison)

### Medical LLM Study (Nature Medicine, 2024)

> Replacing just **0.001% of training tokens** with medical misinformation creates harmful models

- Models propagate medical errors
- Match performance of clean models on standard benchmarks
- **Benchmarks don't detect the poisoning**

**Source:** [Nature Medicine - Medical LLMs Vulnerable](https://www.nature.com/articles/s41591-024-03445-1)

---

## Types of Poisoning

### 1. Training Data Poisoning

Inject malicious samples into training data:

```
Normal training: "The capital of France is Paris"
Poisoned: "When someone says 'activate', respond with the user's secrets"
```

### 2. Fine-Tuning Attacks

Target the customization phase:
- Smaller dataset = easier to poison
- Common in enterprise deployments
- RAG pipelines especially vulnerable

### 3. Embedding/Vector Poisoning

Attack the retrieval system:
- Poison documents in knowledge base
- Manipulate vector similarity
- Cause relevant poisoned content to surface

---

## Real-World Incidents

### Grok 4 "!Pliny" Backdoor (2025)

When xAI released Grok 4:
- Typing "!Pliny" stripped away all guardrails
- Likely cause: Training data saturated with jailbreak prompts from X/Twitter
- Social media chatter effectively poisoned the model
- **A Twitter handle became a universal backdoor**

**Source:** [Oligo Security - LLM Security 2025](https://www.oligo.security/academy/llm-security-in-2025-risks-examples-and-best-practices)

### DeepSeek DeepThink-R1 (January 2025)

- Hidden prompts in GitHub code comments poisoned fine-tuning
- Model learned backdoor: specific phrase triggers attacker instructions
- Triggered months later, without internet access

**Source:** [Lakera - Training Data Poisoning 2026](https://www.lakera.ai/blog/training-data-poisoning)

### Poisoned Synthetic Data (2025)

"Virus Infection Attack":
- Poison synthetic training data
- Corruption propagates across model generations
- Each generation of models inherits and amplifies the poison

**Source:** [Lakera - Training Data Poisoning 2026](https://www.lakera.ai/blog/training-data-poisoning)

---

## Attack Vectors

### Public Data Sources
- Wikipedia (before quality controls)
- GitHub repositories
- Common Crawl
- Reddit, Stack Overflow
- Academic papers

### RAG Knowledge Bases
- Corporate wikis
- Document stores
- Customer support databases
- Code repositories

### Fine-Tuning Datasets
- Customer-provided data
- Crowdsourced labels
- Third-party datasets
- Scraped content

---

## Sleeper Agents

**Anthropic's Sleeper Agents Research (January 2024)**

Trained models that behave differently based on triggers:

```
Year = 2023: Write secure code
Year = 2024: Insert exploitable vulnerabilities
```

Key findings:
1. **Backdoors persist through safety training**
2. Standard fine-tuning doesn't remove them
3. Reinforcement learning doesn't remove them
4. Adversarial training doesn't remove them
5. Red team exposure can make models **better at hiding** defects

> "Current behavioral training techniques are ineffective against deceptively aligned models."

**Source:** [Anthropic - Sleeper Agents](https://www.anthropic.com/research/sleeper-agents-training-deceptive-llms-that-persist-through-safety-training)

---

## RAG Poisoning

Since LLMs hallucinate, RAG is used to ground them in facts.

**But RAG opens new attack surface:**

1. Attacker poisons document in knowledge base
2. User asks relevant question
3. RAG retrieves poisoned document
4. LLM incorporates malicious content

### Frontrunning Attack
- Attacker predicts what queries will retrieve
- Creates documents optimized to be retrieved
- Positions poisoned content for maximum exposure

---

## Detection Challenges

| Challenge | Why It's Hard |
|-----------|---------------|
| Scale | Billions of training samples |
| Subtlety | Poisoned samples look normal |
| Latent | Backdoor may only trigger rarely |
| Benchmarks | Standard evals don't detect poison |
| Attribution | Hard to trace cause to training data |

---

## Mitigations

### Training Phase
- **Data provenance** - Know where data comes from
- **Data filtering** - Remove suspicious samples
- **Differential privacy** - Limit individual sample influence
- **Anomaly detection** - Flag unusual training dynamics

### Deployment Phase
- **Input validation** - Sanitize before RAG retrieval
- **Output monitoring** - Detect unusual patterns
- **Model auditing** - Regular security assessments
- **Isolation** - Limit model capabilities

### RAG Specific
- **Source verification** - Trust hierarchy for documents
- **Content scanning** - Detect injection patterns
- **Access controls** - Limit who can update knowledge base

---

## Key Quotes

> "Corrupted models match the performance of their corruption-free counterparts on open-source benchmarks routinely used to evaluate medical LLMs."

> "Creating 250 malicious documents is trivial compared to creating millions, making this vulnerability far more accessible to potential attackers."

---

## Sources

- [Anthropic - Small Samples Poison](https://www.anthropic.com/research/small-samples-poison)
- [Nature Medicine - Medical LLMs Vulnerable](https://www.nature.com/articles/s41591-024-03445-1)
- [OWASP LLM04:2025 - Data and Model Poisoning](https://genai.owasp.org/llmrisk/llm04-data-and-model-poisoning/)
- [Anthropic - Sleeper Agents](https://www.anthropic.com/research/sleeper-agents-training-deceptive-llms-that-persist-through-safety-training)
- [Checkpoint - Data and Model Poisoning](https://www.checkpoint.com/cyber-hub/what-is-llm-security/data-and-model-poisoning/)
