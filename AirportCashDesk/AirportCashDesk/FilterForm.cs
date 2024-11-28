using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportCashDesk
{
    public partial class FilterForm : Form
    {
        public event EventHandler<FilterEventArgs> FilterApplied; // Подія для передачі фільтру

        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            // Отримуємо значення з форми
            string destination = txtDestination.Text.Trim();
            DateTime selectedDate = dateTimePicker.Value;

            // Перевіряємо, чи введено пункт прибуття
            if (string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Будь ласка, введіть пункт прибуття!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Створюємо об'єкт для передачі фільтраційних даних
            FilterEventArgs args = new FilterEventArgs(destination, selectedDate);

            // Викликаємо подію для фільтрації
            FilterApplied?.Invoke(this, args);

            // Закриваємо форму після застосування фільтру
            this.Close();
        }

        // Кнопка для скасування фільтру
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();  // Просто закриваємо форму
        }
    }

    public class FilterEventArgs : EventArgs
    {
        public string Destination { get; set; }
        public DateTime Date { get; set; }

        public FilterEventArgs(string destination, DateTime date)
        {
            Destination = destination;
            Date = date;
        }
    }
}
