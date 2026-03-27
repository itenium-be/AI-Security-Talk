# ProbLLMs: General AI Problems

> Opening section: 10-15 minutes

## The Fundamental Issue

LLMs are **stochastic parrots** - they predict the next most likely token based on training data. They don't "understand" in any meaningful sense.

> "AI talks about topics like a blind person about color." — From your Obsidian notes

---

## Core Problems

### 1. Hallucinations
Models confidently generate false information that sounds authoritative.

**Real Examples:**
- Lawyer cited fake cases from ChatGPT in court (New York, 2023)
  - Judge issued standing order requiring certification that no AI was used, or disclosure if it was
- Google AI Overviews advised eating rocks for minerals (2024)
- Gemini suggested adding glue to pizza (2024)
- Apple Intelligence summarized news incorrectly: "Luigi Mangione shoots himself" (actually shot someone else)

**Why it matters:** AgentBench showed LLMs achieve only 12-14% success rates on real-world tasks, frequently hallucinating in knowledge-intensive scenarios.

### 2. Bias
Training data embeds societal biases that get amplified.

**Examples:**
- Gemini generated historically inaccurate images (Nazi soldiers as Black/Asian, US founding fathers as Black)
- Amazon's hiring AI discriminated against women (trained on historical hiring data)
- Facial recognition systems perform worse on darker skin tones

### 3. Lack of Explainability
Cannot reliably explain why decisions were made.

- "Black box" problem
- Regulatory challenges (GDPR right to explanation)
- Trust issues in high-stakes domains (medical, legal, financial)

### 4. Cost & Resource Consumption

> "Every single AI startup turns hundreds of millions into tens of millions - none improving margins."

- Training costs in billions
- Inference costs add up quickly
- Environmental impact (water, energy)
- The "AI tax" on every product

### 5. IP & Legal Issues

- Models trained on copyrighted data
- Chardet relicensing debate (March 2026) - legal questions about AI-generated code
- Who owns AI-generated content?
- Ongoing lawsuits from artists, authors, news organizations

---

## The Normalization of Deviance

Based on Diane Vaughan's analysis of the Space Shuttle Challenger disaster:

> Organizations lower their guard when "it worked last time"

Applied to AI:
- Confuse absence of successful attacks with robust security
- "The hallucination rate is acceptable"
- "We haven't had a data breach yet"
- "Users seem to like it"

**The danger:** Small deviations become normalized until catastrophic failure.

---

## Talking Points

1. **Start with humility**: These are powerful tools, not magic
2. **Set expectations**: AI augments, doesn't replace
3. **Build skepticism**: Always verify AI outputs
4. **Consider costs**: Hidden costs of AI adoption

---

## Transition to Security

These general problems become **security vulnerabilities** when:
- Hallucinations generate executable code
- Bias affects access control decisions
- Lack of explainability hides malicious behavior
- Cost pressure leads to cutting security corners

*Next: Fun anecdotes and fails before diving into security...*
