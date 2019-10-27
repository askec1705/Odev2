namespace Odev2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblrastgeleSayi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkalanHak = new System.Windows.Forms.Label();
            this.txtgirilenSayi = new System.Windows.Forms.TextBox();
            this.btngirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen aşağıdaki sayıyı kutucuğa doğru bir şekilde giriniz.";
            // 
            // lblrastgeleSayi
            // 
            this.lblrastgeleSayi.AutoSize = true;
            this.lblrastgeleSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblrastgeleSayi.Location = new System.Drawing.Point(16, 65);
            this.lblrastgeleSayi.Name = "lblrastgeleSayi";
            this.lblrastgeleSayi.Size = new System.Drawing.Size(37, 25);
            this.lblrastgeleSayi.TabIndex = 1;
            this.lblrastgeleSayi.Text = ". . .";
            this.lblrastgeleSayi.Click += new System.EventHandler(this.lblrastgeleSayi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(46, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalan Hakkınız : ";
            // 
            // lblkalanHak
            // 
            this.lblkalanHak.AutoSize = true;
            this.lblkalanHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblkalanHak.ForeColor = System.Drawing.Color.DarkRed;
            this.lblkalanHak.Location = new System.Drawing.Point(165, 153);
            this.lblkalanHak.Name = "lblkalanHak";
            this.lblkalanHak.Size = new System.Drawing.Size(18, 20);
            this.lblkalanHak.TabIndex = 3;
            this.lblkalanHak.Text = "5";
            // 
            // txtgirilenSayi
            // 
            this.txtgirilenSayi.Location = new System.Drawing.Point(19, 97);
            this.txtgirilenSayi.Name = "txtgirilenSayi";
            this.txtgirilenSayi.Size = new System.Drawing.Size(100, 20);
            this.txtgirilenSayi.TabIndex = 4;
            this.txtgirilenSayi.TextChanged += new System.EventHandler(this.txtgirilenSayi_TextChanged);
            // 
            // btngirisYap
            // 
            this.btngirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btngirisYap.Location = new System.Drawing.Point(131, 84);
            this.btngirisYap.Name = "btngirisYap";
            this.btngirisYap.Size = new System.Drawing.Size(102, 45);
            this.btngirisYap.TabIndex = 5;
            this.btngirisYap.Text = "Giriş Yap";
            this.btngirisYap.UseVisualStyleBackColor = true;
            this.btngirisYap.Click += new System.EventHandler(this.btngirisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 202);
            this.Controls.Add(this.btngirisYap);
            this.Controls.Add(this.txtgirilenSayi);
            this.Controls.Add(this.lblkalanHak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblrastgeleSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrastgeleSayi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblkalanHak;
        private System.Windows.Forms.TextBox txtgirilenSayi;
        private System.Windows.Forms.Button btngirisYap;
    }
}

