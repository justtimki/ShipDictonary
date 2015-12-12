using ShipDirectory.ShipModel;
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
using ShipDirectory.Factory;
using System.IO;

namespace UI
{
    public partial class Form1 : Form
    {
        IRepository repository;
        Form shipForm;
        string sortOption;

        private const string SORT_OPTION_NAME = "name";
        private const string SORT_OPTION_DISPLACEMENT = "displacement";
        private const string SORT_OPTION_TYPE = "type";

        public Form1()
        {
            InitializeComponent();
            repository = AbstractFactory.createMemoryRepository();
        }

        private void addShipButtonMemory_Click(object sender, EventArgs e)
        {
            ShowAddShipWindow();
          //  Output.UpdateBox(outputForMemory, infoLabelMem, repository);
        }

        private void showButtonMemory_Click(object sender, EventArgs e)
        {
            Output.UpdateBox(outputForMemory, infoLabelMem, repository);
        }

        private void addShipButtonFile_Click(object sender, EventArgs e)
        {
            ShowAddShipWindow();
            //Output.UpdateBox(outputForFile, infoLabelFile, repository);
        }

        private void showButtonFile_Click(object sender, EventArgs e)
        {
            Output.UpdateBox(outputForFile, infoLabelFile, repository);
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabs.SelectedTab == tabs.TabPages["memoryTabPage"])
            {
                repository = AbstractFactory.createMemoryRepository();
                sortOption = "";
            }
            else if (tabs.SelectedTab == tabs.TabPages["TextfileTabPage2"])
            {
                repository = AbstractFactory.createTextRepository(null);
                sortOption = "";
            }
            else if (tabs.SelectedTab == tabs.TabPages["binaryFileTabPage3"])
            {
                repository = AbstractFactory.createBinaryRepository(null);
                sortOption = "";
            }
        }

        private void ShowAddShipWindow()
        {
            shipForm = new AddShipForm(repository);
            shipForm.Owner = this;
            shipForm.ShowDialog();
        }

        private void ShowDeleteShipWindow()
        {
            shipForm = new DeleteShipForm(repository);
            shipForm.Owner = this;
            shipForm.ShowDialog();
        }

        private void DeleteButtonMemory_Click(object sender, EventArgs e)
        {
            ShowDeleteShipWindow();
        }

        private void DeleteButtonText_Click(object sender, EventArgs e)
        {
            ShowDeleteShipWindow();
        }

        private void sortButtonMemory_Click(object sender, EventArgs e)
        {
            if (repository.Sort(sortOption))
            {
                Output.UpdateBox(outputForMemory, infoLabelMem, repository);
                sortOption = "";
            }
            if (!displacementRadio.Checked && !nameRadio.Checked && !typeRadio.Checked)
            {
                MessageBox.Show("Невозможно отсортировать. Возможно не выбрана опция сортировки." + sortOption, "Ошибка сортировки");
                sortOption = "";
            }
        }

