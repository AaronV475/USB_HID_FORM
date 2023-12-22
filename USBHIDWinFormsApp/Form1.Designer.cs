namespace USBHIDWinFormsApp
{
    partial class Form1
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
            USBFound = new Label();
            searchHidButton = new Button();
            LED1 = new Button();
            LED2 = new Button();
            LED3 = new Button();
            LED4 = new Button();
            LED5 = new Button();
            LED6 = new Button();
            LED7 = new Button();
            LED8 = new Button();
            DK1 = new CheckBox();
            DK2 = new CheckBox();
            DK3 = new CheckBox();
            DK4 = new CheckBox();
            ADC = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // USBFound
            // 
            USBFound.AutoSize = true;
            USBFound.Location = new Point(166, 7);
            USBFound.Name = "USBFound";
            USBFound.Size = new Size(139, 20);
            USBFound.TabIndex = 0;
            USBFound.Text = "Click on Search HID";
            // 
            // searchHidButton
            // 
            searchHidButton.Location = new Point(66, 3);
            searchHidButton.Name = "searchHidButton";
            searchHidButton.Size = new Size(94, 29);
            searchHidButton.TabIndex = 1;
            searchHidButton.Text = "Search HID";
            searchHidButton.UseVisualStyleBackColor = true;
            searchHidButton.Click += searchHidButton_Click;
            // 
            // LED1
            // 
            LED1.Location = new Point(10, 60);
            LED1.Name = "LED1";
            LED1.Size = new Size(60, 30);
            LED1.TabIndex = 5;
            LED1.Text = "LED 1";
            LED1.UseVisualStyleBackColor = true;
            LED1.Click += LED1_Click;
            // 
            // LED2
            // 
            LED2.Location = new Point(100, 60);
            LED2.Name = "LED2";
            LED2.Size = new Size(60, 30);
            LED2.TabIndex = 6;
            LED2.Text = "LED 2";
            LED2.UseVisualStyleBackColor = true;
            LED2.Click += LED2_Click;
            // 
            // LED3
            // 
            LED3.Location = new Point(190, 60);
            LED3.Name = "LED3";
            LED3.Size = new Size(60, 30);
            LED3.TabIndex = 7;
            LED3.Text = "LED 3";
            LED3.UseVisualStyleBackColor = true;
            LED3.Click += LED3_Click;
            // 
            // LED4
            // 
            LED4.Location = new Point(275, 60);
            LED4.Name = "LED4";
            LED4.Size = new Size(60, 30);
            LED4.TabIndex = 8;
            LED4.Text = "LED 4";
            LED4.UseVisualStyleBackColor = true;
            LED4.Click += LED4_Click;
            // 
            // LED5
            // 
            LED5.Location = new Point(10, 96);
            LED5.Name = "LED5";
            LED5.Size = new Size(60, 30);
            LED5.TabIndex = 9;
            LED5.Text = "LED 5";
            LED5.UseVisualStyleBackColor = true;
            LED5.Click += LED5_Click;
            // 
            // LED6
            // 
            LED6.Location = new Point(100, 96);
            LED6.Name = "LED6";
            LED6.Size = new Size(60, 30);
            LED6.TabIndex = 10;
            LED6.Text = "LED 6";
            LED6.UseVisualStyleBackColor = true;
            LED6.Click += LED6_Click;
            // 
            // LED7
            // 
            LED7.Location = new Point(190, 96);
            LED7.Name = "LED7";
            LED7.Size = new Size(60, 30);
            LED7.TabIndex = 11;
            LED7.Text = "LED 7";
            LED7.UseVisualStyleBackColor = true;
            LED7.Click += LED7_Click;
            // 
            // LED8
            // 
            LED8.Location = new Point(275, 96);
            LED8.Name = "LED8";
            LED8.Size = new Size(60, 30);
            LED8.TabIndex = 12;
            LED8.Text = "LED 8";
            LED8.UseVisualStyleBackColor = true;
            LED8.Click += LED8_Click;
            // 
            // DK1
            // 
            DK1.AutoSize = true;
            DK1.Enabled = false;
            DK1.Location = new Point(10, 135);
            DK1.Name = "DK1";
            DK1.Size = new Size(63, 24);
            DK1.TabIndex = 13;
            DK1.Text = "DK 1";
            DK1.UseVisualStyleBackColor = true;
            // 
            // DK2
            // 
            DK2.AutoSize = true;
            DK2.Enabled = false;
            DK2.Location = new Point(100, 135);
            DK2.Name = "DK2";
            DK2.Size = new Size(63, 24);
            DK2.TabIndex = 14;
            DK2.Text = "DK 2";
            DK2.UseVisualStyleBackColor = true;
            // 
            // DK3
            // 
            DK3.AutoSize = true;
            DK3.Enabled = false;
            DK3.Location = new Point(190, 135);
            DK3.Name = "DK3";
            DK3.Size = new Size(63, 24);
            DK3.TabIndex = 15;
            DK3.Text = "DK 3";
            DK3.UseVisualStyleBackColor = true;
            // 
            // DK4
            // 
            DK4.AutoSize = true;
            DK4.Enabled = false;
            DK4.Location = new Point(275, 135);
            DK4.Name = "DK4";
            DK4.Size = new Size(63, 24);
            DK4.TabIndex = 16;
            DK4.Text = "DK 4";
            DK4.UseVisualStyleBackColor = true;
            // 
            // ADC
            // 
            ADC.Location = new Point(190, 193);
            ADC.Name = "ADC";
            ADC.Size = new Size(125, 27);
            ADC.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 196);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 18;
            label1.Text = "ADC-waarde (0-15):";
            // 
            // Form1
            // 
            ClientSize = new Size(347, 307);
            Controls.Add(label1);
            Controls.Add(ADC);
            Controls.Add(DK4);
            Controls.Add(DK3);
            Controls.Add(DK2);
            Controls.Add(DK1);
            Controls.Add(LED8);
            Controls.Add(LED7);
            Controls.Add(LED6);
            Controls.Add(LED5);
            Controls.Add(LED4);
            Controls.Add(LED3);
            Controls.Add(LED2);
            Controls.Add(LED1);
            Controls.Add(searchHidButton);
            Controls.Add(USBFound);
            Name = "Form1";
            Text = "HID - Windows Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label USBFound;
        private Button searchHidButton;
        private Button LED1;
        private Button LED2;
        private Button LED3;
        private Button LED4;
        private Button LED5;
        private Button LED6;
        private Button LED7;
        private Button LED8;
        private CheckBox DK1;
        private CheckBox DK2;
        private CheckBox DK3;
        private CheckBox DK4;
        private TextBox ADC;
        private Label label1;
    }
}