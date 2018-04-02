namespace letsCinema
{
    partial class Salon_Three
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
            this.SalonName3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reserveSeats3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalonName3
            // 
            this.SalonName3.AutoSize = true;
            this.SalonName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalonName3.Location = new System.Drawing.Point(640, 31);
            this.SalonName3.Name = "SalonName3";
            this.SalonName3.Size = new System.Drawing.Size(66, 24);
            this.SalonName3.TabIndex = 0;
            this.SalonName3.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(618, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 177);
            this.textBox1.TabIndex = 1;
            // 
            // reserveSeats3
            // 
            this.reserveSeats3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.reserveSeats3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveSeats3.Location = new System.Drawing.Point(191, 353);
            this.reserveSeats3.Name = "reserveSeats3";
            this.reserveSeats3.Size = new System.Drawing.Size(104, 31);
            this.reserveSeats3.TabIndex = 2;
            this.reserveSeats3.Text = "Reserve";
            this.reserveSeats3.UseVisualStyleBackColor = false;
            this.reserveSeats3.Click += new System.EventHandler(this.reserveSeats3_Click);
            // 
            // Salon_Three
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reserveSeats3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SalonName3);
            this.Name = "Salon_Three";
            this.Text = "Salon_Three";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SalonName3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button reserveSeats3;
    }
}