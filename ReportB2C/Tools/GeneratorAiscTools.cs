using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using ReportB2C.Models;
using ReportB2C.Models.EpuModels;
using ReportB2C.ModelsLocal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReportB2C.Tools
{
    public class GeneratorAiscTools : IGeneratorAiscTools
    {
        string path;

        public ObservableCollection<AisExcel> CreateExcel(string path)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb;
            Worksheet ws;

            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets["Arkusz1"];

            ObservableCollection<AisExcel> listAisExcel = new ObservableCollection<AisExcel>();

            for (int i = 1; i <= 5 * 8; i = i + 8)
            {
                AisExcel aisExcelStatima = new AisExcel()
                {
                    Name = ws.Cells[i, 1].Value2,
                    Stitching = (int)ws.Cells[i + 1, 2].Value2,
                    StitchingCost = new decimal[2] { (decimal)ws.Cells[i + 1, 3].Value2, (decimal)ws.Cells[i + 1, 4].Value2 },
                    Scanning = (int)ws.Cells[i + 2, 2].Value2,
                    ScanningCost = new decimal[2] { (decimal)ws.Cells[i + 2, 3].Value2, (decimal)ws.Cells[i + 2, 4].Value2 },
                    HumanOcr = (int)ws.Cells[i + 3, 2].Value2,
                    HumanOcrCost = new decimal[2] { (decimal)ws.Cells[i + 3, 3].Value2, (decimal)ws.Cells[i + 3, 4].Value2 },
                    Conversion = (int)ws.Cells[i + 4, 2].Value2,
                    ConversionCost = new decimal[2] { (decimal)ws.Cells[i + 4, 3].Value2, (decimal)ws.Cells[i + 4, 4].Value2 },
                    RecognitionTcr = (int)ws.Cells[i + 5, 2].Value2,
                    RecognitionTcrCost = new decimal[2] { (decimal)ws.Cells[i + 5, 3].Value2, (decimal)ws.Cells[i + 5, 4].Value2 },
                    Google = (int)ws.Cells[i + 6, 2].Value2,
                    GoogleCost = new decimal[2] { (decimal)ws.Cells[i + 6, 3].Value2, (decimal)ws.Cells[i + 6, 4].Value2 },
                    AllCost = (decimal)ws.Cells[i + 7, 4].Value2
                };

                listAisExcel.Add(aisExcelStatima);
            }

            wb.Close();

            return listAisExcel;

        }

        public void CreateWordDocument(ObservableCollection<AisExcel> aisExcels, DateTime protocolDate, DateTime jobDate)
        {
            object mainPathRead = Directory.GetCurrentDirectory();

            object statimaReadPath = mainPathRead + "\\Templates\\Generator\\AISOCR\\Protokoły\\PROTOKÓL REALIZACJI DIGITALIZACJI DOKUMENTÓW - STATIMA S.A..docx";
            object cyberReadPath = mainPathRead + "\\Templates\\Generator\\AISOCR\\Protokoły\\PROTOKÓL REALIZACJI DIGITALIZACJI DOKUMENTÓW - CYBERWINDYKACJA.docx";
            object cyberIReadPath = mainPathRead + "\\Templates\\Generator\\AISOCR\\Protokoły\\PROTOKÓL REALIZACJI DIGITALIZACJI DOKUMENTÓW - CYBERWINDYKACJA I.docx";
            object cyberIIReadPath = mainPathRead + "\\Templates\\Generator\\AISOCR\\Protokoły\\PROTOKÓL REALIZACJI DIGITALIZACJI DOKUMENTÓW - Cyberwindykacja II.docx";

            object statimaSavePath = mainPathRead + "\\Wynik\\PROTOKÓL REALIZACJI DIGITALIZACJI DOKUMENTÓW - STATIMA S.A..docx";
            object cyberSavePath = mainPathRead + "\\Wynik\\PROTOKÓL REALIZACJI DIGITALIZACJI DOKUMENTÓW - CYBERWINDYKACJA.docx";
            object cyberISavePath = mainPathRead + "\\Wynik\\PROTOKÓL REALIZACJI DIGITALIZACJI DOKUMENTÓW - CYBERWINDYKACJA I.docx";
            object cyberIISavePath = mainPathRead + "\\Wynik\\PROTOKÓL REALIZACJI DIGITALIZACJI DOKUMENTÓW - CYBERWINDYKACJA II.docx";

            object statimaReadPathJob = mainPathRead + "\\Templates\\Generator\\AISOCR\\Zlecenia\\STATIMA S.A.  - zlecenie digitalizacji.docx";
            object cyberReadPathjob = mainPathRead + "\\Templates\\Generator\\AISOCR\\Zlecenia\\CYBERWINDYKACJA Sp. z o.o. - zlecenie digitalizacji.docx";
            object cyberIReadPathJob = mainPathRead + "\\Templates\\Generator\\AISOCR\\Zlecenia\\Cyber I Sp. z o.o.  - zlecenie digitalizacji.docx";
            object cyberIIReadPathJob = mainPathRead + "\\Templates\\Generator\\AISOCR\\Zlecenia\\Cyberwindykacja II Sp. z o.o  - zlecenie digitalizacji.docx";

            object statimaSavePathJob = mainPathRead + "\\Wynik\\STATIMA S.A.  - zlecenie digitalizacji.docx";
            object cyberSavePathJob = mainPathRead + "\\Wynik\\CYBERWINDYKACJA Sp. z o.o. - zlecenie digitalizacji.docx";
            object cyberISavePathJob = mainPathRead + "\\Wynik\\Cyber I Sp. z o.o.  - zlecenie digitalizacji.docx";
            object cyberIISavePathJob = mainPathRead + "\\Wynik\\Cyberwindykacja II Sp. z o.o  - zlecenie digitalizacji.docx";

            object[] pathesReadProtocol = new object[5] { statimaReadPath, cyberReadPath, cyberIReadPath, cyberIIReadPath, "" };
            object[] pathesSaveProtocol = new object[5] { statimaSavePath, cyberSavePath, cyberISavePath, cyberIISavePath, "" };

            object[] pathesReadJob = new object[5] { statimaReadPathJob, cyberReadPathjob, cyberIReadPathJob, cyberIIReadPathJob, "" };
            object[] pathesSaveJob = new object[5] { statimaSavePathJob, cyberSavePathJob, cyberISavePathJob, cyberIISavePathJob, "" };

            for (int i = 0; i < aisExcels.Count; i++)
            {
                if (aisExcels[i].Checked == false)
                    continue;

                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document documentProtocol = word.Documents.Open(ref pathesReadProtocol[i], false, false);
                

                documentProtocol.Activate();

                object missing = System.Reflection.Missing.Value;

                var placeholders = new List<(string placeholder, string value)>()
                {
                    ("{stitching}", aisExcels[i].Stitching.ToString()),
                    ("{scanning}", aisExcels[i].Scanning.ToString()),
                    ("{allCost}", aisExcels[i].AllCost.ToString()),
                    ("{protocolDate}", protocolDate.ToString().Replace("00:00:00","")),
                    ("{jobDate}", jobDate.ToString().Replace("00:00:00","")),
                };



                foreach (var placeholder in placeholders)
                {
                    Find findObject = word.ActiveWindow.Selection.Find;
                    findObject.ClearFormatting();
                    findObject.Text = placeholder.placeholder;
                    findObject.Replacement.ClearFormatting();
                    findObject.Replacement.Text = placeholder.value;

                    object replaceAll = WdReplace.wdReplaceAll;
                    findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref replaceAll, ref missing, ref missing, ref missing, ref missing);

                }

                documentProtocol.SaveAs2(pathesSaveProtocol[i]);
                documentProtocol.Close();

                Microsoft.Office.Interop.Word.Document documentJob = word.Documents.Open(ref pathesReadJob[i], false, false);
                documentJob.Activate();

                foreach (var placeholder in placeholders)
                {
                    Find findObject = word.ActiveWindow.Selection.Find;
                    findObject.ClearFormatting();
                    findObject.Text = placeholder.placeholder;
                    findObject.Replacement.ClearFormatting();
                    findObject.Replacement.Text = placeholder.value;

                    object replaceAll = WdReplace.wdReplaceAll;
                    findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref replaceAll, ref missing, ref missing, ref missing, ref missing);

                }

                documentJob.SaveAs2(pathesSaveJob[i]);
                documentJob.Close();
            }

        }
        public string GetPath()
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                path = openFileDialog.FileName;
            }

            return path;
        }
    }
}
