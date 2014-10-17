namespace Todo
{
    partial class MainTaskControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskName = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.checkDoneCkBx = new System.Windows.Forms.CheckBox();
            this.removeTaskBtn = new System.Windows.Forms.Button();
            this.addSubTaskBtn = new System.Windows.Forms.Button();
            this.SubTaskPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(9, 10);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(45, 19);
            this.taskName.TabIndex = 0;
            this.taskName.Text = "Task";
            this.taskName.Click += new System.EventHandler(this.editMainTask_click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionTextBox.BackColor = System.Drawing.Color.LightGray;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(15, 42);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(553, 25);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // checkDoneCkBx
            // 
            this.checkDoneCkBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkDoneCkBx.AutoSize = true;
            this.checkDoneCkBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDoneCkBx.Location = new System.Drawing.Point(508, 11);
            this.checkDoneCkBx.Name = "checkDoneCkBx";
            this.checkDoneCkBx.Size = new System.Drawing.Size(60, 20);
            this.checkDoneCkBx.TabIndex = 2;
            this.checkDoneCkBx.Text = "Done";
            this.checkDoneCkBx.UseVisualStyleBackColor = true;
            this.checkDoneCkBx.Click += new System.EventHandler(this.checkDoneCkBx_Click);
            // 
            // removeTaskBtn
            // 
            this.removeTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeTaskBtn.BackColor = System.Drawing.Color.Crimson;
            this.removeTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeTaskBtn.FlatAppearance.BorderSize = 0;
            this.removeTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTaskBtn.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTaskBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeTaskBtn.Location = new System.Drawing.Point(472, 6);
            this.removeTaskBtn.Name = "removeTaskBtn";
            this.removeTaskBtn.Size = new System.Drawing.Size(30, 30);
            this.removeTaskBtn.TabIndex = 3;
            this.removeTaskBtn.Text = "X";
            this.removeTaskBtn.UseVisualStyleBackColor = false;
            this.removeTaskBtn.Click += new System.EventHandler(this.removeTaskBtn_Click);
            // 
            // addSubTaskBtn
            // 
            this.addSubTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addSubTaskBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addSubTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addSubTaskBtn.FlatAppearance.BorderSize = 0;
            this.addSubTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSubTaskBtn.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubTaskBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addSubTaskBtn.Location = new System.Drawing.Point(436, 6);
            this.addSubTaskBtn.Name = "addSubTaskBtn";
            this.addSubTaskBtn.Size = new System.Drawing.Size(30, 30);
            this.addSubTaskBtn.TabIndex = 4;
            this.addSubTaskBtn.Text = "+";
            this.addSubTaskBtn.UseVisualStyleBackColor = false;
            this.addSubTaskBtn.Click += new System.EventHandler(this.addSubTaskBtn_Click);
            // 
            // SubTaskPanel
            // 
            this.SubTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubTaskPanel.AutoScroll = true;
            this.SubTaskPanel.BackColor = System.Drawing.Color.LightGray;
            this.SubTaskPanel.Location = new System.Drawing.Point(0, 70);
            this.SubTaskPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SubTaskPanel.Name = "SubTaskPanel";
            this.SubTaskPanel.Size = new System.Drawing.Size(568, 46);
            this.SubTaskPanel.TabIndex = 5;
            // 
            // MainTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.SubTaskPanel);
            this.Controls.Add(this.addSubTaskBtn);
            this.Controls.Add(this.removeTaskBtn);
            this.Controls.Add(this.checkDoneCkBx);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.taskName);
            this.DoubleBuffered = true;
            this.Name = "MainTaskControl";
            this.Size = new System.Drawing.Size(585, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox checkDoneCkBx;
        private System.Windows.Forms.Button removeTaskBtn;
        private System.Windows.Forms.Button addSubTaskBtn;
        private System.Windows.Forms.Panel SubTaskPanel;
    }
}
