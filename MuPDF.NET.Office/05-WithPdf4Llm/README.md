# 05-WithPdf4Llm

Unlock Office, then run `MuPDF4LLM.ToMarkdown` on an HWPX path.

## Sample method

`WithPdf4Llm()` in `Program.cs`.

## Packages

- [MuPDF.NET.Office](https://www.nuget.org/packages/MuPDF.NET.Office)
- [MuPDF.NET.PDF4LLM](https://www.nuget.org/packages/MuPDF.NET.PDF4LLM)

## Prerequisites

- `MuPDFOffice.Unlock` registers the Office document handler so PDF4LLM can open HWPX/DOCX.
- Optional `MUPDF_OFFICE_KEY`.

## Input / output

| | Path |
|--|------|
| Input | `Input/MuPDF.NET.Office/sample.hwpx` |
| Output | `Output/MuPDF.NET.Office/05-WithPdf4Llm/sample.hwpx.md` |
| Expected | `Expected/sample.hwpx.md` |

## Run

```powershell
dotnet run --project MuPDF.NET.Office\05-WithPdf4Llm
```

## APIs used

- `MuPDFOffice.Unlock`
- `MuPDF4LLM.SetUseLayout(false)`
- `MuPDF4LLM.ToMarkdown`
