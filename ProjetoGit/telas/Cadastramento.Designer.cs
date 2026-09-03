namespace ProjetoGit.telas
{
    partial class Cadastramento
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
            lbl_titulo_cadastramento = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbl_titulo_cadastramento
            // 
            lbl_titulo_cadastramento.AutoSize = true;
            lbl_titulo_cadastramento.Location = new Point(34, 21);
            lbl_titulo_cadastramento.Name = "lbl_titulo_cadastramento";
            lbl_titulo_cadastramento.Size = new Size(128, 15);
            lbl_titulo_cadastramento.TabIndex = 0;
            lbl_titulo_cadastramento.Text = "Tela de Cadastramento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 113);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 167);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "E-mail:";
            // 
            // Cadastramento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_titulo_cadastramento);
            Name = "Cadastramento";
            Text = "Cadastramento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo_cadastramento;
        private Label label1;
        private Label label2;
    }
}