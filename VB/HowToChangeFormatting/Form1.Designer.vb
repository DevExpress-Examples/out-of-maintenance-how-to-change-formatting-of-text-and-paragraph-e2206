Imports Microsoft.VisualBasic
Imports System
Namespace HowToChangeFormatting
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnFormatParagraph = New DevExpress.XtraEditors.SimpleButton()
			Me.btn_FormatChar = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditControl1.Location = New System.Drawing.Point(0, 54)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(517, 323)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btnFormatParagraph)
			Me.panelControl1.Controls.Add(Me.btn_FormatChar)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(517, 54)
			Me.panelControl1.TabIndex = 1
			' 
			' btnFormatParagraph
			' 
			Me.btnFormatParagraph.Location = New System.Drawing.Point(176, 12)
			Me.btnFormatParagraph.Name = "btnFormatParagraph"
			Me.btnFormatParagraph.Size = New System.Drawing.Size(145, 23)
			Me.btnFormatParagraph.TabIndex = 1
			Me.btnFormatParagraph.Text = "Apply Paragraph Formatting"
'			Me.btnFormatParagraph.Click += New System.EventHandler(Me.btnFormatParagraph_Click);
			' 
			' btn_FormatChar
			' 
			Me.btn_FormatChar.Location = New System.Drawing.Point(12, 12)
			Me.btn_FormatChar.Name = "btn_FormatChar"
			Me.btn_FormatChar.Size = New System.Drawing.Size(141, 23)
			Me.btn_FormatChar.TabIndex = 0
			Me.btn_FormatChar.Text = "Apply Character Formatting"
'			Me.btn_FormatChar.Click += New System.EventHandler(Me.btn_FormatChar_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(517, 377)
			Me.Controls.Add(Me.richEditControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private WithEvents btn_FormatChar As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnFormatParagraph As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

