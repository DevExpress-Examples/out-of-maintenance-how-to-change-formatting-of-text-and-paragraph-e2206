Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Utils
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.Office.Utils
#End Region ' #usings

Namespace HowToChangeFormatting
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            richEditControl1.Document.LoadDocument("SampleText.rtf", DocumentFormat.Rtf)
            richEditControl1.Document.Selection = richEditControl1.Document.Paragraphs(1).Range

        End Sub

        Private Sub btn_FormatChar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_FormatChar.Click
'            #Region "#formatchar"
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
'            #End Region ' #formatchar
        End Sub

        Private Sub btnFormatParagraph_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFormatParagraph.Click
'            #Region "#formatparagraph"
            Dim doc As Document = richEditControl1.Document
            Dim pos As DocumentPosition = doc.Selection.Start
            Dim range As DocumentRange = doc.CreateRange(pos, 0)
            Dim pp As ParagraphProperties = doc.BeginUpdateParagraphs(range)
            ' Center paragraph
            pp.Alignment = ParagraphAlignment.Center
            ' Set triple spacing
            pp.LineSpacingType = ParagraphLineSpacing.Multiple
            pp.LineSpacingMultiplier = 3
            ' Set left indent at 0.5".
            ' Default unit is 1/300 of an inch (a document unit).
            pp.LeftIndent = Units.InchesToDocumentsF(0.5F)
            ' Set tab stop at 1.5"
            Dim tbiColl As TabInfoCollection = pp.BeginUpdateTabs(True)
            Dim tbi As New TabInfo()
            tbi.Alignment = TabAlignmentType.Center
            tbi.Position = Units.InchesToDocumentsF(1.5F)
            tbiColl.Add(tbi)
            pp.EndUpdateTabs(tbiColl)
            doc.EndUpdateParagraphs(pp)
'            #End Region ' #formatparagraph
        End Sub

        Private Sub btn_CharStyle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_CharStyle.Click
'            #Region "#charstyle"
            Dim doc As Document = richEditControl1.Document
            Dim cstyle As CharacterStyle = doc.CharacterStyles("MyCharStyle")

            If cstyle Is Nothing Then
                cstyle = doc.CharacterStyles.CreateNew()
                cstyle.Name = "MyCharStyle"
                cstyle.Parent = doc.CharacterStyles("Default Paragraph Font")
                cstyle.ForeColor = Color.DarkOrange
                cstyle.Strikeout = StrikeoutType.Double
                cstyle.FontName = "Verdana"
                doc.CharacterStyles.Add(cstyle)
            End If

            Dim range As DocumentRange = doc.Selection
            Dim charProps As CharacterProperties = doc.BeginUpdateCharacters(range)
            charProps.Style = cstyle
            doc.EndUpdateCharacters(charProps)
'            #End Region ' #charstyle
        End Sub

        Private Sub btn_ParStyle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_ParStyle.Click
'            #Region "#parstyle"
            Dim doc As Document = richEditControl1.Document
            Dim pstyle As ParagraphStyle = doc.ParagraphStyles("MyParagraphStyle")
            If pstyle Is Nothing Then
                pstyle = doc.ParagraphStyles.CreateNew()
                pstyle.Name = "MyParagraphStyle"
                pstyle.Parent = doc.ParagraphStyles("Normal")
                pstyle.Alignment = ParagraphAlignment.Justify
                pstyle.LineSpacingType = ParagraphLineSpacing.Single
                pstyle.FirstLineIndentType = ParagraphFirstLineIndent.None
                doc.ParagraphStyles.Add(pstyle)
            End If
            Dim range As DocumentRange = doc.Selection
            Dim parProps As ParagraphProperties = doc.BeginUpdateParagraphs(range)
            parProps.FirstLineIndentType = Nothing
            parProps.Alignment = ParagraphAlignment.Justify
            parProps.Style = pstyle
            doc.EndUpdateParagraphs(parProps)
'            #End Region ' #parstyle
        End Sub

        Private Sub btn_LinkedStyle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_LinkedStyle.Click
'            #Region "#linkedparstyle"
            Dim doc As Document = richEditControl1.Document
            Dim pstyle As ParagraphStyle = doc.ParagraphStyles("MyLinkedParagraphStyle")
            Dim cstyle As CharacterStyle = doc.CharacterStyles("MyLinkedCharStyle")
            If pstyle Is Nothing AndAlso cstyle Is Nothing Then
                cstyle = doc.CharacterStyles.CreateNew()
                cstyle.Name = "MyLinkedCharStyle"
                doc.CharacterStyles.Add(cstyle)
                pstyle = doc.ParagraphStyles.CreateNew()
                pstyle.LinkedStyle = cstyle
                pstyle.Name = "MyLinkedParagraphStyle"
                pstyle.Parent = doc.ParagraphStyles("Normal")
                pstyle.Alignment = ParagraphAlignment.Center
                pstyle.LineSpacingType = ParagraphLineSpacing.Single
                pstyle.ForeColor = Color.DarkGreen
                pstyle.Underline = UnderlineType.None
                pstyle.FontName = "Script"
                doc.ParagraphStyles.Add(pstyle)
            End If
            Dim range As DocumentRange = doc.Selection
            Dim charProps As CharacterProperties = doc.BeginUpdateCharacters(range)
            charProps.Style = cstyle
            doc.EndUpdateCharacters(charProps)
'            #End Region ' #linkedparstyle
        End Sub

    End Class
End Namespace