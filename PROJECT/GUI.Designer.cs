﻿namespace CSharpCalc
{
    partial class GUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result = new System.Windows.Forms.TextBox();
            this.Num1Label = new System.Windows.Forms.Label();
            this.Num2Label = new System.Windows.Forms.Label();
            this.OpLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Mod = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.Num1Place = new System.Windows.Forms.Button();
            this.Num2Place = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Error = new System.Windows.Forms.TextBox();
            this.About = new System.Windows.Forms.MenuStrip();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.About.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Result.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.ForeColor = System.Drawing.Color.Black;
            this.Result.Location = new System.Drawing.Point(199, 396);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(652, 40);
            this.Result.TabIndex = 1;
            this.Result.Text = "0";
            // 
            // Num1Label
            // 
            this.Num1Label.AutoSize = true;
            this.Num1Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num1Label.ForeColor = System.Drawing.Color.White;
            this.Num1Label.Location = new System.Drawing.Point(33, 144);
            this.Num1Label.Name = "Num1Label";
            this.Num1Label.Size = new System.Drawing.Size(149, 32);
            this.Num1Label.TabIndex = 2;
            this.Num1Label.Text = "1st Number";
            // 
            // Num2Label
            // 
            this.Num2Label.AutoSize = true;
            this.Num2Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num2Label.ForeColor = System.Drawing.Color.White;
            this.Num2Label.Location = new System.Drawing.Point(33, 311);
            this.Num2Label.Name = "Num2Label";
            this.Num2Label.Size = new System.Drawing.Size(159, 32);
            this.Num2Label.TabIndex = 3;
            this.Num2Label.Text = "2nd Number";
            // 
            // OpLabel
            // 
            this.OpLabel.AutoSize = true;
            this.OpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpLabel.ForeColor = System.Drawing.Color.White;
            this.OpLabel.Location = new System.Drawing.Point(33, 232);
            this.OpLabel.Name = "OpLabel";
            this.OpLabel.Size = new System.Drawing.Size(129, 32);
            this.OpLabel.TabIndex = 4;
            this.OpLabel.Text = "Operation";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Unispace", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Yellow;
            this.Title.Location = new System.Drawing.Point(298, 67);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(260, 48);
            this.Title.TabIndex = 5;
            this.Title.Text = "Calculator";
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Mult.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mult.Location = new System.Drawing.Point(199, 217);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(70, 60);
            this.Mult.TabIndex = 6;
            this.Mult.Text = "x";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Div.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Div.Location = new System.Drawing.Point(320, 217);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(70, 60);
            this.Div.TabIndex = 7;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Sub.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sub.Location = new System.Drawing.Point(546, 217);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(70, 60);
            this.Sub.TabIndex = 8;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Add.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(433, 217);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(70, 60);
            this.Add.TabIndex = 9;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(33, 400);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(84, 32);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Result";
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num1.Location = new System.Drawing.Point(199, 145);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(412, 40);
            this.Num1.TabIndex = 12;
            this.Num1.Text = "0";
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num2.Location = new System.Drawing.Point(199, 307);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(412, 40);
            this.Num2.TabIndex = 13;
            this.Num2.Text = "0";
            // 
            // Mod
            // 
            this.Mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Mod.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mod.Location = new System.Drawing.Point(664, 217);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(70, 60);
            this.Mod.TabIndex = 14;
            this.Mod.Text = "%";
            this.Mod.UseVisualStyleBackColor = false;
            this.Mod.Click += new System.EventHandler(this.Mod_Click);
            // 
            // Pow
            // 
            this.Pow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Pow.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pow.Location = new System.Drawing.Point(781, 217);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(70, 60);
            this.Pow.TabIndex = 15;
            this.Pow.Text = "^";
            this.Pow.UseVisualStyleBackColor = false;
            this.Pow.Click += new System.EventHandler(this.Pow_Click);
            // 
            // Num1Place
            // 
            this.Num1Place.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Num1Place.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num1Place.Location = new System.Drawing.Point(617, 144);
            this.Num1Place.Name = "Num1Place";
            this.Num1Place.Size = new System.Drawing.Size(234, 41);
            this.Num1Place.TabIndex = 16;
            this.Num1Place.Text = "Place Results";
            this.Num1Place.UseVisualStyleBackColor = false;
            this.Num1Place.Click += new System.EventHandler(this.Num1Place_Click);
            // 
            // Num2Place
            // 
            this.Num2Place.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Num2Place.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num2Place.Location = new System.Drawing.Point(617, 304);
            this.Num2Place.Name = "Num2Place";
            this.Num2Place.Size = new System.Drawing.Size(234, 41);
            this.Num2Place.TabIndex = 17;
            this.Num2Place.Text = "Place Results";
            this.Num2Place.UseVisualStyleBackColor = false;
            this.Num2Place.Click += new System.EventHandler(this.Num2Place_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.White;
            this.ErrorLabel.Location = new System.Drawing.Point(33, 462);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(72, 32);
            this.ErrorLabel.TabIndex = 19;
            this.ErrorLabel.Text = "Error";
            // 
            // Error
            // 
            this.Error.BackColor = System.Drawing.Color.Thistle;
            this.Error.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Error.ForeColor = System.Drawing.Color.Black;
            this.Error.Location = new System.Drawing.Point(199, 465);
            this.Error.Name = "Error";
            this.Error.ReadOnly = true;
            this.Error.Size = new System.Drawing.Size(652, 33);
            this.Error.TabIndex = 18;
            this.Error.Text = "None";
            // 
            // About
            // 
            this.About.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.About.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenu});
            this.About.Location = new System.Drawing.Point(0, 0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(905, 33);
            this.About.TabIndex = 20;
            this.About.Text = "About";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(78, 29);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(905, 535);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Num2Place);
            this.Controls.Add(this.Num1Place);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.OpLabel);
            this.Controls.Add(this.Num2Label);
            this.Controls.Add(this.Num1Label);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.About);
            this.MainMenuStrip = this.About;
            this.Name = "GUI";
            this.Text = "Calculator";
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox Result;
        private Label Num1Label;
        private Label Num2Label;
        private Label OpLabel;
        private Label Title;
        private Button Mult;
        private Button Div;
        private Button Sub;
        private Button Add;
        private Label ResultLabel;
        private TextBox Num1;
        private TextBox Num2;
        private Button Mod;
        private Button Pow;
        private Button Num1Place;
        private Button Num2Place;
        private Label ErrorLabel;
        private TextBox Error;
        private MenuStrip About;
        private ToolStripMenuItem AboutMenu;
    }
}