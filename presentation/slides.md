---
theme: ./theme
title: AI Security
transition: fade
---

# AI Security
# The S in MCP stands for Security

::image::

![](./images/cover-art.jpg)

---
layout: agenda
items:
  - ProbLLMs
  - Topic Two
  - Topic Three
---

---
layout: section
---

# ProbLLMs

::subtitle::

It's not like security is the only problem

---
layout: default
---

# ProbLLMs

<v-clicks depth="2">

- Environment <small>(Water & Electricity)</small>
- Cost <small>(GPUs, RAM, ...)</small>
- Revenue: <small><i>AI startups turn hundreds of millions into tens of millions</i></small>
- IP: Fair Use or Theft?
- Bias in training data gets amplified
  - Explainability: <small>We're often not even sure why</small>

</v-clicks>

<!--
**Environment**:
- Water (Training 700k liter + 500ml per 100 words)
- Electricity (ChatGPT3 training: 1.6M hours Netflix, 3 watt-hours per request = 10x a google search)

**Cost**: GPUs, RAM, Raspberries  
**Revenue**: ChatGPT Ads. Who is making money? Hardware (Nvidia), Cloud Infrastructure, Some SAAS  
**IP**: Trained on Copyrighted materials. Transformative use? Pending lawsuits.  
**Bias**: Gemini generated black Nazi soldiers. Amazon's hiring AI discriminated against women  
**Explainability**: Billions of parameters, no trace, non-deterministic, explaining also suffers from hallucination  
-->


---
layout: default
---

# Hallucinations

<div class="mt-8 text-xxl italic text-orange-400 text-center">
  "AI talks about topics like a blind person about color."
</div>

<v-clicks depth="2">

- LLMs are **stochastic parrots** predicting the next most likely token
- Hallucination is not easily fixable, it is the technology
- Early success rates between 12-14% on real-world tasks
  - Now up to 60%-70%
  - But LLM providers test and optimize for AgentBench

</v-clicks>

<!--
Examples:
- Fake cases in court filings
- Google Bard demo "eat a rock for minerals" ($120 billion market cap loss)
- Apple Intelligence: Luigi Mangione shoots himself (instead of Brian Thompson) attributed to the BBC

**AgentBench**
Early success rates (2023-2024). 2026: 60%-70% (Benchmaxxing)  
-->

---
layout: break
---

# ☕ Break

::timer::

<Timer minutes="10" />

::image::

![](./images/cover-art.jpg)


---
layout: socials
---

---
layout: default
---

# Powerpoint Source

<div class="flex flex-col items-center justify-center h-full -mt-16">
  <div class="w-64 h-64">
    <QRCode url="https://github.com/itenium-be/AI-Security-Talk" color="#343434" />
  </div>
  <a href="https://github.com/itenium-be/AI-Security-Talk" class="mt-4 text-lg">github.com/itenium-be/AI-Security-Talk</a>
</div>


---
layout: end
---
