using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class WeatherAppWithApi : Form
    {

        string APIkey = "6b23c082a2ca2bcdc9fff6eed8a38279";
        
        public WeatherAppWithApi()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            getWeatherInfo();
        }

        void getWeatherInfo()
        {

            try
            {
                using (WebClient web = new WebClient())
                {
                    string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBoxCity.Text, APIkey);
                    var json = web.DownloadString(url);
                    WeatherApi.AllClass Info = JsonConvert.DeserializeObject<WeatherApi.AllClass>(json);

                    pictureBoxIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                    labelConditionValue.Text = Info.weather[0].main;
                    labelDetailValue.Text = Info.weather[0].description;
                    labelSunrise.Text = convertTime(Info.sys.sunrise).ToShortTimeString();
                    labelSunset.Text = convertTime(Info.sys.sunset).ToShortTimeString();
                    labelPressure.Text = Info.main.pressure.ToString();
                    labelWindspped.Text = Info.wind.speed.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No City Found!!!!");
            }

           
        }

        DateTime convertTime(double suntime)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(suntime).ToLocalTime();
            return day;
        }
    }
}
