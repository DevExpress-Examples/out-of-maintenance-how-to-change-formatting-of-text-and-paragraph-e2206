namespace HowToChangeFormatting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnFormatParagraph = new DevExpress.XtraEditors.SimpleButton();
            this.btn_FormatChar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 54);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(517, 323);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFormatParagraph);
            this.panelControl1.Controls.Add(this.btn_FormatChar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(517, 54);
            this.panelControl1.TabIndex = 1;
            // 
            // btnFormatParagraph
            // 
            this.btnFormatParagraph.Location = new System.Drawing.Point(176, 12);
            this.btnFormatParagraph.Name = "btnFormatParagraph";
            this.btnFormatParagraph.Size = new System.Drawing.Size(145, 23);
            this.btnFormatParagraph.TabIndex = 1;
            this.btnFormatParagraph.Text = "Apply Paragraph Formatting";
            this.btnFormatParagraph.Click += new System.EventHandler(this.btnFormatParagraph_Click);
            // 
            // btn_FormatChar
            // 
            this.btn_FormatChar.Location = new System.Drawing.Point(12, 12);
            this.btn_FormatChar.Name = "btn_FormatChar";
            this.btn_FormatChar.Size = new System.Drawing.Size(141, 23);
            this.btn_FormatChar.TabIndex = 0;
            this.btn_FormatChar.Text = "Apply Character Formatting";
            this.btn_FormatChar.Click += new System.EventHandler(this.btn_FormatChar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 377);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_FormatChar;
        private DevExpress.XtraEditors.SimpleButton btnFormatParagraph;
    }
}

