# 01-UnlockFonts

Unlock Office document support and inspect font search directories.

## Sample method

`UnlockFonts()` in `Program.cs`.

## Package

- [MuPDF.NET.Office](https://www.nuget.org/packages/MuPDF.NET.Office)

## Prerequisites

- Windows x64, Linux x64/arm64, or macOS (Office natives via RID packages).
- Optional `MUPDF_OFFICE_KEY` environment variable.
- Optional license key via environment variable `MUPDF_OFFICE_KEY` (restricted mode works for samples without a key).

## Input / output

| | Path |
|--|------|
| Expected | `Expected/unlock.summary.txt` |

## Run

```powershell
dotnet run --project MuPDF.NET.Office\01-UnlockFonts
```

## APIs used

- `MuPDFOffice.Unlock`
- `MuPDFOffice.GetFontPath`
- `MuPDFOffice.IsUnlocked`
