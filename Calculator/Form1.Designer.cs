namespace Calculator
{
    partial class mainForm
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.calcTab = new System.Windows.Forms.TabPage();
            this.factorTab = new System.Windows.Forms.TabPage();
            this.sumPage = new System.Windows.Forms.TabPage();
            this.tabPageSums = new System.Windows.Forms.TabControl();
            this.geometricTab = new System.Windows.Forms.TabPage();
            this.arithmeticTab = new System.Windows.Forms.TabPage();
            this.naturalTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sum_naturals_upperboundTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sum_naturals_lowerboundTxtbox = new System.Windows.Forms.TextBox();
            this.sum_naturalsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.factor_factorizeBtn = new System.Windows.Forms.Button();
            this.sum_naturals_displayTxtbox = new System.Windows.Forms.TextBox();
            this.factors_numTxtbox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.factors_numTxtbox2 = new System.Windows.Forms.TextBox();
            this.factor_gcfBtn = new System.Windows.Forms.Button();
            this.factors_primelbl1 = new System.Windows.Forms.Label();
            this.factors_primelbl2 = new System.Windows.Forms.Label();
            this.factor_resultTxtbox = new System.Windows.Forms.TextBox();
            this.tabPage.SuspendLayout();
            this.factorTab.SuspendLayout();
            this.sumPage.SuspendLayout();
            this.tabPageSums.SuspendLayout();
            this.naturalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPage.Controls.Add(this.calcTab);
            this.tabPage.Controls.Add(this.factorTab);
            this.tabPage.Controls.Add(this.sumPage);
            this.tabPage.Location = new System.Drawing.Point(-1, 0);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(344, 333);
            this.tabPage.TabIndex = 0;
            this.tabPage.SelectedIndexChanged += new System.EventHandler(this.tabPage_SelectedIndexChanged);
            // 
            // calcTab
            // 
            this.calcTab.Location = new System.Drawing.Point(4, 22);
            this.calcTab.Name = "calcTab";
            this.calcTab.Padding = new System.Windows.Forms.Padding(3);
            this.calcTab.Size = new System.Drawing.Size(392, 323);
            this.calcTab.TabIndex = 0;
            this.calcTab.Text = "Calculator";
            this.calcTab.UseVisualStyleBackColor = true;
            // 
            // factorTab
            // 
            this.factorTab.Controls.Add(this.factor_resultTxtbox);
            this.factorTab.Controls.Add(this.factors_primelbl2);
            this.factorTab.Controls.Add(this.factors_primelbl1);
            this.factorTab.Controls.Add(this.factor_gcfBtn);
            this.factorTab.Controls.Add(this.factors_numTxtbox2);
            this.factorTab.Controls.Add(this.label3);
            this.factorTab.Controls.Add(this.factors_numTxtbox1);
            this.factorTab.Controls.Add(this.factor_factorizeBtn);
            this.factorTab.Location = new System.Drawing.Point(4, 22);
            this.factorTab.Name = "factorTab";
            this.factorTab.Padding = new System.Windows.Forms.Padding(3);
            this.factorTab.Size = new System.Drawing.Size(336, 307);
            this.factorTab.TabIndex = 1;
            this.factorTab.Text = "Factors";
            this.factorTab.UseVisualStyleBackColor = true;
            // 
            // sumPage
            // 
            this.sumPage.Controls.Add(this.tabPageSums);
            this.sumPage.Location = new System.Drawing.Point(4, 22);
            this.sumPage.Name = "sumPage";
            this.sumPage.Size = new System.Drawing.Size(336, 307);
            this.sumPage.TabIndex = 2;
            this.sumPage.Text = "Sums";
            this.sumPage.UseVisualStyleBackColor = true;
            // 
            // tabPageSums
            // 
            this.tabPageSums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPageSums.Controls.Add(this.geometricTab);
            this.tabPageSums.Controls.Add(this.arithmeticTab);
            this.tabPageSums.Controls.Add(this.naturalTab);
            this.tabPageSums.Location = new System.Drawing.Point(-4, 0);
            this.tabPageSums.Name = "tabPageSums";
            this.tabPageSums.SelectedIndex = 0;
            this.tabPageSums.Size = new System.Drawing.Size(340, 304);
            this.tabPageSums.TabIndex = 0;
            this.tabPageSums.SelectedIndexChanged += new System.EventHandler(this.tabPageSums_SelectedIndexChanged);
            // 
            // geometricTab
            // 
            this.geometricTab.Location = new System.Drawing.Point(4, 22);
            this.geometricTab.Name = "geometricTab";
            this.geometricTab.Padding = new System.Windows.Forms.Padding(3);
            this.geometricTab.Size = new System.Drawing.Size(388, 294);
            this.geometricTab.TabIndex = 0;
            this.geometricTab.Text = "Geometric Series";
            this.geometricTab.UseVisualStyleBackColor = true;
            // 
            // arithmeticTab
            // 
            this.arithmeticTab.Location = new System.Drawing.Point(4, 22);
            this.arithmeticTab.Name = "arithmeticTab";
            this.arithmeticTab.Padding = new System.Windows.Forms.Padding(3);
            this.arithmeticTab.Size = new System.Drawing.Size(388, 294);
            this.arithmeticTab.TabIndex = 1;
            this.arithmeticTab.Text = "Arithmetic Series";
            this.arithmeticTab.UseVisualStyleBackColor = true;
            // 
            // naturalTab
            // 
            this.naturalTab.Controls.Add(this.sum_naturals_displayTxtbox);
            this.naturalTab.Controls.Add(this.pictureBox1);
            this.naturalTab.Controls.Add(this.sum_naturals_upperboundTxtbox);
            this.naturalTab.Controls.Add(this.label2);
            this.naturalTab.Controls.Add(this.sum_naturals_lowerboundTxtbox);
            this.naturalTab.Controls.Add(this.sum_naturalsBtn);
            this.naturalTab.Controls.Add(this.label1);
            this.naturalTab.Location = new System.Drawing.Point(4, 22);
            this.naturalTab.Name = "naturalTab";
            this.naturalTab.Size = new System.Drawing.Size(332, 278);
            this.naturalTab.TabIndex = 2;
            this.naturalTab.Text = "Naturals";
            this.naturalTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 82);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // sum_naturals_upperboundTxtbox
            // 
            this.sum_naturals_upperboundTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sum_naturals_upperboundTxtbox.Location = new System.Drawing.Point(179, 32);
            this.sum_naturals_upperboundTxtbox.Name = "sum_naturals_upperboundTxtbox";
            this.sum_naturals_upperboundTxtbox.Size = new System.Drawing.Size(141, 20);
            this.sum_naturals_upperboundTxtbox.TabIndex = 4;
            this.sum_naturals_upperboundTxtbox.Text = "9";
            this.sum_naturals_upperboundTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Upper Bound (inclusive)";
            // 
            // sum_naturals_lowerboundTxtbox
            // 
            this.sum_naturals_lowerboundTxtbox.Location = new System.Drawing.Point(9, 32);
            this.sum_naturals_lowerboundTxtbox.Name = "sum_naturals_lowerboundTxtbox";
            this.sum_naturals_lowerboundTxtbox.Size = new System.Drawing.Size(141, 20);
            this.sum_naturals_lowerboundTxtbox.TabIndex = 2;
            this.sum_naturals_lowerboundTxtbox.Text = "1";
            this.sum_naturals_lowerboundTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sum_naturalsBtn
            // 
            this.sum_naturalsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sum_naturalsBtn.Location = new System.Drawing.Point(239, 239);
            this.sum_naturalsBtn.Name = "sum_naturalsBtn";
            this.sum_naturalsBtn.Size = new System.Drawing.Size(82, 30);
            this.sum_naturalsBtn.TabIndex = 0;
            this.sum_naturalsBtn.TabStop = false;
            this.sum_naturalsBtn.Text = "Equals";
            this.sum_naturalsBtn.UseVisualStyleBackColor = true;
            this.sum_naturalsBtn.Click += new System.EventHandler(this.sum_naturalsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Bound (inclusive)";
            // 
            // factor_factorizeBtn
            // 
            this.factor_factorizeBtn.Location = new System.Drawing.Point(79, 81);
            this.factor_factorizeBtn.Name = "factor_factorizeBtn";
            this.factor_factorizeBtn.Size = new System.Drawing.Size(75, 23);
            this.factor_factorizeBtn.TabIndex = 0;
            this.factor_factorizeBtn.Text = "Factorize";
            this.factor_factorizeBtn.UseVisualStyleBackColor = true;
            this.factor_factorizeBtn.Click += new System.EventHandler(this.factor_factorizeBtn_Click);
            // 
            // sum_naturals_displayTxtbox
            // 
            this.sum_naturals_displayTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sum_naturals_displayTxtbox.Location = new System.Drawing.Point(9, 68);
            this.sum_naturals_displayTxtbox.Name = "sum_naturals_displayTxtbox";
            this.sum_naturals_displayTxtbox.ReadOnly = true;
            this.sum_naturals_displayTxtbox.Size = new System.Drawing.Size(311, 20);
            this.sum_naturals_displayTxtbox.TabIndex = 7;
            this.sum_naturals_displayTxtbox.Text = "1";
            this.sum_naturals_displayTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // factors_numTxtbox1
            // 
            this.factors_numTxtbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factors_numTxtbox1.Location = new System.Drawing.Point(24, 29);
            this.factors_numTxtbox1.Name = "factors_numTxtbox1";
            this.factors_numTxtbox1.Size = new System.Drawing.Size(241, 20);
            this.factors_numTxtbox1.TabIndex = 1;
            this.factors_numTxtbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numbers";
            // 
            // factors_numTxtbox2
            // 
            this.factors_numTxtbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factors_numTxtbox2.Location = new System.Drawing.Point(24, 55);
            this.factors_numTxtbox2.Name = "factors_numTxtbox2";
            this.factors_numTxtbox2.Size = new System.Drawing.Size(241, 20);
            this.factors_numTxtbox2.TabIndex = 3;
            this.factors_numTxtbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // factor_gcfBtn
            // 
            this.factor_gcfBtn.Location = new System.Drawing.Point(25, 81);
            this.factor_gcfBtn.Name = "factor_gcfBtn";
            this.factor_gcfBtn.Size = new System.Drawing.Size(48, 23);
            this.factor_gcfBtn.TabIndex = 4;
            this.factor_gcfBtn.Text = "GCF";
            this.factor_gcfBtn.UseVisualStyleBackColor = true;
            this.factor_gcfBtn.Click += new System.EventHandler(this.factor_gcfBtn_Click);
            // 
            // factors_primelbl1
            // 
            this.factors_primelbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.factors_primelbl1.AutoSize = true;
            this.factors_primelbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.factors_primelbl1.Location = new System.Drawing.Point(272, 32);
            this.factors_primelbl1.Name = "factors_primelbl1";
            this.factors_primelbl1.Size = new System.Drawing.Size(79, 13);
            this.factors_primelbl1.TabIndex = 5;
            this.factors_primelbl1.Text = "                        ";
            // 
            // factors_primelbl2
            // 
            this.factors_primelbl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.factors_primelbl2.AutoSize = true;
            this.factors_primelbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.factors_primelbl2.Location = new System.Drawing.Point(271, 58);
            this.factors_primelbl2.Name = "factors_primelbl2";
            this.factors_primelbl2.Size = new System.Drawing.Size(79, 13);
            this.factors_primelbl2.TabIndex = 6;
            this.factors_primelbl2.Text = "                        ";
            // 
            // factor_resultTxtbox
            // 
            this.factor_resultTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.factor_resultTxtbox.Location = new System.Drawing.Point(24, 110);
            this.factor_resultTxtbox.Name = "factor_resultTxtbox";
            this.factor_resultTxtbox.ReadOnly = true;
            this.factor_resultTxtbox.Size = new System.Drawing.Size(285, 20);
            this.factor_resultTxtbox.TabIndex = 7;
            this.factor_resultTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainForm
            // 
            this.AcceptButton = this.sum_naturalsBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 325);
            this.Controls.Add(this.tabPage);
            this.Name = "mainForm";
            this.Text = "Dmorrow3\'s Calculator";
            this.tabPage.ResumeLayout(false);
            this.factorTab.ResumeLayout(false);
            this.factorTab.PerformLayout();
            this.sumPage.ResumeLayout(false);
            this.tabPageSums.ResumeLayout(false);
            this.naturalTab.ResumeLayout(false);
            this.naturalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage calcTab;
        private System.Windows.Forms.TabPage factorTab;
        private System.Windows.Forms.TabPage sumPage;
        private System.Windows.Forms.TabControl tabPageSums;
        private System.Windows.Forms.TabPage geometricTab;
        private System.Windows.Forms.TabPage arithmeticTab;
        private System.Windows.Forms.TabPage naturalTab;
        private System.Windows.Forms.TextBox sum_naturals_lowerboundTxtbox;
        private System.Windows.Forms.Button sum_naturalsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox sum_naturals_upperboundTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button factor_factorizeBtn;
        private System.Windows.Forms.TextBox sum_naturals_displayTxtbox;
        private System.Windows.Forms.TextBox factors_numTxtbox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox factors_numTxtbox1;
        private System.Windows.Forms.TextBox factor_resultTxtbox;
        private System.Windows.Forms.Label factors_primelbl2;
        private System.Windows.Forms.Label factors_primelbl1;
        private System.Windows.Forms.Button factor_gcfBtn;
    }
}

