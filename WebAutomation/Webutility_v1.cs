using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
namespace WebAutomation
{
    public class Webutility_v1
    {  
         public Dictionary<string, string> dict = new Dictionary<string, string>();

        public void CreateExcelSheets()
        {
            string sourcefile = @"C:\Users\Manas.Singh\Desktop\Backup\Setup.xlsx";
            System.Reflection.Missing Default = System.Reflection.Missing.Value;

            var excel = new Excel.Application();
            Excel.Workbook excelWorkBook = excel.Workbooks.Open(sourcefile, Editable: true);
            excel.Visible = false;
            excel.DisplayAlerts = false;
            var sheets = excelWorkBook.Sheets;
      

            int sheetcol = 0;
            if (sheets != null)
            {

                foreach (var item in sheets)
                {
                    sheetcol++;
                    var sheet = (Excel.Worksheet)item;
                    if (sheetcol == 4)
                        break;

                    var ColumnCount = ((Excel.Range)sheet.UsedRange.Rows[1, Type.Missing]).Columns.Count;
                    var rowCount = ((Excel.Range)sheet.UsedRange.Columns[1, Type.Missing]).Rows.Count;

                    for (int i = 0; i < rowCount; i++)
                    {
                      var cell = (Excel.Range)sheet.Cells[i + 2, 1];
                      var dictvalue = (Excel.Range)sheet.Cells[i + 2, 2];
                        
                       if (cell.Value != null && cell.Value != string.Empty)
                       {
                         dict.Add(cell.Value, dictvalue.Value);
                       }

                       else
                       { 
                         break;
                       }
                    }
                }
            }

           excelWorkBook.Close();
            excel.Quit();

        }
    }
}
