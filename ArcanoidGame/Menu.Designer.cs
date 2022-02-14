namespace ArcanoidGame
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
            this.Start = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Rec = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.PictureBox();
            this.Rules = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Lvl1 = new System.Windows.Forms.PictureBox();
            this.Lvl2 = new System.Windows.Forms.PictureBox();
            this.Escape = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl2)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Location = new System.Drawing.Point(26, 120);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(339, 50);
            this.Start.TabIndex = 0;
            this.Start.TabStop = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Location = new System.Drawing.Point(26, 344);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(339, 50);
            this.Exit.TabIndex = 1;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Rec
            // 
            this.Rec.BackColor = System.Drawing.Color.Transparent;
            this.Rec.Location = new System.Drawing.Point(26, 288);
            this.Rec.Name = "Rec";
            this.Rec.Size = new System.Drawing.Size(339, 50);
            this.Rec.TabIndex = 2;
            this.Rec.TabStop = false;
            this.Rec.Click += new System.EventHandler(this.Rec_Click);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.Location = new System.Drawing.Point(26, 232);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(339, 50);
            this.Info.TabIndex = 3;
            this.Info.TabStop = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.Color.Transparent;
            this.Rules.Location = new System.Drawing.Point(26, 176);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(339, 50);
            this.Rules.TabIndex = 4;
            this.Rules.TabStop = false;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Caesar Dressing Cyrillic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Firebrick;
            this.Title.Location = new System.Drawing.Point(336, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(173, 45);
            this.Title.TabIndex = 5;
            this.Title.Text = "Arkanoid";
            // 
            // Lvl1
            // 
            this.Lvl1.BackColor = System.Drawing.Color.Transparent;
            this.Lvl1.Image = global::ArcanoidGame.Properties.Resources.Lvl1_Button;
            this.Lvl1.Location = new System.Drawing.Point(26, 120);
            this.Lvl1.Name = "Lvl1";
            this.Lvl1.Size = new System.Drawing.Size(339, 50);
            this.Lvl1.TabIndex = 6;
            this.Lvl1.TabStop = false;
            this.Lvl1.Visible = false;
            this.Lvl1.Click += new System.EventHandler(this.Lvl1_Click);
            // 
            // Lvl2
            // 
            this.Lvl2.BackColor = System.Drawing.Color.Transparent;
            this.Lvl2.Image = global::ArcanoidGame.Properties.Resources.Lvl2_Button;
            this.Lvl2.Location = new System.Drawing.Point(26, 176);
            this.Lvl2.Name = "Lvl2";
            this.Lvl2.Size = new System.Drawing.Size(339, 50);
            this.Lvl2.TabIndex = 7;
            this.Lvl2.TabStop = false;
            this.Lvl2.Visible = false;
            this.Lvl2.Click += new System.EventHandler(this.Lvl2_Click);
            // 
            // Escape
            // 
            this.Escape.AutoSize = true;
            this.Escape.BackColor = System.Drawing.Color.Transparent;
            this.Escape.Cursor = System.Windows.Forms.Cursors.Default;
            this.Escape.Font = new System.Drawing.Font("Arkhip", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Escape.ForeColor = System.Drawing.Color.White;
            this.Escape.Location = new System.Drawing.Point(672, 9);
            this.Escape.Name = "Escape";
            this.Escape.Size = new System.Drawing.Size(159, 31);
            this.Escape.TabIndex = 8;
            this.Escape.Text = "Esc-назад";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.Escape);
            this.Controls.Add(this.Lvl2);
            this.Controls.Add(this.Lvl1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Rec);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Start);
            this.DoubleBuffered = true;
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Rec;
        private System.Windows.Forms.PictureBox Info;
        private System.Windows.Forms.PictureBox Rules;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox Lvl1;
        private System.Windows.Forms.PictureBox Lvl2;
        private System.Windows.Forms.Label Escape;
    }
}