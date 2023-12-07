namespace Agenda.Viuw.VizualizarPessoa
{
    partial class VizualizarPessoa
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
            btn_ContinuarE = new Button();
            btn_AvancarE = new Button();
            groupBox1 = new GroupBox();
            tbx_NomeE = new TextBox();
            tbx_EmailE = new TextBox();
            tbx_FoneE = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            tbx_Vizualizar = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ContinuarE
            // 
            btn_ContinuarE.Location = new Point(445, 122);
            btn_ContinuarE.Name = "btn_ContinuarE";
            btn_ContinuarE.Size = new Size(86, 26);
            btn_ContinuarE.TabIndex = 0;
            btn_ContinuarE.Text = "Continuar";
            btn_ContinuarE.UseVisualStyleBackColor = true;
            btn_ContinuarE.Click += btn_Continuar_Click;
            // 
            // btn_AvancarE
            // 
            btn_AvancarE.Location = new Point(431, 258);
            btn_AvancarE.Name = "btn_AvancarE";
            btn_AvancarE.Size = new Size(86, 26);
            btn_AvancarE.TabIndex = 1;
            btn_AvancarE.Text = "Avançar";
            btn_AvancarE.UseVisualStyleBackColor = true;
            btn_AvancarE.Click += btn_Avancar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_NomeE);
            groupBox1.Controls.Add(tbx_EmailE);
            groupBox1.Controls.Add(tbx_FoneE);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btn_AvancarE);
            groupBox1.Location = new Point(14, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 291);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // tbx_NomeE
            // 
            tbx_NomeE.Location = new Point(106, 50);
            tbx_NomeE.Name = "tbx_NomeE";
            tbx_NomeE.Size = new Size(204, 25);
            tbx_NomeE.TabIndex = 5;
            tbx_NomeE.TextChanged += tbx_NomeE_TextChanged;
            // 
            // tbx_EmailE
            // 
            tbx_EmailE.Location = new Point(106, 114);
            tbx_EmailE.Name = "tbx_EmailE";
            tbx_EmailE.Size = new Size(204, 25);
            tbx_EmailE.TabIndex = 6;
            // 
            // tbx_FoneE
            // 
            tbx_FoneE.Location = new Point(106, 177);
            tbx_FoneE.Name = "tbx_FoneE";
            tbx_FoneE.Size = new Size(204, 25);
            tbx_FoneE.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 53);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 4;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 114);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 180);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 6;
            label5.Text = "Fone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 45);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 131);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 3;
            label2.Text = "Vizualizar:";
            // 
            // tbx_Vizualizar
            // 
            tbx_Vizualizar.Location = new Point(171, 124);
            tbx_Vizualizar.Name = "tbx_Vizualizar";
            tbx_Vizualizar.Size = new Size(212, 25);
            tbx_Vizualizar.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(201, 28);
            label6.Name = "label6";
            label6.Size = new Size(210, 32);
            label6.TabIndex = 5;
            label6.Text = "Vizualizar Pessoa";
            // 
            // VizualizarPessoa
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 547);
            Controls.Add(label6);
            Controls.Add(tbx_Vizualizar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btn_ContinuarE);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "VizualizarPessoa";
            Text = "VizualizarPessoa";
            Load += VizualizarPessoa_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ContinuarE;
        private Button btn_AvancarE;
        private GroupBox groupBox1;
        private TextBox tbx_NomeE;
        private TextBox tbx_EmailE;
        private TextBox tbx_FoneE;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label2;
        private TextBox tbx_Vizualizar;
        private Label label6;
    }
}