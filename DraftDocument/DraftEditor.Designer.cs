namespace DraftDocument
{
    partial class DraftEditor
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
            this.groupBoxFields = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textControl = new DraftDocument.TextControl();
            this.groupBoxFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFields
            // 
            this.groupBoxFields.Controls.Add(this.tableLayoutPanel);
            this.groupBoxFields.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFields.Name = "groupBoxFields";
            this.groupBoxFields.Size = new System.Drawing.Size(830, 75);
            this.groupBoxFields.TabIndex = 1;
            this.groupBoxFields.TabStop = false;
            this.groupBoxFields.Text = "Campos";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AllowDrop = true;
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(824, 56);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textControl
            // 
            this.textControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textControl.Location = new System.Drawing.Point(0, 93);
            this.textControl.Name = "textControl";
            this.textControl.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            this.textControl.Options.MailMerge.KeepLastParagraph = false;
            this.textControl.Size = new System.Drawing.Size(854, 484);
            this.textControl.TabIndex = 0;
            // 
            // DraftEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 577);
            this.Controls.Add(this.textControl);
            this.Controls.Add(this.groupBoxFields);
            this.Name = "DraftEditor";
            this.Text = "Minuta Contratual";
            this.groupBoxFields.ResumeLayout(false);
            this.groupBoxFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextControl textControl;
        private System.Windows.Forms.GroupBox groupBoxFields;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;        
       
    }
}