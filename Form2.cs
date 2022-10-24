using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void AddB_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book(Book.maxVal + 1, textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), false);
               Form1.form1instance.bindingSource1.Add(book)
            }
            catch (Exception ex)
            {
                // TODO - якщо некорректне число, то не маємо закривати вікно і дати можливість користувачу виправити
                MessageBox.Show("Число введено невірно","Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.Close();
        }

        //TODO - видаляємо, оскільки відсутня обробка
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
