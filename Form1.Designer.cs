
namespace CST117Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_enterWeight = new System.Windows.Forms.TextBox();
            this.lb_planets = new System.Windows.Forms.ListBox();
            this.tb_finalWeight = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pb_planet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_planet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your weight on Earth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your weight on:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_enterWeight
            // 
            this.tb_enterWeight.Location = new System.Drawing.Point(179, 57);
            this.tb_enterWeight.Name = "tb_enterWeight";
            this.tb_enterWeight.Size = new System.Drawing.Size(233, 20);
            this.tb_enterWeight.TabIndex = 2;
            // 
            // lb_planets
            // 
            this.lb_planets.FormattingEnabled = true;
            this.lb_planets.Location = new System.Drawing.Point(128, 97);
            this.lb_planets.Name = "lb_planets";
            this.lb_planets.Size = new System.Drawing.Size(80, 43);
            this.lb_planets.TabIndex = 3;
            this.lb_planets.SelectedIndexChanged += new System.EventHandler(this.lb_planets_SelectedIndexChanged);
            // 
            // tb_finalWeight
            // 
            this.tb_finalWeight.Location = new System.Drawing.Point(223, 95);
            this.tb_finalWeight.Name = "tb_finalWeight";
            this.tb_finalWeight.Size = new System.Drawing.Size(82, 20);
            this.tb_finalWeight.TabIndex = 4;
            this.tb_finalWeight.TextChanged += new System.EventHandler(this.tb_finalWeight_TextChanged);
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(41, 145);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pounds (lbs)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pounds (lbs)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(483, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "How much do I weigh? On another planet!";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pb_planet
            // 
            this.pb_planet.Image = global::CST117Project.Properties.Resources.universe;
            this.pb_planet.Location = new System.Drawing.Point(190, 168);
            this.pb_planet.Name = "pb_planet";
            this.pb_planet.Size = new System.Drawing.Size(305, 257);
            this.pb_planet.TabIndex = 9;
            this.pb_planet.TabStop = false;
            this.pb_planet.Click += new System.EventHandler(this.pb_planet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 437);
            this.Controls.Add(this.pb_planet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.tb_finalWeight);
            this.Controls.Add(this.lb_planets);
            this.Controls.Add(this.tb_enterWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_planet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_enterWeight;
        private System.Windows.Forms.ListBox lb_planets;
        private System.Windows.Forms.TextBox tb_finalWeight;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb_planet;
    }
}

