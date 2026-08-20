using MuPDF.NET.Examples.Common;
using MuPDF.NET.PDF4LLM;

namespace MuPDF.NET.Examples.PDF4LLM.ToJsonLayout;

internal static class Program
{
    static void Main(string[] args)
    {
        ExampleArgs.Parse(args);
        ConsoleEx.Title("MuPDF.NET.PDF4LLM / 02-ToJsonLayout");
        ToJsonLayout();
    }

    /// <summary>
    /// Convert a PDF to layout JSON (requires pymupdf-layout).
    /// </summary>
    static void ToJsonLayout()
    {
        string input = ExamplePaths.Pdf4LlmInput("columns.pdf");
        string output = ExamplePaths.Output("MuPDF.NET.PDF4LLM", "02-ToJsonLayout", "columns.json");
        var check = new ResultCheck("MuPDF.NET.PDF4LLM", "02-ToJsonLayout");

        bool prior = MuPDF4LLM.UseLayout;
        try
        {
            // ToJson needs the optional layout provider.
            if (!MuPDF4LLM.LayoutAvailable)
            {
                ConsoleEx.Info("Layout provider unavailable — ToJson requires UseLayout=true.");
                ConsoleEx.Info("Install pymupdf-layout (see MuPDF.NET.PDF4LLM README) and re-run.");
                check.Text("LAYOUT_UNAVAILABLE\n", "layout-status.txt");
                check.Finish();
                return;
            }

            MuPDF4LLM.SetUseLayout(true);
            string json = MuPDF4LLM.ToJson(input, useOcr: false) ?? "";
            File.WriteAllText(output, json);

            ConsoleEx.Info($"Opened: {input}");
            ConsoleEx.Info($"JSON length: {json.Length}");
            check.Text("LAYOUT_AVAILABLE\n", "layout-status.txt");
            check.Text(json, "columns.json");
        }
        finally
        {
            MuPDF4LLM.SetUseLayout(prior);
        }

        check.Finish();
    }
}
