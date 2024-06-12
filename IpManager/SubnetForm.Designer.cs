namespace IpManager
{
    partial class SubnetForm
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
            ipTextBox = new TextBox();
            maskTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            calculateButton = new Button();
            labelNetwork = new Label();
            labelBroadcast = new Label();
            labelUsableRange = new Label();
            labelUsableHosts = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ipTextBox
            // 
            ipTextBox.Location = new Point(12, 32);
            ipTextBox.Name = "ipTextBox";
            ipTextBox.Size = new Size(125, 27);
            ipTextBox.TabIndex = 0;
            // 
            // maskTextBox
            // 
            maskTextBox.Location = new Point(12, 101);
            maskTextBox.Name = "maskTextBox";
            maskTextBox.Size = new Size(125, 27);
            maskTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Ip address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Mask";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(12, 137);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(125, 29);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // labelNetwork
            // 
            labelNetwork.AutoSize = true;
            labelNetwork.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelNetwork.Location = new Point(162, 31);
            labelNetwork.Name = "labelNetwork";
            labelNetwork.Size = new Size(88, 25);
            labelNetwork.TabIndex = 5;
            labelNetwork.Text = "Network: ";
            // 
            // labelBroadcast
            // 
            labelBroadcast.AutoSize = true;
            labelBroadcast.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelBroadcast.Location = new Point(162, 66);
            labelBroadcast.Name = "labelBroadcast";
            labelBroadcast.Size = new Size(94, 25);
            labelBroadcast.TabIndex = 6;
            labelBroadcast.Text = "Broadcast:";
            // 
            // labelUsableRange
            // 
            labelUsableRange.AutoSize = true;
            labelUsableRange.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelUsableRange.Location = new Point(162, 100);
            labelUsableRange.Name = "labelUsableRange";
            labelUsableRange.Size = new Size(119, 25);
            labelUsableRange.TabIndex = 7;
            labelUsableRange.Text = "Usable range:";
            // 
            // labelUsableHosts
            // 
            labelUsableHosts.AutoSize = true;
            labelUsableHosts.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            labelUsableHosts.Location = new Point(162, 137);
            labelUsableHosts.Name = "labelUsableHosts";
            labelUsableHosts.Size = new Size(117, 25);
            labelUsableHosts.TabIndex = 8;
            labelUsableHosts.Text = "Usable hosts:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(281, 4);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 9;
            label3.Text = "Result";
            // 
            // SubnetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 178);
            Controls.Add(label3);
            Controls.Add(labelUsableHosts);
            Controls.Add(labelUsableRange);
            Controls.Add(labelBroadcast);
            Controls.Add(labelNetwork);
            Controls.Add(calculateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskTextBox);
            Controls.Add(ipTextBox);
            MaximizeBox = false;
            MaximumSize = new Size(570, 225);
            MinimumSize = new Size(570, 225);
            Name = "SubnetForm";
            ShowIcon = false;
            Text = "Subnet Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ipTextBox;
        private TextBox maskTextBox;
        private Label label1;
        private Label label2;
        private Button calculateButton;
        private Label labelNetwork;
        private Label labelBroadcast;
        private Label labelUsableRange;
        private Label labelUsableHosts;
        private Label label3;
    }
}