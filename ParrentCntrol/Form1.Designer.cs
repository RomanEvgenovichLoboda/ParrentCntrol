namespace ParrentCntrol
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
            this.textBoxBlack = new System.Windows.Forms.TextBox();
            this.textBoxWhite = new System.Windows.Forms.TextBox();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.GroupBox();
            this.buttonStopBlack = new System.Windows.Forms.Button();
            this.buttonDellBlack = new System.Windows.Forms.Button();
            this.buttonStartBlack = new System.Windows.Forms.Button();
            this.listBoxBlack = new System.Windows.Forms.ListBox();
            this.White = new System.Windows.Forms.GroupBox();
            this.buttonStartWhite = new System.Windows.Forms.Button();
            this.listBoxWhite = new System.Windows.Forms.ListBox();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonStopWhite = new System.Windows.Forms.Button();
            this.buttonDellWhite = new System.Windows.Forms.Button();
            this.Black.SuspendLayout();
            this.White.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBlack
            // 
            this.textBoxBlack.Location = new System.Drawing.Point(6, 33);
            this.textBoxBlack.Name = "textBoxBlack";
            this.textBoxBlack.Size = new System.Drawing.Size(127, 22);
            this.textBoxBlack.TabIndex = 0;
            // 
            // textBoxWhite
            // 
            this.textBoxWhite.Location = new System.Drawing.Point(6, 32);
            this.textBoxWhite.Name = "textBoxWhite";
            this.textBoxWhite.Size = new System.Drawing.Size(125, 22);
            this.textBoxWhite.TabIndex = 1;
            // 
            // buttonBlack
            // 
            this.buttonBlack.Location = new System.Drawing.Point(158, 33);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(75, 23);
            this.buttonBlack.TabIndex = 2;
            this.buttonBlack.Text = "Add";
            this.buttonBlack.UseVisualStyleBackColor = true;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // Black
            // 
            this.Black.Controls.Add(this.buttonStopBlack);
            this.Black.Controls.Add(this.buttonDellBlack);
            this.Black.Controls.Add(this.buttonStartBlack);
            this.Black.Controls.Add(this.listBoxBlack);
            this.Black.Controls.Add(this.textBoxBlack);
            this.Black.Controls.Add(this.buttonBlack);
            this.Black.Location = new System.Drawing.Point(12, 17);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(250, 421);
            this.Black.TabIndex = 3;
            this.Black.TabStop = false;
            this.Black.Text = "BlackList";
            // 
            // buttonStopBlack
            // 
            this.buttonStopBlack.Location = new System.Drawing.Point(6, 389);
            this.buttonStopBlack.Name = "buttonStopBlack";
            this.buttonStopBlack.Size = new System.Drawing.Size(75, 23);
            this.buttonStopBlack.TabIndex = 6;
            this.buttonStopBlack.Text = "Stop";
            this.buttonStopBlack.UseVisualStyleBackColor = true;
            this.buttonStopBlack.Click += new System.EventHandler(this.buttonStopBlack_Click);
            // 
            // buttonDellBlack
            // 
            this.buttonDellBlack.Location = new System.Drawing.Point(127, 379);
            this.buttonDellBlack.Name = "buttonDellBlack";
            this.buttonDellBlack.Size = new System.Drawing.Size(106, 23);
            this.buttonDellBlack.TabIndex = 5;
            this.buttonDellBlack.Text = "SellectDell";
            this.buttonDellBlack.UseVisualStyleBackColor = true;
            this.buttonDellBlack.Click += new System.EventHandler(this.buttonDellBlack_Click);
            // 
            // buttonStartBlack
            // 
            this.buttonStartBlack.Location = new System.Drawing.Point(6, 360);
            this.buttonStartBlack.Name = "buttonStartBlack";
            this.buttonStartBlack.Size = new System.Drawing.Size(75, 23);
            this.buttonStartBlack.TabIndex = 4;
            this.buttonStartBlack.Text = "Start";
            this.buttonStartBlack.UseVisualStyleBackColor = true;
            this.buttonStartBlack.Click += new System.EventHandler(this.buttonStartBlack_Click);
            // 
            // listBoxBlack
            // 
            this.listBoxBlack.FormattingEnabled = true;
            this.listBoxBlack.ItemHeight = 16;
            this.listBoxBlack.Location = new System.Drawing.Point(6, 78);
            this.listBoxBlack.Name = "listBoxBlack";
            this.listBoxBlack.Size = new System.Drawing.Size(227, 276);
            this.listBoxBlack.TabIndex = 3;
            // 
            // White
            // 
            this.White.Controls.Add(this.buttonDellWhite);
            this.White.Controls.Add(this.buttonStopWhite);
            this.White.Controls.Add(this.buttonStartWhite);
            this.White.Controls.Add(this.listBoxWhite);
            this.White.Controls.Add(this.buttonWhite);
            this.White.Controls.Add(this.textBoxWhite);
            this.White.Location = new System.Drawing.Point(280, 17);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(250, 421);
            this.White.TabIndex = 4;
            this.White.TabStop = false;
            this.White.Text = "WhiteList";
            // 
            // buttonStartWhite
            // 
            this.buttonStartWhite.Location = new System.Drawing.Point(6, 360);
            this.buttonStartWhite.Name = "buttonStartWhite";
            this.buttonStartWhite.Size = new System.Drawing.Size(75, 23);
            this.buttonStartWhite.TabIndex = 5;
            this.buttonStartWhite.Text = "Start";
            this.buttonStartWhite.UseVisualStyleBackColor = true;
            this.buttonStartWhite.Click += new System.EventHandler(this.buttonStartWhite_Click);
            // 
            // listBoxWhite
            // 
            this.listBoxWhite.FormattingEnabled = true;
            this.listBoxWhite.ItemHeight = 16;
            this.listBoxWhite.Location = new System.Drawing.Point(6, 78);
            this.listBoxWhite.Name = "listBoxWhite";
            this.listBoxWhite.Size = new System.Drawing.Size(224, 276);
            this.listBoxWhite.TabIndex = 4;
            // 
            // buttonWhite
            // 
            this.buttonWhite.Location = new System.Drawing.Point(155, 33);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(75, 23);
            this.buttonWhite.TabIndex = 3;
            this.buttonWhite.Text = "Add";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonStopWhite
            // 
            this.buttonStopWhite.Location = new System.Drawing.Point(6, 392);
            this.buttonStopWhite.Name = "buttonStopWhite";
            this.buttonStopWhite.Size = new System.Drawing.Size(75, 23);
            this.buttonStopWhite.TabIndex = 6;
            this.buttonStopWhite.Text = "Stop";
            this.buttonStopWhite.UseVisualStyleBackColor = true;
            this.buttonStopWhite.Click += new System.EventHandler(this.buttonStopWhite_Click);
            // 
            // buttonDellWhite
            // 
            this.buttonDellWhite.Location = new System.Drawing.Point(124, 379);
            this.buttonDellWhite.Name = "buttonDellWhite";
            this.buttonDellWhite.Size = new System.Drawing.Size(106, 23);
            this.buttonDellWhite.TabIndex = 7;
            this.buttonDellWhite.Text = "SellectDell";
            this.buttonDellWhite.UseVisualStyleBackColor = true;
            this.buttonDellWhite.Click += new System.EventHandler(this.buttonDellWhite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Black);
            this.Name = "Form1";
            this.Text = "ParrentControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Black.ResumeLayout(false);
            this.Black.PerformLayout();
            this.White.ResumeLayout(false);
            this.White.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBlack;
        private System.Windows.Forms.TextBox textBoxWhite;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.GroupBox Black;
        private System.Windows.Forms.GroupBox White;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.ListBox listBoxBlack;
        private System.Windows.Forms.ListBox listBoxWhite;
        private System.Windows.Forms.Button buttonStartBlack;
        private System.Windows.Forms.Button buttonStartWhite;
        private System.Windows.Forms.Button buttonDellBlack;
        private System.Windows.Forms.Button buttonStopBlack;
        private System.Windows.Forms.Button buttonStopWhite;
        private System.Windows.Forms.Button buttonDellWhite;
    }
}

