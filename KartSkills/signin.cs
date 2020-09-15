using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр для окна main и отображаем его
            new main().Show();
            // Скрываем текущее окно (форму)
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр для окна main и отображаем его
            new signin().Show();
            // Скрываем текущее окно (форму)
            Hide();
        }
    }
}
