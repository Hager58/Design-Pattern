namespace WeatherApp
{
    public delegate void myDelegate (WeatherData weatherData);
    public partial class WeatherData : Form
    {
        public decimal Humidity { get; set; }
        public decimal Pressure { get; set; }
        public decimal Temprature { get; set; }

        public event myDelegate myDelegate;
        public WeatherData()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        { 
            Humidity = decimal.Parse(txb_humidity.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}