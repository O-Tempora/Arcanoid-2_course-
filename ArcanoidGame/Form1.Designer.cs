namespace ArcanoidGame
{
    partial class Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScoreOutput
            // 
            this.ScoreOutput.AutoSize = true;
            this.ScoreOutput.BackColor = System.Drawing.Color.Transparent;
            this.ScoreOutput.Font = new System.Drawing.Font("Arkhip", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScoreOutput.Location = new System.Drawing.Point(12, 9);
            this.ScoreOutput.Name = "ScoreOutput";
            this.ScoreOutput.Size = new System.Drawing.Size(0, 31);
            this.ScoreOutput.TabIndex = 0;
            this.ScoreOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ScoreOutput.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.ScoreOutput);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ScoreOutput;
    }
}

