
namespace AntiGuyDoPietra
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tbInventoryKey = new System.Windows.Forms.TextBox();
            this.btnUnfocus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nmXOfensivePosition = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmYOfensivePosition = new System.Windows.Forms.NumericUpDown();
            this.tbTriggerKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMouseButton = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nmDelayBeforeOpenInventory = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nmDelayAfterOpenInventory = new System.Windows.Forms.NumericUpDown();
            this.lbScreenHalf = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nmDelayHoldGrenadeFor = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nmDropClicks = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nmDelayBetweenClicks = new System.Windows.Forms.NumericUpDown();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cbTriggerMethod = new System.Windows.Forms.ComboBox();
            this.cbIsEnabled = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTriggerLifetimeCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmXOfensivePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYOfensivePosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayBeforeOpenInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayAfterOpenInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayHoldGrenadeFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDropClicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayBetweenClicks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory key:";
            // 
            // tbInventoryKey
            // 
            this.tbInventoryKey.Location = new System.Drawing.Point(164, 5);
            this.tbInventoryKey.Name = "tbInventoryKey";
            this.tbInventoryKey.ReadOnly = true;
            this.tbInventoryKey.Size = new System.Drawing.Size(100, 20);
            this.tbInventoryKey.TabIndex = 2;
            // 
            // btnUnfocus
            // 
            this.btnUnfocus.Location = new System.Drawing.Point(273, 5);
            this.btnUnfocus.Name = "btnUnfocus";
            this.btnUnfocus.Size = new System.Drawing.Size(75, 23);
            this.btnUnfocus.TabIndex = 1;
            this.btnUnfocus.Text = "Unfocus";
            this.btnUnfocus.UseVisualStyleBackColor = true;
            this.btnUnfocus.Click += new System.EventHandler(this.EventValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ofensive slot mouse position:";
            // 
            // nmXOfensivePosition
            // 
            this.nmXOfensivePosition.Location = new System.Drawing.Point(328, 108);
            this.nmXOfensivePosition.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nmXOfensivePosition.Name = "nmXOfensivePosition";
            this.nmXOfensivePosition.Size = new System.Drawing.Size(100, 20);
            this.nmXOfensivePosition.TabIndex = 4;
            this.nmXOfensivePosition.ValueChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y:";
            // 
            // nmYOfensivePosition
            // 
            this.nmYOfensivePosition.Location = new System.Drawing.Point(457, 108);
            this.nmYOfensivePosition.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nmYOfensivePosition.Name = "nmYOfensivePosition";
            this.nmYOfensivePosition.Size = new System.Drawing.Size(100, 20);
            this.nmYOfensivePosition.TabIndex = 6;
            this.nmYOfensivePosition.ValueChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // tbTriggerKey
            // 
            this.tbTriggerKey.Location = new System.Drawing.Point(164, 31);
            this.tbTriggerKey.Name = "tbTriggerKey";
            this.tbTriggerKey.ReadOnly = true;
            this.tbTriggerKey.Size = new System.Drawing.Size(100, 20);
            this.tbTriggerKey.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trigger key:";
            // 
            // cbMouseButton
            // 
            this.cbMouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMouseButton.FormattingEnabled = true;
            this.cbMouseButton.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cbMouseButton.Location = new System.Drawing.Point(163, 163);
            this.cbMouseButton.Name = "cbMouseButton";
            this.cbMouseButton.Size = new System.Drawing.Size(101, 21);
            this.cbMouseButton.TabIndex = 10;
            this.cbMouseButton.SelectedIndexChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Drop inventory mouse key:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Delay before open inventory:";
            // 
            // nmDelayBeforeOpenInventory
            // 
            this.nmDelayBeforeOpenInventory.Location = new System.Drawing.Point(164, 111);
            this.nmDelayBeforeOpenInventory.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmDelayBeforeOpenInventory.Name = "nmDelayBeforeOpenInventory";
            this.nmDelayBeforeOpenInventory.Size = new System.Drawing.Size(100, 20);
            this.nmDelayBeforeOpenInventory.TabIndex = 12;
            this.nmDelayBeforeOpenInventory.ValueChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Delay after open inventory:";
            // 
            // nmDelayAfterOpenInventory
            // 
            this.nmDelayAfterOpenInventory.Location = new System.Drawing.Point(164, 137);
            this.nmDelayAfterOpenInventory.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmDelayAfterOpenInventory.Name = "nmDelayAfterOpenInventory";
            this.nmDelayAfterOpenInventory.Size = new System.Drawing.Size(100, 20);
            this.nmDelayAfterOpenInventory.TabIndex = 15;
            this.nmDelayAfterOpenInventory.ValueChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // lbScreenHalf
            // 
            this.lbScreenHalf.AutoSize = true;
            this.lbScreenHalf.Location = new System.Drawing.Point(305, 62);
            this.lbScreenHalf.Name = "lbScreenHalf";
            this.lbScreenHalf.Size = new System.Drawing.Size(64, 13);
            this.lbScreenHalf.TabIndex = 18;
            this.lbScreenHalf.Text = "Screen half:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "ms";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Hold grenade for:";
            // 
            // nmDelayHoldGrenadeFor
            // 
            this.nmDelayHoldGrenadeFor.Location = new System.Drawing.Point(164, 85);
            this.nmDelayHoldGrenadeFor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmDelayHoldGrenadeFor.Name = "nmDelayHoldGrenadeFor";
            this.nmDelayHoldGrenadeFor.Size = new System.Drawing.Size(100, 20);
            this.nmDelayHoldGrenadeFor.TabIndex = 19;
            this.nmDelayHoldGrenadeFor.ValueChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Number of drop clicks:";
            // 
            // nmDropClicks
            // 
            this.nmDropClicks.Location = new System.Drawing.Point(164, 190);
            this.nmDropClicks.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmDropClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmDropClicks.Name = "nmDropClicks";
            this.nmDropClicks.Size = new System.Drawing.Size(100, 20);
            this.nmDropClicks.TabIndex = 22;
            this.nmDropClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmDropClicks.ValueChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(270, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "ms";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Delay between clicks:";
            // 
            // nmDelayBetweenClicks
            // 
            this.nmDelayBetweenClicks.Location = new System.Drawing.Point(164, 216);
            this.nmDelayBetweenClicks.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmDelayBetweenClicks.Name = "nmDelayBetweenClicks";
            this.nmDelayBetweenClicks.Size = new System.Drawing.Size(100, 20);
            this.nmDelayBetweenClicks.TabIndex = 24;
            this.nmDelayBetweenClicks.ValueChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Location = new System.Drawing.Point(353, 5);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(134, 23);
            this.btnResetSettings.TabIndex = 27;
            this.btnResetSettings.Text = "Reset settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.EventValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(76, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Trigger method:";
            // 
            // cbTriggerMethod
            // 
            this.cbTriggerMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTriggerMethod.FormattingEnabled = true;
            this.cbTriggerMethod.Items.AddRange(new object[] {
            "Manual thrown",
            "Auto thrown"});
            this.cbTriggerMethod.Location = new System.Drawing.Point(163, 57);
            this.cbTriggerMethod.Name = "cbTriggerMethod";
            this.cbTriggerMethod.Size = new System.Drawing.Size(101, 21);
            this.cbTriggerMethod.TabIndex = 28;
            this.cbTriggerMethod.SelectedIndexChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // cbIsEnabled
            // 
            this.cbIsEnabled.AutoSize = true;
            this.cbIsEnabled.Location = new System.Drawing.Point(273, 33);
            this.cbIsEnabled.Name = "cbIsEnabled";
            this.cbIsEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbIsEnabled.TabIndex = 30;
            this.cbIsEnabled.Text = "Enabled";
            this.cbIsEnabled.UseVisualStyleBackColor = true;
            this.cbIsEnabled.CheckedChanged += new System.EventHandler(this.EventValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(305, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(266, 60);
            this.label17.TabIndex = 31;
            this.label17.Text = "Warning: While this help alot, \r\nthe guys are not here to make friends,\r\nIs highl" +
    "y advised to refill your lube stock!\r\nBeware where the arm goes!";
            // 
            // lbTriggerLifetimeCount
            // 
            this.lbTriggerLifetimeCount.AutoSize = true;
            this.lbTriggerLifetimeCount.Location = new System.Drawing.Point(49, 247);
            this.lbTriggerLifetimeCount.Name = "lbTriggerLifetimeCount";
            this.lbTriggerLifetimeCount.Size = new System.Drawing.Size(126, 13);
            this.lbTriggerLifetimeCount.TabIndex = 32;
            this.lbTriggerLifetimeCount.Text = "Lifetime trigger count:    0";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 273);
            this.Controls.Add(this.lbTriggerLifetimeCount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbIsEnabled);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbTriggerMethod);
            this.Controls.Add(this.btnResetSettings);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nmDelayBetweenClicks);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nmDropClicks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nmDelayHoldGrenadeFor);
            this.Controls.Add(this.lbScreenHalf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmDelayAfterOpenInventory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmDelayBeforeOpenInventory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMouseButton);
            this.Controls.Add(this.tbTriggerKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmYOfensivePosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmXOfensivePosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnfocus);
            this.Controls.Add(this.tbInventoryKey);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Anti Guy do Pietra";
            ((System.ComponentModel.ISupportInitialize)(this.nmXOfensivePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYOfensivePosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayBeforeOpenInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayAfterOpenInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayHoldGrenadeFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDropClicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDelayBetweenClicks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInventoryKey;
        private System.Windows.Forms.Button btnUnfocus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmXOfensivePosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmYOfensivePosition;
        private System.Windows.Forms.TextBox tbTriggerKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMouseButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmDelayBeforeOpenInventory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmDelayAfterOpenInventory;
        private System.Windows.Forms.Label lbScreenHalf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmDelayHoldGrenadeFor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nmDropClicks;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nmDelayBetweenClicks;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbTriggerMethod;
        private System.Windows.Forms.CheckBox cbIsEnabled;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbTriggerLifetimeCount;
    }
}

