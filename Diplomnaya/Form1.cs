using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using static Diplomnaya.BetterListBox;
using static Diplomnaya.Form1;

namespace Diplomnaya
{
    public partial class Form1 : Form
    {
        BetterListBox list1 = new BetterListBox
        {
            Width = 98,
            Height = 185,
            Location = new Point(364, 248),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
        };
        
        BetterListBox list2 = new BetterListBox
        {
            Width = 80,
            Height = 185,
            Location = new Point(285, 248),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list3 = new BetterListBox
        {
            Width = 53,
            Height = 185,
            Location = new Point(233, 248),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list4 = new BetterListBox
        {
            Width = 57,
            Height = 185,
            Location = new Point(179, 248),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list5 = new BetterListBox
        {
            Width = 180,
            Height = 185,
            Location = new Point(0, 248),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list6 = new BetterListBox
        {
            Width = 85,
            Height = 185,
            Location = new Point(792, 248),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list7 = new BetterListBox
        {
            Width = 53,
            Height = 185,
            Location = new Point(742, 248),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list8 = new BetterListBox
        {
            Width = 66,
            Height = 185,
            Location = new Point(677, 248),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list9 = new BetterListBox
        {
            Width = 219,
            Height = 185,
            Location = new Point(461, 248),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list10 = new BetterListBox
        {
            Width = 177,
            Height = 264,
            Location = new Point(701, 130),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list11 = new BetterListBox
        {
            Width = 163,
            Height = 264,
            Location = new Point(546, 130),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list12 = new BetterListBox
        {
            Width = 474,
            Height = 264,
            Location = new Point(13, 130),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list13 = new BetterListBox
        {
            Width = 65,
            Height = 264,
            Location = new Point(484, 130),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list14 = new BetterListBox
        {
            Width = 166,
            Height = 264,
            Location = new Point(712, 130),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list15 = new BetterListBox
        {
            Width = 150,
            Height = 264,
            Location = new Point(565, 130),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list16 = new BetterListBox
        {
            Width = 94,
            Height = 264,
            Location = new Point(472, 130),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list17 = new BetterListBox
        {
            Width = 73,
            Height = 264,
            Location = new Point(401, 130),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };
        BetterListBox list18 = new BetterListBox
        {
            Width = 395,
            Height = 264,
            Location = new Point(13, 130),
            Enabled = true,
            Font = new Font("Microsoft Sans Serif", 12F),
            HorizontalScrollbar = false,
            ScrollAlwaysVisible = false
        };

        public Form1()
        {
            InitializeComponent();
            // TabPages3 listBoxs details
            tabPage3.Controls.Add(list1);
            tabPage3.Controls.Add(list2);
            tabPage3.Controls.Add(list3);
            tabPage3.Controls.Add(list4);
            tabPage3.Controls.Add(list5);
            // TabPages3 listBoxs works
            tabPage3.Controls.Add(list6);
            tabPage3.Controls.Add(list7);
            tabPage3.Controls.Add(list8);
            tabPage3.Controls.Add(list9);
            // TabPages5 listBoxs works
            tabPage5.Controls.Add(list10);
            tabPage5.Controls.Add(list11);
            tabPage5.Controls.Add(list12);
            tabPage5.Controls.Add(list13);
            // TabPages5 listBoxs details
            tabPage6.Controls.Add(list14);
            tabPage6.Controls.Add(list15);
            tabPage6.Controls.Add(list16);
            tabPage6.Controls.Add(list17);
            tabPage6.Controls.Add(list18);
            // ListBoxs Event Scroll
            list1.Scroll += BetterListBox1_Scroll;
            list2.Scroll += BetterListBox2_Scroll;
            list3.Scroll += BetterListBox3_Scroll;
            list4.Scroll += BetterListBox4_Scroll;
            list5.Scroll += BetterListBox5_Scroll;
            list6.Scroll += BetterListBox6_Scroll;
            list7.Scroll += BetterListBox7_Scroll;
            list8.Scroll += BetterListBox8_Scroll;
            list9.Scroll += BetterListBox9_Scroll;
            list10.Scroll += BetterListBox10_Scroll;
            list11.Scroll += BetterListBox11_Scroll;
            list12.Scroll += BetterListBox12_Scroll;
            list13.Scroll += BetterListBox13_Scroll;
            list14.Scroll += BetterListBox14_Scroll;
            list15.Scroll += BetterListBox15_Scroll;
            list16.Scroll += BetterListBox16_Scroll;
            list17.Scroll += BetterListBox17_Scroll;
            list18.Scroll += BetterListBox18_Scroll;

        }
        private void BetterListBox1_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list5.TopIndex = list4.TopIndex = list3.TopIndex = list2.TopIndex = list1.TopIndex;
        }
        private void BetterListBox2_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list5.TopIndex = list4.TopIndex = list3.TopIndex  = list1.TopIndex = list2.TopIndex;
        }
        private void BetterListBox3_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list5.TopIndex = list4.TopIndex  = list2.TopIndex = list1.TopIndex = list3.TopIndex;
        }
        private void BetterListBox4_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list5.TopIndex  = list3.TopIndex = list2.TopIndex = list1.TopIndex = list4.TopIndex;
        }
        private void BetterListBox5_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list4.TopIndex = list3.TopIndex = list2.TopIndex = list1.TopIndex = list5.TopIndex;
        }
        private void BetterListBox6_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list7.TopIndex = list8.TopIndex = list9.TopIndex = list6.TopIndex;
        }
        private void BetterListBox7_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list8.TopIndex = list9.TopIndex = list6.TopIndex = list7.TopIndex;
        }
        private void BetterListBox8_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list7.TopIndex  = list9.TopIndex = list6.TopIndex = list8.TopIndex;
        }
        private void BetterListBox9_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list7.TopIndex = list8.TopIndex  = list6.TopIndex = list9.TopIndex;
        }
        private void BetterListBox10_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list11.TopIndex = list12.TopIndex = list13.TopIndex = list10.TopIndex;
        }
        private void BetterListBox11_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list10.TopIndex = list12.TopIndex = list13.TopIndex = list11.TopIndex;
        }
        private void BetterListBox12_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list11.TopIndex = list10.TopIndex = list13.TopIndex = list12.TopIndex;
        }
        private void BetterListBox13_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list11.TopIndex = list12.TopIndex = list10.TopIndex = list13.TopIndex;
        }
        private void BetterListBox14_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list18.TopIndex = list17.TopIndex = list16.TopIndex = list15.TopIndex = list14.TopIndex;
        }
        private void BetterListBox15_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list18.TopIndex = list17.TopIndex = list16.TopIndex  = list14.TopIndex = list15.TopIndex;
        }
        private void BetterListBox16_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list18.TopIndex = list17.TopIndex  = list15.TopIndex = list14.TopIndex = list16.TopIndex;
        }
        private void BetterListBox17_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list18.TopIndex  = list16.TopIndex = list15.TopIndex = list14.TopIndex = list17.TopIndex;
        }
        private void BetterListBox18_Scroll(object s, BetterListBoxScrollArgs e)
        {
            list17.TopIndex = list16.TopIndex = list15.TopIndex = list14.TopIndex = list18.TopIndex;
        }
        private void button1_Click(object sender, EventArgs e) // INSERT ZAKAZ 
        {
            using (SampleContext sc = new SampleContext())
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" &&
                    textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" &&
                    textBox11.Text != "" && textBox12.Text != "" && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    try
                    {
                        int miliage = int.Parse(textBox8.Text);
                        int realeseyear = int.Parse(textBox10.Text);
                        ModelZakaz mzazak = new ModelZakaz()
                        {
                            ZakazNumber = textBox1.Text,
                            Client = textBox2.Text,
                            DateStart = dateTimePicker1.Value,
                            DateEnd = dateTimePicker2.Value,
                        };
                        ModelClient mclient = new ModelClient()
                        {
                            ZakazNumber = textBox1.Text,
                            FIO = textBox4.Text,
                            Phone = textBox3.Text
                        };
                        ModelCar mcar = new ModelCar()
                        {
                            ZakazNumber = textBox1.Text,
                            Model = textBox5.Text,
                            Body = textBox7.Text,
                            Miliage = miliage,
                            VIN = textBox9.Text,
                            GOS = textBox6.Text,
                            ReleaseYear = realeseyear,
                            Chassis = textBox11.Text,
                            Engine = textBox12.Text
                        };
                        sc.Zakazs.Add(mzazak);
                        sc.Clients.Add(mclient);
                        sc.Cars.Add(mcar);
                        try
                        {
                            sc.SaveChanges();
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            textBox8.Clear();
                            textBox9.Clear();
                            textBox10.Clear();
                            textBox11.Clear();
                            textBox12.Clear();
                            textBox13.Clear();
                            textBox14.Clear();
                            MessageBox.Show("Заказ успешно добавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Произошла ошибка!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Поля год выпуска и пробег должны состоять строго из целых чисел!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля!!!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)// INSERT WORK 
        {
            list10.Items.Clear();
            list11.Items.Clear();
            list12.Items.Clear();
            list13.Items.Clear();
            DbSelect dBCommands = new DbSelect();
            if (textBox23.Text != "" && textBox24.Text != "" && textBox27.Text != "" && textBox28.Text != "" && textBox26.Text != "")
            {
                try
                {
                    double Amount = double.Parse(textBox24.Text);
                    double Quantity = double.Parse(textBox26.Text);
                    double Summ = double.Parse(textBox23.Text);
                    using (SampleContext sc = new SampleContext())
                    {
                        ModelWork mwork = new ModelWork()
                        {
                            ZakazNumber = textBox27.Text,
                            NameWorks = textBox28.Text,
                            QuantityHours = Quantity,
                            Amount = Amount,
                            Summ = Summ
                        };
                        sc.Works.Add(mwork);
                        try
                        {
                            sc.SaveChanges();
                            textBox24.Clear();
                            textBox23.Clear();
                            textBox26.Clear();
                            textBox28.Clear();
                            MessageBox.Show("Работа добавлена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Произошла ошибка!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Поля сумма, кол-во и цена должны быть строго числовыми", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!!!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            List<ModelWork> mworks = dBCommands.SelectWork(textBox27.Text);
            foreach (var index in mworks)
            {
                list12.Items.Add(index.NameWorks);
                list13.Items.Add(index.QuantityHours);
                list11.Items.Add(index.Amount);
                list10.Items.Add(index.Summ);
            }
        }

        private void button2_Click(object sender, EventArgs e) // INSERT DETAIL 
        {
            list14.Items.Clear();
            list15.Items.Clear();
            list16.Items.Clear();
            list17.Items.Clear();
            list18.Items.Clear();
            DbSelect dBCommands = new DbSelect();
            if (textBox18.Text != "" && textBox19.Text != "" && textBox16.Text != "" && textBox17.Text != "")
            {
                try
                {
                    double Amount = double.Parse(textBox18.Text);
                    double Quantity = double.Parse(textBox16.Text);
                    double Summ = double.Parse(textBox19.Text);
                    using (SampleContext sc = new SampleContext())
                    {
                        ModelDetail mdetail = new ModelDetail()
                        {
                            ZakazNumber = textBox20.Text,
                            NameDetails = textBox15.Text,
                            Amount = Amount,
                            Quantity = Quantity,
                            Unit = textBox17.Text,
                            Summ = Summ
                        };
                        sc.Details.Add(mdetail);
                        try
                        {
                            sc.SaveChanges();
                            textBox16.Clear();
                            textBox17.Clear();
                            textBox18.Clear();
                            textBox19.Clear();
                            MessageBox.Show("Деталь добавлена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Произошла ошибка!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Поля сумма, кол-во и цена должны быть строго числовыми", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!!!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            List<ModelDetail> mdelail = dBCommands.SelectDetail(textBox20.Text);
            foreach (var index in mdelail)
            {
                list18.Items.Add(index.NameDetails);
                list17.Items.Add(index.Quantity);
                list16.Items.Add(index.Unit);
                list15.Items.Add(index.Amount);
                list14.Items.Add(index.Summ);
            }
        }

        private void button4_Click(object sender, EventArgs e) // DELETE ZAKAZ 
        {
            if (textBox30.Text != "")
            {
                using (SampleContext sc = new SampleContext())
                {
                    try
                    {
                        ModelZakaz deletezakaz = sc.Zakazs.Where(x => x.ZakazNumber == textBox30.Text).FirstOrDefault();
                        sc.Zakazs.Remove(deletezakaz);
                        try
                        {
                            ModelClient deleteclient = sc.Clients.Where(x => x.ZakazNumber == textBox30.Text).FirstOrDefault();
                            sc.Clients.Remove(deleteclient);
                        }
                        catch
                        {
                            MessageBox.Show("Клиент не был добавлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        try
                        {
                            ModelCar deletecar = sc.Cars.Where(x => x.ZakazNumber == textBox30.Text).FirstOrDefault();
                            sc.Cars.Remove(deletecar);
                        }
                        catch
                        {
                            MessageBox.Show("Автомобиль не был добавлен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        try
                        {
                            ModelWork deletework = sc.Works.Where(x => x.ZakazNumber == textBox30.Text).FirstOrDefault();
                            sc.Works.Remove(deletework);
                        }
                        catch
                        {
                            MessageBox.Show("Нету работ по данному заказу", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        try
                        {
                            ModelDetail deletedetail = sc.Details.Where(x => x.ZakazNumber == textBox30.Text).FirstOrDefault();
                            sc.Details.Remove(deletedetail);
                        }
                        catch
                        {
                            MessageBox.Show("Нету деталей по данному заказу", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        try
                        {
                            sc.SaveChanges();
                            MessageBox.Show("Заказ удален!!!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Произошла ошибка, попробуйте еще раз", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Такого заказа не существует!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите номер заказа!!!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e) // DELETE WORK 
        {
            if (textBox31.Text != "" && textBox33.Text != "")
            {
                using (SampleContext deletecontext = new SampleContext())
                {
                    try
                    {
                        ModelWork deletework = deletecontext.Works.Where(x => x.ZakazNumber == textBox31.Text && x.NameWorks == textBox33.Text).FirstOrDefault();
                        deletecontext.Works.Remove(deletework);
                        try
                        {
                            deletecontext.SaveChanges();
                            MessageBox.Show("Работа удалена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox33.Clear();
                        }
                        catch
                        {
                            MessageBox.Show("Произошла ошибка!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Номер заказа или название работы указаны неверно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните оба поля!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e) // DELETE DETAIL 
        {
            if (textBox32.Text != "" && textBox34.Text != "")
            {
                using (SampleContext deletecontext = new SampleContext())
                {
                    try
                    {
                        ModelDetail deletedetail = deletecontext.Details.Where(x => x.ZakazNumber == textBox32.Text && x.NameDetails == textBox34.Text).FirstOrDefault();
                        deletecontext.Details.Remove(deletedetail);
                        try
                        {
                            deletecontext.SaveChanges();
                            MessageBox.Show("Деталь удалена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox34.Clear();
                        }
                        catch
                        {
                            MessageBox.Show("Произошла ошибка!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Номер заказа или название детали указанны неверно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Заполните оба поля!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e) // SEARCH ZAKAZ FOR UPDATE 
        {
            if (textBox36.Text != "")
            {
                if (!string.IsNullOrWhiteSpace(textBox36.Text))
                {
                    DbSelect dbSearch = new DbSelect();
                    using (SampleContext sc = new SampleContext())
                    {
                        var ZakazRedaction = dbSearch.SearchZakaz(textBox36.Text);
                        foreach (var index in ZakazRedaction)
                        {
                            textBox48.Text = index.ZakazNumber;
                            textBox49.Text = index.Client;
                            dateTimePicker4.Value = index.DateStart;
                            dateTimePicker3.Value = index.DateEnd;
                        }
                        var ClientRedaction = dbSearch.SearcClient1(textBox36.Text);
                        foreach (var index in ClientRedaction)
                        {
                            textBox46.Text = index.FIO;
                            textBox47.Text = index.Phone;
                        }
                        var CarRedaction = dbSearch.SearchCar(textBox36.Text);
                        foreach (var index in CarRedaction)
                        {
                            textBox45.Text = index.Model;
                            textBox43.Text = index.Body;
                            textBox41.Text = Convert.ToString(index.Miliage);
                            textBox39.Text = index.VIN;
                            textBox44.Text = index.GOS;
                            textBox42.Text = Convert.ToString(index.ReleaseYear);
                            textBox40.Text = index.Chassis;
                            textBox38.Text = index.Engine;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Номер заказа не может содержать пробелы!", "Уведомления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Введите номер заказа!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button9_Click(object sender, EventArgs e) // ZAKAZ UPDATE 
        {
            if (textBox39.Text != "" && textBox40.Text != "" && textBox41.Text != "" && textBox42.Text != ""
                && textBox43.Text != "" && textBox44.Text != "" && textBox45.Text != "" && textBox46.Text != ""
                && textBox47.Text != "" && textBox48.Text != "" && textBox49.Text != "" && textBox38.Text != ""
                && !string.IsNullOrWhiteSpace(textBox48.Text))
            {
                using (SampleContext sc = new SampleContext())
                {
                    try
                    {
                        var zakaz = sc.Zakazs.Where(x => x.ZakazNumber == textBox36.Text).FirstOrDefault();
                        zakaz.ZakazNumber = textBox48.Text;
                        zakaz.Client = textBox49.Text;
                        zakaz.DateStart = dateTimePicker4.Value;
                        zakaz.DateEnd = dateTimePicker3.Value;
                        var client = sc.Clients.Where(x => x.ZakazNumber == textBox36.Text).FirstOrDefault();
                        client.FIO = textBox46.Text;
                        client.Phone = textBox47.Text;
                        var car = sc.Cars.Where(x => x.ZakazNumber == textBox36.Text).FirstOrDefault();
                        car.Body = textBox43.Text;
                        car.Model = textBox45.Text;
                        car.VIN = textBox39.Text;
                        car.GOS = textBox44.Text;
                        car.Chassis = textBox40.Text;
                        car.Engine = textBox38.Text;
                        car.Miliage = int.Parse(textBox41.Text);
                        car.ReleaseYear = int.Parse(textBox42.Text);
                        try
                        {
                            sc.SaveChanges();
                            MessageBox.Show("Данные успешно отредактированны!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox39.Clear();
                            textBox40.Clear();
                            textBox41.Clear();
                            textBox42.Clear();
                            textBox43.Clear();
                            textBox44.Clear();
                            textBox45.Clear();
                            textBox46.Clear();
                            textBox47.Clear();
                            textBox48.Clear();
                            textBox49.Clear();
                        }
                        catch
                        {
                            MessageBox.Show("Произошла ошибка!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Поля год выпуска и пробег должны быть целочисленными!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SelectedCars(object sender, EventArgs e, string search)
        {
            DbSelect DbCommandLoad = new DbSelect();
            List<ModelCar> lmc = DbCommandLoad.SelectCar(search);
            foreach (var index in lmc)
            {
                listBox2.Items.Add(index.Model);
                listBox2.Items.Add(index.Body);
                listBox2.Items.Add(index.GOS);
                listBox2.Items.Add(index.Miliage);
                listBox2.Items.Add(index.ReleaseYear);
                listBox2.Items.Add(index.VIN);
                listBox2.Items.Add(index.Chassis);
                listBox2.Items.Add(index.Engine);
            }
        }

        private void SelectedZazak(object sender, EventArgs e)
        {
            DbSelect DbCommandLoad = new DbSelect();
            List<ModelZakaz> Zakaz = DbCommandLoad.SelectZakaz();
            foreach (var index in Zakaz)
            {
                string daystart = index.DateStart.Day.ToString();
                string dayend = index.DateEnd.Day.ToString();
                if (index.DateEnd == null)  // нету даты конца работ
                {
                    if (daystart.Length == 1) // день старта работ = 1
                    {
                        daystart = "0" + daystart;
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + daystart + ":" + index.DateStart.Month + ":" + index.DateStart.Year
                            + " " + "Даты конца работ нету!");
                    }
                    else // день старта работ != 1
                    {
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + index.DateStart.Day + ":" + index.DateStart.Month + ":" + index.DateStart.Year
                            + " " + "Даты конца работ нету!");
                    }
                }
                else // есть дата конца работ
                {

                    if (daystart.Length == 1 && dayend.Length == 1)
                    {
                        daystart = "0" + daystart;
                        dayend = "0" + dayend;
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + daystart + ":" + index.DateStart.Month + ":" + index.DateStart.Year + " "
                            + dayend + ":" + index.DateEnd.Month + ":" + index.DateEnd.Year);
                    }
                    else if (daystart.Length == 1 && dayend.Length != 1)
                    {
                        daystart = "0" + daystart;
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + daystart + ":" + index.DateStart.Month + ":" + index.DateStart.Year + " "
                            + index.DateEnd.Day + ":" + index.DateEnd.Month + ":" + index.DateEnd.Year);

                    }
                    else if (daystart.Length != 1 && dayend.Length == 1)
                    {
                        dayend = "0" + dayend;
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + index.DateStart.Day + ":" + index.DateStart.Month + ":" + index.DateStart.Year + " "
                            + dayend + ":" + index.DateEnd.Month + ":" + index.DateEnd.Year);
                    }
                    else
                    {
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + index.DateStart.Day + ":" + index.DateStart.Month + ":" + index.DateStart.Year + " "
                            + index.DateEnd.Day + ":" + index.DateEnd.Month + ":" + index.DateEnd.Year);
                    }
                }

            }
        }
        private void SelectedWork(object sender, EventArgs e, string search)
        {
            DbSelect DbCommandLoad = new DbSelect();
            List<ModelWork> lmw = DbCommandLoad.SelectWork(search);
            foreach (var index in lmw)
            {
                list9.Items.Add(index.NameWorks);
                list8.Items.Add(index.QuantityHours);
                list7.Items.Add(index.Amount);
                list6.Items.Add(index.Summ);
            }
        }
        private void SelectedDetail(object sender, EventArgs e, string search)
        {
            DbSelect DbCommandLoad = new DbSelect();
            List<ModelDetail> lmd = DbCommandLoad.SelectDetail(search);
            foreach (var index in lmd)
            {
                list5.Items.Add(index.NameDetails);
                list4.Items.Add(index.Quantity);
                list3.Items.Add(index.Unit);
                list2.Items.Add(index.Amount);
                list1.Items.Add(index.Summ);

            }
        }
        private void SelectedClient(object sender, EventArgs e, string search)
        {
            DbSelect DbCommandLoad = new DbSelect();
            List<ModelClient> lmclient = DbCommandLoad.SelectClient(search);
            foreach (var index in lmclient)
            {
                listBox5.Items.Add(index.FIO);
                listBox5.Items.Add(index.Phone);
            }
        }
        private void ListBoxMainClear(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox5.Items.Clear();
            listBox2.Items.Clear();
            list1.Items.Clear();
            list5.Items.Clear();
            list4.Items.Clear();
            list3.Items.Clear();
            list2.Items.Clear();
            list6.Items.Clear();
            list7.Items.Clear();
            list8.Items.Clear();
            list9.Items.Clear();


        }
        private void SearchClient(object sender, EventArgs e, string search)
        {
            DbSelect dbSearch = new DbSelect();
            List<ModelClient> searchclient = dbSearch.SearcClient(search);
            foreach (var index in searchclient)
            {
                listBox2.Items.Add(index.FIO);
                listBox2.Items.Add(index.Phone);
            }
        }
        private void SearchZakaz(object sender, EventArgs e, string search)
        {
            DbSelect dbSearch = new DbSelect();
            List<ModelZakaz> Zakaz = dbSearch.SearchZakaz(search);
            foreach (var index in Zakaz)
            {
                string daystart = index.DateStart.Day.ToString();
                string dayend = index.DateEnd.Day.ToString();
                if (index.DateEnd == null)  // нету даты конца работ
                {
                    if (daystart.Length == 1) // день старта работ = 1
                    {
                        daystart = "0" + daystart;
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + daystart + ":" + index.DateStart.Month + ":" + index.DateStart.Year
                            + " " + "Даты конца работ нету!");
                    }
                    else // день старта работ != 1
                    {
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + index.DateStart.Day + ":" + index.DateStart.Month + ":" + index.DateStart.Year
                            + " " + "Даты конца работ нету!");
                    }
                }
                else // есть дата конца работ
                {

                    if (daystart.Length == 1 && dayend.Length == 1)
                    {
                        daystart = "0" + daystart;
                        dayend = "0" + dayend;
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + daystart + ":" + index.DateStart.Month + ":" + index.DateStart.Year + " "
                            + dayend + ":" + index.DateEnd.Month + ":" + index.DateEnd.Year);
                    }
                    else if (daystart.Length == 1 && dayend.Length != 1)
                    {
                        daystart = "0" + daystart;
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + daystart + ":" + index.DateStart.Month + ":" + index.DateStart.Year + " "
                            + index.DateEnd.Day + ":" + index.DateEnd.Month + ":" + index.DateEnd.Year);

                    }
                    else if (daystart.Length != 1 && dayend.Length == 1)
                    {
                        dayend = "0" + dayend;
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + index.DateStart.Day + ":" + index.DateStart.Month + ":" + index.DateStart.Year + " "
                            + dayend + ":" + index.DateEnd.Month + ":" + index.DateEnd.Year);
                    }
                    else
                    {
                        listBox1.Items.Add(index.ZakazNumber + " " + index.Client + " "
                            + index.DateStart.Day + ":" + index.DateStart.Month + ":" + index.DateStart.Year + " "
                            + index.DateEnd.Day + ":" + index.DateEnd.Month + ":" + index.DateEnd.Year);
                    }
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) // index ganche clear textboxs
        {
            try
            {
                string search = listBox1.SelectedItem.ToString().Substring(0, listBox1.SelectedItem.ToString().IndexOf(' '));
                listBox2.Items.Clear();
                listBox5.Items.Clear();
                list6.Items.Clear();
                list7.Items.Clear();
                list8.Items.Clear();
                list9.Items.Clear();
                list1.Items.Clear();
                list5.Items.Clear();
                list4.Items.Clear();
                list3.Items.Clear();
                list2.Items.Clear();
                SelectedCars(sender, e, search);
                SelectedDetail(sender, e, search);
                SelectedWork(sender, e, search);
                SelectedClient(sender, e, search);
            }
            catch
            {

            }
        }

        private void button7_Click(object sender, EventArgs e) // SEARCH FOR DB 
        {
            string search = textBox35.Text;
            ListBoxMainClear(sender, e);
            if (comboBox1.Text == "Все заказы")
            {
                if (textBox35.Text == "")
                {
                    SelectedZazak(sender, e);
                }
                else
                {
                    MessageBox.Show("В поле не должно быть текста!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "Номер заказа")
            {
                if (textBox35.Text != "")
                {
                    SearchZakaz(sender, e, search);
                    SelectedCars(sender, e, search);
                    SelectedDetail(sender, e, search);
                    SelectedWork(sender, e, search);
                    SelectedClient(sender, e, search);
                }
                else
                {
                    MessageBox.Show("Введите номер заказа!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "ФИО клиента")
            {
                if (textBox35.Text != "")
                {
                    ListBoxMainClear(sender, e);
                    using (SampleContext sc = new SampleContext())
                    {
                        List<ModelClient> ListClient = sc.Clients.Where(x => x.FIO == search).ToList();
                        foreach (var index in ListClient)
                        {
                            string str = index.ZakazNumber;
                            SearchZakaz(sender, e, str);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите ФИО клиента!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "ГОС номер авто")
            {
                if (textBox35.Text != "")
                {
                    ListBoxMainClear(sender, e);
                    using (SampleContext sc = new SampleContext())
                    {
                        List<ModelCar> ListCar = sc.Cars.Where(x => x.GOS == search).ToList();
                        foreach (var index in ListCar)
                        {
                            string str = index.ZakazNumber;
                            SearchZakaz(sender, e, str);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Ведите ГОС номер авто", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "Номер телефона")
            {
                if (textBox35.Text != "")
                {
                    ListBoxMainClear(sender, e);
                    using (SampleContext sc = new SampleContext())
                    {
                        List<ModelClient> ListClient = sc.Clients.Where(x => x.Phone == search).ToList();
                        foreach (var index in ListClient)
                        {
                            string str = index.ZakazNumber;
                            SearchZakaz(sender, e, str);
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Ведите номер телефона!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "Название работы")
            {
                if (textBox35.Text != "")
                {
                    ListBoxMainClear(sender, e);
                    using (SampleContext sc = new SampleContext())
                    {
                        List<ModelWork> ListWork = sc.Works.Where(x => x.NameWorks == search).ToList();
                        foreach (var index in ListWork)
                        {
                            string str = index.ZakazNumber;
                            SearchZakaz(sender, e, str);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите название работы!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "Название детали")
            {
                if (textBox35.Text != "")
                {
                    ListBoxMainClear(sender, e);
                    using (SampleContext sc = new SampleContext())
                    {
                        List<ModelDetail> ListDetail = sc.Details.Where(x => x.NameDetails == search).ToList();
                        foreach (var index in ListDetail)
                        {
                            string str = index.ZakazNumber;
                            SearchZakaz(sender, e, str);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите название детали!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (comboBox1.Text == "Модель автомобиля")
            {
                if (textBox35.Text != "")
                {
                    ListBoxMainClear(sender, e);
                    using (SampleContext sc = new SampleContext())
                    {
                        List<ModelCar> ListCar = sc.Cars.Where(x => x.Model == search).ToList();
                        foreach (var index in ListCar)
                        {
                            string str = index.ZakazNumber;
                            SearchZakaz(sender, e, str);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите название автомобиля!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) => SelectedZazak(sender, e);
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox5.Items.Clear();
            list6.Items.Clear();
            list7.Items.Clear();
            list8.Items.Clear();
            list9.Items.Clear();
            list1.Items.Clear();
            list5.Items.Clear();
            list4.Items.Clear();
            list3.Items.Clear();
            list2.Items.Clear();
            SelectedZazak(sender, e);
        }

    }
    public class BetterListBox : ListBox
    {
        // Event declaration
        public delegate void BetterListBoxScrollDelegate(object Sender,
        BetterListBoxScrollArgs e);
        public event BetterListBoxScrollDelegate Scroll;
        // WM_VSCROLL message constants
        private const int WM_VSCROLL = 0x0115;
        private const int SB_THUMBTRACK = 5;
        private const int SB_ENDSCROLL = 8;

        protected override void WndProc(ref Message m)
        {
            // Trap the WM_VSCROLL message to generate the Scroll event
            base.WndProc(ref m);
            if (m.Msg == WM_VSCROLL)
            {
                int nfy = m.WParam.ToInt32() & 0xFFFF;
                if (Scroll != null && (nfy == SB_THUMBTRACK || nfy == SB_ENDSCROLL))
                    Scroll(this, new BetterListBoxScrollArgs(this.TopIndex, nfy == SB_THUMBTRACK));
            }
        }
        public class BetterListBoxScrollArgs
        {
            // Scroll event argument
            private int mTop;
            private bool mTracking;
            public BetterListBoxScrollArgs(int top, bool tracking)
            {
                mTop = top;
                mTracking = tracking;
            }
            public int Top
            {
                get { return mTop; }
            }
            public bool Tracking
            {
                get { return mTracking; }
            }
        }
    }
}
