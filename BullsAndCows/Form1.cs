using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class Form1 : Form
    {
        public int ConceivedNumber;
        public int Number;
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserNumbers.Items.Clear();
            Result.Items.Clear();
            Random random = new Random();
            ConceivedNumber = random.Next(1000, 10000);
            count = 0;
        }

        private void UserNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            List<int> ConNumber, UserNum;
            int _ConceivedNumber = ConceivedNumber;
            int B = 0, C = 0;
            ConNumber = new List<int>();
            UserNum = new List<int>();
            try
            {
                Number = Int32.Parse(UserEnter.Text);
            }
            catch (Exception)
            {

                throw;
            }

            if (Number == _ConceivedNumber)
            {
                MessageBox.Show("Вы выиграли", "Ошибка!", MessageBoxButtons.YesNoCancel);
                return;
            }

            while (_ConceivedNumber > 0)
            {
                ConNumber.Add(_ConceivedNumber % 10);
                _ConceivedNumber = _ConceivedNumber / 10;
            }

            UserNumbers.Items.Add($"{count}: {Number}");

            while (Number > 0)
            {
                UserNum.Add(Number % 10);
                Number = Number / 10;
            }

            for (int i = 0; i < UserNum.Count; i++)
            {
                if (ConNumber[i] == UserNum[i])
                {
                    B++;
                }
            }

            for (int i = 0; i < UserNum.Count; i++)
            {
                for (int j = 0; j < UserNum.Count; j++)
                {
                    if ((i != j) & (ConNumber[i] == UserNum[j]))
                    {
                        C++;
                    }
                }
            }

            Result.Items.Add($"Были замечены {B}Быки и {C}Коровы");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Ответ {ConceivedNumber}", "Ошибка!", MessageBoxButtons.OK);
            return;
        }
    }
}
