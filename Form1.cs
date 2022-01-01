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
using System.Globalization;

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
        string oldTbText;
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                //labCondition.Text = Info.weather[0].main;
                labDetails.Text = ToTitleCase(Info.weather[0].description);
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

        string ToTitleCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var words = s.Split(' ');

            var t = "";
            foreach (var word in words)
            {
                if (word != "and")
                {
                    t += char.ToUpper(word[0]) + word.Substring(1) + ' ';
                }              
            }
            return t.Trim();
        }
        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,alerts&appid={2}", lat, lon, APIKey);
                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);
               
                ForecastUC FUC;
                HourlyForecastUC HFUC;
                if (oldTbText != "" && TBCity.Text != oldTbText)  // If the user enters a different city,
                {                                                 // this 'if' statement clears the old forecasts.
                    CustomFLP.Controls.Clear();
                    HourlyFLP.Controls.Clear();
                }
                for (int i = 0; i < 8; i++)
                {
                    if (TBCity.Text == oldTbText) { break; }

                    HFUC = new HourlyForecastUC();
                    HFUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.hourly[i].weather[0].icon + ".png";
                    HFUC.labDT.Text = convertDateTime(ForecastInfo.hourly[i].dt).ToString("hh:mm tt", CultureInfo.InvariantCulture);
                    HFUC.labWeatherDescription.Text = ToTitleCase(ForecastInfo.hourly[i].weather[0].description);
                    HFUC.labTemp.Text = Convert.ToInt32(kelvinToFahrenheit(ForecastInfo.hourly[i].temp)).ToString() + "°F";


                    FUC = new ForecastUC();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + ForecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labDT.Text = convertDateTime(ForecastInfo.daily[i].dt).DayOfWeek.ToString();
                    FUC.labWeatherDescription.Text = ToTitleCase(ForecastInfo.daily[i].weather[0].description);
                    FUC.labTemp.Text = Convert.ToInt32(kelvinToFahrenheit(ForecastInfo.daily[i].temp.day)).ToString() + "°F";

                    HourlyFLP.Controls.Add(HFUC);
                    CustomFLP.Controls.Add(FUC);
                }
            }
            oldTbText = TBCity.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

