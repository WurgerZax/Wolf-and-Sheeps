namespace Wolf_and_Sheeps
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelWolf = new System.Windows.Forms.Label();
            this.labelSheep = new System.Windows.Forms.Label();
            this.timerSheep = new System.Windows.Forms.Timer(this.components);
            this.timerWolf = new System.Windows.Forms.Timer(this.components);
            this.buttonGO = new System.Windows.Forms.Button();
            this.Field = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureWolf = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureSheep = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSheep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.labelSheep);
            this.panel3.Controls.Add(this.pictureSheep);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.labelWolf);
            this.panel4.Controls.Add(this.pictureWolf);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(496, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 100);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonGO);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(264, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 100);
            this.panel5.TabIndex = 2;
            // 
            // labelWolf
            // 
            this.labelWolf.AutoSize = true;
            this.labelWolf.Location = new System.Drawing.Point(204, 43);
            this.labelWolf.Name = "labelWolf";
            this.labelWolf.Size = new System.Drawing.Size(16, 17);
            this.labelWolf.TabIndex = 2;
            this.labelWolf.Text = "0";
            // 
            // labelSheep
            // 
            this.labelSheep.AutoSize = true;
            this.labelSheep.Location = new System.Drawing.Point(83, 43);
            this.labelSheep.Name = "labelSheep";
            this.labelSheep.Size = new System.Drawing.Size(16, 17);
            this.labelSheep.TabIndex = 1;
            this.labelSheep.Text = "0";
            // 
            // timerSheep
            // 
            this.timerSheep.Interval = 1000;
            this.timerSheep.Tick += new System.EventHandler(this.timerSheep_Tick);
            // 
            // timerWolf
            // 
            this.timerWolf.Interval = 500;
            this.timerWolf.Tick += new System.EventHandler(this.timerWolf_Tick);
            // 
            // buttonGO
            // 
            this.buttonGO.BackColor = System.Drawing.Color.DarkRed;
            this.buttonGO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGO.Location = new System.Drawing.Point(0, 0);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(232, 100);
            this.buttonGO.TabIndex = 0;
            this.buttonGO.Text = "GO";
            this.buttonGO.UseVisualStyleBackColor = false;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // Field
            // 
            this.Field.BackgroundImage = global::Wolf_and_Sheeps.Properties.Resources.grass4;
            this.Field.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Field.Location = new System.Drawing.Point(0, 100);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(800, 350);
            this.Field.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Wolf_and_Sheeps.Properties.Resources.icons8_plus_64;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(82, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureWolf
            // 
            this.pictureWolf.BackgroundImage = global::Wolf_and_Sheeps.Properties.Resources.icons8_wolf_64;
            this.pictureWolf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureWolf.Location = new System.Drawing.Point(226, 19);
            this.pictureWolf.Name = "pictureWolf";
            this.pictureWolf.Size = new System.Drawing.Size(64, 64);
            this.pictureWolf.TabIndex = 1;
            this.pictureWolf.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Wolf_and_Sheeps.Properties.Resources.icons8_plus_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(154, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureSheep
            // 
            this.pictureSheep.BackgroundImage = global::Wolf_and_Sheeps.Properties.Resources.icons8_lamb_64;
            this.pictureSheep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureSheep.Location = new System.Drawing.Point(12, 22);
            this.pictureSheep.Name = "pictureSheep";
            this.pictureSheep.Size = new System.Drawing.Size(64, 64);
            this.pictureSheep.TabIndex = 0;
            this.pictureSheep.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WolfsAndSheeps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSheep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelWolf;
        private System.Windows.Forms.PictureBox pictureWolf;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelSheep;
        private System.Windows.Forms.PictureBox pictureSheep;
        private System.Windows.Forms.Panel Field;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerSheep;
        private System.Windows.Forms.Timer timerWolf;
        private System.Windows.Forms.Button buttonGO;
    }
}

