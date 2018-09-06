namespace PhotoSearch
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this._subjectText = new System.Windows.Forms.TextBox();
            this._photoBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Show me a picture of a(n):";
            // 
            // _subjectText
            // 
            this._subjectText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._subjectText.Location = new System.Drawing.Point(148, 15);
            this._subjectText.Name = "_subjectText";
            this._subjectText.Size = new System.Drawing.Size(442, 20);
            this._subjectText.TabIndex = 1;
            // 
            // _photoBox
            // 
            this._photoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._photoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._photoBox.Location = new System.Drawing.Point(14, 60);
            this._photoBox.Name = "_photoBox";
            this._photoBox.Size = new System.Drawing.Size(657, 389);
            this._photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._photoBox.TabIndex = 2;
            this._photoBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(14, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 10);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Location = new System.Drawing.Point(596, 13);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(75, 23);
            this._searchButton.TabIndex = 4;
            this._searchButton.Text = "Search";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this._searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this._searchButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._photoBox);
            this.Controls.Add(this._subjectText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Photo Search";
            ((System.ComponentModel.ISupportInitialize)(this._photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _subjectText;
        private System.Windows.Forms.PictureBox _photoBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _searchButton;
    }
}

