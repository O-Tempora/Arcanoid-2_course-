using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ArcanoidGame
{
    public partial class Menu : Form
    {
        PictureBox InfoWindow;
        PictureBox RulesWindow;

        int lvl_Choice;

        DataGridView Table_of_Records;

        private List<Records> RecordTable = new List<Records>();
        public string path = Path.GetFullPath("SaveFile.txt"); // Файл сохранения
        public Menu()
        {
            InitializeComponent();
            BackgroundImage = new Bitmap(Properties.Resources.MenuBack, ClientSize);
            Start.Image = new Bitmap(Properties.Resources.Start);
            Rules.Image = new Bitmap(Properties.Resources.Rules);
            Info.Image = new Bitmap(Properties.Resources.Info);
            Rec.Image = new Bitmap(Properties.Resources.Rec);
            Exit.Image = new Bitmap(Properties.Resources.Exit);
            Escape.Visible = false;

            Start.MouseEnter += Start_MouseEnter;
            Start.MouseLeave += Start_MouseLeave;
            Rules.MouseEnter += Rules_MouseEnter;
            Rules.MouseLeave += Rules_MouseLeave;
            Info.MouseEnter += Info_MouseEnter;
            Info.MouseLeave += Info_MouseLeave;
            Rec.MouseEnter += Rec_MouseEnter;
            Rec.MouseLeave += Rec_MouseLeave;
            Exit.MouseEnter += Exit_MouseEnter;
            Exit.MouseLeave += Exit_MouseLeave;
            Lvl1.MouseEnter += Lvl1_MouseEnter;
            Lvl1.MouseLeave += Lvl1_MouseLeave;
            Lvl2.MouseEnter += Lvl2_MouseEnter;
            Lvl2.MouseLeave += Lvl2_MouseLeave;

            this.KeyDown += new KeyEventHandler(Rules_Info_Table_Close); // Закрытие окон в меню
        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void Start_MouseEnter(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.Yellow, 2), Start.Bounds);
            }
        }
        private void Rules_MouseLeave(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void Rules_MouseEnter(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.Yellow, 2), Rules.Bounds);
            }
        }
        private void Info_MouseLeave(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void Info_MouseEnter(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.Yellow, 2), Info.Bounds);
            }
        }
        private void Rec_MouseLeave(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void Rec_MouseEnter(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.Yellow, 2), Rec.Bounds);
            }
        }
        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.Yellow, 2), Exit.Bounds);
            }
        }
        private void Lvl1_MouseLeave(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void Lvl1_MouseEnter(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.Yellow, 2), Lvl1.Bounds);
            }
        }
        private void Lvl2_MouseLeave(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void Lvl2_MouseEnter(object sender, EventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.DrawRectangle(new Pen(Color.Yellow, 2), Lvl2.Bounds);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Controls.Remove(Start);
            Controls.Remove(Rules);
            Controls.Remove(Info);
            Controls.Remove(Rec);
            Controls.Remove(Exit);

            Controls.Add(Lvl1);
            Controls.Add(Lvl2);
            Lvl1.Visible = true;
            Lvl2.Visible = true;
            Escape.Visible = true;
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            RulesWindow = new PictureBox();
            RulesWindow.Location = new Point(20, 20);
            RulesWindow.Size = new Size(700, 600);
            RulesWindow.Image = new Bitmap(Properties.Resources.RulesBox);
            RulesWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            RulesWindow.Visible = true;
            Controls.Add(RulesWindow);
            Start.SendToBack();
            Rules.SendToBack();
            Info.SendToBack();
            Rec.SendToBack();
            Exit.SendToBack();
            Title.SendToBack();
            Escape.Visible = true;
        }

        private void Info_Click(object sender, EventArgs e)
        {
            InfoWindow = new PictureBox();
            InfoWindow.Location = new Point(20, 20);
            InfoWindow.Size = new Size(700, 600);
            InfoWindow.Image = new Bitmap(Properties.Resources.InfoBox);
            InfoWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            InfoWindow.Visible = true;
            Controls.Add(InfoWindow);
            Start.SendToBack();
            Rules.SendToBack();
            Info.SendToBack();
            Rec.SendToBack();
            Exit.SendToBack();
            Title.SendToBack();
            Escape.Visible = true;
        }

        private void Rules_Info_Table_Close(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                if (RulesWindow != null) { RulesWindow.Dispose(); Escape.Visible = false; }
                if (InfoWindow != null) { InfoWindow.Dispose(); Escape.Visible = false; }
                if (Table_of_Records != null) { Table_of_Records.Dispose(); Escape.Visible = false; }
                if (Lvl1.Visible == true && Lvl2.Visible == true)
                {
                    Lvl1.Visible = false;
                    Lvl2.Visible = false;
                    Controls.Remove(Lvl1);
                    Controls.Remove(Lvl2);

                    Controls.Add(Start);
                    Controls.Add(Rules);
                    Controls.Add(Info);
                    Controls.Add(Rec);
                    Controls.Add(Exit);

                    Escape.Visible = false;
                }
            }
        }

        private void Rec_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                if (fs.Length != 0)
                {
                    object table = formatter.Deserialize(fs);
                    RecordTable = (table as List<ArcanoidGame.Records>);
                }
            }
            Table_of_Records = new DataGridView();
            Table_of_Records.Location = new Point(450, 150);
            Table_of_Records.Size = new Size(300, 400);

            DataTable rec_table = new DataTable();
            rec_table.Columns.Add("Дата", typeof(string));
            rec_table.Columns.Add("Время", typeof(string));
            rec_table.Columns.Add("Очки", typeof(int));

            if (RecordTable.Count != 0)
            {
                for (int i = 0; i < RecordTable.Count; i++)
                {
                    rec_table.Rows.Add(RecordTable[i].Get_Record_Date(), RecordTable[i].Get_Record_Time(), RecordTable[i].Get_Record_Score());
                }
                Table_of_Records.DataSource = rec_table;
                Controls.Add(Table_of_Records);
            }
            Escape.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lvl1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            lvl_Choice = 1;
            Data.EventHandler(lvl_Choice);
            game.Show();
        }

        private void Lvl2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game();
            lvl_Choice = 2;
            Data.EventHandler(lvl_Choice);
            game.Show();
        }
    }
}
