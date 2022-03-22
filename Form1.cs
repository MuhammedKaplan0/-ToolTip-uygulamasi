using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Label = System.Reflection.Emit.Label;

namespace ToolTip_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     ToolTip tt = new ToolTip();
  
  tt.SetToolTip(label1, "Adınızı giriniz.");
  tt.SetToolTip(label2, "Soyadınızı giriniz.");
  tt.SetToolTip(label3, "Doğum tarihinizi gg/aa/yyyy şeklinde giriniz.");
  tt.SetToolTip(label4, "Adresinizi giriniz.");
  tt.SetToolTip(button1, "Kaydetmek için tıklayınız.");
        }
    }
}
