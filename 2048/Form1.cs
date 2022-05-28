using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label[,] labels = new Label[4,4];
        Random random = new Random();
        int[,] matris = new int[4, 4];
        int i, j, k, hafiza;
        int[] hafiza2 = new int[2];
        int event_iptal = 0;
        int kontrol;
        Font binfont = new Font("Constantia",16);
        Font yuzfont = new Font("Constantia", 32);
        Font onfont = new Font("Constantia", 48);
        Font birfont = new Font("Constantia", 72);
        private void font_size_degis(int i, int j)
        {
            if(matris[i,j] / 1000 >= 1)
            {
                labels[i, j].Font = binfont;
            }
            else if (matris[i,j] / 100 >= 1)
            {
                labels[i,j].Font = yuzfont;
            }
            else if (matris[i,j] / 10 >= 1)
            {
                labels[i,j].Font = onfont;
            }
            else
            {
                labels[i, j].Font = birfont;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (kontrol == 1)
            {
                //capture up arrow key
                if (keyData == Keys.Up)
                {
                    //**************************************************************************************************
                    for (j = 0; j < 4; j++)
                    {
                        for (i = 0; i < 4; i++)
                        {
                            if (matris[i, j] != 0)
                            {
                                for (k = i + 1; k < 4; k++)
                                {
                                    if (matris[i, j] != matris[k, j])
                                    {
                                        if (matris[k, j] != 0)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    else if (matris[i, j] == matris[k, j])
                                    {
                                        event_iptal = 1;
                                        matris[i, j] *= 2;
                                        font_size_degis(i, j);
                                        matris[k, j] = 0;
                                        font_size_degis(k,j);
                                        labels[i, j].Text = matris[i, j].ToString();
                                        labels[k, j].Text = "";
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (j = 0; j < 4; j++)
                    {
                        for (i = 0; i < 4; i++)
                        {
                            if (matris[i, j] != 0)
                            {
                                for (k = 0; k < i; k++)
                                {
                                    if (matris[k, j] == 0)
                                    {
                                        event_iptal = 1;
                                        matris[k, j] = matris[i, j];
                                        font_size_degis(k, j);
                                        matris[i, j] = 0;
                                        font_size_degis(i, j);
                                        labels[k, j].Text = matris[k, j].ToString();
                                        labels[i, j].Text = "";
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if (event_iptal == 1)
                    {
                        event_iptal = 0;
                        while (true)
                        {
                            hafiza = random.Next(0, 16);
                            if (matris[hafiza / 4, hafiza % 4] == 0)
                            {
                                if (random.Next(0, 8) == 0)
                                {
                                    matris[hafiza / 4, hafiza % 4] = 2 * 2;
                                    labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();
                                }
                                else
                                {
                                    matris[hafiza / 4, hafiza % 4] = 2;
                                    labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();
                                }
                                break;
                            }
                        }
                    }
                    
                    return true;
                }
                //capture down arrow key
                if (keyData == Keys.Down)
                {
                    //**************************************************************************************************
                    for (j = 0; j < 4; j++)
                    {
                        for (i = 3; i >= 0; i--)
                        {
                            if (matris[i, j] != 0)
                            {
                                for (k = i - 1; k >= 0; k--)
                                {
                                    if (matris[i, j] != matris[k, j])
                                    {
                                        if (matris[k, j] != 0)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    else if (matris[i, j] == matris[k, j])
                                    {
                                        event_iptal = 1;
                                        matris[i, j] *= 2;
                                        font_size_degis(i, j);
                                        matris[k, j] = 0;
                                        font_size_degis(k, j);
                                        labels[i, j].Text = matris[i, j].ToString();
                                        labels[k, j].Text = "";
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (j = 0; j < 4; j++)
                    {
                        for (i = 3; i >= 0; i--)
                        {
                            if (matris[i, j] != 0)
                            {
                                for (k = 3; k > i - 1; k--)
                                {
                                    if (matris[k, j] == 0)
                                    {
                                        event_iptal = 1;
                                        matris[k, j] = matris[i, j];
                                        font_size_degis(k, j);
                                        matris[i, j] = 0;
                                        font_size_degis(i, j);
                                        labels[k, j].Text = matris[k, j].ToString();
                                        labels[i, j].Text = "";
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if (event_iptal == 1)
                    {
                        event_iptal = 0;
                        while (true)
                        {
                            hafiza = random.Next(0, 16);
                            if (matris[hafiza / 4, hafiza % 4] == 0)
                            {
                                if (random.Next(0, 8) == 0)
                                {
                                    matris[hafiza / 4, hafiza % 4] = 2 * 2;
                                    labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();
                                }
                                else
                                {
                                    matris[hafiza / 4, hafiza % 4] = 2;
                                    labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();
                                }
                                break;
                            }
                        }
                    }
                    return true;
                }
                //capture left arrow key
                if (keyData == Keys.Left)
                {
                    //**************************************************************************************************

                    for (i = 0; i < 4; i++)
                    {
                        for (j = 0; j < 4; j++)
                        {
                            if (matris[i, j] != 0)
                            {
                                for (k = j + 1; k < 4; k++)
                                {
                                    if (matris[i, j] != matris[i, k])
                                    {
                                        if (matris[i, k] != 0)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    else if (matris[i, j] == matris[i, k])
                                    {
                                        event_iptal = 1;
                                        matris[i, j] *= 2;
                                        font_size_degis(i, j);
                                        matris[i, k] = 0;
                                        font_size_degis(i, k);
                                        labels[i, j].Text = matris[i, j].ToString();
                                        labels[i, k].Text = "";
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (i = 0; i < 4; i++)
                    {
                        for (j = 0; j < 4; j++)
                        {
                            if (matris[i, j] != 0)
                            {
                                for (k = 0; k < j; k++)
                                {
                                    if (matris[i, k] == 0)
                                    {
                                        event_iptal = 1;
                                        matris[i, k] = matris[i, j];
                                        font_size_degis(i, k);
                                        matris[i, j] = 0;
                                        font_size_degis(i, j);
                                        labels[i, k].Text = matris[i, k].ToString();
                                        labels[i, j].Text = "";
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if (event_iptal == 1)
                    {
                        event_iptal = 0;
                        while (true)
                        {
                            hafiza = random.Next(0, 16);
                            if (matris[hafiza / 4, hafiza % 4] == 0)
                            {
                                if (random.Next(0, 8) == 0)
                                {
                                    matris[hafiza / 4, hafiza % 4] = 2 * 2;
                                    labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();
                                }
                                else
                                {
                                    matris[hafiza / 4, hafiza % 4] = 2;
                                    labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();
                                }
                                break;
                            }
                        }
                    }

                    return true;
                }



                //capture right arrow key
                if (keyData == Keys.Right)
                {
                    //**************************************************************************************************
                    for (i = 0; i < 4; i++)
                    {
                        for (j = 3; j >= 0; j--)
                        {
                            if (matris[i, j] != 0)
                            {
                                for (k = j - 1; k >= 0; k--)
                                {
                                    if (matris[i, j] != matris[i, k])
                                    {
                                        if (matris[i, k] != 0)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    else if (matris[i, j] == matris[i, k])
                                    {
                                        event_iptal = 1;
                                        matris[i, j] *= 2;
                                        font_size_degis(i, j);
                                        matris[i, k] = 0;
                                        font_size_degis(i, k);
                                        labels[i, j].Text = matris[i, j].ToString();
                                        labels[i, k].Text = "";

                                        break;
                                    }
                                }
                            }
                        }
                    }

                    for (i = 0; i < 4; i++)
                    {
                        for (j = 3; j >= 0; j--)
                        {
                            if (matris[i, j] != 0)
                            {
                                for (k = 3; k > j - 1; k--)
                                {
                                    if (matris[i, k] == 0)
                                    {
                                        event_iptal = 1;
                                        matris[i, k] = matris[i, j];
                                        font_size_degis(i, k);
                                        matris[i, j] = 0;
                                        font_size_degis(i, j);
                                        labels[i, j].Text = "";
                                        labels[i, k].Text = matris[i, k].ToString();

                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (event_iptal == 1)
                    {
                        event_iptal = 0;
                        while (true)
                        {
                            hafiza = random.Next(0, 16);
                            if (matris[hafiza / 4, hafiza % 4] == 0)
                            {
                                if (random.Next(0, 8) == 0)
                                {
                                    matris[hafiza / 4, hafiza % 4] = 2 * 2;
                                    labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();
                                }
                                else
                                {
                                    matris[hafiza / 4, hafiza % 4] = 2;
                                    labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();
                                }
                                break;
                            }
                        }
                    }
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void basla_Click(object sender, EventArgs e)
        {
            labels[0, 0] = kare_label1;
            labels[0, 1] = kare_label2;
            labels[0, 2] = kare_label3;
            labels[0, 3] = kare_label4;
            labels[1, 0] = kare_label5;
            labels[1, 1] = kare_label6;
            labels[1, 2] = kare_label7;
            labels[1, 3] = kare_label8;
            labels[2, 0] = kare_label9;
            labels[2, 1] = kare_label10;
            labels[2, 2] = kare_label11;
            labels[2, 3] = kare_label12;
            labels[3, 0] = kare_label13;
            labels[3, 1] = kare_label14;
            labels[3, 2] = kare_label15;
            labels[3, 3] = kare_label16;

            for ( i = 0; i < 4; i++)
            {
                for ( j = 0; j < 4; j++)
                {
                    labels[i, j].Text = "";
                }
            }


            for (i = 0; i < 2; i++)
            {
                while (true)
                {
                    hafiza = random.Next(0, 16);
                    if (matris[hafiza / 4, hafiza % 4] == 0)
                    {
                        if (random.Next(0, 8) == 0)
                        {
                            matris[hafiza / 4, hafiza % 4] = 2 * 2;
                            labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();  
                        }
                        else
                        {
                            matris[hafiza / 4, hafiza % 4] = 2;
                            labels[hafiza / 4, hafiza % 4].Text = matris[hafiza / 4, hafiza % 4].ToString();
                        }
                        break;
                    }
                }
            }


            kontrol = 1;
            ana_panel.Visible = false;
        }
    }
}
