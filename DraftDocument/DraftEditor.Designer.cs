namespace DraftDocument
{
    internal partial class DraftEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DraftEditor));
            this.richEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonLoadFile = new System.Windows.Forms.ToolStripButton();
            this.buttonSaveFile = new System.Windows.Forms.ToolStripButton();
            this.buttonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labelParameters = new System.Windows.Forms.ToolStripLabel();
            this.comboBoxParameters = new System.Windows.Forms.ToolStripComboBox();
            this.ButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonEdit = new System.Windows.Forms.ToolStripButton();
            this.buttonShowResult = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.tabEdit = new DevExpress.XtraTab.XtraTabPage();
            this.tabResult = new DevExpress.XtraTab.XtraTabPage();
            this.richEditControlResult = new DevExpress.XtraRichEdit.RichEditControl();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEditControl
            // 
            this.richEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl.Location = new System.Drawing.Point(0, 0);
            this.richEditControl.Name = "richEditControl";
            this.richEditControl.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.richEditControl.Options.MailMerge.KeepLastParagraph = false;
            this.richEditControl.Size = new System.Drawing.Size(824, 571);
            this.richEditControl.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonLoadFile,
            this.buttonSaveFile,
            this.buttonPrint,
            this.toolStripSeparator1,
            this.labelParameters,
            this.comboBoxParameters,
            this.ButtonAdd,
            this.toolStripSeparator2,
            this.buttonEdit,
            this.buttonShowResult});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(830, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonLoadFile
            // 
            this.buttonLoadFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadFile.Image")));
            this.buttonLoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLoadFile.Name = "buttonLoadFile";
            this.buttonLoadFile.Size = new System.Drawing.Size(110, 22);
            this.buttonLoadFile.Text = "Carregar Arquivo";
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.Image")));
            this.buttonSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(57, 22);
            this.buttonSaveFile.Text = "Salvar";
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(65, 22);
            this.buttonPrint.Text = "Imprimir";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // labelParameters
            // 
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(66, 22);
            this.labelParameters.Text = "Parâmetros:";
            // 
            // comboBoxParameters
            // 
            this.comboBoxParameters.Name = "comboBoxParameters";
            this.comboBoxParameters.Size = new System.Drawing.Size(121, 25);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
            this.ButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(55, 22);
            this.ButtonAdd.Text = "Adicionar";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonEdit
            // 
            this.buttonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(39, 22);
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonShowResult
            // 
            this.buttonShowResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonShowResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonShowResult.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowResult.Image")));
            this.buttonShowResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonShowResult.Name = "buttonShowResult";
            this.buttonShowResult.Size = new System.Drawing.Size(99, 22);
            this.buttonShowResult.Text = "Mostrar Resultado";
            this.buttonShowResult.Click += new System.EventHandler(this.buttonShowResult_Click);
            // 
            // tabControl
            // 
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Never;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.tabEdit;
            this.tabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.tabControl.Size = new System.Drawing.Size(830, 577);
            this.tabControl.TabIndex = 22;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabEdit,
            this.tabResult});
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.richEditControl);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(824, 571);
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.richEditControlResult);
            this.tabResult.Name = "tabResult";
            this.tabResult.Size = new System.Drawing.Size(824, 571);
            // 
            // richEditControlResult
            // 
            this.richEditControlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControlResult.Location = new System.Drawing.Point(0, 0);
            this.richEditControlResult.Name = "richEditControlResult";
            this.richEditControlResult.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.richEditControlResult.Options.MailMerge.KeepLastParagraph = false;
            this.richEditControlResult.Size = new System.Drawing.Size(824, 571);
            this.richEditControlResult.TabIndex = 0;
            // 
            // DraftEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(830, 602);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DraftEditor";
            this.Text = "Mala Direta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DraftEditor_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabEdit.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labelParameters;
        private System.Windows.Forms.ToolStripComboBox comboBoxParameters;
        private System.Windows.Forms.ToolStripButton ButtonAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton buttonEdit;
        private System.Windows.Forms.ToolStripButton buttonShowResult;
        private DevExpress.XtraTab.XtraTabControl tabControl;
        private DevExpress.XtraTab.XtraTabPage tabEdit;
        private DevExpress.XtraTab.XtraTabPage tabResult;        
        private DevExpress.XtraRichEdit.RichEditControl richEditControlResult;
        private System.Windows.Forms.ToolStripButton buttonLoadFile;
        private System.Windows.Forms.ToolStripButton buttonSaveFile;
        private System.Windows.Forms.ToolStripButton buttonPrint;
    }
}