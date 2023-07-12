namespace UdpTrafficGenerator
{
    partial class Form1 : Form
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
            ipTextBox = new TextBox();
            macTextBox = new TextBox();
            bitrateTextBox = new TextBox();
            packetSizeTextBox = new TextBox();
            startButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            stopButton = new Button();
            SuspendLayout();
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(24, 38);
            ipTextBox.Margin = new Padding(3, 2, 3, 2);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(210, 23);
            ipTextBox.TabIndex = 0;
            // 
            // macTextBox
            // 
            macTextBox.Location = new Point(252, 38);
            macTextBox.Margin = new Padding(3, 2, 3, 2);
            macTextBox.Name = "macTextBox";
            macTextBox.Size = new Size(202, 23);
            macTextBox.TabIndex = 1;
            // 
            // bitrateTextBox
            // 
            bitrateTextBox.Location = new Point(478, 38);
            bitrateTextBox.Margin = new Padding(3, 2, 3, 2);
            bitrateTextBox.Name = "bitrateTextBox";
            bitrateTextBox.Size = new Size(110, 23);
            bitrateTextBox.TabIndex = 2;
            // 
            // packetSizeTextBox
            // 
            packetSizeTextBox.Location = new Point(612, 38);
            packetSizeTextBox.Margin = new Padding(3, 2, 3, 2);
            packetSizeTextBox.Name = "packetSizeTextBox";
            packetSizeTextBox.Size = new Size(110, 23);
            packetSizeTextBox.TabIndex = 3;
            // 
            // startButton
            // 
            startButton.Location = new Point(506, 91);
            startButton.Margin = new Padding(3, 2, 3, 2);
            startButton.Name = "startButton";
            startButton.Size = new Size(82, 22);
            startButton.TabIndex = 4;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 16);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "IP Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 16);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 6;
            label2.Text = "MAC Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 16);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 7;
            label3.Text = "bitrate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(612, 16);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 8;
            label4.Text = "packet Size";
            // 
            // stopButton
            // 
            stopButton.Location = new Point(647, 90);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(75, 23);
            stopButton.TabIndex = 9;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 134);
            Controls.Add(stopButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startButton);
            Controls.Add(packetSizeTextBox);
            Controls.Add(bitrateTextBox);
            Controls.Add(macTextBox);
            Controls.Add(ipTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ipTextBox;
        private TextBox macTextBox;
        private TextBox bitrateTextBox;
        private TextBox packetSizeTextBox;
        private Button startButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button stopButton;
    }
}