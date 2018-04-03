namespace letsCinema
{
    partial class Salon_One
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
            this.SalonName = new System.Windows.Forms.Label();
            this.reserveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SalonName
            // 
            this.SalonName.AutoSize = true;
            this.SalonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalonName.Location = new System.Drawing.Point(565, 28);
            this.SalonName.Name = "SalonName";
            this.SalonName.Size = new System.Drawing.Size(75, 24);
            this.SalonName.TabIndex = 0;
            this.SalonName.Text = "Salon: ";
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.Aqua;
            this.reserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveButton.Location = new System.Drawing.Point(143, 344);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(90, 31);
            this.reserveButton.TabIndex = 1;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(594, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 175);
            this.textBox1.TabIndex = 2;
            // 
            // Salon_One
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.SalonName);
            this.Name = "Salon_One";
            this.Text = "Salon_One";
            this.Load += new System.EventHandler(this.Salon_One_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SalonName;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}