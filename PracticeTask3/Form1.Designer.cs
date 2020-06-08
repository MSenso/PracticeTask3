namespace PracticeTask3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.XInput = new System.Windows.Forms.TextBox();
            this.YInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ввод x:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(130, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ввод y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(205, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "График области D:";
            // 
            // XInput
            // 
            this.XInput.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XInput.Location = new System.Drawing.Point(222, 511);
            this.XInput.Name = "XInput";
            this.XInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.XInput.Size = new System.Drawing.Size(281, 36);
            this.XInput.TabIndex = 4;
            this.XInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XInput.TextChanged += new System.EventHandler(this.XInput_TextChanged);
            this.XInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XInput_KeyDown);
            // 
            // YInput
            // 
            this.YInput.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YInput.Location = new System.Drawing.Point(222, 553);
            this.YInput.Name = "YInput";
            this.YInput.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.YInput.Size = new System.Drawing.Size(281, 36);
            this.YInput.TabIndex = 5;
            this.YInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YInput_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(120, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "u равно:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::PracticeTask3.Properties.Resources.Plot;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(598, 463);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UOutput
            // 
            this.UOutput.BackColor = System.Drawing.Color.White;
            this.UOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UOutput.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UOutput.Location = new System.Drawing.Point(222, 619);
            this.UOutput.Name = "UOutput";
            this.UOutput.Size = new System.Drawing.Size(281, 33);
            this.UOutput.TabIndex = 8;
            this.UOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PracticeTask3.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(622, 683);
            this.Controls.Add(this.UOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.YInput);
            this.Controls.Add(this.XInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычисление u";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox XInput;
        private System.Windows.Forms.TextBox YInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UOutput;
    }
}

