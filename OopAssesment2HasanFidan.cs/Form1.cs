using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopAssesment2HasanFidan.cs
{
    public partial class Form1 : Form
    {
        
        int column = 6;
        int row = 8;
        int counter = 0;
        int rowSayac = 1;

        public Form1()
        {
            InitializeComponent();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<Form2> form2listesi = new List<Form2>();
            List<Musteri> musterilistesi = new List<Musteri>();
            labelOlustur();
            for (int i = 1; i <= column; i++)
            {
                butonOlustur(counter, 40, 40 * i, row);
                counter++;
                for(int j = 1;j< row; j++)
                {
                    butonOlustur(counter, 40 * (j + 1), 40 * i, row);
                    counter++;
                }
                if(row == 8)
                {
                    row = 12;
                }
                else if(row == 12)
                {
                    row = 8;
                }
                
                if(rowSayac == 6)
                {
                    break;
                }
                rowSayac++;
            }
            Button butonOlustur(int nmbr, int xCoordinates, int yCoordinates, int satir)
            {
                Button b = new Button
                {
                    Text = nmbr.ToString(),
                    TextAlign = ContentAlignment.TopLeft,
                    Name = "btn_" + nmbr.ToString(),
                    Size = new Size(45, 45),
                    BackColor = Color.Blue,
                    Image = Image.FromFile("C:/Users/MSI/source/repos/OopAssesment2HasanFidan.cs/OopAssesment2HasanFidan.cs/chair.ico"),
                    BackgroundImageLayout = ImageLayout.Stretch
                };

                if (satir == 8)
                {
                    b.Location = new Point(xCoordinates+80, yCoordinates);
                }
                else
                {
                    b.Location = new Point(xCoordinates, yCoordinates);
                }

                Musteri m = new Musteri
                {
                    AdSoyad = null,
                    TcNo = null,
                    KoltukBos = true,
                    Cinsiyet = true
                };
                Form2 f2 = new Form2(m,b);
                
                b.Click += delegate (object sender2, EventArgs e2)
                {
                    Button_Click(sender2, e2, f2);              
                };
                Controls.Add(b);               
                return b;
            }
            Label labelOlustur(){
                Label l = new Label();
                l.Name = "lbl_sahne";
                l.Size = new Size(320, 5);
                l.Location = new Point(120,20);
                l.ForeColor = Color.Black;
                l.BackColor = Color.Black;
                Controls.Add(l);
                return l;
            }
        }
       
        void Button_Click(object sender2,EventArgs e2,Form2 fonk)
        {
                 fonk.ShowDialog();       
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erkek Musteri sayisi : "+ Musteri.BayMusteri + "Kadin Musteri Sayisi : "+Musteri.KadinMusteri);
        }

       
    }
}