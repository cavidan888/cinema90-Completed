namespace letsCinema
{
    partial class ReserveSeats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveSeats));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userSurNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.getReserve = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(22, 24);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(45, 15);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Name";
            // 
            // userSurNameLabel
            // 
            this.userSurNameLabel.AutoSize = true;
            this.userSurNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSurNameLabel.Location = new System.Drawing.Point(22, 52);
            this.userSurNameLabel.Name = "userSurNameLabel";
            this.userSurNameLabel.Size = new System.Drawing.Size(67, 15);
            this.userSurNameLabel.TabIndex = 1;
            this.userSurNameLabel.Text = "SurName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 3;
            // 
            // getReserve
            // 
            this.getReserve.BackColor = System.Drawing.Color.Lime;
            this.getReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getReserve.ForeColor = System.Drawing.Color.Black;
            this.getReserve.Location = new System.Drawing.Point(123, 88);
            this.getReserve.Name = "getReserve";
            this.getReserve.Size = new System.Drawing.Size(81, 25);
            this.getReserve.TabIndex = 4;
            this.getReserve.Text = "Get Reserve";
            this.getReserve.UseVisualStyleBackColor = false;
            this.getReserve.Click += new System.EventHandler(this.getReserve_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ReserveSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(318, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.getReserve);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userSurNameLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "ReserveSeats";
            this.Text = "ReserveSeats";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userSurNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button getReserve;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}