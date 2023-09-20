namespace Moving_Picture
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonDU = new System.Windows.Forms.Button();
            this.buttonUR = new System.Windows.Forms.Button();
            this.buttonDR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1340, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Down Left";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Moving_Picture.Properties.Resources.Marco_Bezzecchi_72__Photo_courtesy_Mooney_VR46_Racing_Team_2_1687613337;
            this.pictureBox1.Location = new System.Drawing.Point(1058, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(1421, 78);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(75, 23);
            this.buttonU.TabIndex = 3;
            this.buttonU.Text = "Up";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(1340, 107);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(75, 23);
            this.buttonL.TabIndex = 4;
            this.buttonL.Text = "Left";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(1421, 136);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(75, 23);
            this.buttonD.TabIndex = 5;
            this.buttonD.Text = "Down ";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(1502, 107);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(75, 23);
            this.buttonR.TabIndex = 6;
            this.buttonR.Text = "Right";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // buttonDU
            // 
            this.buttonDU.Location = new System.Drawing.Point(1340, 78);
            this.buttonDU.Name = "buttonDU";
            this.buttonDU.Size = new System.Drawing.Size(75, 23);
            this.buttonDU.TabIndex = 7;
            this.buttonDU.Text = "Up Left";
            this.buttonDU.UseVisualStyleBackColor = true;
            this.buttonDU.Click += new System.EventHandler(this.buttonDU_Click);
            // 
            // buttonUR
            // 
            this.buttonUR.Location = new System.Drawing.Point(1502, 78);
            this.buttonUR.Name = "buttonUR";
            this.buttonUR.Size = new System.Drawing.Size(75, 23);
            this.buttonUR.TabIndex = 8;
            this.buttonUR.Text = "Up Right";
            this.buttonUR.UseVisualStyleBackColor = true;
            this.buttonUR.Click += new System.EventHandler(this.buttonUR_Click);
            // 
            // buttonDR
            // 
            this.buttonDR.Location = new System.Drawing.Point(1502, 136);
            this.buttonDR.Name = "buttonDR";
            this.buttonDR.Size = new System.Drawing.Size(75, 23);
            this.buttonDR.TabIndex = 9;
            this.buttonDR.Text = "Down Right";
            this.buttonDR.UseVisualStyleBackColor = true;
            this.buttonDR.Click += new System.EventHandler(this.buttonDR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1614, 785);
            this.Controls.Add(this.buttonDR);
            this.Controls.Add(this.buttonUR);
            this.Controls.Add(this.buttonDU);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonDU;
        private System.Windows.Forms.Button buttonUR;
        private System.Windows.Forms.Button buttonDR;
    }
}

