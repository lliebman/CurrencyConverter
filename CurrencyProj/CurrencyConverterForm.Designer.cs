namespace CurrencyProj
{
    partial class CurrencyConverterForm
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
            this.USD_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CADRate = new System.Windows.Forms.TextBox();
            this.GBPRate = new System.Windows.Forms.TextBox();
            this.EURRate = new System.Windows.Forms.TextBox();
            this.AUDRate = new System.Windows.Forms.TextBox();
            this.JPYRate = new System.Windows.Forms.TextBox();
            this.NISRate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.USDQuant = new System.Windows.Forms.TextBox();
            this.CADQuant = new System.Windows.Forms.TextBox();
            this.GBPQuant = new System.Windows.Forms.TextBox();
            this.JPYQuant = new System.Windows.Forms.TextBox();
            this.NISQuant = new System.Windows.Forms.TextBox();
            this.AUDQuant = new System.Windows.Forms.TextBox();
            this.EURQuant = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // USD_Label
            // 
            this.USD_Label.AutoSize = true;
            this.USD_Label.Location = new System.Drawing.Point(53, 109);
            this.USD_Label.Name = "USD_Label";
            this.USD_Label.Size = new System.Drawing.Size(84, 37);
            this.USD_Label.TabIndex = 0;
            this.USD_Label.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "CAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "JPY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "EUR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "GBP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 805);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "AUD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CADRate);
            this.groupBox2.Controls.Add(this.GBPRate);
            this.groupBox2.Controls.Add(this.EURRate);
            this.groupBox2.Controls.Add(this.AUDRate);
            this.groupBox2.Controls.Add(this.JPYRate);
            this.groupBox2.Controls.Add(this.NISRate);
            this.groupBox2.Location = new System.Drawing.Point(436, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 815);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convertion Rates (FX/USD)";
            // 
            // CADRate
            // 
            this.CADRate.Location = new System.Drawing.Point(51, 143);
            this.CADRate.Name = "CADRate";
            this.CADRate.Size = new System.Drawing.Size(125, 44);
            this.CADRate.TabIndex = 8;
            this.CADRate.Text = "1.31";
            this.CADRate.TextChanged += new System.EventHandler(this.CAD_Rate_TextChanged);
            // 
            // GBPRate
            // 
            this.GBPRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GBPRate.Location = new System.Drawing.Point(51, 259);
            this.GBPRate.Name = "GBPRate";
            this.GBPRate.Size = new System.Drawing.Size(125, 44);
            this.GBPRate.TabIndex = 13;
            this.GBPRate.Text = "0.76";
            this.GBPRate.TextChanged += new System.EventHandler(this.GBP_Rate_TextChanged);
            // 
            // EURRate
            // 
            this.EURRate.AllowDrop = true;
            this.EURRate.Location = new System.Drawing.Point(51, 375);
            this.EURRate.Name = "EURRate";
            this.EURRate.Size = new System.Drawing.Size(125, 44);
            this.EURRate.TabIndex = 14;
            this.EURRate.Text = "0.85";
            this.EURRate.TextChanged += new System.EventHandler(this.EUR_Rate_TextChanged);
            // 
            // AUDRate
            // 
            this.AUDRate.Location = new System.Drawing.Point(51, 723);
            this.AUDRate.Name = "AUDRate";
            this.AUDRate.Size = new System.Drawing.Size(125, 44);
            this.AUDRate.TabIndex = 15;
            this.AUDRate.Text = "1.38";
            this.AUDRate.TextChanged += new System.EventHandler(this.AUD_Rate_TextChanged);
            // 
            // JPYRate
            // 
            this.JPYRate.Location = new System.Drawing.Point(51, 607);
            this.JPYRate.Name = "JPYRate";
            this.JPYRate.Size = new System.Drawing.Size(125, 44);
            this.JPYRate.TabIndex = 16;
            this.JPYRate.Text = "105.17";
            this.JPYRate.TextChanged += new System.EventHandler(this.JPY_Rate_TextChanged);
            // 
            // NISRate
            // 
            this.NISRate.Location = new System.Drawing.Point(51, 491);
            this.NISRate.Name = "NISRate";
            this.NISRate.Size = new System.Drawing.Size(125, 44);
            this.NISRate.TabIndex = 17;
            this.NISRate.Text = "3.37";
            this.NISRate.TextChanged += new System.EventHandler(this.NIS_Rate_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.USDQuant);
            this.groupBox1.Controls.Add(this.CADQuant);
            this.groupBox1.Controls.Add(this.GBPQuant);
            this.groupBox1.Controls.Add(this.JPYQuant);
            this.groupBox1.Controls.Add(this.NISQuant);
            this.groupBox1.Controls.Add(this.AUDQuant);
            this.groupBox1.Controls.Add(this.EURQuant);
            this.groupBox1.Location = new System.Drawing.Point(198, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 851);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantity";
            // 
            // USDQuant
            // 
            this.USDQuant.Location = new System.Drawing.Point(51, 70);
            this.USDQuant.Name = "USDQuant";
            this.USDQuant.Size = new System.Drawing.Size(125, 44);
            this.USDQuant.TabIndex = 22;
            this.USDQuant.Text = "0.00";
            this.USDQuant.TextChanged += new System.EventHandler(this.USDQuant_TextChanged);
            // 
            // CADQuant
            // 
            this.CADQuant.Location = new System.Drawing.Point(51, 179);
            this.CADQuant.Name = "CADQuant";
            this.CADQuant.Size = new System.Drawing.Size(125, 44);
            this.CADQuant.TabIndex = 13;
            this.CADQuant.Text = "0.00";
            this.CADQuant.TextChanged += new System.EventHandler(this.CAD_Quant_TextChanged);
            // 
            // GBPQuant
            // 
            this.GBPQuant.Location = new System.Drawing.Point(51, 295);
            this.GBPQuant.Name = "GBPQuant";
            this.GBPQuant.Size = new System.Drawing.Size(125, 44);
            this.GBPQuant.TabIndex = 14;
            this.GBPQuant.Text = "0.00";
            this.GBPQuant.TextChanged += new System.EventHandler(this.GBP_Quant_TextChanged);
            // 
            // JPYQuant
            // 
            this.JPYQuant.Location = new System.Drawing.Point(51, 643);
            this.JPYQuant.Name = "JPYQuant";
            this.JPYQuant.Size = new System.Drawing.Size(125, 44);
            this.JPYQuant.TabIndex = 15;
            this.JPYQuant.Text = "0.00";
            this.JPYQuant.TextChanged += new System.EventHandler(this.JPY_Quant_TextChanged);
            // 
            // NISQuant
            // 
            this.NISQuant.Location = new System.Drawing.Point(51, 527);
            this.NISQuant.Name = "NISQuant";
            this.NISQuant.Size = new System.Drawing.Size(125, 44);
            this.NISQuant.TabIndex = 16;
            this.NISQuant.Text = "0.00";
            this.NISQuant.TextChanged += new System.EventHandler(this.NIS_Quant_TextChanged);
            // 
            // AUDQuant
            // 
            this.AUDQuant.Location = new System.Drawing.Point(51, 759);
            this.AUDQuant.Name = "AUDQuant";
            this.AUDQuant.Size = new System.Drawing.Size(125, 44);
            this.AUDQuant.TabIndex = 10;
            this.AUDQuant.Text = "0.00";
            this.AUDQuant.TextChanged += new System.EventHandler(this.AUD_Quant_TextChanged);
            // 
            // EURQuant
            // 
            this.EURQuant.Location = new System.Drawing.Point(51, 411);
            this.EURQuant.Name = "EURQuant";
            this.EURQuant.Size = new System.Drawing.Size(125, 44);
            this.EURQuant.TabIndex = 17;
            this.EURQuant.Text = "0.00";
            this.EURQuant.TextChanged += new System.EventHandler(this.EUR_Quant_TextChanged);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 1006);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.USD_Label);
            this.Name = "CurrencyConverterForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label USD_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CADRate;
        private System.Windows.Forms.TextBox EURRate;
        private System.Windows.Forms.TextBox AUDRate;
        private System.Windows.Forms.TextBox JPYRate;
        private System.Windows.Forms.TextBox NISRate;
        private System.Windows.Forms.TextBox GBPRate;
        private System.Windows.Forms.TextBox USDQuant;
        private System.Windows.Forms.TextBox CADQuant;
        private System.Windows.Forms.TextBox GBPQuant;
        private System.Windows.Forms.TextBox JPYQuant;
        private System.Windows.Forms.TextBox NISQuant;
        private System.Windows.Forms.TextBox AUDQuant;
        private System.Windows.Forms.TextBox EURQuant;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}

