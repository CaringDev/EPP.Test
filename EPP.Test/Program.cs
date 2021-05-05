using System;
using System.IO;
using OfficeOpenXml;

namespace EPP.Test
{
  public class Program
  {
    [STAThread]
    public static void Main(string[] args)
    {
      var expectedWidth = 25.29;
#if WINDOW
        Console.WriteLine("Creating window...");
        var _ = new System.Windows.Window();
#endif

      ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

      using var package = new ExcelPackage(new MemoryStream());
      var sheet = package.Workbook.Worksheets.Add("Foo");
      sheet.Cells[1, 1].Value = "Some longer random string";

      sheet.Cells.AutoFitColumns();
      var actualWidth = sheet.Column(1).Width;

      if (Math.Abs(actualWidth - expectedWidth) > 0.01)
      {
        throw new Exception($"Unexpected difference {expectedWidth} <> {actualWidth}");
      }

      Console.WriteLine($"As expected: {actualWidth}");
    }
  }
}