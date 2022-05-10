
namespace SimplePaint
{
    partial class FomSimplePaint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.CbTamanho = new System.Windows.Forms.ComboBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnBorracha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCor = new System.Windows.Forms.Button();
            this.PanelPaint = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnSalvar);
            this.groupBox1.Controls.Add(this.CbTamanho);
            this.groupBox1.Controls.Add(this.BtnLimpar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtnBorracha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnCor);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ferramentas";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSalvar.Location = new System.Drawing.Point(705, 9);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(87, 25);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CbTamanho
            // 
            this.CbTamanho.FormattingEnabled = true;
            this.CbTamanho.Location = new System.Drawing.Point(9, 34);
            this.CbTamanho.Name = "CbTamanho";
            this.CbTamanho.Size = new System.Drawing.Size(65, 24);
            this.CbTamanho.TabIndex = 2;
            this.CbTamanho.SelectedIndexChanged += new System.EventHandler(this.CbTamanho_SelectedIndexChanged);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLimpar.Location = new System.Drawing.Point(705, 36);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(87, 25);
            this.BtnLimpar.TabIndex = 6;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Borracha :";
            // 
            // BtnBorracha
            // 
            this.BtnBorracha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBorracha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnBorracha.Location = new System.Drawing.Point(191, 34);
            this.BtnBorracha.Name = "BtnBorracha";
            this.BtnBorracha.Size = new System.Drawing.Size(65, 24);
            this.BtnBorracha.TabIndex = 4;
            this.BtnBorracha.UseVisualStyleBackColor = false;
            this.BtnBorracha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnBorracha_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamanho :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tinta :";
            // 
            // BtnCor
            // 
            this.BtnCor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCor.Location = new System.Drawing.Point(100, 34);
            this.BtnCor.Name = "BtnCor";
            this.BtnCor.Size = new System.Drawing.Size(65, 24);
            this.BtnCor.TabIndex = 0;
            this.BtnCor.UseVisualStyleBackColor = false;
            this.BtnCor.Click += new System.EventHandler(this.BtnCor_Click);
            // 
            // PanelPaint
            // 
            this.PanelPaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelPaint.BackColor = System.Drawing.Color.White;
            this.PanelPaint.Location = new System.Drawing.Point(12, 98);
            this.PanelPaint.Name = "PanelPaint";
            this.PanelPaint.Size = new System.Drawing.Size(798, 340);
            this.PanelPaint.TabIndex = 1;
            this.PanelPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelPaint_MouseDown);
            this.PanelPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelPaint_MouseMove);
            this.PanelPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelPaint_MouseUp);
            this.PanelPaint.Resize += new System.EventHandler(this.PanelPaint_Resize);
            // 
            // FomSimplePaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.PanelPaint);
            this.Controls.Add(this.groupBox1);
            this.Name = "FomSimplePaint";
            this.ShowIcon = false;
            this.Text = "Paint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.ComboBox CbTamanho;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnBorracha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelPaint;
    }
}