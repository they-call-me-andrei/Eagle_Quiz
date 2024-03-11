using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Eagle
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        int index = 0, index2 = 0;

        bool ok = false,back = false,front = true;
        List<Panel> list = new List<Panel>();
        List<Label> list2 = new List<Label>();
        int[] corecte1 = { 1, 1, 3, 2, 1 }, corecte2 = { 3, 2, 1, 3, 1 }, corecte3 = { 2, 1, 1, 1, 2 }, corecte4 = { 1, 1, 3, 3, 2 }, corecte5 = {1,1,1,1,1},corecte6 = {1,2,3,3,2 };
        int[] raspunsuri = {-1,-1,-1,-1,-1};
        int test = -1;


        private void main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void afiseaza()
        {
            for (int i = 0; i < list2.Count; i++)
            {
                list2[i].BringToFront();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.BringToFront();
            list2.Add(label3);
            list2.Add(label4);
            list2.Add(label5);
            list2.Add(label6);
            list2.Add(label7);
            
            
            next1.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next2.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare2_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare3_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare5_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            scor1_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            coperta_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare2_1_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare2_2_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare2_3_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare2_4_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare2_5_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare3_1_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare3_2_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare3_3_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare3_4_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            intrebare3_5_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            reguli2_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            reguli3_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next4_1.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next4_2.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next4_3.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next4_4.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next4_5.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next5_1.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next5_2.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next5_3.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next5_4.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next5_5.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next6_1.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next6_2.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next6_3.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next6_4.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            next6_5.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);


            list.Add(coperta);
            list.Add(poveste);
            list.Add(main);
            list.Add(reguli);
            list.Add(reguli2);
            list.Add(reguli3);
            ///////////////////
            list.Add(intrebare1);
            list.Add(intrebare2);
            list.Add(intrebare3);
            list.Add(intrebare4);
            list.Add(intrebare5);
            ////////////////////
            list.Add(intrebare2_1);
            list.Add(intrebare2_2);
            list.Add(intrebare2_3);
            list.Add(intrebare2_4);
            list.Add(intrebare2_5);
            /////////////////////
            list.Add(intrebare3_1);
            list.Add(intrebare3_2);
            list.Add(intrebare3_3);
            list.Add(intrebare3_4);
            list.Add(intrebare3_5);
            ///////////////////////
            list.Add(intrebare4_1);
            list.Add(intrebare4_2);
            list.Add(intrebare4_3);
            list.Add(intrebare4_4);
            list.Add(intrebare4_5);
            ///////////////////////
            list.Add(intrebare5_1);
            list.Add(intrebare5_2);
            list.Add(intrebare5_3);
            list.Add(intrebare5_4);
            list.Add(intrebare5_5);
            ///////////////////////
            list.Add(intrebare6_1);
            list.Add(intrebare6_2);
            list.Add(intrebare6_3);
            list.Add(intrebare6_4);
            list.Add(intrebare6_5);
            ///////////////////////
            list.Add(scor1);

            list.Add(test1_raspunsuri);
            list.Add(test2_raspunsuri);
            list.Add(test3_raspunsuri);
            list.Add(test4_raspunsuri);
            list.Add(test5_raspunsuri);
            list.Add(test6_raspunsuri);

            list[index].BringToFront();
            list2[index2].ForeColor = Color.Lime;
            list2[index].Top += 7;
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }

        }

        private void start_Click(object sender, EventArgs e)
        {
            nr_rasp_corecte = 0;
            for (int i = 0; i < raspunsuri.Length; i++)
            {
                raspunsuri[i] = -1;
            }
            if (test > 0)
            {
                avertisment.Visible = false;
                if (test <= 3)
                {
                    index++;
                }else if(test == 4||test == 6)
                {
                    index += 2;
                }else if(test == 5)
                {
                    index += 3;
                }
                list[index].Visible = true;
                list[index].BringToFront();
                for(int i = 0; i < list.Count; i++)
                {
                    if (i != index)
                    {
                        list[i].Visible = false;
                    }
                }
            }
            else
            {
                avertisment.Visible = true;
            }

        }

        private void goBack1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackColor = Color.Transparent;
        }

        private void goBack1_Click(object sender, EventArgs e)
        {
            index--;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }


        private void next1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackColor = Color.Transparent;
        }

        private void NextPanel()
        {
            index++;
            for (int i = 0; i < list2.Count; i++)
            {
                list2[i].BringToFront();
            }
        }

        private void BackPanel()
        {
            index--;
            list[index].BringToFront();
            
        }
        private void next1_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (box.Name == "poveste_next")
            {
                index++;
                list[index].Visible = true;
                list[index].BringToFront();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != index)
                    {
                        list[i].Visible = false;
                    }
                }
            }
            else
            {
                if(test == 1)
                {
                    index+=3;
                }else if(test == 2)
                {
                    index +=8;
                }else if(test == 3)
                {
                    index += 13;
                }else if(test == 4)
                {
                    index += 17;
                }else if(test == 5)
                {
                    index +=21;
                }else if(test == 6)
                {
                    index += 27;
                }
                list[index].Visible = true;
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != index)
                    {
                        list[i].Visible = false;
                    }
                }
                for (int i = 0; i < list2.Count; i++)
                {
                    list2[i].BringToFront();
                }
            }

        }
        
        

        private void rasp1_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            rasp1_1.BackgroundImage = Properties.Resources._checked;
            rasp1_2.BackgroundImage = null;
            rasp1_3.BackgroundImage = null;

        }

        private void rasp1_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            rasp1_1.BackgroundImage = null;
            rasp1_2.BackgroundImage = Properties.Resources._checked;
            rasp1_3.BackgroundImage = null;
        }

        private void rasp1_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            rasp1_1.BackgroundImage = null;
            rasp1_2.BackgroundImage = null;
            rasp1_3.BackgroundImage = Properties.Resources._checked;
        }
        private void MoveForward()
        {
            if (index2 <= list2.Count - 2)
            {
                index2++;
                list2[index2].ForeColor = Color.Lime;
                list2[index2 - 1].ForeColor = Color.Black;

            }
        }
        private void MoveBack()
        {
            if (index2 >= 0)
            {
                index2--;
                list2[index2].ForeColor = Color.Lime;
                list2[index2 + 1].ForeColor = Color.Black;

            }
        }

        private void next2_Click(object sender, EventArgs e)
        {
            index++;
            list[index].Visible = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
            afiseaza();
            MoveForward();

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void next2_MouseHover(object sender, EventArgs e)
        {
            
        }

        [Obsolete]
        private void start_MouseEnter(object sender, EventArgs e)
        {

        }

        private void goBack1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackColor = Color.Red;
        }

        private void next1_MouseEnter(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackColor = Color.Green;
        }

        private void next2_MouseEnter(object sender, EventArgs e)
        {
            next2.BackgroundImage = Properties.Resources.arr1;
            next2.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void intrebare1_back_Click(object sender, EventArgs e)
        {
            index--;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void intrebare1_back_MouseEnter(object sender, EventArgs e)
        {
           intrebare1_back.BackgroundImage = Properties.Resources.arr1;
        }

        private void intrebare1_back_MouseLeave(object sender, EventArgs e)
        {
            intrebare1_back.BackgroundImage = Properties.Resources.arr2;
        }

        private void intrebare2_back_MouseEnter(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackgroundImage = Properties.Resources.arr1;
        }

        private void intrebare2_back_MouseLeave(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackgroundImage = Properties.Resources.arr2;
        }

        private void intrebare2_back_Click(object sender, EventArgs e)
        {
            index--;
            list[index].Visible = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
            afiseaza();
            if (index2 >=0)
            {
                index2--;
                list2[index2].ForeColor = Color.Lime;
                list2[index2 + 1].ForeColor = Color.Black;
               
            }

        }

        private void intrebare2_next_Click(object sender, EventArgs e)
        {
            index++;
            list[index].Visible = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
            afiseaza();
            MoveForward();
        }

        private void intrebare2_next_MouseEnter(object sender, EventArgs e)
        {
            intrebare2_next.BackgroundImage = Properties.Resources.arr1;
            intrebare2_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void intrebare2_next_MouseLeave(object sender, EventArgs e)
        {
            intrebare2_next.BackgroundImage = Properties.Resources.arr2;
            intrebare2_next.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void bifat1(PictureBox x,PictureBox y, PictureBox z)
        {
            x.BackgroundImage = Properties.Resources._checked;
            y.BackgroundImage = null;
            z.BackgroundImage = null;
        }
        private void bifat2(PictureBox x, PictureBox y, PictureBox z)
        {
            x.BackgroundImage = null;
            y.BackgroundImage = Properties.Resources._checked;
            z.BackgroundImage = null;
        }
        private void bifat3(PictureBox x, PictureBox y, PictureBox z)
        {
            x.BackgroundImage = null;
            y.BackgroundImage = null;
            z.BackgroundImage = Properties.Resources._checked;
        }

        private void rasp2_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp2_1,rasp2_2,rasp2_3);
        }

        private void rasp2_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp2_1, rasp2_2, rasp2_3);
        }

        private void rasp2_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp2_1, rasp2_2, rasp2_3);
        }

        private void intrebare3_next_Click(object sender, EventArgs e)
        {
            index++;
            list[index].Visible = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
            afiseaza();
            MoveForward();
        }

        private void intrebare3_next_MouseEnter(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackgroundImage = Properties.Resources.arr1;
            box.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void intrebare3_next_MouseLeave(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackgroundImage = Properties.Resources.arr2;
            box.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }


        private void rasp3_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp3_1, rasp3_2, rasp3_3);
        }

        private void rasp3_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp3_1, rasp3_2, rasp3_3);
        }

        private void rasp3_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp3_1, rasp3_2, rasp3_3);
        }

        private void rasp4_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp4_1, rasp4_2, rasp4_3);
        }

        private void rasp4_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp4_1, rasp4_2, rasp4_3);
        }

        private void rasp4_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp4_1, rasp4_2, rasp4_3);
        }

        int nr_rasp_corecte = 0;

        private void intrebare5_next_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < corecte1.Length; i++)
            {
                if (corecte1[i] == raspunsuri[i])
                {
                    nr_rasp_corecte += 20;
                }
            }
            text_scor1.Text = nr_rasp_corecte.ToString();
            if (nr_rasp_corecte > 0)
            {
                if(nr_rasp_corecte != 100)
                {
                    text_scor1.Left += 10;
                }
            }
            else
            {
                text_scor1.Left += 20;
            }

            index+=26;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
            

        }

        private void rasp5_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp5_1, rasp5_2, rasp5_3);
        }

        private void rasp5_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp5_1, rasp5_2, rasp5_3);
        }

        private void rasp5_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3
                (rasp5_1, rasp5_2, rasp5_3);
        }

        private void scor1_next_Click(object sender, EventArgs e)
        {
            if (test == 1)
            {
                index++;
                list[index].Visible = true;
                list[index].BringToFront();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != index)
                    {
                        list[i].Visible = false;
                    }
                }
            }
            else if (test == 2)
            {
                index+=2;
                list[index].Visible = true;
                list[index].BringToFront();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != index)
                    {
                        list[i].Visible = false;
                    }
                }
            }else if(test == 3)
            {
                index += 3;
                list[index].Visible = true;
                list[index].BringToFront();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != index)
                    {
                        list[i].Visible = false;
                    }
                }
            }else if(test == 4)
            {
                index += 4;
                list[index].Visible = true;
                list[index].BringToFront();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != index)
                    {
                        list[i].Visible = false;
                    }
                }
            }else if(test == 5)
            {
                index += 5;
                list[index].Visible = true;
                list[index].BringToFront();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != index)
                    {
                        list[i].Visible = false;
                    }
                }
            }else if(test == 6)
            {
                index += 6;
                list[index].Visible = true;
                list[index].BringToFront();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i != index)
                    {
                        list[i].Visible = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test = 1;
            Button but = (Button)sender;
            but.BackgroundImage = Properties.Resources.green_radient_bg;
            button2.BackgroundImage = Properties.Resources.buton;
            button3.BackgroundImage = Properties.Resources.buton;
            button4.BackgroundImage = Properties.Resources.buton;
            button5.BackgroundImage = Properties.Resources.buton;
            button6.BackgroundImage = Properties.Resources.buton;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test = 2;
            Button but = (Button)sender;
            but.BackgroundImage = Properties.Resources.green_radient_bg;
            button1.BackgroundImage = Properties.Resources.buton;
            button3.BackgroundImage = Properties.Resources.buton;
            button4.BackgroundImage = Properties.Resources.buton;
            button5.BackgroundImage = Properties.Resources.buton;
            button6.BackgroundImage = Properties.Resources.buton;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            test = 3;
            Button but = (Button)sender;
            but.BackgroundImage = Properties.Resources.green_radient_bg;
            button1.BackgroundImage = Properties.Resources.buton;
            button2.BackgroundImage = Properties.Resources.buton;
            button4.BackgroundImage = Properties.Resources.buton;
            button5.BackgroundImage = Properties.Resources.buton;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            test = 4;
        }

        private void coperta_next_Click(object sender, EventArgs e)
        {
            index++;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }

            }
        }

        private void label22_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Red;
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
        }

        private void label40_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Red;
        }

        private void label22_Click(object sender, EventArgs e)
        {
            index--;
            list[index].Visible = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }

            }
        }

        private void label40_Click(object sender, EventArgs e)
        {
            game3 g = new game3(nr_rasp_corecte);
            g.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp2_1_1, rasp2_1_2, rasp2_1_3);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp2_1_1, rasp2_1_2, rasp2_1_3);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp2_1_1, rasp2_1_2, rasp2_1_3);
        }

        private void intrebare2_1_back_Click(object sender, EventArgs e)
        {
            index -= 6;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void test2_rasp3_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(test2_rasp3_1, test2_rasp3_2, test2_rasp3_3);
        }

        private void test2_rasp3_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(test2_rasp3_1, test2_rasp3_2, test2_rasp3_3);
        }

        private void test2_rasp3_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(test2_rasp3_1, test2_rasp3_2, test2_rasp3_3);
        }

        private void test2_rasp2_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(test2_rasp2_1, test2_rasp2_2, test2_rasp2_3);
        }

        private void test2_rasp2_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(test2_rasp2_1, test2_rasp2_2, test2_rasp2_3);
        }

        private void test2_rasp2_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(test2_rasp2_1, test2_rasp2_2, test2_rasp2_3);
        }

        private void test2_rasp4_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(test2_rasp4_1, test2_rasp4_2, test2_rasp4_3);
        }

        private void test2_rasp4_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(test2_rasp4_1, test2_rasp4_2, test2_rasp4_3);
        }

        private void test2_rasp4_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(test2_rasp4_1, test2_rasp4_2, test2_rasp4_3);
        }

        private void intrebare2_5_next_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < corecte1.Length; i++)
            {
                if (corecte2[i] == raspunsuri[i])
                {
                    nr_rasp_corecte += 20;
                }
            }
            text_scor1.Text = nr_rasp_corecte.ToString();
            if (nr_rasp_corecte > 0)
            {
                if (nr_rasp_corecte != 100)
                {
                    text_scor1.Left += 10;
                }
            }
            else
            {
                text_scor1.Left += 20;
            }

            index += 21;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void test2_rasp5_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(test2_rasp5_1, test2_rasp5_2, test2_rasp5_2);
        }

        private void label72_Click(object sender, EventArgs e)
        {
            index -= 2;
            list[index].Visible = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }

            }
        }

        private void intrebare3_1_back_Click(object sender, EventArgs e)
        {
            index -= 11;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }

            }
        }

        private void next_MouseEnter(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackgroundImage = Properties.Resources.arr4;
        }

        private void next_MouseLeave(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackgroundImage = Properties.Resources.arr3;
        }

        private void test3_rasp1_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(test3_rasp1_1, test3_rasp1_2, test3_rasp1_3);
        }

        private void test3_rasp1_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(test3_rasp1_1, test3_rasp1_2, test3_rasp1_3);
        }

        private void test3_rasp1_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(test3_rasp1_1, test3_rasp1_2, test3_rasp1_3);
        }

        private void test3_rasp2_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(test3_rasp2_1, test3_rasp2_2, test3_rasp2_3);
        }

        private void test3_rasp2_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(test3_rasp2_1, test3_rasp2_2, test3_rasp2_3);
        }

        private void test3_rasp2_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(test3_rasp2_1, test3_rasp2_2, test3_rasp2_3);
        }

        private void test3_rasp3_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(test3_rasp3_1, test3_rasp3_2, test3_rasp3_3);
        }

        private void test3_rasp3_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(test3_rasp3_1, test3_rasp3_2, test3_rasp3_3);
        }

        private void test3_rasp3_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(test3_rasp3_1, test3_rasp3_2, test3_rasp3_3);
        }

        private void test3_rasp4_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(test3_rasp4_1, test3_rasp4_2, test3_rasp4_3);
        }

        private void test3_rasp4_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(test3_rasp4_1, test3_rasp4_2, test3_rasp4_3);
        }

        private void test3_rasp4_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(test3_rasp4_1, test3_rasp4_2, test3_rasp4_3);
        }

        private void intrebare3_5_next_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < corecte2.Length; i++)
            {
                if (corecte3[i] == raspunsuri[i])
                {
                    nr_rasp_corecte += 20;
                }
            }
            text_scor1.Text = nr_rasp_corecte.ToString();
            if (nr_rasp_corecte > 0)
            {
                if (nr_rasp_corecte != 100)
                {
                    text_scor1.Left += 10;
                }
            }
            else
            {
                text_scor1.Left += 20;
            }

            index += 16;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void test3_rasp5_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(test3_rasp5_1, test3_rasp5_2, test3_rasp5_3);
        }

        private void test3_rasp5_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(test3_rasp5_1, test3_rasp5_2, test3_rasp5_3);
        }

        private void label103_Click(object sender, EventArgs e)
        {
            index -= 3;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        
        private void coperta_next_MouseLeave(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.BackgroundImage = Properties.Resources.arr2_nou;
            box.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            test = 4;
            Button but = (Button)sender;
            but.BackgroundImage = Properties.Resources.green_radient_bg;
            button1.BackgroundImage = Properties.Resources.buton;
            button2.BackgroundImage = Properties.Resources.buton;
            button3.BackgroundImage = Properties.Resources.buton;
            button5.BackgroundImage = Properties.Resources.buton;
            button6.BackgroundImage = Properties.Resources.buton;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            test = 5;
            Button but = (Button)sender;
            but.BackgroundImage = Properties.Resources.green_radient_bg;
            button1.BackgroundImage = Properties.Resources.buton;
            button2.BackgroundImage = Properties.Resources.buton;
            button3.BackgroundImage = Properties.Resources.buton;
            button4.BackgroundImage = Properties.Resources.buton;
            button6.BackgroundImage = Properties.Resources.buton;
        }

        private void reguli2_back_Click(object sender, EventArgs e)
        {
            index-=2;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void reguli3_next_Click(object sender, EventArgs e)
        {

        }

        private void reguli3_back_Click(object sender, EventArgs e)
        {
            index -= 3;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            but.BackgroundImage = Properties.Resources.green_radient_bg;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            but.BackgroundImage = Properties.Resources.buton;
        }

        private void back4_1_Click(object sender, EventArgs e)
        {
            index -= 17;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void rasp4_1_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp4_1_1, rasp4_1_2, rasp4_1_3);
        }

        private void rasp4_1_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp4_1_1, rasp4_1_2, rasp4_1_3);
        }

        private void rasp4_1_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp4_1_1, rasp4_1_2, rasp4_1_3);
        }

        private void rasp4_2_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp4_2_1, rasp4_2_2, rasp4_2_3);
        }

        private void rasp4_2_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp4_2_1, rasp4_2_2, rasp4_2_3);
        }

        private void rasp4_2_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp4_2_1, rasp4_2_2, rasp4_2_3);
        }

        private void rasp4_3_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp4_3_1, rasp4_3_2, rasp4_3_3);
        }

        private void rasp4_3_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp4_3_1, rasp4_3_2, rasp4_3_3);
        }

        private void rasp4_3_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp4_3_1, rasp4_3_2, rasp4_3_3);
        }

        private void rasp4_4_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp4_4_1, rasp4_4_2, rasp4_4_3);
        }

        private void rasp4_4_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp4_4_1, rasp4_4_2, rasp4_4_3);
        }

        private void rasp4_4_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp4_4_1, rasp4_4_2, rasp4_4_3);
        }

        private void rasp4_5_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp4_5_1, rasp4_5_2, rasp4_5_3);
        }

        private void rasp4_5_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp4_5_1, rasp4_5_2, rasp4_5_3);
        }

        private void label145_Click(object sender, EventArgs e)
        {
            index -= 4;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void back5_1_Click(object sender, EventArgs e)
        {
            index -= 21;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void rasp5_1_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp5_1_1, rasp5_1_2, rasp5_1_3);
        }

        private void rasp5_1_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp5_1_1, rasp5_1_2, rasp5_1_3);
        }

        private void rasp5_1_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp5_1_1, rasp5_1_2, rasp5_1_3);
        }

        private void rasp5_2_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp5_2_1, rasp5_2_2, rasp5_2_3);
        }

        private void rasp5_2_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp5_2_1, rasp5_2_2, rasp5_2_3);
        }

        private void rasp5_3_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp5_3_1, rasp5_3_2, rasp5_3_3);
        }

        private void rasp5_3_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp5_3_1, rasp5_3_2, rasp5_3_3);
        }

        private void rasp5_4_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp5_4_1, rasp5_4_2, rasp5_4_3);
        }

        private void rasp5_4_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp5_4_1, rasp5_4_2, rasp5_4_3);
        }

        private void rasp5_4_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp5_4_1, rasp5_4_2, rasp5_4_3);
        }

        private void next5_5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < corecte2.Length; i++)
            {
                if (corecte5[i] == raspunsuri[i])
                {
                    nr_rasp_corecte += 20;
                }
            }
            text_scor1.Text = nr_rasp_corecte.ToString();
            if (nr_rasp_corecte > 0)
            {
                if (nr_rasp_corecte != 100)
                {
                    text_scor1.Left += 10;
                }
            }
            else
            {
                text_scor1.Left += 20;
            }

            index += 6;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void rasp5_5_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp5_5_1, rasp5_5_2, rasp5_5_3);
        }

        private void rasp5_5_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp5_5_1, rasp5_5_2, rasp5_5_3);
        }

        private void label182_Click(object sender, EventArgs e)
        {
            index -= 5;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void back6_1_Click(object sender, EventArgs e)
        {
            index -= 27;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void rasp6_1_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp6_1_1, rasp6_1_2, rasp6_1_3);
        }

        private void rasp6_1_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp6_1_1, rasp6_1_2, rasp6_1_3);
        }

        private void rasp6_1_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp6_1_1, rasp6_1_2, rasp6_1_3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            test = 6;
            Button but = (Button)sender;
            but.BackgroundImage = Properties.Resources.green_radient_bg;
            button1.BackgroundImage = Properties.Resources.buton;
            button2.BackgroundImage = Properties.Resources.buton;
            button3.BackgroundImage = Properties.Resources.buton;
            button4.BackgroundImage = Properties.Resources.buton;
            button5.BackgroundImage = Properties.Resources.buton;
        }

        private void rasp6_2_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp6_2_1, rasp6_2_2, rasp6_2_3);
        }

        private void rasp6_2_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp6_2_1, rasp6_2_2, rasp6_2_3);
        }

        private void rasp6_3_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp6_3_1, rasp6_3_2, rasp6_3_3);
        }

        private void rasp6_3_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp6_3_1, rasp6_3_2, rasp6_3_3);
        }

        private void rasp6_3_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp6_3_1, rasp6_3_2, rasp6_3_3);
        }

        private void rasp6_4_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp6_4_1, rasp6_4_2, rasp6_4_3);
        }

        private void rasp6_4_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp6_4_1, rasp6_4_2, rasp6_4_3);
        }

        private void rasp6_4_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp6_4_1, rasp6_4_2, rasp6_4_3);
        }

        private void rasp6_5_1_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 1;
            bifat1(rasp6_5_1, rasp6_5_2, rasp6_5_3);
        }

        private void rasp6_5_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(rasp6_5_1, rasp6_5_2, rasp6_5_3);
        }

        private void rasp6_5_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp6_5_1, rasp6_5_2, rasp6_5_3);
        }

        private void next6_5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < corecte2.Length; i++)
            {
                if (corecte6[i] == raspunsuri[i])
                {
                    nr_rasp_corecte += 20;
                }
            }
            text_scor1.Text = nr_rasp_corecte.ToString();
            if (nr_rasp_corecte > 0)
            {
                if (nr_rasp_corecte != 100)
                {
                    text_scor1.Left += 10;
                }
            }
            else
            {
                text_scor1.Left += 20;
            }

            index += 1;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void label215_Click(object sender, EventArgs e)
        {
            index -= 6;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void rasp6_2_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp6_2_1, rasp6_2_2, rasp6_2_3);
        }

        private void rasp5_5_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(rasp5_5_1, rasp5_5_2, rasp5_5_3);
        }

        private void next4_5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < corecte2.Length; i++)
            {
                if (corecte4[i] == raspunsuri[i])
                {
                    nr_rasp_corecte += 20;
                }
            }
            text_scor1.Text = nr_rasp_corecte.ToString();
            if (nr_rasp_corecte > 0)
            {
                if (nr_rasp_corecte != 100)
                {
                    text_scor1.Left += 10;
                }
            }
            else
            {
                text_scor1.Left += 20;
            }

            index += 11;
            list[index].Visible = true;
            list[index].BringToFront();
            for (int i = 0; i < list.Count; i++)
            {
                if (i != index)
                {
                    list[i].Visible = false;
                }
            }
        }

        private void test3_rasp5_3_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 3;
            bifat3(test3_rasp5_1, test3_rasp5_2, test3_rasp5_3);
        }

        private void test2_rasp5_2_Click(object sender, EventArgs e)
        {
            raspunsuri[index2] = 2;
            bifat2(test2_rasp5_1, test2_rasp5_2, test2_rasp5_1);
        }

        private void next2_MouseLeave(object sender, EventArgs e)
        {
            next2.BackgroundImage = Properties.Resources.arr2;
            next2.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void start_MouseLeave(object sender, EventArgs e)
        {
            
        }

        [Obsolete]
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (ok)
            {
                if(front == true)
                {
                    start.Left-=1;
                    start.Top -= 1;
                    start.Height += 2;
                    start.Width += 2;
                }else if(back == true)
                {
                    start.Left+=1;
                    start.Top += 1;
                    start.Height -= 2;
                    start.Width -= 2;

                }
                if(start.Left == 333)
                {
                    front = false;
                    back = true;
                }
                if(start.Left == 338)
                {
                    front = true;
                    back = false;
                    ok = false;
                }
            }*/
            
        }
    }
}
