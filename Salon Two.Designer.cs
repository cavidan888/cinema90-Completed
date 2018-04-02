namespace letsCinema
{
    partial class Salon_Two
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
            this.SalonName2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reserveSeats2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalonName2
            // 
            this.SalonName2.AutoSize = true;
            this.SalonName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalonName2.Location = new System.Drawing.Point(604, 30);
            this.SalonName2.Name = "SalonName2";
            this.SalonName2.Size = new System.Drawing.Size(69, 24);
            this.SalonName2.TabIndex = 0;
            this.SalonName2.Text = "Salon:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(634, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 167);
            this.textBox1.TabIndex = 1;
            // 
            // reserveSeats2
            // 
            this.reserveSeats2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.reserveSeats2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reserveSeats2.Location = new System.Drawing.Point(304, 348);
            this.reserveSeats2.Name = "reserveSeats2";
            this.reserveSeats2.Size = new System.Drawing.Size(95, 36);
            this.reserveSeats2.TabIndex = 2;
            this.reserveSeats2.Text = "Reserve";
            this.reserveSeats2.UseVisualStyleBackColor = false;
            this.reserveSeats2.Click += new System.EventHandler(this.reserveSeats2_Click);
            // 
            // Salon_Two
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reserveSeats2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SalonName2);
            this.Name = "Salon_Two";
            this.Text = "Salon_Two";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SalonName2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reserveSeats2;
    }
}