using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brosok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const float Pi = 3.14F;
        const float g = 9.8F;
        float x;
        float y;
        float x0;
        float y0;
        float v;
        float v0;
        float vx0;
        float vy0;
        float vx;
        float vy;
        double alpha0;
        float ax;
        float ay;
        float t;
        float dt;
        float m;
        float n;
        float R;
        float Fx;
        float Fy;


        Color PixColor;
        private void Perezapusk_Click(object sender, EventArgs e)//перезапуск
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            int z = 0;
            ygol_alpha.Text = Convert.ToString(z);
            Speed_0.Text = Convert.ToString(z);
            time_dt.Text = Convert.ToString(z);
            Hight.Text = Convert.ToString(z);
            Ox.Text = Convert.ToString(z);
            Oy.Text = Convert.ToString(z);
            mass.Text = Convert.ToString(z);
            soprotivlenye.Text = Convert.ToString(z);
            pokazatel.Text = Convert.ToString(z);
            axis1.ClearDin();
            axis1.ClearPic();            //очистка axis, 
            x = 0;
            y = 0;
            t = 0;
        }

        private void instraction_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void axis1_Load(object sender, EventArgs e)
        {
            axis1.PixDraw(2, 2, Color.Aqua, 1);
            axis1.Axis_Type = 1;
            axis1.x_Name = "Ox";
            axis1.y_Name = "Oy";
            axis1.x_Base = Convert.ToSingle(Ox.Text);            
            axis1.y_Base = Convert.ToSingle(Oy.Text); 
            axis1.AxisDraw();
            axis1.DinToPic();
            axis1.StatToDin();
        }
    
        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                alpha0 = Convert.ToSingle(ygol_alpha.Text);
                v0 = Convert.ToSingle(Speed_0.Text);
                dt = Convert.ToSingle(time_dt.Text);
                m = Convert.ToSingle(mass.Text);
                R = Convert.ToSingle(soprotivlenye.Text);
                n = Convert.ToSingle(pokazatel.Text);
                t = 0;
                v = v0;
                vx0 = v0 * (float)(Math.Cos(alpha0 * Pi / 180));
                vy0 = v0 * (float)(Math.Sin(alpha0 * Pi / 180)) - g * t;
                x0 = 0;
                y0 = Convert.ToSingle(Hight.Text);

                if (alpha0 < 0 || dt < 0 || v0 < 0 || y0 < 0 || m < 0 || R < 0 || n < 0)
                {
                    timer2.Stop();
                    timer1.Stop();
                    MessageBox.Show("Уважаемый пользователь, пожалуйста, введите все величины в виде положительного числа");
                }
            }
            catch (FormatException)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Уважаемый пользователь, пожалуйста, введите ЧИСЛО!");
                ygol_alpha.Select();
                Speed_0.Select();
                int z = 0;
                ygol_alpha.Text = Convert.ToString(z);
                Speed_0.Text = Convert.ToString(z);
                time_dt.Text = Convert.ToString(z);
                Hight.Text = Convert.ToString(z);
                Ox.Text = Convert.ToString(z);
                Oy.Text = Convert.ToString(z);
                mass.Text = Convert.ToString(z);
                soprotivlenye.Text = Convert.ToString(z);
                pokazatel.Text = Convert.ToString(z);
                return;
            }
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = (t).ToString();
            t = t + dt;
            if (Sopritivleni_on_off.Checked)
            {
                       //Fx = (float)(-R * Math.Pow(v, n-1)*vx);
                       // Fy = (float)(-R * Math.Pow(v,n-1)*vy-m*g);
                ax = -v * vx;
                ay = -1 - (v * vy);
                      // ax = Fx/m;
                      //  ay = Fy/m;
                vx = vx0 + ax * dt;
                vy = vy0 + ay * dt;
                      // x = (float)((Math.Pow(vx0, n) * Math.Cos(alpha0 * Math.PI / 180) * m / R) - (Math.Pow(vx0, n) * Math.Cos(alpha0 * Math.PI / 180) * m / R));
                      //y = y0 + (float)((m*g+(vy0 * Math.Sin(alpha0 * Math.PI / 180)*R))*dt) - ((g * dt * dt) / 2);
                x = x0 + (vx0 + vx)/2 * dt + ax * dt * dt / 2;
                y = y0 + (vy0 + vy)/2 * dt + ay * dt * dt / 2;

              x0 = x;
              y0 = y;
              vx0 = vx;
              vy0 = vy;
              v = (float)Math.Sqrt(vx * vx + vy * vy);
              PixColor = Color.Magenta;
            }
            else
            {
                    //Fx = (float)(vx);
                    //Fy = (float)(vy - m * g);
                ax = 0;
                ay = -1;
                    //ax = Fy/m;
                    //ay = Fx/m;
                vx = vx0 + ax * dt;
                vy = vy0 + ay * dt;
                    //x = (float)(( Math.Cos(alpha0 * Math.PI / 180) * m ) - (Math.Cos(alpha0 * Math.PI / 180) * m));
                    //y = y0 + (float)(m * g + (vy0 * Math.Sin(alpha0 * Math.PI / 180)) * dt) - ((g * dt * dt) / 2);
                x = x0 + (vx0 + vx)/2 * dt + ax * dt * dt / 2;
                y = y0 + (vy0 + vy)/2 * dt + ay *g* dt * dt / 2;
 
            x0 = x;
            y0 = y;
            vx0 = vx;
            vy0 = vy;
            v = (float)Math.Sqrt(vx * vx + vy * vy);
             PixColor = Color.Aqua;
            }
            if (y < 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                maxline.Text = (x).ToString();
            }
        }

        private void sozdanie_osey_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            axis1.PixDraw(2, 2, Color.Aqua, 1);
            axis1.Axis_Type = 1;
            axis1.x_Name = "Ox";
            axis1.y_Name = "Oy";
            axis1.x_Base = Convert.ToSingle(Ox.Text);
            axis1.y_Base = Convert.ToSingle(Oy.Text);
            axis1.AxisDraw();
            axis1.DinToPic();
            axis1.StatToDin();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            t += 0.01F;
            Invalidate();
            axis1.Pix_Size = 0.002f;       //след траектории
            axis1.PixDraw(x, y, PixColor, 1);
            axis1.StatToDin();
            axis1.Pix_Size = 0.015f;   //размер тела
            axis1.PixDraw(x, y, Color.Black, 2);
            axis1.DinToPic();
        }
        private void Stop_Click(object sender, EventArgs e)//стоп
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private void New_object_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            x = 0;
            y = 0;
            t = 0;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           if (Sopritivleni_on_off.Checked)
            {
                //Fx = (float)(-R * Math.Pow(v, n-1)*vx);
                //Fy = (float)(-R * Math.Pow(v,n-1)*vy-m*g);
                ax = -v * vx;
                ay = -1 - (v * vy);
                //ax = Fx/m;
                //ay = Fy/m;
                vx = vx0 + ax * dt;
                vy = vy0 + ay * dt;
                //x = (float)((Math.Pow(vx0, n) * Math.Cos(alpha0 * Math.PI / 180) * m / R) - (Math.Pow(vx0, n) * Math.Cos(alpha0 * Math.PI / 180) * m / R));
                x = x0 + (vx0 + vx) / 2 * dt + ax * dt * dt / 2;
                y = y0 + (vy0 + vy) / 2 * dt + ay * dt * dt / 2;
                //y = y0 + (float)((m*g+(vy0 * Math.Sin(alpha0 * Math.PI / 180)*R))*m) - ((g * dt * dt) / 2);
                x0 = x;
                y0 = y;
                vx0 = vx;
                vy0 = vy;
                v = (float)Math.Sqrt(vx * vx + vy * vy);
                PixColor = Color.Magenta;
            }
            else
            {
                ax = 0;
                ay = -1;
                //ax = Fy/m;
                //ay = Fx/m;
                vx = vx0 + ax * dt;
                vy = vy0 + ay * dt;
                // x = (float)(x0 + (vx0 * Math.Cos(alpha0 * Math.PI / 180)) * dt);
                x = x0 + (vx0 + vx) / 2 * dt + ax * dt * dt / 2;
                y = y0 + (vy0 + vy) / 2 * dt + ay * g * dt * dt / 2;
                // y = y0 + (float)((vy0 * Math.Sin(alpha0 * Math.PI / 180)) * dt) - ((g * dt * dt) / 2);
                x0 = x;
                y0 = y;
                vx0 = vx;
                vy0 = vy;
                v = (float)Math.Sqrt(vx * vx + vy * vy);
                PixColor = Color.Aqua;
            }
            if (vy0 < 0)
            {
                maxhight.Text = (y).ToString();
                timer3.Enabled = false;
            }
        }
    }
}


