namespace IndianRailwaySeatLocator
{
    partial class SeatLocator
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
            this.lblClassType = new System.Windows.Forms.Label();
            this.cboClassType = new System.Windows.Forms.ComboBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.sleeperWidget = new IndianRailwaySeatLocator.Widgets.SleeperWidget();
            this.secondSittingWidget = new IndianRailwaySeatLocator.Widgets.SecondSittingWidget();
            this.SuspendLayout();
            // 
            // lblClassType
            // 
            this.lblClassType.AutoSize = true;
            this.lblClassType.Location = new System.Drawing.Point(12, 18);
            this.lblClassType.Name = "lblClassType";
            this.lblClassType.Size = new System.Drawing.Size(59, 13);
            this.lblClassType.TabIndex = 0;
            this.lblClassType.Text = "Class Type";
            // 
            // cboClassType
            // 
            this.cboClassType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassType.FormattingEnabled = true;
            this.cboClassType.Items.AddRange(new object[] {
            "Sleeper",
            "Second Sitting"});
            this.cboClassType.Location = new System.Drawing.Point(93, 15);
            this.cboClassType.Name = "cboClassType";
            this.cboClassType.Size = new System.Drawing.Size(121, 21);
            this.cboClassType.TabIndex = 1;
            this.cboClassType.SelectedIndexChanged += new System.EventHandler(this.cboClassType_SelectedIndexChanged);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(12, 48);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(21, 13);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "No";
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(93, 46);
            this.txtNo.MaxLength = 10;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(65, 20);
            this.txtNo.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(165, 44);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(49, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // sleeperWidget
            // 
            this.sleeperWidget.BackColor = System.Drawing.Color.White;
            this.sleeperWidget.Location = new System.Drawing.Point(27, 111);
            this.sleeperWidget.Name = "sleeperWidget";
            this.sleeperWidget.Size = new System.Drawing.Size(298, 87);
            this.sleeperWidget.TabIndex = 5;
            this.sleeperWidget.Visible = false;
            // 
            // secondSittingWidget
            // 
            this.secondSittingWidget.BackColor = System.Drawing.Color.White;
            this.secondSittingWidget.Location = new System.Drawing.Point(27, 111);
            this.secondSittingWidget.Name = "secondSittingWidget";
            this.secondSittingWidget.Size = new System.Drawing.Size(298, 75);
            this.secondSittingWidget.TabIndex = 4;
            this.secondSittingWidget.Visible = false;
            // 
            // SeatLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 262);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.cboClassType);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblClassType);
            this.Controls.Add(this.sleeperWidget);
            this.Controls.Add(this.secondSittingWidget);
            this.Name = "SeatLocator";
            this.Text = "SeatLocator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassType;
        private System.Windows.Forms.ComboBox cboClassType;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnGo;
        private Widgets.SecondSittingWidget secondSittingWidget;
        private Widgets.SleeperWidget sleeperWidget;
    }
}

