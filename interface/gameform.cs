using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class gameform : Form
{
    public gameform()
    {
        InitializeComponent();
            start();
    }
        Random rng = new Random();
        List<PictureBox> cars = new List<PictureBox>();
        Timer carmove = new Timer();
        Timer trainspawn = new Timer();
        Timer trainmove = new Timer();
        
        void start()
        {
            movecars();

            pictureBox5.Click += (s,e) =>
            {
                if (pictureBox3.Height >= 130)
                {
                    pictureBox3.Height = 20;
                }
                else
                {
                    pictureBox3.Height = 130;
                }

            };

        }
        void movecars()
        {
            makecar();
            carmove.Interval = 25;
            carmove.Start();
            carmove.Tick += (s,e ) => {
                foreach (PictureBox item in cars)
                {
                    if (pictureBox3.Height == 20)
                    {
                        item.Left += 2;
                    }
                    else if(pictureBox3.Height == 130)
                    {
                        if(item.Right >= pictureBox3.Left)
                        {
                            item.Left += 2;
                        }
                    }
                }
            if (cars.Last().Left >=10)
            {
                makecar();
            }
            };

            
            
        }
        void movetrain()
        {
            trainspawn.Interval = 30000;
            trainspawn.Start();
            trainmove.Interval = 10;
            trainmove.Start();
            trainspawn.Tick += (s, e) =>
            {
                maketrain();

                trainmove.Tick += (a, d) =>
                {
                    if(train.Top <= this.Height)
                    {
                        train.Top += 4;
                    }
                };
            };
        }
        void makecar()
        {
            PictureBox car = new PictureBox();
            car.Height = pictureBox1.Height - 10;
            car.Width = 70;
            car.Top = pictureBox1.Top + 5;
            car.Left = -90;
            car.BackColor = Color.FromArgb(rng.Next(0, 255), rng.Next(0, 255), rng.Next(0, 255));
            Controls.Add(car);
            car.BringToFront();
            cars.Add(car);
        }
        PictureBox train = new PictureBox();
        void maketrain()
        {
            train.Height = pictureBox4.Height + 10;
            train.Width = pictureBox4.Width-6;
            train.Top = (train.Height *-1)-10;
            train.Left = pictureBox4.Left+3;
            train.BackColor = Color.WhiteSmoke;
            Controls.Add(train);
            train.BringToFront();
        }
    }
}