        private void sortButtonFile_Click(object sender, EventArgs e)
        {
            if (repository.Sort(sortOption))
            {
                Output.UpdateBox(outputForFile, infoLabelFile, repository);
                sortOption = "";
            }
            if (!displacementRadioFile.Checked && !nameRadioFile.Checked && !typeRadioFile.Checked)
            {
                MessageBox.Show("Невозможно отсортировать. Возможно не выбрана опция сортировки.", "Ошибка сортировки");
                sortOption = "";
            }
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName).Equals(".csv"))
                {
                    try
                    {
                        repository = AbstractFactory.createTextRepository(openFileDialog1.FileName);
                        tabs.TabPages["TextfileTabPage2"].Text = Path.GetFileName(openFileDialog1.FileName);
                    }
                    catch(IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Output.UpdateBox(outputForFile, infoLabelFile, repository);
                }
                else
                {
                    MessageBox.Show("Используйте только *.csv файлы.", "Ошибка чтения файла");
                }
            }
        }

        private void binaryChoseFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName).Equals(".dat"))
                {
                    try
                    {
                        repository = AbstractFactory.createBinaryRepository(openFileDialog1.FileName);
                        tabs.TabPages["binaryFileTabPage3"].Text = Path.GetFileName(openFileDialog1.FileName);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Output.UpdateBox(outputForBinary, binaryInfoLabel, repository);
                }
                else
                {
                    MessageBox.Show("Используйте только *.dat файлы.", "Ошибка чтения файла");
                }
            }
        }

        private void binarySortButton_Click(object sender, EventArgs e)
        {
            if (repository.Sort(sortOption))
            {
                Output.UpdateBox(outputForBinary, binaryInfoLabel, repository);
                sortOption = "";
            }
            if (!displacementRadioBinary.Checked && !nameRadioBinary.Checked && !typeRadioBinary.Checked)
            {
                MessageBox.Show("Невозможно отсортировать. Возможно не выбрана опция сортировки.", "Ошибка сортировки");
                sortOption = "";
            }
        }

        private void showButtonBinary_Click(object sender, EventArgs e)
        {
            Output.UpdateBox(outputForBinary, binaryInfoLabel, repository);
        }

        private void binaryAddButton_Click(object sender, EventArgs e)
        {
            ShowAddShipWindow();
        }

        private void binaryDeleteButton_Click(object sender, EventArgs e)
        {
            ShowDeleteShipWindow();
        }

        private void displacementRadio_CheckedChanged(object sender, EventArgs e)
        {
            sortOption = SORT_OPTION_DISPLACEMENT;
        }

        private void typeRadio_CheckedChanged(object sender, EventArgs e)
        {
            sortOption = SORT_OPTION_TYPE;
        }

        private void nameRadio_CheckedChanged(object sender, EventArgs e)
        {
            sortOption = SORT_OPTION_NAME;
        }

        private void displacementRadioFile_CheckedChanged(object sender, EventArgs e)
        {
            sortOption = SORT_OPTION_DISPLACEMENT;
        }

        private void typeRadioFile_CheckedChanged(object sender, EventArgs e)
        {
            sortOption = SORT_OPTION_TYPE;
        }

        private void nameRadioFile_CheckedChanged(object sender, EventArgs e)
        {
            sortOption = SORT_OPTION_NAME;
        }

        private void displacementRadioBinary_CheckedChanged(object sender, EventArgs e)
        {
            sortOption = SORT_OPTION_DISPLACEMENT;
        }

        private void typeRadioBinary_CheckedChanged(object sender, EventArgs e)
        {
            sortOption = SORT_OPTION_TYPE;
        }

        private void nameRadioBinary_CheckedChanged(object sender, EventArgs e)
        {
            sortOption = SORT_OPTION_NAME;
        }

        private void buttonFilterMem_Click(object sender, EventArgs e)
        {
            if (textBoxFilterMem.Text.Equals(""))
            {
                MessageBox.Show("Введите критерий!", "Фильтр");
            }
            else
            {
                try
                {
                    //repository.Filter((string)comboBoxMemory.SelectedItem, textBoxFilterMem.Text);
                    Output.UpdateAfterFilter(outputForMemory, infoLabelMem, repository, (string)comboBoxMemory.SelectedItem, textBoxFilterMem.Text);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonFilterFile_Click(object sender, EventArgs e)
        {
            if (textBoxFilterFile.Text.Equals(""))
            {
                MessageBox.Show("Введите критерий!", "Фильтр");
            }
            else
            {
                try
                {
                    //repository.Filter((string)comboBoxFile.SelectedItem, textBoxFilterFile.Text);
                    Output.UpdateAfterFilter(outputForFile, infoLabelFile, repository, (string)comboBoxFile.SelectedItem, textBoxFilterFile.Text);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonFilterBin_Click(object sender, EventArgs e)
        {
            if (textBoxFilterBin.Text.Equals(""))
            {
                MessageBox.Show("Введите критерий!", "Фильтр");
            }
            else
            {
                try
                {
                   // repository.Filter((string)comboBoxBin.SelectedItem, textBoxFilterBin.Text);
                    Output.UpdateAfterFilter(outputForBinary, binaryInfoLabel, repository, (string)comboBoxBin.SelectedItem, textBoxFilterBin.Text);
                }
                catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
