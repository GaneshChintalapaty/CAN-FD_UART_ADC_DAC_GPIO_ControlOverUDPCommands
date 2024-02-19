namespace CAN_FD_UART_ADC_DAC_GPIO_ControlOverUDPCommands
{
    partial class CUADGC
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
            this.controlGPIO1 = new System.Windows.Forms.Button();
            this.controlGPIO2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.controlDAC1 = new System.Windows.Forms.TrackBar();
            this.controlDAC2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.hostADCDispalyValues = new System.Windows.Forms.Integration.ElementHost();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sendCANFDBytes = new System.Windows.Forms.Button();
            this.sendUARTBytes = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.readCANFDUARTBytes = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controlDAC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDAC2)).BeginInit();
            this.SuspendLayout();
            // 
            // controlGPIO1
            // 
            this.controlGPIO1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.controlGPIO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlGPIO1.Location = new System.Drawing.Point(351, 70);
            this.controlGPIO1.Name = "controlGPIO1";
            this.controlGPIO1.Size = new System.Drawing.Size(101, 39);
            this.controlGPIO1.TabIndex = 0;
            this.controlGPIO1.Text = "GPIO1 LOW";
            this.controlGPIO1.UseVisualStyleBackColor = false;
            // 
            // controlGPIO2
            // 
            this.controlGPIO2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.controlGPIO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlGPIO2.ForeColor = System.Drawing.Color.Black;
            this.controlGPIO2.Location = new System.Drawing.Point(473, 70);
            this.controlGPIO2.Name = "controlGPIO2";
            this.controlGPIO2.Size = new System.Drawing.Size(101, 39);
            this.controlGPIO2.TabIndex = 1;
            this.controlGPIO2.Text = "GPIO2 LOW";
            this.controlGPIO2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GPIO Control";
            // 
            // controlDAC1
            // 
            this.controlDAC1.Location = new System.Drawing.Point(373, 170);
            this.controlDAC1.Name = "controlDAC1";
            this.controlDAC1.Size = new System.Drawing.Size(223, 45);
            this.controlDAC1.TabIndex = 3;
            // 
            // controlDAC2
            // 
            this.controlDAC2.Location = new System.Drawing.Point(373, 234);
            this.controlDAC2.Name = "controlDAC2";
            this.controlDAC2.Size = new System.Drawing.Size(223, 45);
            this.controlDAC2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DAC Control";
            // 
            // hostADCDispalyValues
            // 
            this.hostADCDispalyValues.Location = new System.Drawing.Point(12, 12);
            this.hostADCDispalyValues.Name = "hostADCDispalyValues";
            this.hostADCDispalyValues.Size = new System.Drawing.Size(300, 300);
            this.hostADCDispalyValues.TabIndex = 6;
            this.hostADCDispalyValues.Text = "elementHost1";
            this.hostADCDispalyValues.Child = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CAN-FD Write:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 8;
            // 
            // sendCANFDBytes
            // 
            this.sendCANFDBytes.Location = new System.Drawing.Point(521, 343);
            this.sendCANFDBytes.Name = "sendCANFDBytes";
            this.sendCANFDBytes.Size = new System.Drawing.Size(75, 23);
            this.sendCANFDBytes.TabIndex = 9;
            this.sendCANFDBytes.Text = "Send";
            this.sendCANFDBytes.UseVisualStyleBackColor = true;
            // 
            // sendUARTBytes
            // 
            this.sendUARTBytes.Location = new System.Drawing.Point(521, 380);
            this.sendUARTBytes.Name = "sendUARTBytes";
            this.sendUARTBytes.Size = new System.Drawing.Size(75, 23);
            this.sendUARTBytes.TabIndex = 12;
            this.sendUARTBytes.Text = "Send";
            this.sendUARTBytes.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 381);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "UART Write:";
            // 
            // readCANFDUARTBytes
            // 
            this.readCANFDUARTBytes.FormattingEnabled = true;
            this.readCANFDUARTBytes.Location = new System.Drawing.Point(12, 431);
            this.readCANFDUARTBytes.Name = "readCANFDUARTBytes";
            this.readCANFDUARTBytes.Size = new System.Drawing.Size(584, 173);
            this.readCANFDUARTBytes.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "DAC1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "DAC2:";
            // 
            // CUADGC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 624);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.readCANFDUARTBytes);
            this.Controls.Add(this.sendUARTBytes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sendCANFDBytes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hostADCDispalyValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controlDAC2);
            this.Controls.Add(this.controlDAC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlGPIO2);
            this.Controls.Add(this.controlGPIO1);
            this.MaximizeBox = false;
            this.Name = "CUADGC";
            this.Text = "CAN-FD UART ADC DAC GPIO Control over UDP Commands";
            this.Load += new System.EventHandler(this.CUADGC_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlDAC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlDAC2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button controlGPIO1;
        private System.Windows.Forms.Button controlGPIO2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar controlDAC1;
        private System.Windows.Forms.TrackBar controlDAC2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Integration.ElementHost hostADCDispalyValues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sendCANFDBytes;
        private System.Windows.Forms.Button sendUARTBytes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox readCANFDUARTBytes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

