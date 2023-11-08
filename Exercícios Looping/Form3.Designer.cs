
namespace Exercícios_Looping
{
    partial class frmexercicio12
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnenq = new System.Windows.Forms.Button();
            this.btnpara = new System.Windows.Forms.Button();
            this.btnrep = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(180, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = " Conversão celsius para fahrenheit";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblnum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnum.Location = new System.Drawing.Point(32, 102);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(336, 24);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "Digite a temperatura em celsius:";
            this.lblnum.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.lblresult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblresult.Location = new System.Drawing.Point(300, 162);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(293, 24);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "Temperatura em fahrenheit:";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.btnvoltar.Location = new System.Drawing.Point(22, 12);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(89, 34);
            this.btnvoltar.TabIndex = 3;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnenq
            // 
            this.btnenq.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.btnenq.Location = new System.Drawing.Point(242, 404);
            this.btnenq.Name = "btnenq";
            this.btnenq.Size = new System.Drawing.Size(89, 34);
            this.btnenq.TabIndex = 4;
            this.btnenq.Text = "Enquanto";
            this.btnenq.UseVisualStyleBackColor = true;
            this.btnenq.Click += new System.EventHandler(this.btnenq_Click);
            // 
            // btnpara
            // 
            this.btnpara.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.btnpara.Location = new System.Drawing.Point(546, 404);
            this.btnpara.Name = "btnpara";
            this.btnpara.Size = new System.Drawing.Size(89, 34);
            this.btnpara.TabIndex = 5;
            this.btnpara.Text = "Para";
            this.btnpara.UseVisualStyleBackColor = true;
            this.btnpara.Click += new System.EventHandler(this.btnpara_Click);
            // 
            // btnrep
            // 
            this.btnrep.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.btnrep.Location = new System.Drawing.Point(394, 404);
            this.btnrep.Name = "btnrep";
            this.btnrep.Size = new System.Drawing.Size(89, 34);
            this.btnrep.TabIndex = 6;
            this.btnrep.Text = "Repita";
            this.btnrep.UseVisualStyleBackColor = true;
            this.btnrep.Click += new System.EventHandler(this.btnrep_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(374, 108);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 7;
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(359, 207);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(166, 159);
            this.txtresult.TabIndex = 12;
            this.txtresult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // frmexercicio12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnrep);
            this.Controls.Add(this.btnpara);
            this.Controls.Add(this.btnenq);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.label1);
            this.Name = "frmexercicio12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 12";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnenq;
        private System.Windows.Forms.Button btnpara;
        private System.Windows.Forms.Button btnrep;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtresult;
    }
}