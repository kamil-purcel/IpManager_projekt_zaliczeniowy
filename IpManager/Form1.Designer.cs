namespace IpManager
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
            components = new System.ComponentModel.Container();
            dataView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ipAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hostnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isEnabledDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            deviceBindingSource = new BindingSource(components);
            addButton = new Button();
            removeButton = new Button();
            subnetCalculatorButton = new Button();
            searchIp = new TextBox();
            searchHostname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deviceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AllowUserToOrderColumns = true;
            dataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataView.AutoGenerateColumns = false;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, ipAddressDataGridViewTextBoxColumn, hostnameDataGridViewTextBoxColumn, isEnabledDataGridViewCheckBoxColumn });
            dataView.DataSource = deviceBindingSource;
            dataView.EditMode = DataGridViewEditMode.EditOnEnter;
            dataView.Location = new Point(12, 45);
            dataView.Name = "dataView";
            dataView.RowHeadersWidth = 51;
            dataView.ScrollBars = ScrollBars.Vertical;
            dataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataView.Size = new Size(526, 361);
            dataView.TabIndex = 0;
            dataView.CellEndEdit += dataView_CellEndEdit;
            dataView.ColumnHeaderMouseClick += dataView_ColumnHeaderMouseClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // ipAddressDataGridViewTextBoxColumn
            // 
            ipAddressDataGridViewTextBoxColumn.DataPropertyName = "IpAddress";
            ipAddressDataGridViewTextBoxColumn.HeaderText = "IpAddress";
            ipAddressDataGridViewTextBoxColumn.MinimumWidth = 50;
            ipAddressDataGridViewTextBoxColumn.Name = "ipAddressDataGridViewTextBoxColumn";
            ipAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // hostnameDataGridViewTextBoxColumn
            // 
            hostnameDataGridViewTextBoxColumn.DataPropertyName = "Hostname";
            hostnameDataGridViewTextBoxColumn.HeaderText = "Hostname";
            hostnameDataGridViewTextBoxColumn.MinimumWidth = 125;
            hostnameDataGridViewTextBoxColumn.Name = "hostnameDataGridViewTextBoxColumn";
            hostnameDataGridViewTextBoxColumn.Width = 225;
            // 
            // isEnabledDataGridViewCheckBoxColumn
            // 
            isEnabledDataGridViewCheckBoxColumn.DataPropertyName = "IsEnabled";
            isEnabledDataGridViewCheckBoxColumn.HeaderText = "IsEnabled";
            isEnabledDataGridViewCheckBoxColumn.MinimumWidth = 50;
            isEnabledDataGridViewCheckBoxColumn.Name = "isEnabledDataGridViewCheckBoxColumn";
            isEnabledDataGridViewCheckBoxColumn.Width = 125;
            // 
            // deviceBindingSource
            // 
            deviceBindingSource.DataSource = typeof(Models.Device);
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addButton.Location = new Point(12, 412);
            addButton.Name = "addButton";
            addButton.Size = new Size(147, 29);
            addButton.TabIndex = 1;
            addButton.Text = "Add new";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            removeButton.Location = new Point(184, 412);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(189, 29);
            removeButton.TabIndex = 2;
            removeButton.Text = "Remove selected";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // subnetCalculatorButton
            // 
            subnetCalculatorButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subnetCalculatorButton.Location = new Point(391, 412);
            subnetCalculatorButton.Name = "subnetCalculatorButton";
            subnetCalculatorButton.Size = new Size(147, 29);
            subnetCalculatorButton.TabIndex = 3;
            subnetCalculatorButton.Text = "Calculate Subnet";
            subnetCalculatorButton.UseVisualStyleBackColor = true;
            subnetCalculatorButton.Click += subnetCalculatorButton_Click;
            // 
            // searchIp
            // 
            searchIp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchIp.Location = new Point(12, 12);
            searchIp.Name = "searchIp";
            searchIp.PlaceholderText = "Ip address";
            searchIp.Size = new Size(252, 27);
            searchIp.TabIndex = 4;
            searchIp.TextChanged += searchIp_TextChanged;
            // 
            // searchHostname
            // 
            searchHostname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchHostname.Location = new Point(283, 12);
            searchHostname.Name = "searchHostname";
            searchHostname.PlaceholderText = "Hostname";
            searchHostname.Size = new Size(255, 27);
            searchHostname.TabIndex = 5;
            searchHostname.TextChanged += searchHostname_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 453);
            Controls.Add(searchHostname);
            Controls.Add(searchIp);
            Controls.Add(subnetCalculatorButton);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(dataView);
            MaximizeBox = false;
            MaximumSize = new Size(570, 500);
            MinimumSize = new Size(570, 500);
            Name = "Form1";
            ShowIcon = false;
            Text = "IP Manager";
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)deviceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataView;
        private Button addButton;
        private Button removeButton;
        private Button subnetCalculatorButton;
        private TextBox searchIp;
        private TextBox searchHostname;
        private BindingSource deviceBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ipAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hostnameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isEnabledDataGridViewCheckBoxColumn;
    }
}
