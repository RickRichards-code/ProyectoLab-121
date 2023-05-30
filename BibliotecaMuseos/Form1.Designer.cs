namespace BibliotecaMuseos
{
    partial class Form1
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
            this.menu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBiblioteca = new System.Windows.Forms.Button();
            this.buttonMuseos = new System.Windows.Forms.Button();
            this.buttonProblema1 = new System.Windows.Forms.Button();
            this.buttonProblema2 = new System.Windows.Forms.Button();
            this.buttonProblema3 = new System.Windows.Forms.Button();
            this.buttonProblema4 = new System.Windows.Forms.Button();
            this.buttonProblema5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(26)))));
            this.menu.Controls.Add(this.panel3);
            this.menu.Controls.Add(this.panelMenu);
            this.menu.Controls.Add(this.panel2);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(250, 655);
            this.menu.TabIndex = 0;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.menu_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 655);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 123);
            this.panel2.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 123);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 54);
            this.panelMenu.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonProblema5);
            this.panel3.Controls.Add(this.buttonProblema4);
            this.panel3.Controls.Add(this.buttonProblema3);
            this.panel3.Controls.Add(this.buttonProblema2);
            this.panel3.Controls.Add(this.buttonProblema1);
            this.panel3.Controls.Add(this.buttonMuseos);
            this.panel3.Controls.Add(this.buttonBiblioteca);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 426);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // buttonBiblioteca
            // 
            this.buttonBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.buttonBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBiblioteca.FlatAppearance.BorderSize = 0;
            this.buttonBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBiblioteca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.buttonBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.buttonBiblioteca.Name = "buttonBiblioteca";
            this.buttonBiblioteca.Size = new System.Drawing.Size(250, 45);
            this.buttonBiblioteca.TabIndex = 0;
            this.buttonBiblioteca.Text = "Biblioteca";
            this.buttonBiblioteca.UseVisualStyleBackColor = false;
            this.buttonBiblioteca.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonMuseos
            // 
            this.buttonMuseos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.buttonMuseos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMuseos.FlatAppearance.BorderSize = 0;
            this.buttonMuseos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMuseos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.buttonMuseos.Location = new System.Drawing.Point(0, 45);
            this.buttonMuseos.Name = "buttonMuseos";
            this.buttonMuseos.Size = new System.Drawing.Size(250, 45);
            this.buttonMuseos.TabIndex = 1;
            this.buttonMuseos.Text = "Museos";
            this.buttonMuseos.UseVisualStyleBackColor = false;
            this.buttonMuseos.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonProblema1
            // 
            this.buttonProblema1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.buttonProblema1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProblema1.FlatAppearance.BorderSize = 0;
            this.buttonProblema1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProblema1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.buttonProblema1.Location = new System.Drawing.Point(0, 90);
            this.buttonProblema1.Name = "buttonProblema1";
            this.buttonProblema1.Size = new System.Drawing.Size(250, 45);
            this.buttonProblema1.TabIndex = 2;
            this.buttonProblema1.Text = "Problema 1";
            this.buttonProblema1.UseVisualStyleBackColor = false;
            // 
            // buttonProblema2
            // 
            this.buttonProblema2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.buttonProblema2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProblema2.FlatAppearance.BorderSize = 0;
            this.buttonProblema2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProblema2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.buttonProblema2.Location = new System.Drawing.Point(0, 135);
            this.buttonProblema2.Name = "buttonProblema2";
            this.buttonProblema2.Size = new System.Drawing.Size(250, 45);
            this.buttonProblema2.TabIndex = 3;
            this.buttonProblema2.Text = "Problema 2";
            this.buttonProblema2.UseVisualStyleBackColor = false;
            // 
            // buttonProblema3
            // 
            this.buttonProblema3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.buttonProblema3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProblema3.FlatAppearance.BorderSize = 0;
            this.buttonProblema3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProblema3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.buttonProblema3.Location = new System.Drawing.Point(0, 180);
            this.buttonProblema3.Name = "buttonProblema3";
            this.buttonProblema3.Size = new System.Drawing.Size(250, 45);
            this.buttonProblema3.TabIndex = 4;
            this.buttonProblema3.Text = "Problema 3";
            this.buttonProblema3.UseVisualStyleBackColor = false;
            // 
            // buttonProblema4
            // 
            this.buttonProblema4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.buttonProblema4.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProblema4.FlatAppearance.BorderSize = 0;
            this.buttonProblema4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProblema4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.buttonProblema4.Location = new System.Drawing.Point(0, 225);
            this.buttonProblema4.Name = "buttonProblema4";
            this.buttonProblema4.Size = new System.Drawing.Size(250, 45);
            this.buttonProblema4.TabIndex = 5;
            this.buttonProblema4.Text = "Problema 4";
            this.buttonProblema4.UseVisualStyleBackColor = false;
            this.buttonProblema4.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonProblema5
            // 
            this.buttonProblema5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.buttonProblema5.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProblema5.FlatAppearance.BorderSize = 0;
            this.buttonProblema5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProblema5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(218)))), ((int)(((byte)(202)))));
            this.buttonProblema5.Location = new System.Drawing.Point(0, 270);
            this.buttonProblema5.Name = "buttonProblema5";
            this.buttonProblema5.Size = new System.Drawing.Size(250, 45);
            this.buttonProblema5.TabIndex = 6;
            this.buttonProblema5.Text = "Problema 5";
            this.buttonProblema5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(118)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(97, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonProblema5;
        private System.Windows.Forms.Button buttonProblema4;
        private System.Windows.Forms.Button buttonProblema3;
        private System.Windows.Forms.Button buttonProblema2;
        private System.Windows.Forms.Button buttonProblema1;
        private System.Windows.Forms.Button buttonMuseos;
        private System.Windows.Forms.Button buttonBiblioteca;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label1;
    }
}

