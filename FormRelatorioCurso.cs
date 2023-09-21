using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace projeto4
{

    public partial class FormRelatorioCurso : MaterialForm
    {

        string cs = @"server=127.0.0.1;" + "uid=root;" + "pwd=;" + "database=academico";

        public FormRelatorioCurso()
        {
            InitializeComponent();
            carregaImpressoras();
        }

        private void carregaImpressoras()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
            }
        }


        private void MontaRelatorio()
        {
            var con = new MySqlConnection(cs);
            con.Open();

            var sql = "SELECT * FROM curso WHERE 1 = 1";
            
            if (cboTipo.SelectedIndex != 0)
            {
                sql += " AND tipo = @tipo";
            }
            if (txtDt.Text != "")
            {
                sql += " AND ano_criado = @ano";
            }

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            if (cboTipo.SelectedIndex != 0)
            {
                sqlAd.SelectCommand.Parameters.AddWithValue("@tipo", cboTipo.Text);
            }
            if (txtDt.Text != "")
            {
                sqlAd.SelectCommand.Parameters.AddWithValue("@ano", txtDt);
            }

            var dt = new DataTable();
            sqlAd.Fill(dt);
            con.Close();

            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            int y = 15;
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatório do Curso", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);

            PdfTable table = new PdfTable();

            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
            table.Style.ShowHeader = true;
            table.DataSource = dt;

            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }
            
            table.Draw(page, new Point(0, y + 30));

            doc.SaveToFile("RelatorioCurso.pdf");
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            MontaRelatorio();

            String impressora = cboImpressora.Text;

            if (String.IsNullOrEmpty(impressora)) return;

            PdfDocument doc = new PdfDocument();

            doc.LoadFromFile(@"RelatorioCurso.pdf");
            doc.PrintSettings.PrinterName = impressora;
            doc.Print();

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            MontaRelatorio();

            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioCurso.pdf")
            {
                UseShellExecute = true,
            };
            p.Start();
        }

        private void FormRelatorioCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal.isOpenRelatorioCurso = false;
        }
    }
}
