namespace Agenda.Viuw.AdicionarPessoa
{
    partial class AdicionarPessoa
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
            btn_avancar = new Button();
            tbx_Fone = new TextBox();
            tbx_Email = new TextBox();
            tbx_Nome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_avancar);
            groupBox1.Controls.Add(tbx_Fone);
            groupBox1.Controls.Add(tbx_Email);
            groupBox1.Controls.Add(tbx_Nome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informações";
            // 
            // btn_avancar
            // 
            btn_avancar.Location = new Point(377, 240);
            btn_avancar.Name = "btn_avancar";
            btn_avancar.Size = new Size(75, 23);
            btn_avancar.TabIndex = 7;
            btn_avancar.Text = "Avançar";
            btn_avancar.UseVisualStyleBackColor = true;
            btn_avancar.Click += btn_avancar_Click;
            // 
            // tbx_Fone
            // 
            tbx_Fone.Location = new Point(68, 173);
            tbx_Fone.Name = "tbx_Fone";
            tbx_Fone.Size = new Size(196, 23);
            tbx_Fone.TabIndex = 5;
            // 
            // tbx_Email
            // 
            tbx_Email.Location = new Point(68, 124);
            tbx_Email.Name = "tbx_Email";
            tbx_Email.Size = new Size(196, 23);
            tbx_Email.TabIndex = 4;
            // 
            // tbx_Nome
            // 
            tbx_Nome.Location = new Point(68, 79);
            tbx_Nome.Name = "tbx_Nome";
            tbx_Nome.Size = new Size(196, 23);
            tbx_Nome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 176);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Fone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 127);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 78);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(130, 33);
            label4.Name = "label4";
            label4.Size = new Size(240, 32);
            label4.TabIndex = 8;
            label4.Text = "Adicionar a Agenda";
            // 
            // AdicionarPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 477);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "AdicionarPessoa";
            Text = "AdicionarPessoa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_avancar;
        private TextBox tbx_Fone;
        private TextBox tbx_Email;
        private TextBox tbx_Nome;
        private Label label4;
    }
}