using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TransactionsReaderPrototype
{
    public partial class Form1 : Form
    {
        private string _outoutDir;
        private string _inputPdfFile;

        public Form1()
        {
            InitializeComponent();
            openPdfDialog.Filter = "PDF files (*.pdf)|*.pdf";
            Shown += Form1_Shown;

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            SelectPdf.Click += LoadPdfFile;
            StartProcessing_btn.Click += StartProcessing_btn_Click;
        }

        private void StartProcessing_btn_Click(object sender, EventArgs e)
        {
            var tetxtFile = ConvertPDFToText();
            ConvertTextToCsv(tetxtFile);
        }

        private void ConvertTextToCsv(string tetxtFile)
        {
            var outputCsv = $"{_inputPdfFile}.CSV";
            var header = "DATA CONT.; DATA VALUTA; DATA DISP.; A VOSTRO DEBITO; A VOSTRO CREDITO; DESCRIZIONE DELLE OPERAZIONI;\n";
            var lines =new List<string>();
            File.AppendAllText(outputCsv,header);
            var regexParser = new Regex(@"^((\s+)(?<dates>((\d{2}[/]\d{2}[/]\d{2})\s+){3})(?<number>((\d{1,3}\.*)+\,\d{2})[-]?))(?<message>.*)$");
            foreach (var line in File.ReadLines(tetxtFile))
            {
                var match = regexParser.Match(line);
                var suc = match.Success;
                if (suc)
                {
                    var dates = match.Groups["dates"].Value;
                    var splitedDate = dates.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);
                    var number = match.Groups["number"].Value;
                    var numberRepresentation = "";
                    numberRepresentation = number.EndsWith("-") ? $"{number};{string.Empty}" : $"{string.Empty};{number}";
                    var message = match.Groups["message"].Value;
                    var lineToAdd =
                        $"{splitedDate[0]};{splitedDate[1]};{splitedDate[2]};{numberRepresentation};{message}";
                    lines.Add(lineToAdd);
                }
            }
            File.AppendAllLines(outputCsv,lines);
            MessageBox.Show("Operation done please open the generated file to check.","DONE");
        }

        private string ConvertPDFToText()
        {
            var outputFile = Path.GetTempFileName();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "tools\\pdftotext.exe",
                Arguments = $"\"{_inputPdfFile}\" \"{outputFile}\" -r 100 -layout",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process processTemp = new Process
            {
                StartInfo = startInfo,
                EnableRaisingEvents = true
            };
            try
            {
                processTemp.Start();
                processTemp.WaitForExit();

            }
            catch (Exception e)
            {
                throw;
            }
            return outputFile;
        }

        private void LoadPdfFile(object sender, EventArgs e)
        {
            var openDialogResult = openPdfDialog.ShowDialog();
            if (openDialogResult == DialogResult.OK)
            {
                _inputPdfFile = openPdfDialog.FileName;
                PdfFile_txt.Text = _inputPdfFile;
            }
        }
    }
}
