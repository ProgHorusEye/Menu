namespace Menu
{
    partial class identifie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(identifie));
            this.label1 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.Valide = new System.Windows.Forms.Button();
            this.motdepasse = new System.Windows.Forms.TextBox();
            this.EtiLogin = new System.Windows.Forms.Label();
            this.Etipassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quel est votre prénom mon brave ?";
            // 
            // Prenom
            // 
            this.Prenom.AcceptsReturn = true;
            this.Prenom.AcceptsTab = true;
            this.Prenom.Location = new System.Drawing.Point(130, 76);
            this.Prenom.Name = "Prenom";
            this.Prenom.ShortcutsEnabled = false;
            this.Prenom.Size = new System.Drawing.Size(195, 20);
            this.Prenom.TabIndex = 1;
            this.Prenom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Prenom_KeyDown);
            this.Prenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Prenom_KeyPress);
            // 
            // Valide
            // 
            this.Valide.Location = new System.Drawing.Point(109, 172);
            this.Valide.Name = "Valide";
            this.Valide.Size = new System.Drawing.Size(154, 23);
            this.Valide.TabIndex = 3;
            this.Valide.Text = "Envoi du Lourd !!!";
            this.Valide.UseVisualStyleBackColor = true;
            this.Valide.Click += new System.EventHandler(this.Valide_Click);
            // 
            // motdepasse
            // 
            this.motdepasse.AcceptsReturn = true;
            this.motdepasse.AcceptsTab = true;
            this.motdepasse.Location = new System.Drawing.Point(130, 121);
            this.motdepasse.Name = "motdepasse";
            this.motdepasse.ShortcutsEnabled = false;
            this.motdepasse.Size = new System.Drawing.Size(195, 20);
            this.motdepasse.TabIndex = 2;
            this.motdepasse.UseSystemPasswordChar = true;
            // 
            // EtiLogin
            // 
            this.EtiLogin.AutoSize = true;
            this.EtiLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtiLogin.Location = new System.Drawing.Point(37, 80);
            this.EtiLogin.Name = "EtiLogin";
            this.EtiLogin.Size = new System.Drawing.Size(46, 16);
            this.EtiLogin.TabIndex = 4;
            this.EtiLogin.Text = "Login";
            // 
            // Etipassword
            // 
            this.Etipassword.AutoSize = true;
            this.Etipassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etipassword.Location = new System.Drawing.Point(37, 125);
            this.Etipassword.Name = "Etipassword";
            this.Etipassword.Size = new System.Drawing.Size(76, 16);
            this.Etipassword.TabIndex = 5;
            this.Etipassword.Text = "Password";
            // 
            // identifie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 207);
            this.Controls.Add(this.Etipassword);
            this.Controls.Add(this.EtiLogin);
            this.Controls.Add(this.motdepasse);
            this.Controls.Add(this.Valide);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "identifie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tel est la question !";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.identifie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Button Valide;
        private System.Windows.Forms.TextBox motdepasse;
        private System.Windows.Forms.Label EtiLogin;
        private System.Windows.Forms.Label Etipassword;
    }
}