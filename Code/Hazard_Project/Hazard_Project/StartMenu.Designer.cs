namespace Hazard_Project
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.NewGame = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.HelpBox = new System.Windows.Forms.Label();
            this.HelpBoxQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatAppearance.BorderSize = 0;
            this.NewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame.ForeColor = System.Drawing.Color.Transparent;
            this.NewGame.Location = new System.Drawing.Point(632, 258);
            this.NewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewGame.MinimumSize = new System.Drawing.Size(20, 20);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(638, 128);
            this.NewGame.TabIndex = 0;
            this.NewGame.Tag = "StartMenu";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Quit.FlatAppearance.BorderSize = 0;
            this.Quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quit.ForeColor = System.Drawing.Color.Transparent;
            this.Quit.Location = new System.Drawing.Point(631, 444);
            this.Quit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Quit.MinimumSize = new System.Drawing.Size(20, 20);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(639, 128);
            this.Quit.TabIndex = 1;
            this.Quit.Tag = "StartMenu";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.FlatAppearance.BorderSize = 0;
            this.Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.ForeColor = System.Drawing.Color.Transparent;
            this.Help.Location = new System.Drawing.Point(652, 630);
            this.Help.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Help.MinimumSize = new System.Drawing.Size(20, 20);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(593, 98);
            this.Help.TabIndex = 2;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // HelpBox
            // 
            this.HelpBox.AutoSize = true;
            this.HelpBox.BackColor = System.Drawing.Color.Transparent;
            this.HelpBox.Location = new System.Drawing.Point(3, 2);
            this.HelpBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelpBox.MinimumSize = new System.Drawing.Size(20, 20);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.Size = new System.Drawing.Size(20, 20);
            this.HelpBox.TabIndex = 3;
            // 
            // HelpBoxQuit
            // 
            this.HelpBoxQuit.BackColor = System.Drawing.Color.DimGray;
            this.HelpBoxQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HelpBoxQuit.BackgroundImage")));
            this.HelpBoxQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpBoxQuit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.HelpBoxQuit.FlatAppearance.BorderSize = 0;
            this.HelpBoxQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HelpBoxQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HelpBoxQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBoxQuit.ForeColor = System.Drawing.Color.Transparent;
            this.HelpBoxQuit.Location = new System.Drawing.Point(1841, 14);
            this.HelpBoxQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HelpBoxQuit.MinimumSize = new System.Drawing.Size(20, 20);
            this.HelpBoxQuit.Name = "HelpBoxQuit";
            this.HelpBoxQuit.Size = new System.Drawing.Size(70, 68);
            this.HelpBoxQuit.TabIndex = 4;
            this.HelpBoxQuit.UseVisualStyleBackColor = false;
            this.HelpBoxQuit.Visible = false;
            this.HelpBoxQuit.Click += new System.EventHandler(this.HelpBoxQuit_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.HelpBoxQuit);
            this.Controls.Add(this.HelpBox);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.NewGame);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Label HelpBox;
        private System.Windows.Forms.Button HelpBoxQuit;
    }
}

