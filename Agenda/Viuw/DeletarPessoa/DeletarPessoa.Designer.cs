namespace Agenda.Viuw.DeletarPessoa
{
    partial class DeletarPessoa
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
            btn_DeletarD = new Button();
            btn_BuscarD = new Button();
            groupBox1 = new GroupBox();
            tbx_CodigoD = new TextBox();
            label6 = new Label();
            tbx_FoneD = new TextBox();
            label5 = new Label();
            tbx_NomeD = new TextBox();
            tbx_EmailD = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            tbx_BuscarD = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_DeletarD
            // 
            btn_DeletarD.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DeletarD.Location = new Point(404, 246);
            btn_DeletarD.Name = "btn_DeletarD";
            btn_DeletarD.Size = new Size(75, 23);
            btn_DeletarD.TabIndex = 0;
            btn_DeletarD.Text = "Deletar";
            btn_DeletarD.UseVisualStyleBackColor = true;
            btn_DeletarD.Click += btn_DeletarD_Click_1;
            // 
            // btn_BuscarD
            // 
            btn_BuscarD.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_BuscarD.Location = new Point(416, 87);
            btn_BuscarD.Name = "btn_BuscarD";
            btn_BuscarD.Size = new Size(75, 23);
            btn_BuscarD.TabIndex = 1;
            btn_BuscarD.Text = "Buscar";
            btn_BuscarD.UseVisualStyleBackColor = true;
            btn_BuscarD.Click += btn_BuscarD_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_CodigoD);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbx_FoneD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbx_NomeD);
            groupBox1.Controls.Add(tbx_EmailD);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_DeletarD);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 288);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // tbx_CodigoD
            // 
            tbx_CodigoD.Location = new Point(128, 29);
            tbx_CodigoD.Name = "tbx_CodigoD";
            tbx_CodigoD.Size = new Size(215, 23);
            tbx_CodigoD.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 32);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 8;
            label6.Text = "Codigo:";
            // 
            // tbx_FoneD
            // 
            tbx_FoneD.Location = new Point(128, 137);
            tbx_FoneD.Name = "tbx_FoneD";
            tbx_FoneD.Size = new Size(215, 23);
            tbx_FoneD.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 137);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 5;
            label5.Text = "Fone:";
            // 
            // tbx_NomeD
            // 
            tbx_NomeD.Location = new Point(128, 80);
            tbx_NomeD.Name = "tbx_NomeD";
            tbx_NomeD.Size = new Size(215, 23);
            tbx_NomeD.TabIndex = 5;
            // 
            // tbx_EmailD
            // 
            tbx_EmailD.Location = new Point(128, 188);
            tbx_EmailD.Name = "tbx_EmailD";
            tbx_EmailD.Size = new Size(215, 23);
            tbx_EmailD.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 188);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 83);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 16);
            label1.Name = "label1";
            label1.Size = new Size(97, 32);
            label1.TabIndex = 0;
            label1.Text = "Deletar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 91);
            label2.Name = "label2";
            label2.Size = new Size(121, 17);
            label2.TabIndex = 1;
            label2.Text = "Selecionar Pessoa:";
            // 
            // tbx_BuscarD
            // 
            tbx_BuscarD.Location = new Point(150, 91);
            tbx_BuscarD.Name = "tbx_BuscarD";
            tbx_BuscarD.Size = new Size(235, 23);
            tbx_BuscarD.TabIndex = 4;
            // 
            // DeletarPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 475);
            Controls.Add(tbx_BuscarD);
            Controls.Add(groupBox1);
            Controls.Add(btn_BuscarD);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "DeletarPessoa";
            Text = "DeletarPessoa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_DeletarD;
        private Button btn_BuscarD;
        private GroupBox groupBox1;
        private TextBox tbx_NomeD;
        private TextBox tbx_EmailD;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox tbx_BuscarD;
        private Label label5;
        private TextBox tbx_FoneD;
        private TextBox tbx_CodigoD;
        private Label label6;
    }
}