using ShipDirectory.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DeleteShipForm : Form
    {
        private IRepository repository;
        public DeleteShipForm(IRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private void OkButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (repository.RemoveById(int.Parse(IdTextBox.Text)))
                {
                        MessageBox.Show("Корабль успешно удален!", "Удаление корябля");
                        delErrorLabel.Text = "";
                        this.Close();
                }
                else
                {
                    MessageBox.Show("Корабль " + IdTextBox.Text + " не найден!", "Удаление корябля");
                    delErrorLabel.Text = "";
                    IdTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                IdTextBox.BackColor = Color.Crimson;
                delErrorLabel.Text = "Заполните поле корректо.";
                IdTextBox.Text = "";
            }
               
        }
   
        private void CancelButtonDel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdTextBox_Click(object sender, EventArgs e)
        {
            IdTextBox.BackColor = Color.White;
        }

        private void DeleteShipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)this.Owner).showButtonMemory.PerformClick();
            ((Form1)this.Owner).showButtonFile.PerformClick();
            ((Form1)this.Owner).showButtonBinary.PerformClick(); 
        }   
    }
}
