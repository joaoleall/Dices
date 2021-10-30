using Dados.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
       
        double count_face1;
        double count_face2;
        double count_face3;
        double count_face4;
        double count_face5;
        double count_face6;
        double percentual_face1;
        double percentual_face2;
        double percentual_face3;
        double percentual_face4;
        double percentual_face5;
        double percentual_face6;

        string count_face_1;
        string count_face_2;
        string count_face_3;
        string count_face_4;
        string count_face_5;
        string count_face_6;
        string perc_face1;
        string perc_face2;
        string perc_face3;
        string perc_face4;
        string perc_face5;
        string perc_face6;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Random random = new Random();
            int[] randomPicture = new int[12];

            PictureBox[] pictureBox =
            {
                pictureBox1,pictureBox2,pictureBox3,pictureBox4,
                pictureBox5,pictureBox6,pictureBox7,pictureBox8,
                pictureBox9,pictureBox10,pictureBox11,pictureBox12
            };
           
            for (int i = 0; i<= 11; i++)
            {
                randomPicture[i] = random.Next(1, 7);
                
                switch (randomPicture[i])
                {
                    case 1:
                        for(int j = 0; j < pictureBox.Length; j++)
                        {
                            if(j == i)
                            {
                                pictureBox[j].Image = Resources.Face_1;
                                count_face1++;
                                percentual_face1 = (count_face1 / 12) * 100;
                                break;
                            }
                           
                        }
                        break;
                        
                    case 2:
                        for (int j = 0; j < pictureBox.Length; j++)
                        {
                            if (j == i)
                            {
                                pictureBox[j].Image = Resources.Face_2;
                                count_face2++;
                                percentual_face2 = (count_face2 / 12) * 100;
                                break;
                            }

                        }
                        break;
                    case 3:
                        for (int j = 0; j < pictureBox.Length; j++)
                        {
                            if (j == i)
                            {
                                pictureBox[j].Image = Resources.Face_3;
                                count_face3++;
                                percentual_face3 = (count_face3 / 12) * 100;
                                break;
                            }

                        }
                        break;
                    case 4:
                        for (int j = 0; j < pictureBox.Length; j++)
                        {
                            if (j == i)
                            {
                                pictureBox[j].Image = Resources.Face_4;
                                count_face4++;
                                percentual_face4 = (count_face4 / 12) * 100;
                                break;
                            }
                        }
                        break;
                    case 5:
                        for (int j = 0; j < pictureBox.Length; j++)
                        {
                            if (j == i)
                            {
                                pictureBox[j].Image = Resources.Face_5;
                                count_face5++;
                                percentual_face5 = (count_face5 / 12) * 100;
                                break;
                            }

                        }
                        break;
                    case 6:
                        for (int j = 0; j < pictureBox.Length; j++)
                        {
                            if (j == i)
                            {
                                pictureBox[j].Image = Resources.Face_6;
                                count_face6++;
                                percentual_face6 = (count_face6 / 12) * 100;
                                break;
                            }
                        }
                        break;
                }
                
            }


            perc_face1 = percentual_face1.ToString("F2");
            perc_face2 = percentual_face2.ToString("F2");
            perc_face3 = percentual_face3.ToString("F2");
            perc_face4 = percentual_face4.ToString("F2");
            perc_face5 = percentual_face5.ToString("F2");
            perc_face6 = percentual_face6.ToString("F2");
            count_face_1 = count_face1.ToString();
            count_face_2 = count_face2.ToString();
            count_face_3 = count_face3.ToString();
            count_face_4 = count_face4.ToString();
            count_face_5 = count_face5.ToString();
            count_face_6 = count_face6.ToString();
            
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new string[] { "1", count_face_1, perc_face1 + "%" }));
            listView1.Items.Add(new ListViewItem(new string[] { "2", count_face_2, perc_face2 + "%" }));
            listView1.Items.Add(new ListViewItem(new string[] { "3", count_face_3, perc_face3 + "%" }));
            listView1.Items.Add(new ListViewItem(new string[] { "4", count_face_4, perc_face4 + "%" }));
            listView1.Items.Add(new ListViewItem(new string[] { "5", count_face_5, perc_face5 + "%" }));
            listView1.Items.Add(new ListViewItem(new string[] { "6", count_face_6, perc_face6 + "%" }));

        }

        
    }
}
