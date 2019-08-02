namespace AutoPageUpdater
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
            this.addressBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.countOfUpdatesLabel = new System.Windows.Forms.Label();
            this.countOfUpdates = new System.Windows.Forms.TextBox();
            this.timeRangeLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.minTimeUpdate = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxTimeUpdate = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timeToUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressBox
            // 
            this.addressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox.Location = new System.Drawing.Point(12, 29);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(570, 20);
            this.addressBox.TabIndex = 0;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 13);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(161, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Адрес обновляемой страницы";
            // 
            // countOfUpdatesLabel
            // 
            this.countOfUpdatesLabel.AutoSize = true;
            this.countOfUpdatesLabel.Location = new System.Drawing.Point(13, 56);
            this.countOfUpdatesLabel.Name = "countOfUpdatesLabel";
            this.countOfUpdatesLabel.Size = new System.Drawing.Size(181, 13);
            this.countOfUpdatesLabel.TabIndex = 2;
            this.countOfUpdatesLabel.Text = "Количество обновлений страницы";
            // 
            // countOfUpdates
            // 
            this.countOfUpdates.Location = new System.Drawing.Point(12, 72);
            this.countOfUpdates.Name = "countOfUpdates";
            this.countOfUpdates.Size = new System.Drawing.Size(182, 20);
            this.countOfUpdates.TabIndex = 3;
            this.countOfUpdates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.countOfUpdates_KeyPress);
            this.countOfUpdates.KeyUp += new System.Windows.Forms.KeyEventHandler(this.countOfUpdates_KeyUp);
            // 
            // timeRangeLabel
            // 
            this.timeRangeLabel.AutoSize = true;
            this.timeRangeLabel.Location = new System.Drawing.Point(214, 56);
            this.timeRangeLabel.Name = "timeRangeLabel";
            this.timeRangeLabel.Size = new System.Drawing.Size(273, 13);
            this.timeRangeLabel.TabIndex = 4;
            this.timeRangeLabel.Text = "Временной интервал обновления страницы (секунд)";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(214, 75);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(28, 13);
            this.minLabel.TabIndex = 5;
            this.minLabel.Text = "Мин";
            // 
            // minTimeUpdate
            // 
            this.minTimeUpdate.Location = new System.Drawing.Point(249, 73);
            this.minTimeUpdate.Name = "minTimeUpdate";
            this.minTimeUpdate.Size = new System.Drawing.Size(100, 20);
            this.minTimeUpdate.TabIndex = 6;
            this.minTimeUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minTimeUpdate_KeyPress);
            this.minTimeUpdate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.minTimeUpdate_KeyUp);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(355, 75);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(34, 13);
            this.maxLabel.TabIndex = 7;
            this.maxLabel.Text = "Макс";
            // 
            // maxTimeUpdate
            // 
            this.maxTimeUpdate.Location = new System.Drawing.Point(396, 73);
            this.maxTimeUpdate.Name = "maxTimeUpdate";
            this.maxTimeUpdate.Size = new System.Drawing.Size(100, 20);
            this.maxTimeUpdate.TabIndex = 8;
            this.maxTimeUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxTimeUpdate_KeyPress);
            this.maxTimeUpdate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maxTimeUpdate_KeyUp);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 99);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(192, 13);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Количество прошедших обновлений:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(503, 56);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(79, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Запустить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(503, 86);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(79, 23);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "Остановить";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timeToUpdate
            // 
            this.timeToUpdate.AutoSize = true;
            this.timeToUpdate.Location = new System.Drawing.Point(249, 99);
            this.timeToUpdate.Name = "timeToUpdate";
            this.timeToUpdate.Size = new System.Drawing.Size(171, 13);
            this.timeToUpdate.TabIndex = 12;
            this.timeToUpdate.Text = "Текущее время до обновления: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 122);
            this.Controls.Add(this.timeToUpdate);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.maxTimeUpdate);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minTimeUpdate);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.timeRangeLabel);
            this.Controls.Add(this.countOfUpdates);
            this.Controls.Add(this.countOfUpdatesLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Автообновляшка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label countOfUpdatesLabel;
        private System.Windows.Forms.TextBox countOfUpdates;
        private System.Windows.Forms.Label timeRangeLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minTimeUpdate;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.TextBox maxTimeUpdate;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label timeToUpdate;
    }
}

