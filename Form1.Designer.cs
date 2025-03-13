namespace AppCalcRevisão
{
    partial class frmCalculadora
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
            txtResultado = new TextBox();
            btnSoma = new Button();
            btnSubtrair = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnZero = new Button();
            btnResultado = new Button();
            btnLimpar = new Button();
            txtTroca = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Info;
            txtResultado.Font = new Font("Segoe UI", 14F);
            txtResultado.Location = new Point(87, 10);
            txtResultado.Margin = new Padding(1);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(210, 32);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnSoma.Location = new Point(245, 64);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(52, 54);
            btnSoma.TabIndex = 1;
            btnSoma.Text = "+\r\n";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnSubtrair.Location = new Point(246, 141);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(52, 54);
            btnSubtrair.TabIndex = 2;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnDividir
            // 
            btnDividir.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnDividir.Location = new Point(243, 296);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(52, 54);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnMultiplicar.Location = new Point(243, 220);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(52, 54);
            btnMultiplicar.TabIndex = 4;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnSete.Location = new Point(10, 64);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(52, 54);
            btnSete.TabIndex = 5;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnOito.Location = new Point(87, 64);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(52, 54);
            btnOito.TabIndex = 6;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnNove.Location = new Point(164, 64);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(52, 54);
            btnNove.TabIndex = 7;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnQuatro.Location = new Point(10, 141);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(52, 54);
            btnQuatro.TabIndex = 8;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnCinco.Location = new Point(87, 141);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(52, 54);
            btnCinco.TabIndex = 9;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnSeis.Location = new Point(164, 141);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(52, 54);
            btnSeis.TabIndex = 10;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnUm.Location = new Point(10, 220);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(52, 54);
            btnUm.TabIndex = 11;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnDois.Location = new Point(87, 220);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(52, 54);
            btnDois.TabIndex = 12;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnTres.Location = new Point(164, 220);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(52, 54);
            btnTres.TabIndex = 13;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnZero.Location = new Point(10, 296);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(52, 54);
            btnZero.TabIndex = 14;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnResultado.Location = new Point(87, 296);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(52, 54);
            btnResultado.TabIndex = 15;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Document);
            btnLimpar.Location = new Point(164, 296);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(52, 54);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "CE";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtTroca
            // 
            txtTroca.BackColor = SystemColors.GradientActiveCaption;
            txtTroca.Font = new Font("Segoe UI", 14F);
            txtTroca.Location = new Point(6, 10);
            txtTroca.Margin = new Padding(1);
            txtTroca.Name = "txtTroca";
            txtTroca.ReadOnly = true;
            txtTroca.Size = new Size(56, 32);
            txtTroca.TabIndex = 17;
            txtTroca.TextAlign = HorizontalAlignment.Right;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(2F, 4F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(307, 362);
            Controls.Add(txtTroca);
            Controls.Add(btnLimpar);
            Controls.Add(btnResultado);
            Controls.Add(btnZero);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSoma);
            Controls.Add(txtResultado);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Document);
            Margin = new Padding(1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCalculadora";
            Text = "Calculadora";
            Load += frmCalculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSoma;
        private Button btnSubtrair;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnZero;
        private Button btnResultado;
        private Button btnLimpar;
        private TextBox txtTroca;
    }
}
