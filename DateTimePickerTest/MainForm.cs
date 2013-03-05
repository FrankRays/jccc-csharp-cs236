using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateTimePickerTest
{
    public partial class MainForm : Form
    {
        public enum DeliveryType
        {
            Economy = 0,
            Standard = 1,
            TwoDay = 2,
            Overnight = 3,
        };

        DateTime date = DateTime.Today;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            deliveryMethodComboBox.SelectedIndex = (int)DeliveryType.Standard; // auto select Standard.

            dropOffDateTimePicker.MinDate = DateTime.Today;
            dropOffDateTimePicker.MaxDate = DateTime.Today.AddYears(1);

            CalculateDeliveryDate();
        }

        private void dropOffDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CalculateDeliveryDate();
        }

        private void deliveryMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDeliveryDate();
        }

        void CalculateDeliveryDate()
        {
            date = dropOffDateTimePicker.Value;
            
            if (deliveryMethodComboBox.SelectedIndex == (int)DeliveryType.Economy)
                date = date.AddDays(8);
            else if (deliveryMethodComboBox.SelectedIndex == (int)DeliveryType.Standard)
                date = date.AddDays(4);
            else if (deliveryMethodComboBox.SelectedIndex == (int)DeliveryType.TwoDay)
                date = date.AddDays(2);
            else
                date = date.AddDays(1);

            if (date.DayOfWeek == DayOfWeek.Sunday)
                date = date.AddDays(1);

            infoTextBox.Text = "Estimated Delivery Date: " + date.ToLongDateString();
        }
    }
}
