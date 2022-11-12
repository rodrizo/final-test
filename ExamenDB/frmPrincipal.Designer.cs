namespace ExamenDB
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPracticasPr = new System.Windows.Forms.Button();
            this.btnPracticasEst = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(406, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1216, 117);
            this.panelTitleBar.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(434, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Examen final DB";
            // 
            // btnPracticasPr
            // 
            this.btnPracticasPr.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPracticasPr.FlatAppearance.BorderSize = 0;
            this.btnPracticasPr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPracticasPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPracticasPr.ForeColor = System.Drawing.Color.White;
            this.btnPracticasPr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPracticasPr.Location = new System.Drawing.Point(0, 190);
            this.btnPracticasPr.Name = "btnPracticasPr";
            this.btnPracticasPr.Size = new System.Drawing.Size(406, 73);
            this.btnPracticasPr.TabIndex = 2;
            this.btnPracticasPr.Text = "Prácticas profesores";
            this.btnPracticasPr.UseVisualStyleBackColor = true;
            this.btnPracticasPr.Click += new System.EventHandler(this.btnPracticasPr_Click);
            // 
            // btnPracticasEst
            // 
            this.btnPracticasEst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPracticasEst.FlatAppearance.BorderSize = 0;
            this.btnPracticasEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPracticasEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPracticasEst.ForeColor = System.Drawing.Color.White;
            this.btnPracticasEst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPracticasEst.Location = new System.Drawing.Point(0, 117);
            this.btnPracticasEst.Name = "btnPracticasEst";
            this.btnPracticasEst.Size = new System.Drawing.Size(406, 73);
            this.btnPracticasEst.TabIndex = 1;
            this.btnPracticasEst.Text = "Prácticas estudiantes";
            this.btnPracticasEst.UseVisualStyleBackColor = true;
            this.btnPracticasEst.Click += new System.EventHandler(this.btnPracticasEst_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.LightGray;
            this.panelDesktopPane.Controls.Add(this.panel1);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(406, 0);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1216, 823);
            this.panelDesktopPane.TabIndex = 6;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(406, 117);
            this.panelLogo.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnPracticasPr);
            this.panelMenu.Controls.Add(this.btnPracticasEst);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(406, 823);
            this.panelMenu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(3, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 706);
            this.panel1.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 823);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPracticasPr;
        private System.Windows.Forms.Button btnPracticasEst;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
    }
}

