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
    public partial class Form2 : Form
    {
        Musteri _gelenmusteri;
        Button _gelenbutton;

        public Form2(Musteri m,Button b)
        {
            
            InitializeComponent();
            this._gelenmusteri = m;
            this._gelenbutton = b;
           
        }
      
        private void Form2_Load(object sender, EventArgs e)
        {
            txbx_tcNo.MaxLength = 11;
            if(_gelenmusteri.KoltukBos == false)
            {
                DialogResult dialogResult = MessageBox.Show("Koltuk dolu sifirlamak istermisin?", "Koltuk dolu!", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    txbx_adSoyad.Clear();
                    txbx_tcNo.Clear();
                    _gelenbutton.BackColor = Color.Blue;
                    _gelenmusteri.KoltukBos = true;
                    Musteri.ToplamMusteri--;
                    if (_gelenmusteri.Cinsiyet == true)
                    {
                        Musteri.BayMusteri--;
                    }
                    else
                    {
                        Musteri.KadinMusteri--;
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_gelenmusteri.KoltukBos == true)
            {
                txbx_adSoyad.Clear();
                txbx_tcNo.Clear();
                _gelenbutton.BackColor = Color.Blue;
            }
          
        }

        private void Btn_onayla_Click(object sender, EventArgs e)
        {
            if (txbx_adSoyad.TextLength <6 || txbx_tcNo.TextLength!=11)
            {
                MessageBox.Show("Ad Soyad 6 haneden kucuk olamaz ve tc 11 hane olmalıdır");
            }
            else
            {
                _gelenmusteri.AdSoyad = Convert.ToString(txbx_adSoyad.Text);
                _gelenmusteri.TcNo = Convert.ToString(txbx_tcNo.Text);
                
                if (_gelenmusteri.KoltukBos == true)
                {

                    Musteri.ToplamMusteri++;
                    if (rdb_bay.Checked)
                    {
                        _gelenmusteri.Cinsiyet = true;
                        Musteri.BayMusteri++;                        
                    }
                    else
                    {
                        _gelenmusteri.Cinsiyet = false;
                        Musteri.KadinMusteri++;       
                    }
                    _gelenmusteri.BironcekiSecim = _gelenmusteri.Cinsiyet;
                    _gelenbutton.BackColor = Color.Red;
                    _gelenmusteri.KoltukBos = false;
                    Close();
                }
                else
                {
                    
                    Close();
                }
            }
        }
        
        private void btn_iptal_Click(object sender, EventArgs e)
        {    
            Close();
        }
    }    
}