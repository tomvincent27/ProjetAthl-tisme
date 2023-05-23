
namespace ProjetAthlétisme
{
    partial class VueGénérale
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPrénom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lblPrénom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(286, 263);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(221, 51);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Se connecter ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxPrénom
            // 
            this.txtBoxPrénom.Location = new System.Drawing.Point(286, 97);
            this.txtBoxPrénom.Name = "txtBoxPrénom";
            this.txtBoxPrénom.Size = new System.Drawing.Size(221, 29);
            this.txtBoxPrénom.TabIndex = 1;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(286, 177);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(221, 29);
            this.txtBoxNom.TabIndex = 2;
            // 
            // lblPrénom
            // 
            this.lblPrénom.AutoSize = true;
            this.lblPrénom.Location = new System.Drawing.Point(158, 97);
            this.lblPrénom.Name = "lblPrénom";
            this.lblPrénom.Size = new System.Drawing.Size(96, 25);
            this.lblPrénom.TabIndex = 3;
            this.lblPrénom.Text = "Prénom : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(158, 181);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(69, 25);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom : ";
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(286, 352);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(221, 51);
            this.btnEnregistre.TabIndex = 5;
            this.btnEnregistre.Text = "S\'enregistrer";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // VueGénérale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistre);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrénom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.txtBoxPrénom);
            this.Controls.Add(this.btnLogin);
            this.Name = "VueGénérale";
            this.Text = "FrmPrincipale";
            this.Load += new System.EventHandler(this.FrmPrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxPrénom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lblPrénom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnEnregistre;
    }
}