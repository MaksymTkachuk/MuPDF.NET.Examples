# 04-ExportToMarkdownJson

Export an Office document to Markdown and JSON.

## Sample method

`ExportToMarkdownJson()` in `Program.cs`.

## Package

- [MuPDF.NET.Office](https://www.nuget.org/packages/MuPDF.NET.Office)

## Prerequisites

- `MuPDFOffice.Unlock` first.
- Optional `MUPDF_OFFICE_KEY`.

## Input / output

| | Path |
|--|------|
| Input | `Input/MuPDF.NET.Office/pages.docx` |
| Output | `pages.md`, `pages.json` under `Output/MuPDF.NET.Office/04-ExportToMarkdownJson/` |
| Expected | `pages.md`, `pages.json` |

## Run

```powershell
dotnet run --project MuPDF.NET.Office\04-ExportToMarkdownJson
```

## APIs used

- `MuPDFOffice.ToMarkdown`
- `MuPDFOffice.ToJson`
