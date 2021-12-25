namespace Weather_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.windSpeed = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.details = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.labTemperature = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(37, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(95, 34);
            this.label.TabIndex = 0;
            this.label.Text = "City: ";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(132, 39);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(361, 42);
            this.TBCity.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(510, 36);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(123, 46);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.White;
            this.labCondition.Location = new System.Drawing.Point(194, 149);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(68, 34);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "N/A";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(194, 215);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(68, 34);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "N/A";
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.ForeColor = System.Drawing.Color.White;
            this.sunrise.Location = new System.Drawing.Point(37, 278);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(136, 34);
            this.sunrise.TabIndex = 5;
            this.sunrise.Text = "Sunrise:";
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.ForeColor = System.Drawing.Color.White;
            this.sunset.Location = new System.Drawing.Point(37, 335);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(126, 34);
            this.sunset.TabIndex = 6;
            this.sunset.Text = "Sunset:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(194, 278);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(68, 34);
            this.labSunrise.TabIndex = 7;
            this.labSunrise.Text = "N/A";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(194, 335);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(68, 34);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(704, 278);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(68, 34);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "N/A";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(704, 215);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(68, 34);
            this.labWindSpeed.TabIndex = 11;
            this.labWindSpeed.Text = "N/A";
            // 
            // pressure
            // 
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressure.ForeColor = System.Drawing.Color.White;
            this.pressure.Location = new System.Drawing.Point(504, 278);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(151, 34);
            this.pressure.TabIndex = 10;
            this.pressure.Text = "Pressure:";
            // 
            // windSpeed
            // 
            this.windSpeed.AutoSize = true;
            this.windSpeed.BackColor = System.Drawing.Color.Transparent;
            this.windSpeed.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeed.ForeColor = System.Drawing.Color.White;
            this.windSpeed.Location = new System.Drawing.Point(504, 215);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(197, 34);
            this.windSpeed.TabIndex = 9;
            this.windSpeed.Text = "Wind Speed:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(681, 21);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(162, 91);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.BackColor = System.Drawing.Color.Transparent;
            this.details.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.ForeColor = System.Drawing.Color.White;
            this.details.Location = new System.Drawing.Point(37, 215);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(128, 34);
            this.details.TabIndex = 15;
            this.details.Text = "Details:";
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Cursor = System.Windows.Forms.Cursors.Default;
            this.condition.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition.ForeColor = System.Drawing.Color.White;
            this.condition.Location = new System.Drawing.Point(37, 149);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(164, 34);
            this.condition.TabIndex = 14;
            this.condition.Text = "Condition:";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.BackColor = System.Drawing.Color.Transparent;
            this.temperature.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.ForeColor = System.Drawing.Color.White;
            this.temperature.Location = new System.Drawing.Point(504, 149);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(217, 34);
            this.temperature.TabIndex = 16;
            this.temperature.Text = "Temperature: ";
            // 
            // labTemperature
            // 
            this.labTemperature.AutoSize = true;
            this.labTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemperature.ForeColor = System.Drawing.Color.White;
            this.labTemperature.Location = new System.Drawing.Point(704, 149);
            this.labTemperature.Name = "labTemperature";
            this.labTemperature.Size = new System.Drawing.Size(68, 34);
            this.labTemperature.TabIndex = 17;
            this.labTemperature.Text = "N/A";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.Color.White;
            this.labHumidity.Location = new System.Drawing.Point(704, 335);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(68, 34);
            this.labHumidity.TabIndex = 19;
            this.labHumidity.Text = "N/A";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.BackColor = System.Drawing.Color.Transparent;
            this.Humidity.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity.ForeColor = System.Drawing.Color.White;
            this.Humidity.Location = new System.Drawing.Point(504, 335);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(157, 34);
            this.Humidity.TabIndex = 18;
            this.Humidity.Text = "Humidity:";
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(43, 541);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(1014, 135);
            this.FLP.TabIndex = 20;
            this.FLP.WrapContents = false;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1097, 818);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.labHumidity);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.labTemperature);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.details);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label windSpeed;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label labTemperature;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.FlowLayoutPanel FLP;
    }
}

