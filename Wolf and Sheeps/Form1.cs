using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolf_and_Sheeps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int numberSheeps = 0;
        public int numberWolfs = 0;
        public int step = 128;
        public int SheepSize = 64;
        public int WolfSize = 64;
        Random random = new Random();
        List<PictureBox> Sheeps = new List<PictureBox>();
        List<PictureBox> Wolfs = new List<PictureBox>();
        private void addSheep() 
        {
            int x = random.Next(0, Field.Width);
            if (x > Field.Width - SheepSize) 
            {
                x = Field.Width - SheepSize;
            }

            int y = random.Next(0, Field.Height);
            if (y > Field.Height - SheepSize) 
            {
                y = Field.Height - SheepSize;
            }
            PictureBox sheep = new PictureBox();
            sheep.BackgroundImage = Properties.Resources.icons8_lamb_64;
            sheep.BackColor = Color.Transparent;
            sheep.Width = SheepSize;
            sheep.Height = SheepSize;
            sheep.Left = x;
            sheep.Top = y;
            Field.Controls.Add(sheep);
            numberSheeps++;
            labelSheep.Text = numberSheeps.ToString();
            Sheeps.Add(sheep);
        }
        private void addWolf()
        {
            int x = random.Next(0, Field.Width);
            if (x > Field.Width - WolfSize)
            {
                x = Field.Width - WolfSize;
            }

            int y = random.Next(0, Field.Height);
            if (y > Field.Height - WolfSize)
            {
                y = Field.Height - WolfSize;
            }
            PictureBox wolf = new PictureBox();
            wolf.BackgroundImage = Properties.Resources.icons8_wolf_64;
            wolf.BackColor = Color.Transparent;
            wolf.Width = SheepSize;
            wolf.Height = SheepSize;
            wolf.Left = x;
            wolf.Top = y;
            Field.Controls.Add(wolf);
            numberWolfs++;
            labelWolf.Text = numberWolfs.ToString();
            Wolfs.Add(wolf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addSheep();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addWolf();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            addSheep();
            addSheep();
            addSheep();
            addWolf();
        }

        private void AnimalSetPosition(PictureBox animal, int Dir, int Step) 
        {
            switch (Dir) 
            {
                case 1:
                    {
                        animal.Top -= Step;
                        if(animal.Top < 0) 
                        {
                            animal.Top = 0;
                        }
                        break;
                    }
                case 2: 
                    {
                        animal.Top -= Step;
                        animal.Left += Step;
                        if(animal.Top < 0) { animal.Top = 0; }
                        if(animal.Left > Field.Width-SheepSize) { animal.Left = Field.Width - SheepSize; }
                        break;
                    }
                case 3:
                    {
                        animal.Left += Step;
                        if (animal.Left > Field.Width - SheepSize) { animal.Left = Field.Width - SheepSize; }
                        break;
                    }
                case 4:
                    {
                        animal.Top += Step;
                        animal.Left += Step;
                        if (animal.Top > Field.Height - SheepSize) { animal.Top = Field.Height - SheepSize; }
                        if (animal.Left > Field.Width - SheepSize) { animal.Left = Field.Width - SheepSize; }
                        break;
                    }
                case 5:
                    {
                        animal.Top += Step;
                        if (animal.Top > Field.Height - SheepSize) { animal.Top = Field.Height - SheepSize; }
                        break;
                    }
                case 6:
                    {
                        animal.Top += Step;
                        animal.Left -= Step;
                        if (animal.Top > Field.Height - SheepSize) { animal.Top = Field.Height - SheepSize; }
                        if (animal.Left < 0) { animal.Left = 0; }
                        break;
                    }
                case 7:
                    {
                        animal.Left -= Step;
                        
                        if (animal.Left < 0) { animal.Left = 0; }
                        break;
                    }
                case 8:
                    {
                        animal.Top -= Step;
                        animal.Left -= Step;
                        if (animal.Top < 0) { animal.Top = 0; }
                        if (animal.Left < 0) { animal.Left = 0; }
                        break;
                    }
            }
        }
        private void SheepMoving() 
        {
            for(int i = 0; i < numberSheeps; i++) 
            {
                AnimalSetPosition(Sheeps[i], random.Next(1,9), step);
            }
        }
        private void WolfMoving()
        {
            for (int i = 0; i < numberWolfs; i++)
            {
                AnimalSetPosition(Wolfs[i], random.Next(1, 9), step);
            }
        }

        private void timerWolf_Tick(object sender, EventArgs e)
        {
            UpdateWolfs();
            if (numberSheeps <= 0) 
            {
                timerWolf.Enabled = false;
                timerSheep.Enabled = false;
                MessageBox.Show("Game Over"); 
            }
        }

        private void timerSheep_Tick(object sender, EventArgs e)
        {
            UpdateSheeps();
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            timerWolf.Enabled = true;
            timerSheep.Enabled = true;
        }
        private bool IsIntersect(PictureBox p1, PictureBox p2) 
        {
            return (p2.Left < p1.Left + p1.Width) && (p1.Left < (p2.Left + p2.Width)) && 
                (p2.Top < p1.Top + p1.Height) && (p1.Top < p2.Top + p2.Height); 
        }
        private void IntersectSheepsAndSheeps() 
        {
            for (int i = 0; i < numberSheeps-1; i++)
            {
                for (int j = i+1; j < numberSheeps; j++)
                {
                    if (IsIntersect(Sheeps[i], Sheeps[j])) { addSheep(); }
                }
            }
        }
        private void IntersectSheepsAndWolfs()
        {
            for (int i = 0; i < numberWolfs; i++)
            {
                for (int j = 0; j < numberSheeps; j++)
                {
                    if (IsIntersect(Wolfs[i], Sheeps[j])) 
                    { 
                        Sheeps.Remove(Sheeps[j]);
                        numberSheeps -= 1;
                        labelSheep.Text = numberSheeps.ToString();
                        //Field.Update();
                        break;
                    }
                }
            }
        }
        private void UpdateSheeps() 
        {
            SheepMoving();
            IntersectSheepsAndSheeps();
        }
        private void UpdateWolfs()
        {
            WolfMoving();
            IntersectSheepsAndWolfs();
        }
    }
}
