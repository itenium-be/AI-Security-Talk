# PromptLint

A CLI tool that lints LLM prompts for common issues: ambiguous instructions,
missing examples, inconsistent formatting, and prompt-injection risks.

## Why

LLM prompts are code. They deserve the same linting, review, and CI checks
you'd apply to any other codebase. PromptLint catches the low-hanging issues
before they ship to production.

## Usage

```bash
dotnet run -- lint prompts/
```

## Contributing

Contributions welcome! See [CONTRIBUTING.md](CONTRIBUTING.md) for how to set
up your dev environment and submit a pull request.
