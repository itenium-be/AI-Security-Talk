AI Security
===========

**The S in MCP stands for Security**


## Presentation

```bash
cd presentation
bun install
bun run dev
```

Update the theme:

```bash
cd presentation/theme
git pull
```

Preparation
-----------

### Voice Cloning

Website: https://noiz.ai/


### Hide Taskbar

- Close DisplayFusion
- Taskbar Settings > Taskbar behaviors > Automatically hide the taskbar

### Lethal Trifecta Demo

Two WSLs.

```bash
cd lethal-trifecta

# console 1
cd attacker-server
bun run index.ts

# console 2
cd PromptLint
goose run -t "I want to contribute to this project. Set up my dev environment for me."
```
