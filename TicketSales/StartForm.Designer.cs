
namespace TicketSales
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.TextBox();
            this.EventDate = new System.Windows.Forms.DateTimePicker();
            this.CashierName = new System.Windows.Forms.TextBox();
            this.DefFile = new System.Windows.Forms.TextBox();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cashier Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Definition File";
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(156, 29);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(209, 23);
            this.EventName.TabIndex = 4;
            // 
            // EventDate
            // 
            this.EventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EventDate.Location = new System.Drawing.Point(156, 65);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(100, 23);
            this.EventDate.TabIndex = 5;
            // 
            // CashierName
            // 
            this.CashierName.Location = new System.Drawing.Point(156, 112);
            this.CashierName.Name = "CashierName";
            this.CashierName.Size = new System.Drawing.Size(209, 23);
            this.CashierName.TabIndex = 6;
            // 
            // DefFile
            // 
            this.DefFile.Location = new System.Drawing.Point(156, 153);
            this.DefFile.Name = "DefFile";
            this.DefFile.Size = new System.Drawing.Size(209, 23);
            this.DefFile.TabIndex = 7;
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(386, 153);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(102, 23);
            this.ChooseFile.TabIndex = 8;
            this.ChooseFile.Text = "Choose File";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(527, 206);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 241);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.DefFile);
            this.Controls.Add(this.CashierName);
            this.Controls.Add(this.EventDate);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "Initialization";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.DateTimePicker EventDate;
        private System.Windows.Forms.TextBox CashierName;
        private System.Windows.Forms.TextBox DefFile;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.Button StartButton;
    }
}

