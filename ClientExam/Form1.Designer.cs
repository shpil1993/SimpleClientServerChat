namespace ClientExam
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.receiveTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.myPortTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(92, 6);
            this.nameTextBox.MaxLength = 25;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(635, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 33);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(635, 46);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(85, 33);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.Location = new System.Drawing.Point(12, 153);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.ReadOnly = true;
            this.receiveTextBox.Size = new System.Drawing.Size(708, 304);
            this.receiveTextBox.TabIndex = 4;
            this.receiveTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address: ";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(92, 40);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(159, 22);
            this.addressTextBox.TabIndex = 6;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(291, 6);
            this.messageTextBox.MaxLength = 4000;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(338, 73);
            this.messageTextBox.TabIndex = 7;
            this.messageTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port: ";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(92, 74);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(159, 22);
            this.portTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "My Port: ";
            // 
            // myPortTextBox
            // 
            this.myPortTextBox.Location = new System.Drawing.Point(92, 106);
            this.myPortTextBox.Name = "myPortTextBox";
            this.myPortTextBox.Size = new System.Drawing.Size(159, 22);
            this.myPortTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 469);
            this.Controls.Add(this.myPortTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receiveTextBox);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.RichTextBox receiveTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox myPortTextBox;
    }
}

