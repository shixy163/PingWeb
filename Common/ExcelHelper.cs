using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ExcelHelper
    {
        public static DataTable ExcelToDatatalbe(string excelPath)//导入
        {
            Workbook book = new Workbook(excelPath);
            Worksheet sheet = book.Worksheets[0];
            Cells cells = sheet.Cells;
            //获取excel中的数据保存到一个datatable中
            DataTable dt_Import = cells.ExportDataTableAsString(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, true);
            // dt_Import.
            return dt_Import;
        }

    }
}
