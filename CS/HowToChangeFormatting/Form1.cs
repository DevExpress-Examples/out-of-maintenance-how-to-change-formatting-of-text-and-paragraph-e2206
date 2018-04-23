using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
#endregion #usings

namespace HowToChangeFormatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richEditControl1.Document.LoadDocument("SampleText.rtf", DocumentFormat.Rtf);
            richEditControl1.Document.Selection = richEditControl1.Document.Paragraphs[1].Range;
            richEditControl1.ActiveView.ZoomFactor = 0.8f;
        }

        private void btn_FormatChar_Click(object sender, EventArgs e)
        {
            #region #formatchar
            Document doc = richEditControl1.Document;
            DocumentRange range = richEditControl1.Document.Paragraphs[1].Range;
            CharacterProperties cp = doc.BeginUpdateCharacters(range);
            cp.FontName = "Comic Sans MS";
            cp.FontSize = 18;
            cp.ForeColor = Color.Yellow;
            cp.BackColor = Color.Blue;
            cp.Underline = UnderlineType.DoubleWave;
            cp.UnderlineColor = Color.White;
            doc.EndUpdateCharacters(cp);
            #endregion #formatchar
        }

        private void btnFormatParagraph_Click(object sender, EventArgs e)
        {
            #region #formatparagraph
            Document doc = richEditControl1.Document;
            DocumentPosition pos = richEditControl1.Document.Selection.Start;
            DocumentRange range = richEditControl1.Document.CreateRange(pos, 0);

            ParagraphProperties pp = doc.BeginUpdateParagraphs(range);
            pp.Alignment = ParagraphAlignment.Center;
            pp.LineSpacingType = ParagraphLineSpacing.Multiple;
            pp.LineSpacingMultiplier = 3;
            pp.LeftIndent = 150;
            doc.EndUpdateParagraphs(pp);
            #endregion #formatparagraph
        }

        
    }
}