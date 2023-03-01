namespace periyodikbakimci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnHava = new System.Windows.Forms.Button();
            this.BtnYag = new System.Windows.Forms.Button();
            this.BtnYakıt = new System.Windows.Forms.Button();
            this.TxtAracBslk = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnPolen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMotorKod = new System.Windows.Forms.TextBox();
            this.TxtMevcutMrk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHava
            // 
            this.BtnHava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnHava.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHava.Location = new System.Drawing.Point(12, 104);
            this.BtnHava.Name = "BtnHava";
            this.BtnHava.Size = new System.Drawing.Size(308, 45);
            this.BtnHava.TabIndex = 3;
            this.BtnHava.TabStop = false;
            this.BtnHava.Text = "HAVA FİLTRESİ";
            this.BtnHava.UseVisualStyleBackColor = false;
            this.BtnHava.Click += new System.EventHandler(this.BtnHava_Click);
            // 
            // BtnYag
            // 
            this.BtnYag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnYag.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYag.Location = new System.Drawing.Point(359, 104);
            this.BtnYag.Name = "BtnYag";
            this.BtnYag.Size = new System.Drawing.Size(287, 45);
            this.BtnYag.TabIndex = 4;
            this.BtnYag.TabStop = false;
            this.BtnYag.Text = "YAĞ FİLTRESİ";
            this.BtnYag.UseVisualStyleBackColor = false;
            this.BtnYag.Click += new System.EventHandler(this.BtnYag_Click);
            // 
            // BtnYakıt
            // 
            this.BtnYakıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnYakıt.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYakıt.Location = new System.Drawing.Point(685, 104);
            this.BtnYakıt.Name = "BtnYakıt";
            this.BtnYakıt.Size = new System.Drawing.Size(313, 45);
            this.BtnYakıt.TabIndex = 5;
            this.BtnYakıt.TabStop = false;
            this.BtnYakıt.Text = "YAKIT FİLTRESİ";
            this.BtnYakıt.UseVisualStyleBackColor = false;
            this.BtnYakıt.Click += new System.EventHandler(this.BtnYakıt_Click);
            // 
            // TxtAracBslk
            // 
            this.TxtAracBslk.Location = new System.Drawing.Point(12, 56);
            this.TxtAracBslk.Multiline = true;
            this.TxtAracBslk.Name = "TxtAracBslk";
            this.TxtAracBslk.Size = new System.Drawing.Size(634, 33);
            this.TxtAracBslk.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 165);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1365, 590);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // BtnPolen
            // 
            this.BtnPolen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPolen.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPolen.Location = new System.Drawing.Point(1043, 104);
            this.BtnPolen.Name = "BtnPolen";
            this.BtnPolen.Size = new System.Drawing.Size(334, 45);
            this.BtnPolen.TabIndex = 6;
            this.BtnPolen.TabStop = false;
            this.BtnPolen.Text = "POLEN FİLTRESİ";
            this.BtnPolen.UseVisualStyleBackColor = false;
            this.BtnPolen.Click += new System.EventHandler(this.BtnPolen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Araç Başlığını Giriniz";
            // 
            // TxtMotorKod
            // 
            this.TxtMotorKod.Location = new System.Drawing.Point(685, 55);
            this.TxtMotorKod.Multiline = true;
            this.TxtMotorKod.Name = "TxtMotorKod";
            this.TxtMotorKod.Size = new System.Drawing.Size(313, 33);
            this.TxtMotorKod.TabIndex = 1;
            // 
            // TxtMevcutMrk
            // 
            this.TxtMevcutMrk.Location = new System.Drawing.Point(1043, 56);
            this.TxtMevcutMrk.Multiline = true;
            this.TxtMevcutMrk.Name = "TxtMevcutMrk";
            this.TxtMevcutMrk.Size = new System.Drawing.Size(334, 33);
            this.TxtMevcutMrk.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(687, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Motor Kodunu Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1044, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Elinizdeki Mevcut Markaları Giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1409, 786);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtMevcutMrk);
            this.Controls.Add(this.TxtMotorKod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPolen);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TxtAracBslk);
            this.Controls.Add(this.BtnYakıt);
            this.Controls.Add(this.BtnYag);
            this.Controls.Add(this.BtnHava);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Periyodik Bakımcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHava;
        private System.Windows.Forms.Button BtnYag;
        private System.Windows.Forms.Button BtnYakıt;
        private System.Windows.Forms.TextBox TxtAracBslk;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnPolen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMotorKod;
        private System.Windows.Forms.TextBox TxtMevcutMrk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

