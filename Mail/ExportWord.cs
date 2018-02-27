using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop;
using System.Runtime.InteropServices;


namespace Mail
{
    public partial class ExportWord : Form
    {
        public ExportWord()
        {
            InitializeComponent();
        }

        private void ExportWord_Load(object sender, EventArgs e)
        {
            ExportToWord();
        }

        public void ExportToWord()
        {
            word.Application newapp = new word.Application();
            word.Document newdoc;
            object nothing = System.Reflection.Missing.Value;
            newdoc = newapp.Documents.Add(ref nothing, ref nothing,ref nothing,ref nothing);
            newapp.Visible = true;
            var FileName = @"C:\test.doc";

            var wordTable = newdoc.Tables.Add(newdoc.Paragraphs.Last.Range,10,10,ref nothing);
            for (var i = 0; i < 10;i++)
            {
                wordTable.Cell(0, i + 1).Range.Text = i.ToString();
            }

            newdoc.SaveAsQuickStyleSet(FileName);
        }
    }
}
