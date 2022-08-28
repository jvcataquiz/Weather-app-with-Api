namespace WeatherApp
{
    partial class WeatherAppWithApi
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelConditionValue = new System.Windows.Forms.Label();
            this.labelDetailValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSunrise = new System.Windows.Forms.Label();
            this.labelSunset = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelWindspped = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(58, 307);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(236, 20);
            this.textBoxCity.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(317, 304);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelConditionValue
            // 
            this.labelConditionValue.AutoSize = true;
            this.labelConditionValue.Location = new System.Drawing.Point(170, 100);
            this.labelConditionValue.Name = "labelConditionValue";
            this.labelConditionValue.Size = new System.Drawing.Size(78, 13);
            this.labelConditionValue.TabIndex = 3;
            this.labelConditionValue.Text = "ConditionValue";
            // 
            // labelDetailValue
            // 
            this.labelDetailValue.AutoSize = true;
            this.labelDetailValue.Location = new System.Drawing.Point(170, 162);
            this.labelDetailValue.Name = "labelDetailValue";
            this.labelDetailValue.Size = new System.Drawing.Size(66, 13);
            this.labelDetailValue.TabIndex = 4;
            this.labelDetailValue.Text = "DetailsValue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunrise";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sunset";
            // 
            // labelSunrise
            // 
            this.labelSunrise.AutoSize = true;
            this.labelSunrise.Location = new System.Drawing.Point(105, 205);
            this.labelSunrise.Name = "labelSunrise";
            this.labelSunrise.Size = new System.Drawing.Size(39, 13);
            this.labelSunrise.TabIndex = 7;
            this.labelSunrise.Text = "value1";
            // 
            // labelSunset
            // 
            this.labelSunset.AutoSize = true;
            this.labelSunset.Location = new System.Drawing.Point(103, 236);
            this.labelSunset.Name = "labelSunset";
            this.labelSunset.Size = new System.Drawing.Size(40, 13);
            this.labelSunset.TabIndex = 8;
            this.labelSunset.Text = "Value2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Windspeed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pressure";
            // 
            // labelWindspped
            // 
            this.labelWindspped.AutoSize = true;
            this.labelWindspped.Location = new System.Drawing.Point(255, 205);
            this.labelWindspped.Name = "labelWindspped";
            this.labelWindspped.Size = new System.Drawing.Size(40, 13);
            this.labelWindspped.TabIndex = 11;
            this.labelWindspped.Text = "Value3";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(255, 236);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(40, 13);
            this.labelPressure.TabIndex = 12;
            this.labelPressure.Text = "Value4";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(279, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(154, 139);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 13;
            this.pictureBoxIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Condition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Description";
            // 
            // WeatherAppWithApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelWindspped);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSunset);
            this.Controls.Add(this.labelSunrise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDetailValue);
            this.Controls.Add(this.labelConditionValue);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.label1);
            this.Name = "WeatherAppWithApi";
            this.Text = "WeatherApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelConditionValue;
        private System.Windows.Forms.Label labelDetailValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSunrise;
        private System.Windows.Forms.Label labelSunset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWindspped;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

