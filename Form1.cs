using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {
        public List<Book> Books { get; private set; } = new List<Book>();
        public static Form1 Form1Instance { get; private set; }
        public Form1()
        {
            InitializeComponent();
            dataGridView.RowHeadersVisible = false;
            form1instance = this;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            books.Add(new Book(1, "Шерлок Холмс", "А-БА-БА-ГА-ЛА-МА-ГА",750,true));
            books.Add(new Book(2, "Паскудна звістка", "Фабула",222,false));
            bindingSource1.DataSource = books;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        // TODO - можна значно простіше в цьому випадку
        
			if (dataGridView.SelectedCells.Count > 0)
			{
				bindingSource1.RemoveCurrent();
			}
			else
			{
				// MessageBox.Show(
			}
            /*
            try
            {
                int rowIndex = dataGridView.CurrentCell.RowIndex; //find rowIndex
                DataGridViewRow selectedRow = dataGridView.Rows[rowIndex]; //find allRow
                int selectedId = Int32.Parse(selectedRow.Cells[0].Value.ToString()); // find value at selected Id
                books.RemoveAll(r => r.Id == selectedId);
                bindingSource1.ResetBindings(false);
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Таблиця пуста","Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
    }
}
