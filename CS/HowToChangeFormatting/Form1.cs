using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Utils;
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
            DocumentPosition pos = doc.Selection.Start;
            DocumentRange range = doc.CreateRange(pos, 0);
            ParagraphProperties pp = doc.BeginUpdateParagraphs(range);
            // Center paragraph
            pp.Alignment = ParagraphAlignment.Center;
            // Set triple spacing
            pp.LineSpacingType = ParagraphLineSpacing.Multiple;
            pp.LineSpacingMultiplier = 3;
            // Set left indent at 0.5".
            // Default unit is 1/300 of an inch (a document unit).
            pp.LeftIndent = Units.InchesToDocumentsF(0.5f);
            // Set tab stop at 1.5"
            TabInfoCollection tbiColl = pp.BeginUpdateTabs(true);
            TabInfo tbi = new TabInfo();
            tbi.Alignment = TabAlignmentType.Center;
            tbi.Position = Units.InchesToDocumentsF(1.5f);
            tbiColl.Add(tbi);
            pp.EndUpdateTabs(tbiColl);
            doc.EndUpdateParagraphs(pp);
            #endregion #formatparagraph
        }

        private void btn_CharStyle_Click(object sender, EventArgs e)
        {
            #region #charstyle
            Document doc = richEditControl1.Document;
            CharacterStyle cstyle = doc.CharacterStyles["MyCharStyle"];

            if (cstyle == null)
            {
                cstyle = doc.CharacterStyles.CreateNew();
                cstyle.Name = "MyCharStyle";
                cstyle.Parent = doc.CharacterStyles["Default Paragraph Font"];
                cstyle.ForeColor = Color.DarkOrange;
                cstyle.Strikeout = StrikeoutType.Double;
                cstyle.FontName = "Verdana";
                doc.CharacterStyles.Add(cstyle);
            }

            DocumentRange range = doc.Selection;
            CharacterProperties charProps =
                doc.BeginUpdateCharacters(range);
            charProps.Style = cstyle;
            doc.EndUpdateCharacters(charProps);
            #endregion #charstyle
        }

        private void btn_ParStyle_Click(object sender, EventArgs e)
        {
            #region #parstyle
            Document doc = richEditControl1.Document;
            ParagraphStyle pstyle = doc.ParagraphStyles["MyParagraphStyle"];
            if (pstyle == null)
            {
                pstyle = doc.ParagraphStyles.CreateNew();
                pstyle.Name = "MyParagraphStyle";
                pstyle.Parent = doc.ParagraphStyles["Normal"];
                pstyle.Alignment = ParagraphAlignment.Justify;
                pstyle.LineSpacingType = ParagraphLineSpacing.Single;
                pstyle.FirstLineIndentType = ParagraphFirstLineIndent.None;
                doc.ParagraphStyles.Add(pstyle);
            }
            DocumentRange range = doc.Selection;
            ParagraphProperties parProps =
                doc.BeginUpdateParagraphs(range);
            parProps.FirstLineIndentType = null;
            parProps.Alignment = ParagraphAlignment.Justify;
            parProps.Style = pstyle;
            doc.EndUpdateParagraphs(parProps);
            #endregion #parstyle
        }

        private void btn_LinkedStyle_Click(object sender, EventArgs e)
        {
            #region #linkedparstyle
            Document doc = richEditControl1.Document;
            ParagraphStyle pstyle = doc.ParagraphStyles["MyLinkedParagraphStyle"];
            CharacterStyle cstyle = doc.CharacterStyles["MyLinkedCharStyle"];
            if (pstyle == null && cstyle == null)
            {
                cstyle = doc.CharacterStyles.CreateNew();
                cstyle.Name = "MyLinkedCharStyle";
                doc.CharacterStyles.Add(cstyle);
                pstyle = doc.ParagraphStyles.CreateNew();
                pstyle.LinkedStyle = cstyle;
                pstyle.Name = "MyLinkedParagraphStyle";
                pstyle.Parent = doc.ParagraphStyles["Normal"];
                pstyle.Alignment = ParagraphAlignment.Center;
                pstyle.LineSpacingType = ParagraphLineSpacing.Single;
                pstyle.ForeColor = Color.DarkGreen;
                pstyle.Underline = UnderlineType.None;
                pstyle.FontName = "Script";
                doc.ParagraphStyles.Add(pstyle);
            }
            DocumentRange range = doc.Selection;
            CharacterProperties charProps =
                doc.BeginUpdateCharacters(range);
            charProps.Style = cstyle;
            doc.EndUpdateCharacters(charProps);
            #endregion #linkedparstyle
        }

    }
}