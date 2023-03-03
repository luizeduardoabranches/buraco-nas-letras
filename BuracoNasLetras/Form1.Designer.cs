namespace BuracoNasLetras
{
    partial class BuracoNasLetras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTexto = new Label();
            lblTamanhoTexto = new Label();
            lblTotalPalavras = new Label();
            lblTotalBuracos = new Label();
            txtTexto = new TextBox();
            lblTamanhoTextoContador = new Label();
            lblTotalPalavrasContador = new Label();
            lblTotalBuracosContador = new Label();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(12, 19);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(104, 15);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Insira o texto aqui:";
            // 
            // lblTamanhoTexto
            // 
            lblTamanhoTexto.AutoSize = true;
            lblTamanhoTexto.Location = new Point(12, 76);
            lblTamanhoTexto.Name = "lblTamanhoTexto";
            lblTamanhoTexto.Size = new Size(106, 15);
            lblTamanhoTexto.TabIndex = 1;
            lblTamanhoTexto.Text = "Tamanho do texto:";
            // 
            // lblTotalPalavras
            // 
            lblTotalPalavras.AutoSize = true;
            lblTotalPalavras.Location = new Point(12, 99);
            lblTotalPalavras.Name = "lblTotalPalavras";
            lblTotalPalavras.Size = new Size(97, 15);
            lblTotalPalavras.TabIndex = 2;
            lblTotalPalavras.Text = "Total de palavras:";
            // 
            // lblTotalBuracos
            // 
            lblTotalBuracos.AutoSize = true;
            lblTotalBuracos.Location = new Point(12, 122);
            lblTotalBuracos.Name = "lblTotalBuracos";
            lblTotalBuracos.Size = new Size(96, 15);
            lblTotalBuracos.TabIndex = 3;
            lblTotalBuracos.Text = "Total de buracos:";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(12, 37);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(387, 23);
            txtTexto.TabIndex = 4;
            txtTexto.TextChanged += txtTexto_TextChanged;
            // 
            // lblTamanhoTextoContador
            // 
            lblTamanhoTextoContador.AutoSize = true;
            lblTamanhoTextoContador.Location = new Point(124, 76);
            lblTamanhoTextoContador.Name = "lblTamanhoTextoContador";
            lblTamanhoTextoContador.Size = new Size(13, 15);
            lblTamanhoTextoContador.TabIndex = 5;
            lblTamanhoTextoContador.Text = "0";
            // 
            // lblTotalPalavrasContador
            // 
            lblTotalPalavrasContador.AutoSize = true;
            lblTotalPalavrasContador.Location = new Point(124, 99);
            lblTotalPalavrasContador.Name = "lblTotalPalavrasContador";
            lblTotalPalavrasContador.Size = new Size(13, 15);
            lblTotalPalavrasContador.TabIndex = 6;
            lblTotalPalavrasContador.Text = "0";
            // 
            // lblTotalBuracosContador
            // 
            lblTotalBuracosContador.AutoSize = true;
            lblTotalBuracosContador.Location = new Point(124, 122);
            lblTotalBuracosContador.Name = "lblTotalBuracosContador";
            lblTotalBuracosContador.Size = new Size(13, 15);
            lblTotalBuracosContador.TabIndex = 7;
            lblTotalBuracosContador.Text = "0";
            // 
            // BuracoNasLetras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 167);
            Controls.Add(lblTotalBuracosContador);
            Controls.Add(lblTotalPalavrasContador);
            Controls.Add(lblTamanhoTextoContador);
            Controls.Add(txtTexto);
            Controls.Add(lblTotalBuracos);
            Controls.Add(lblTotalPalavras);
            Controls.Add(lblTamanhoTexto);
            Controls.Add(lblTexto);
            MaximizeBox = false;
            Name = "BuracoNasLetras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buraco nas letras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private Label lblTamanhoTexto;
        private Label lblTotalPalavras;
        private Label lblTotalBuracos;
        private TextBox txtTexto;
        private Label lblTamanhoTextoContador;
        private Label lblTotalPalavrasContador;
        private Label lblTotalBuracosContador;
    }
}