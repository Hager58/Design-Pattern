using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class CurrentCondition : Form
    {
        public decimal _humidity { get; set; }
        public decimal _pressure { get; set; }
        public decimal _temprature { get; set; }
        public CurrentCondition()
        {
            InitializeComponent();
        }
        public void SetTempAndHumidity(WeatherData weatherData)
        {
            _humidity = weatherData.Humidity;
            _pressure = weatherData.Pressure;
            _temprature = weatherData.Temprature;

           // Temperature.Text = e.Temperature.ToString();
           // Humidity.Text = e.Humidity.ToString();
        }
        private void Register()
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
