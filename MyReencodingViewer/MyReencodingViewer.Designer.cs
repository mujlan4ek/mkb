namespace MyReencodingViewer
{
    partial class MyReencodingViewer
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
            this.tbTextFile = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbCyrEncodings = new System.Windows.Forms.ComboBox();
            this.rtbTextFile = new System.Windows.Forms.RichTextBox();
            this.ofdTextFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tbTextFile
            // 
            this.tbTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTextFile.Location = new System.Drawing.Point(20, 20);
            this.tbTextFile.Name = "tbTextFile";
            this.tbTextFile.ReadOnly = true;
            this.tbTextFile.Size = new System.Drawing.Size(540, 26);
            this.tbTextFile.TabIndex = 0;
            this.tbTextFile.TextChanged += new System.EventHandler(this.ReloadTextFile);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(580, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(140, 40);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Открыть файл";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cmbCyrEncodings
            // 
            this.cmbCyrEncodings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCyrEncodings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCyrEncodings.FormattingEnabled = true;
            this.cmbCyrEncodings.Location = new System.Drawing.Point(20, 60);
            this.cmbCyrEncodings.Name = "cmbCyrEncodings";
            this.cmbCyrEncodings.Size = new System.Drawing.Size(540, 28);
            this.cmbCyrEncodings.TabIndex = 2;
            this.cmbCyrEncodings.SelectedIndexChanged += new System.EventHandler(this.ReloadTextFile);
            // 
            // rtbTextFile
            // 
            this.rtbTextFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTextFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbTextFile.Location = new System.Drawing.Point(20, 100);
            this.rtbTextFile.Name = "rtbTextFile";
            this.rtbTextFile.ReadOnly = true;
            this.rtbTextFile.Size = new System.Drawing.Size(700, 320);
            this.rtbTextFile.TabIndex = 3;
            this.rtbTextFile.Text = "";
            // 
            // ofdTextFile
            // 
            this.ofdTextFile.Filter = "Текстовые файлы (*.txt)|*.txt";
            // 
            // MyReencodingViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 441);
            this.Controls.Add(this.rtbTextFile);
            this.Controls.Add(this.cmbCyrEncodings);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbTextFile);
            this.Name = "MyReencodingViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр с выбором кодировки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyКeencodingViewer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTextFile;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cmbCyrEncodings;
        private System.Windows.Forms.RichTextBox rtbTextFile;
        private System.Windows.Forms.OpenFileDialog ofdTextFile;
    }
}

