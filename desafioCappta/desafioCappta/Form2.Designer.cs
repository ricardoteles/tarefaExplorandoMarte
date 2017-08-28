namespace desafioCappta
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeqMov = new System.Windows.Forms.TextBox();
            this.txtPosIni = new System.Windows.Forms.TextBox();
            this.bntOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Série de instruções";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Posição incial";
            // 
            // txtSeqMov
            // 
            this.txtSeqMov.Location = new System.Drawing.Point(180, 84);
            this.txtSeqMov.Name = "txtSeqMov";
            this.txtSeqMov.Size = new System.Drawing.Size(164, 20);
            this.txtSeqMov.TabIndex = 9;
            // 
            // txtPosIni
            // 
            this.txtPosIni.Location = new System.Drawing.Point(180, 45);
            this.txtPosIni.Name = "txtPosIni";
            this.txtPosIni.Size = new System.Drawing.Size(164, 20);
            this.txtPosIni.TabIndex = 8;
            // 
            // bntOk
            // 
            this.bntOk.Location = new System.Drawing.Point(109, 133);
            this.bntOk.Name = "bntOk";
            this.bntOk.Size = new System.Drawing.Size(75, 44);
            this.bntOk.TabIndex = 7;
            this.bntOk.Text = "OK";
            this.bntOk.UseVisualStyleBackColor = true;
            this.bntOk.Click += new System.EventHandler(this.bntOk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Adicionar sonda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeqMov);
            this.Controls.Add(this.txtPosIni);
            this.Controls.Add(this.bntOk);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeqMov;
        private System.Windows.Forms.TextBox txtPosIni;
        private System.Windows.Forms.Button bntOk;
        private System.Windows.Forms.Button button1;
    }
}