namespace brosok
{
    partial class Form1
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
            this.axis1 = new myUCLib.Axis();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ygol_alpha = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Speed_0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time_dt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Hight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.sozdanie_osey = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Perezapusk = new System.Windows.Forms.Button();
            this.Sopritivleni_on_off = new System.Windows.Forms.CheckBox();
            this.instraction = new System.Windows.Forms.Button();
            this.Ox = new System.Windows.Forms.TextBox();
            this.Oy = new System.Windows.Forms.TextBox();
            this.mass = new System.Windows.Forms.TextBox();
            this.soprotivlenye = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pokazatel = new System.Windows.Forms.TextBox();
            this.New_object = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.maxhight = new System.Windows.Forms.TextBox();
            this.maxline = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // axis1
            // 
            this.axis1.AllowDrop = true;
            this.axis1.axis_bkcolor = System.Drawing.Color.White;
            this.axis1.axis_color = System.Drawing.Color.Black;
            this.axis1.Axis_Type = ((byte)(1));
            this.axis1.BackColor = System.Drawing.Color.Transparent;
            this.axis1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.axis1.E_x = 0;
            this.axis1.E_y = 0;
            this.axis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.axis1.ForeColor = System.Drawing.Color.Lime;
            this.axis1.Location = new System.Drawing.Point(337, 12);
            this.axis1.Name = "axis1";
            this.axis1.Pix_color = System.Drawing.Color.White;
            this.axis1.Pix_Size = 2F;
            this.axis1.Pix_type = ((byte)(1));
            this.axis1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.axis1.Size = new System.Drawing.Size(914, 625);
            this.axis1.TabIndex = 0;
            this.axis1.x_Base = 1F;
            this.axis1.x_Name = "X";
            this.axis1.y_Base = 1F;
            this.axis1.y_Name = "Y";
            this.axis1.z_Base = 1F;
            this.axis1.z_Name = "Z";
            this.axis1.Load += new System.EventHandler(this.axis1_Load);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LightGray;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(182, 97);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 29);
            this.Start.TabIndex = 1;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(129, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальная скорость тела";
            // 
            // ygol_alpha
            // 
            this.ygol_alpha.BackColor = System.Drawing.Color.White;
            this.ygol_alpha.ForeColor = System.Drawing.Color.Black;
            this.ygol_alpha.Location = new System.Drawing.Point(17, 165);
            this.ygol_alpha.Name = "ygol_alpha";
            this.ygol_alpha.Size = new System.Drawing.Size(100, 20);
            this.ygol_alpha.TabIndex = 3;
            this.ygol_alpha.Text = "45";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Speed_0
            // 
            this.Speed_0.BackColor = System.Drawing.Color.White;
            this.Speed_0.ForeColor = System.Drawing.Color.Black;
            this.Speed_0.Location = new System.Drawing.Point(17, 200);
            this.Speed_0.Name = "Speed_0";
            this.Speed_0.Size = new System.Drawing.Size(100, 20);
            this.Speed_0.TabIndex = 4;
            this.Speed_0.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Угол броска тела  α";
            // 
            // time_dt
            // 
            this.time_dt.BackColor = System.Drawing.Color.White;
            this.time_dt.ForeColor = System.Drawing.Color.Black;
            this.time_dt.Location = new System.Drawing.Point(17, 234);
            this.time_dt.Name = "time_dt";
            this.time_dt.Size = new System.Drawing.Size(100, 20);
            this.time_dt.TabIndex = 6;
            this.time_dt.Text = "0,05";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(129, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "dt (рекомендуется 0,1)";
            // 
            // Hight
            // 
            this.Hight.BackColor = System.Drawing.Color.White;
            this.Hight.ForeColor = System.Drawing.Color.Black;
            this.Hight.Location = new System.Drawing.Point(17, 266);
            this.Hight.Name = "Hight";
            this.Hight.Size = new System.Drawing.Size(100, 20);
            this.Hight.TabIndex = 8;
            this.Hight.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(129, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Высота";
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.LightGray;
            this.Stop.ForeColor = System.Drawing.Color.Black;
            this.Stop.Location = new System.Drawing.Point(144, 712);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(95, 29);
            this.Stop.TabIndex = 11;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // sozdanie_osey
            // 
            this.sozdanie_osey.BackColor = System.Drawing.Color.LightGray;
            this.sozdanie_osey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sozdanie_osey.ForeColor = System.Drawing.Color.Black;
            this.sozdanie_osey.Location = new System.Drawing.Point(12, 91);
            this.sozdanie_osey.Name = "sozdanie_osey";
            this.sozdanie_osey.Size = new System.Drawing.Size(122, 43);
            this.sozdanie_osey.TabIndex = 12;
            this.sozdanie_osey.Text = "Создание осей и тела";
            this.sozdanie_osey.UseVisualStyleBackColor = false;
            this.sozdanie_osey.Click += new System.EventHandler(this.sozdanie_osey_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Perezapusk
            // 
            this.Perezapusk.BackColor = System.Drawing.Color.LightGray;
            this.Perezapusk.ForeColor = System.Drawing.Color.Black;
            this.Perezapusk.Location = new System.Drawing.Point(22, 712);
            this.Perezapusk.Name = "Perezapusk";
            this.Perezapusk.Size = new System.Drawing.Size(95, 29);
            this.Perezapusk.TabIndex = 13;
            this.Perezapusk.Text = "Перезапуск";
            this.Perezapusk.UseVisualStyleBackColor = false;
            this.Perezapusk.Click += new System.EventHandler(this.Perezapusk_Click);
            // 
            // Sopritivleni_on_off
            // 
            this.Sopritivleni_on_off.AutoSize = true;
            this.Sopritivleni_on_off.ForeColor = System.Drawing.Color.Black;
            this.Sopritivleni_on_off.Location = new System.Drawing.Point(17, 645);
            this.Sopritivleni_on_off.Name = "Sopritivleni_on_off";
            this.Sopritivleni_on_off.Size = new System.Drawing.Size(147, 17);
            this.Sopritivleni_on_off.TabIndex = 14;
            this.Sopritivleni_on_off.Text = "Сопротивление воздуха";
            this.Sopritivleni_on_off.UseVisualStyleBackColor = true;
            // 
            // instraction
            // 
            this.instraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instraction.Location = new System.Drawing.Point(59, 28);
            this.instraction.Name = "instraction";
            this.instraction.Size = new System.Drawing.Size(197, 38);
            this.instraction.TabIndex = 16;
            this.instraction.Text = "Рекомендации";
            this.instraction.UseVisualStyleBackColor = true;
            this.instraction.Click += new System.EventHandler(this.instraction_Click);
            // 
            // Ox
            // 
            this.Ox.BackColor = System.Drawing.Color.White;
            this.Ox.ForeColor = System.Drawing.Color.Black;
            this.Ox.Location = new System.Drawing.Point(17, 300);
            this.Ox.Name = "Ox";
            this.Ox.Size = new System.Drawing.Size(100, 20);
            this.Ox.TabIndex = 17;
            this.Ox.Text = "600";
            // 
            // Oy
            // 
            this.Oy.BackColor = System.Drawing.Color.White;
            this.Oy.ForeColor = System.Drawing.Color.Black;
            this.Oy.Location = new System.Drawing.Point(17, 334);
            this.Oy.Name = "Oy";
            this.Oy.Size = new System.Drawing.Size(100, 20);
            this.Oy.TabIndex = 18;
            this.Oy.Text = "500";
            // 
            // mass
            // 
            this.mass.BackColor = System.Drawing.Color.White;
            this.mass.ForeColor = System.Drawing.Color.Black;
            this.mass.Location = new System.Drawing.Point(17, 368);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(100, 20);
            this.mass.TabIndex = 19;
            this.mass.Text = "2";
            // 
            // soprotivlenye
            // 
            this.soprotivlenye.BackColor = System.Drawing.Color.White;
            this.soprotivlenye.ForeColor = System.Drawing.Color.Black;
            this.soprotivlenye.Location = new System.Drawing.Point(17, 398);
            this.soprotivlenye.Name = "soprotivlenye";
            this.soprotivlenye.Size = new System.Drawing.Size(100, 20);
            this.soprotivlenye.TabIndex = 20;
            this.soprotivlenye.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(129, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Значения оси х";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(129, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Значения оси у";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(129, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Масса тела";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(123, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "коэффициент сопротивления воздуха";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(123, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "эмпирический показатель n";
            // 
            // pokazatel
            // 
            this.pokazatel.BackColor = System.Drawing.Color.White;
            this.pokazatel.ForeColor = System.Drawing.Color.Black;
            this.pokazatel.Location = new System.Drawing.Point(17, 429);
            this.pokazatel.Name = "pokazatel";
            this.pokazatel.Size = new System.Drawing.Size(100, 20);
            this.pokazatel.TabIndex = 26;
            this.pokazatel.Text = "1";
            // 
            // New_object
            // 
            this.New_object.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.New_object.Location = new System.Drawing.Point(87, 668);
            this.New_object.Name = "New_object";
            this.New_object.Size = new System.Drawing.Size(87, 38);
            this.New_object.TabIndex = 27;
            this.New_object.Text = "Добавить";
            this.New_object.UseVisualStyleBackColor = true;
            this.New_object.Click += new System.EventHandler(this.New_object_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(179, 583);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "дальность полета";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(179, 552);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "max высота";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(96, 509);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Результаты";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(179, 611);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "время полета";
            // 
            // maxhight
            // 
            this.maxhight.BackColor = System.Drawing.Color.White;
            this.maxhight.ForeColor = System.Drawing.Color.Black;
            this.maxhight.Location = new System.Drawing.Point(17, 552);
            this.maxhight.Name = "maxhight";
            this.maxhight.Size = new System.Drawing.Size(100, 20);
            this.maxhight.TabIndex = 32;
            // 
            // maxline
            // 
            this.maxline.BackColor = System.Drawing.Color.White;
            this.maxline.ForeColor = System.Drawing.Color.Black;
            this.maxline.Location = new System.Drawing.Point(17, 583);
            this.maxline.Name = "maxline";
            this.maxline.Size = new System.Drawing.Size(100, 20);
            this.maxline.TabIndex = 33;
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.White;
            this.Time.ForeColor = System.Drawing.Color.Black;
            this.Time.Location = new System.Drawing.Point(17, 611);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(100, 20);
            this.Time.TabIndex = 34;
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 779);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.maxline);
            this.Controls.Add(this.maxhight);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.New_object);
            this.Controls.Add(this.pokazatel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.soprotivlenye);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.Oy);
            this.Controls.Add(this.Ox);
            this.Controls.Add(this.instraction);
            this.Controls.Add(this.Sopritivleni_on_off);
            this.Controls.Add(this.Perezapusk);
            this.Controls.Add(this.sozdanie_osey);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.time_dt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Speed_0);
            this.Controls.Add(this.ygol_alpha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.axis1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бросок тела под углом к горизонту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myUCLib.Axis axis1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ygol_alpha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Speed_0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox time_dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Hight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button sozdanie_osey;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Perezapusk;
        private System.Windows.Forms.CheckBox Sopritivleni_on_off;
        private System.Windows.Forms.Button instraction;
        private System.Windows.Forms.TextBox Ox;
        private System.Windows.Forms.TextBox Oy;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.TextBox soprotivlenye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pokazatel;
        private System.Windows.Forms.Button New_object;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox maxhight;
        private System.Windows.Forms.TextBox maxline;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Timer timer3;
    }
}

