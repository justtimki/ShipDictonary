using ShipDirectory.Repositories;
using ShipDirectory.ShipModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public static class Output
    {
        public static void UpdateBox(TextBox textBox, Label label, IRepository repository)
        {
            textBox.Text = "";
            List<Ship> ships = repository.GetAll();

            if (ships == null || ships.Count <= 0)
            {
                label.Text = "Список кораблей пока пуст. Нажмите Добавить корабль, для начала работы.";
            }
            else
            {
                foreach (var item in ships)
                {
                    textBox.Text += item.ToString() + "\r\n";
                }
                label.Visible = false;
            }
        }

        public static void UpdateAfterFilter(TextBox textBox, Label label, IRepository repository, string field, string option)
        {
            textBox.Text = "";
            List<Ship> ships = repository.Filter(field, option);

            if (ships == null || ships.Count <= 0)
            {
                label.Text = "Список кораблей пока пуст. Нажмите Добавить корабль, для начала работы.";
            }
            else
            {
                foreach (var item in ships)
                {
                    textBox.Text += item.ToString() + "\r\n";
                    
                }
                label.Visible = false;
            }
        }
    }
}
