namespace Agenda.Viuw.PesquisarPorCodigo
{
    partial class TelaPesquisarPorCodigo
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
            groupBox1 = new GroupBox();
            tbx_NomeF = new TextBox();
            tbx_EmailF = new TextBox();
            tbx_FoneF = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_AvancarF = new Button();
            btn_PesquisarF = new Button();
            label2 = new Label();
            label3 = new Label();
            tbx_PesquisarF = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbx_NomeF);
            groupBox1.Controls.Add(tbx_EmailF);
            groupBox1.Controls.Add(tbx_FoneF);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btn_AvancarF);
            groupBox1.Location = new Point(12, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 253);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbx_NomeF
            // 
            tbx_NomeF.Location = new Point(72, 35);
            tbx_NomeF.Name = "tbx_NomeF";
            tbx_NomeF.Size = new Size(213, 23);
            tbx_NomeF.TabIndex = 8;
            // 
            // tbx_EmailF
            // 
            tbx_EmailF.Location = new Point(72, 159);
            tbx_EmailF.Name = "tbx_EmailF";
            tbx_EmailF.Size = new Size(213, 23);
            tbx_EmailF.TabIndex = 10;
            // 
            // tbx_FoneF
            // 
            tbx_FoneF.Location = new Point(72, 99);
            tbx_FoneF.Name = "tbx_FoneF";
            tbx_FoneF.Size = new Size(213, 23);
            tbx_FoneF.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 36);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 4;
            label4.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 99);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 5;
            label5.Text = "Fone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 160);
            label6.Name = "label6";
            label6.Size = new Size(46, 17);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // btn_AvancarF
            // 
            btn_AvancarF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AvancarF.Location = new Point(370, 209);
            btn_AvancarF.Name = "btn_AvancarF";
            btn_AvancarF.Size = new Size(75, 23);
            btn_AvancarF.TabIndex = 1;
            btn_AvancarF.Text = "Avançar";
            btn_AvancarF.UseVisualStyleBackColor = true;
            btn_AvancarF.Click += btn_Avancar_Click;
            // 
            // btn_PesquisarF
            // 
            btn_PesquisarF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_PesquisarF.Location = new Point(382, 122);
            btn_PesquisarF.Name = "btn_PesquisarF";
            btn_PesquisarF.Size = new Size(75, 23);
            btn_PesquisarF.TabIndex = 0;
            btn_PesquisarF.Text = "Pesquisar";
            btn_PesquisarF.UseVisualStyleBackColor = true;
            btn_PesquisarF.Click += btn_PesquisarF_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 30);
            label2.Name = "label2";
            label2.Size = new Size(256, 32);
            label2.TabIndex = 2;
            label2.Text = "Pesquisar por codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 122);
            label3.Name = "label3";
            label3.Size = new Size(108, 17);
            label3.TabIndex = 3;
            label3.Text = "Digite o código:";
            // 
            // tbx_PesquisarF
            // 
            tbx_PesquisarF.Location = new Point(146, 121);
            tbx_PesquisarF.Name = "tbx_PesquisarF";
            tbx_PesquisarF.Size = new Size(213, 23);
            tbx_PesquisarF.TabIndex = 7;
            // 
            // TelaPesquisarPorCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 471);
            Controls.Add(tbx_PesquisarF);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(btn_PesquisarF);
            Name = "TelaPesquisarPorCodigo";
            Text = "TelaPesquisarPorCodigo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_AvancarF;
        private Button btn_PesquisarF;
        private Label label2;
        private Label label3;
        private TextBox tbx_NomeF;
        private TextBox tbx_EmailF;
        private TextBox tbx_FoneF;
        private TextBox tbx_PesquisarF;
    }
}