namespace Agenda
{
    partial class Menu
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
            btn_Adicionar = new Button();
            btn_altera = new Button();
            btn_Vizualizar = new Button();
            btn_Deletar = new Button();
            label1 = new Label();
            btn_Sair = new Button();
            btn_Codigo = new Button();
            SuspendLayout();
            // 
            // btn_Adicionar
            // 
            btn_Adicionar.Location = new Point(69, 130);
            btn_Adicionar.Name = "btn_Adicionar";
            btn_Adicionar.Size = new Size(98, 59);
            btn_Adicionar.TabIndex = 0;
            btn_Adicionar.Text = "Adicionar";
            btn_Adicionar.UseVisualStyleBackColor = true;
            btn_Adicionar.Click += btn_Adicionar_Click;
            // 
            // btn_altera
            // 
            btn_altera.Location = new Point(346, 130);
            btn_altera.Name = "btn_altera";
            btn_altera.Size = new Size(104, 59);
            btn_altera.TabIndex = 1;
            btn_altera.Text = "Alterar";
            btn_altera.UseVisualStyleBackColor = true;
            btn_altera.Click += btn_altera_Click;
            // 
            // btn_Vizualizar
            // 
            btn_Vizualizar.Location = new Point(66, 253);
            btn_Vizualizar.Name = "btn_Vizualizar";
            btn_Vizualizar.Size = new Size(98, 62);
            btn_Vizualizar.TabIndex = 2;
            btn_Vizualizar.Text = "Vizualizar";
            btn_Vizualizar.UseVisualStyleBackColor = true;
            btn_Vizualizar.Click += btn_Vizualizar_Click;
            // 
            // btn_Deletar
            // 
            btn_Deletar.Location = new Point(346, 253);
            btn_Deletar.Name = "btn_Deletar";
            btn_Deletar.Size = new Size(104, 62);
            btn_Deletar.TabIndex = 3;
            btn_Deletar.Text = "Deletar";
            btn_Deletar.UseVisualStyleBackColor = true;
            btn_Deletar.Click += btn_Deletar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 26);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 4;
            label1.Text = "Menu de Cadastro";
            // 
            // btn_Sair
            // 
            btn_Sair.Location = new Point(375, 423);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(75, 23);
            btn_Sair.TabIndex = 5;
            btn_Sair.Text = "Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // btn_Codigo
            // 
            btn_Codigo.Location = new Point(66, 374);
            btn_Codigo.Name = "btn_Codigo";
            btn_Codigo.Size = new Size(101, 62);
            btn_Codigo.TabIndex = 6;
            btn_Codigo.Text = "Codigo";
            btn_Codigo.UseVisualStyleBackColor = true;
            btn_Codigo.Click += btn_Codigo_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 458);
            Controls.Add(btn_Codigo);
            Controls.Add(btn_Sair);
            Controls.Add(label1);
            Controls.Add(btn_Deletar);
            Controls.Add(btn_Vizualizar);
            Controls.Add(btn_altera);
            Controls.Add(btn_Adicionar);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Adicionar;
        private Button btn_altera;
        private Button btn_Vizualizar;
        private Button btn_Deletar;
        private Label label1;
        private Button btn_Sair;
        private Button btn_Codigo;
    }
}