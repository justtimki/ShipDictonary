using ShipDirectory.Repositories;
using ShipDirectory.ShipModel;
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
    public partial class AddShipForm : Form
    {
        public AddShipForm(IRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
        }

        private IRepository repository;
        public Ship NewShip { get; private set; }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text == "")
                {
                    nameTextBox.BackColor = Color.Crimson;
                    addErrorLabel.Text = "Поля не должны быть пустыми!";
                }
                else if (typeTextBox.Text == "")
                {
                    typeTextBox.BackColor = Color.Crimson;
                    addErrorLabel.Text = "Поля не должны быть пустыми!";
                }
                else if (displacementTextBox.Text == "")
                {
                    displacementTextBox.BackColor = Color.Crimson;
                    addErrorLabel.Text = "Поля не должны быть пустыми!";
                }
                else if (countryTextBox.Text == "")
                {
                    countryTextBox.BackColor = Color.Crimson;
                    addErrorLabel.Text = "Поля не должны быть пустыми!";
                }
                else
                {
                    NewShip = new Ship(nameTextBox.Text, typeTextBox.Text, double.Parse(displacementTextBox.Text), countryTextBox.Text);
                    try
                    {
                        if (repository.Add(NewShip))
                        {
                            MessageBox.Show("Корабль успешно добавлен!", "Добалвение корабля");
                            addErrorLabel.Text = "";
                            this.Close();
                        }
                    } 
                    catch(NullReferenceException ex)
                    {
                        MessageBox.Show(ex.Message);
                        this.Close();
                    }
                }
            }
            catch (FormatException)
            {
                addErrorLabel.Text = "Водоизмещение должно быть цифрой.";
                displacementTextBox.BackColor = Color.Crimson;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            nameTextBox.BackColor = Color.White;
        }

        private void typeTextBox_Click(object sender, EventArgs e)
        {
            typeTextBox.BackColor = Color.White;
        }

        private void displacementTextBox_Click(object sender, EventArgs e)
        {
            displacementTextBox.BackColor = Color.White;
        }

        private void countryTextBox_Click(object sender, EventArgs e)
        {
            countryTextBox.BackColor = Color.White;
        }

        private void AddShipForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)this.Owner).showButtonMemory.PerformClick();
            ((Form1)this.Owner).showButtonFile.PerformClick();
            ((Form1)this.Owner).showButtonBinary.PerformClick(); 
        }
    }
}
