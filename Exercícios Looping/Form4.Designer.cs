
namespace Exercícios_Looping
{
    partial class frmexercicio13
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
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.btnenq = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblareat = new System.Windows.Forms.Label();
            this.txtareatotal = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.lblcomodo = new System.Windows.Forms.Label();
            this.txtcomodo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtlarg
            // 
            this.txtlarg.Location = new System.Drawing.Point(444, 167);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(100, 20);
            this.txtlarg.TabIndex = 16;
            this.txtlarg.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // btnenq
            // 
            this.btnenq.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.btnenq.Location = new System.Drawing.Point(386, 392);
            this.btnenq.Name = "btnenq";
            this.btnenq.Size = new System.Drawing.Size(89, 34);
            this.btnenq.TabIndex = 12;
            this.btnenq.Text = "Calcular";
            this.btnenq.UseVisualStyleBackColor = true;
            this.btnenq.Click += new System.EventHandler(this.btnenq_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblresult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblresult.Location = new System.Drawing.Point(43, 167);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(395, 22);
            this.lblresult.TabIndex = 11;
            this.lblresult.Text = "Informe a largura do cômodo (em metros):";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnome.Location = new System.Drawing.Point(43, 120);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(263, 22);
            this.lblnome.TabIndex = 10;
            this.lblnome.Text = "Informe o nome do cômodo:";
            this.lblnome.Click += new System.EventHandler(this.lblnum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(312, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Área do cômodo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(43, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Informe o comprimento do cômodo (em metros):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(499, 217);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(100, 20);
            this.txtcomp.TabIndex = 18;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnvoltar.Location = new System.Drawing.Point(12, 27);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(89, 34);
            this.btnvoltar.TabIndex = 21;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblareat
            // 
            this.lblareat.AutoSize = true;
            this.lblareat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblareat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblareat.Location = new System.Drawing.Point(265, 338);
            this.lblareat.Name = "lblareat";
            this.lblareat.Size = new System.Drawing.Size(106, 22);
            this.lblareat.TabIndex = 23;
            this.lblareat.Text = "Área total:";
            this.lblareat.Visible = false;
            // 
            // txtareatotal
            // 
            this.txtareatotal.Enabled = false;
            this.txtareatotal.Location = new System.Drawing.Point(377, 340);
            this.txtareatotal.Name = "txtareatotal";
            this.txtareatotal.Size = new System.Drawing.Size(100, 20);
            this.txtareatotal.TabIndex = 24;
            this.txtareatotal.Visible = false;
            // 
            // txtarea
            // 
            this.txtarea.Enabled = false;
            this.txtarea.Location = new System.Drawing.Point(420, 279);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 20;
            // 
            // lblcomodo
            // 
            this.lblcomodo.AutoSize = true;
            this.lblcomodo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblcomodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcomodo.Location = new System.Drawing.Point(248, 275);
            this.lblcomodo.Name = "lblcomodo";
            this.lblcomodo.Size = new System.Drawing.Size(166, 22);
            this.lblcomodo.TabIndex = 19;
            this.lblcomodo.Text = "Área do cômodo:";
            this.lblcomodo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcomodo
            // 
            this.txtcomodo.Location = new System.Drawing.Point(312, 120);
            this.txtcomodo.Name = "txtcomodo";
            this.txtcomodo.Size = new System.Drawing.Size(100, 20);
            this.txtcomodo.TabIndex = 15;
            this.txtcomodo.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // frmexercicio13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtareatotal);
            this.Controls.Add(this.lblareat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.lblcomodo);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.txtcomodo);
            this.Controls.Add(this.btnenq);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.label1);
            this.Name = "frmexercicio13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.Button btnenq;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblareat;
        private System.Windows.Forms.TextBox txtareatotal;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label lblcomodo;
        private System.Windows.Forms.TextBox txtcomodo;
    }
}