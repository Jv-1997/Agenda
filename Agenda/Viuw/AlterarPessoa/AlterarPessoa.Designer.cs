namespace Agenda.Viuw.AlterarPessoa
{
    partial class AlterarPessoa
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
            btn_Avancar = new Button();
            btn_Continuar = new Button();
            groupBox1 = new GroupBox();
            tbx_FoneA = new TextBox();
            tbx_EmailA = new TextBox();
            tbx_NomeA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbx_ProcurarA = new TextBox();
            label4 = new Label();
            label6 = new Label();
            tbx_CodigoA = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Avancar
            // 
            btn_Avancar.Location = new Point(318, 189);
            btn_Avancar.Name = "btn_Avancar";
            btn_Avancar.Size = new Size(75, 23);
            btn_Avancar.TabIndex = 0;
            btn_Avancar.Text = "Alterar";
            btn_Avancar.UseVisualStyleBackColor = true;
            btn_Avancar.Click += btn_Avancar_Click;
            // 
            // btn_Continuar
            // 
            btn_Continuar.Location = new Point(410, 85);
            btn_Continuar.Name = "btn_Continuar";
            btn_Continuar.Size = new Size(75, 23);
            btn_Continuar.TabIndex = 1;
            btn_Continuar.Text = "Continuar";
            btn_Continuar.UseVisualStyleBackColor = true;
            btn_Continuar.Click += btn_Continuar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_CodigoA);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_FoneA);
            groupBox1.Controls.Add(tbx_EmailA);
            groupBox1.Controls.Add(btn_Avancar);
            groupBox1.Controls.Add(tbx_NomeA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 180);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 273);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informaçôes";
            // 
            // tbx_FoneA
            // 
            tbx_FoneA.Location = new Point(93, 157);
            tbx_FoneA.Name = "tbx_FoneA";
            tbx_FoneA.Size = new Size(149, 23);
            tbx_FoneA.TabIndex = 6;
            // 
            // tbx_EmailA
            // 
            tbx_EmailA.Location = new Point(93, 94);
            tbx_EmailA.Name = "tbx_EmailA";
            tbx_EmailA.Size = new Size(149, 23);
            tbx_EmailA.TabIndex = 5;
            // 
            // tbx_NomeA
            // 
            tbx_NomeA.Location = new Point(93, 39);
            tbx_NomeA.Name = "tbx_NomeA";
            tbx_NomeA.Size = new Size(149, 23);
            tbx_NomeA.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 160);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 2;
            label3.Text = "Fone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 102);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // tbx_ProcurarA
            // 
            tbx_ProcurarA.Location = new Point(160, 85);
            tbx_ProcurarA.Name = "tbx_ProcurarA";
            tbx_ProcurarA.Size = new Size(193, 23);
            tbx_ProcurarA.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(160, 20);
            label4.Name = "label4";
            label4.Size = new Size(177, 32);
            label4.TabIndex = 4;
            label4.Text = "Alterar Pessoa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1, 87);
            label6.Name = "label6";
            label6.Size = new Size(135, 17);
            label6.TabIndex = 8;
            label6.Text = "Procurar por pessoa:";
            // 
            // tbx_CodigoA
            // 
            tbx_CodigoA.Location = new Point(357, 42);
            tbx_CodigoA.Name = "tbx_CodigoA";
            tbx_CodigoA.Size = new Size(82, 23);
            tbx_CodigoA.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(275, 45);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 7;
            label5.Text = "Codigo:";
            // 
            // AlterarPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 465);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(btn_Continuar);
            Controls.Add(tbx_ProcurarA);
            Name = "AlterarPessoa";
            Text = "AlterarPessoa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Avancar;
        private Button btn_Continuar;
        private GroupBox groupBox1;
        private TextBox tbx_FoneA;
        private TextBox tbx_EmailA;
        private TextBox tbx_NomeA;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbx_ProcurarA;
        private Label label4;
        private Label label6;
        private TextBox tbx_CodigoA;
        private Label label5;
    }
}