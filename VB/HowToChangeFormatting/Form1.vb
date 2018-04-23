Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
#End Region ' #usings

Namespace HowToChangeFormatting
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			richEditControl1.Document.LoadDocument("SampleText.rtf", DocumentFormat.Rtf)
			richEditControl1.Document.Selection = richEditControl1.Document.Paragraphs(1).Range
			richEditControl1.ActiveView.ZoomFactor = 0.8f
		End Sub

		Private Sub btn_FormatChar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_FormatChar.Click
'			#Region "#formatchar"
			Dim doc As Document = richEditControl1.Document
			Dim range As DocumentRange = richEditControl1.Document.Paragraphs(1).Range
			Dim cp As CharacterProperties = doc.BeginUpdateCharacters(range)
			cp.FontName = "Comic Sans MS"
			cp.FontSize = 18
			cp.ForeColor = Color.Yellow
			cp.BackColor = Color.Blue
			cp.Underline = UnderlineType.DoubleWave
			cp.UnderlineColor = Color.White
			doc.EndUpdateCharacters(cp)
'			#End Region ' #formatchar
		End Sub

		Private Sub btnFormatParagraph_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFormatParagraph.Click
'			#Region "#formatparagraph"
			Dim doc As Document = richEditControl1.Document
			Dim pos As DocumentPosition = richEditControl1.Document.Selection.Start
			Dim range As DocumentRange = richEditControl1.Document.CreateRange(pos, 0)

			Dim pp As ParagraphProperties = doc.BeginUpdateParagraphs(range)
			pp.Alignment = ParagraphAlignment.Center
			pp.LineSpacingType = ParagraphLineSpacing.Multiple
			pp.LineSpacingMultiplier = 3
			pp.LeftIndent = 150
			doc.EndUpdateParagraphs(pp)
'			#End Region ' #formatparagraph
		End Sub


	End Class
End Namespace