namespace Menu
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lancementBouton = new System.Windows.Forms.ToolStripMenuItem();
            this.lancesouris = new System.Windows.Forms.ToolStripMenuItem();
            this.lancementCalculette = new System.Windows.Forms.ToolStripMenuItem();
            this.lancecouleurtexte = new System.Windows.Forms.ToolStripMenuItem();
            this.lancelistbox = new System.Windows.Forms.ToolStripMenuItem();
            this.lancelistcombo = new System.Windows.Forms.ToolStripMenuItem();
            this.lancemelcoul = new System.Windows.Forms.ToolStripMenuItem();
            this.lancevalidation = new System.Windows.Forms.ToolStripMenuItem();
            this.lanceemprunt = new System.Windows.Forms.ToolStripMenuItem();
            this.fenetresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boutoncascade = new System.Windows.Forms.ToolStripMenuItem();
            this.boutonho = new System.Windows.Forms.ToolStripMenuItem();
            this.bvertical = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statututilisateur = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fenetresToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.MdiWindowListItem = this.fenetresToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            resources.ApplyResources(this.connectionToolStripMenuItem, "connectionToolStripMenuItem");
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            resources.ApplyResources(this.sidentifierToolStripMenuItem, "sidentifierToolStripMenuItem");
            this.sidentifierToolStripMenuItem.Click += new System.EventHandler(this.sidentifierToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            resources.ApplyResources(this.quitterToolStripMenuItem, "quitterToolStripMenuItem");
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lancementBouton,
            this.lancesouris,
            this.lancementCalculette,
            this.lancecouleurtexte,
            this.lancelistbox,
            this.lancelistcombo,
            this.lancemelcoul,
            this.lancevalidation,
            this.lanceemprunt});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // lancementBouton
            // 
            this.lancementBouton.Name = "lancementBouton";
            resources.ApplyResources(this.lancementBouton, "lancementBouton");
            this.lancementBouton.Click += new System.EventHandler(this.boutonToolStripMenuItem_Click);
            // 
            // lancesouris
            // 
            this.lancesouris.Name = "lancesouris";
            resources.ApplyResources(this.lancesouris, "lancesouris");
            this.lancesouris.Click += new System.EventHandler(this.lancesouris_Click);
            // 
            // lancementCalculette
            // 
            this.lancementCalculette.Name = "lancementCalculette";
            resources.ApplyResources(this.lancementCalculette, "lancementCalculette");
            this.lancementCalculette.Click += new System.EventHandler(this.lancementCalculette_Click);
            // 
            // lancecouleurtexte
            // 
            this.lancecouleurtexte.Name = "lancecouleurtexte";
            resources.ApplyResources(this.lancecouleurtexte, "lancecouleurtexte");
            this.lancecouleurtexte.Click += new System.EventHandler(this.lancecouleurtexte_Click);
            // 
            // lancelistbox
            // 
            this.lancelistbox.Name = "lancelistbox";
            resources.ApplyResources(this.lancelistbox, "lancelistbox");
            this.lancelistbox.Click += new System.EventHandler(this.lancelistbox_Click);
            // 
            // lancelistcombo
            // 
            this.lancelistcombo.Name = "lancelistcombo";
            resources.ApplyResources(this.lancelistcombo, "lancelistcombo");
            this.lancelistcombo.Click += new System.EventHandler(this.lancelistcombo_Click);
            // 
            // lancemelcoul
            // 
            this.lancemelcoul.Name = "lancemelcoul";
            resources.ApplyResources(this.lancemelcoul, "lancemelcoul");
            this.lancemelcoul.Click += new System.EventHandler(this.lancemelcoul_Click);
            // 
            // lancevalidation
            // 
            this.lancevalidation.Name = "lancevalidation";
            resources.ApplyResources(this.lancevalidation, "lancevalidation");
            this.lancevalidation.Click += new System.EventHandler(this.lancevalidation_Click);
            // 
            // lanceemprunt
            // 
            this.lanceemprunt.Name = "lanceemprunt";
            resources.ApplyResources(this.lanceemprunt, "lanceemprunt");
            this.lanceemprunt.Click += new System.EventHandler(this.lanceemprunt_Click);
            // 
            // fenetresToolStripMenuItem
            // 
            this.fenetresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boutoncascade,
            this.boutonho,
            this.bvertical,
            this.fermerToutToolStripMenuItem});
            resources.ApplyResources(this.fenetresToolStripMenuItem, "fenetresToolStripMenuItem");
            this.fenetresToolStripMenuItem.Name = "fenetresToolStripMenuItem";
            this.fenetresToolStripMenuItem.Click += new System.EventHandler(this.fenetresToolStripMenuItem_Click);
            // 
            // boutoncascade
            // 
            this.boutoncascade.Name = "boutoncascade";
            resources.ApplyResources(this.boutoncascade, "boutoncascade");
            this.boutoncascade.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // boutonho
            // 
            this.boutonho.Name = "boutonho";
            resources.ApplyResources(this.boutonho, "boutonho");
            this.boutonho.Click += new System.EventHandler(this.boutonho_Click);
            // 
            // bvertical
            // 
            this.bvertical.Name = "bvertical";
            resources.ApplyResources(this.bvertical, "bvertical");
            this.bvertical.Click += new System.EventHandler(this.bvertical_Click);
            // 
            // fermerToutToolStripMenuItem
            // 
            this.fermerToutToolStripMenuItem.Name = "fermerToutToolStripMenuItem";
            resources.ApplyResources(this.fermerToutToolStripMenuItem, "fermerToutToolStripMenuItem");
            this.fermerToutToolStripMenuItem.Click += new System.EventHandler(this.fermerToutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statututilisateur,
            this.LabelDate});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // statututilisateur
            // 
            this.statututilisateur.Name = "statututilisateur";
            resources.ApplyResources(this.statututilisateur, "statututilisateur");
            // 
            // LabelDate
            // 
            this.LabelDate.Name = "LabelDate";
            resources.ApplyResources(this.LabelDate, "LabelDate");
            // 
            // FrmMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMenu_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statututilisateur;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lancementBouton;
        private System.Windows.Forms.ToolStripMenuItem lancementCalculette;
        private System.Windows.Forms.ToolStripMenuItem lancecouleurtexte;
        private System.Windows.Forms.ToolStripMenuItem lancelistbox;
        private System.Windows.Forms.ToolStripMenuItem lancelistcombo;
        private System.Windows.Forms.ToolStripMenuItem lancesouris;
        private System.Windows.Forms.ToolStripMenuItem lancemelcoul;
        private System.Windows.Forms.ToolStripMenuItem lancevalidation;
        private System.Windows.Forms.ToolStripMenuItem lanceemprunt;
        private System.Windows.Forms.ToolStripMenuItem fenetresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boutoncascade;
        private System.Windows.Forms.ToolStripMenuItem boutonho;
        private System.Windows.Forms.ToolStripMenuItem bvertical;
        private System.Windows.Forms.ToolStripStatusLabel LabelDate;
        private System.Windows.Forms.ToolStripMenuItem fermerToutToolStripMenuItem;
    }
}

