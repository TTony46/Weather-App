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

namespace Weather_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            getWeather();
            getForecast();
        }

        string APIKey = "USER_API_FROM_OPENWEATHERMAP";

        double lon;
        double lat;
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                labTemperature.Text = Convert.ToInt32(kelvinToFahrenheit(Info.main.temp)).ToString() + "°F";
                labWindSpeed.Text = Convert.ToInt32(mpsToMph(Info.wind.speed)).ToString() + " mph";
                labPressure.Text = Info.main.pressure.ToString() + " hPa";
                labHumidity.Text = Info.main.humidity.ToString() + "%";

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }
        }

        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            return day.AddSeconds(sec).ToLocalTime();
        }

        double kelvinToFahrenheit(double kelvinValue)
        {
            return ((kelvinValue - 273.15) * 9 / 5) + 32;
        }

        double mpsToMph (double metersPerSecond)
        {
            return (metersPerSecond * 2.23695);
        }
        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,alerts,hourly&appid={2}", lat, lon, APIKey);
                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                ForecastUC FUC; 
                for (int i = 0; i < 8; i++)
                {
                    FUC = new ForecastUC();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labDT.Text = convertDateTime(ForecastInfo.daily[i].dt).DayOfWeek.ToString();
                    FUC.labMainWeather.Text = ForecastInfo.daily[i].weather[0].main;
                    FUC.labWeatherDescription.Text = ForecastInfo.daily[i].weather[0].description;

                    FLP.Controls.Add(FUC);
                }
            }
        }
    }
}
