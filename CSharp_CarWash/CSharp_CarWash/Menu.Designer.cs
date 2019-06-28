namespace CSharp_CarWash
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
            this.Btn_Inserir = new System.Windows.Forms.Button();
            this.Btn_Listar = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Inserir
            // 
            this.Btn_Inserir.Location = new System.Drawing.Point(12, 86);
            this.Btn_Inserir.Name = "Btn_Inserir";
            this.Btn_Inserir.Size = new System.Drawing.Size(246, 95);
            this.Btn_Inserir.TabIndex = 0;
            this.Btn_Inserir.Text = "Inserir";
            this.Btn_Inserir.UseVisualStyleBackColor = true;
            this.Btn_Inserir.Click += new System.EventHandler(this.Btn_Inserir_Click);
            // 
            // Btn_Listar
            // 
            this.Btn_Listar.Location = new System.Drawing.Point(12, 187);
            this.Btn_Listar.Name = "Btn_Listar";
            this.Btn_Listar.Size = new System.Drawing.Size(246, 95);
            this.Btn_Listar.TabIndex = 1;
            this.Btn_Listar.Text = "Listar";
            this.Btn_Listar.UseVisualStyleBackColor = true;
            this.Btn_Listar.Click += new System.EventHandler(this.Btn_Listar_Click);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(12, 288);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(246, 62);
            this.Btn_Sair.TabIndex = 2;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "WashyWashy";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_Listar);
            this.Controls.Add(this.Btn_Inserir);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Inserir;
        private System.Windows.Forms.Button Btn_Listar;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label label1;
    }
}

