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
    public partial class TicketInfoForm : Form
    {
        private Flight flight;
        private int ticketsCount;
        private string classSelected;
        private bool extraLuggage;
        private string paymentMethod;
        private string buyerName;

        public TicketInfoForm()
        {
            InitializeComponent();
        }

        public TicketInfoForm(Flight flight, string buyerName, int ticketsCount, string classSelected, bool extraLuggage, string paymentMethod)
        {
            InitializeComponent();
            this.flight = flight;
            this.buyerName = buyerName;
            this.ticketsCount = ticketsCount;
            this.classSelected = classSelected;
            this.extraLuggage = extraLuggage;
            this.paymentMethod = paymentMethod;
        }

        private void TicketInfoForm_Load(object sender, EventArgs e)
        {
            lblTicketInfo.Text = $"Ім'я покупця: {buyerName}\n" +
                                 $"Рейс: {flight.FlightNumber}\n" +
                                 $"Маршрут: {flight.Route}\n" +
                                 $"Дата відправлення: {flight.DepartureTime.ToString("yyyy-MM-dd HH:mm")}\n" +
                                 $"Кількість квитків: {ticketsCount}\n" +
                                 $"Клас: {classSelected}\n" +
                                 $"Додатковий багаж: {(extraLuggage ? "Так" : "Ні")}\n" +
                                 $"Спосіб оплати: {paymentMethod}";

            MessageBox.Show("Інформація про квиток збережена!", "Збережено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string ticketDetails = $"Ім'я покупця: {buyerName}\n" +
                               $"Рейс: {flight.FlightNumber}\n" +
                               $"Маршрут: {flight.Route}\n" +
                               $"Дата відправлення: {flight.DepartureTime.ToString("yyyy-MM-dd HH:mm")}\n" +
                               $"Кількість квитків: {ticketsCount}\n" +
                               $"Клас: {classSelected}\n" +
                               $"Додатковий багаж: {(extraLuggage ? "Так" : "Ні")}\n" +
                               $"Спосіб оплати: {paymentMethod}";

            try
            {
                string filePath = @"C:\Users\Drrif\Desktop\Курсова робота\AirportCashDesk\AirportCashDesk\bin\Debug\net8.0-windows";
                System.IO.File.WriteAllText(filePath, ticketDetails);
                MessageBox.Show("Квиток збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні квитка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
