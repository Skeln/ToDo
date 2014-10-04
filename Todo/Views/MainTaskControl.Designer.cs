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
            this.components = new System.ComponentModel.Container();
            this.taskName = new System.Windows.Forms.Label();
            this.taskDescription = new System.Windows.Forms.TextBox();
            this.checkDoneCkBx = new System.Windows.Forms.CheckBox();
            this.removeTaskBtn = new System.Windows.Forms.Button();
            this.addSubTaskBtn = new System.Windows.Forms.Button();
            this.SubTaskPanel = new System.Windows.Forms.Panel();
            this.subTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.subTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(9, 10);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(45, 19);
            this.taskName.TabIndex = 0;
            this.taskName.Text = "Task";
            // 
            // taskDescription
            // 
            this.taskDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDescription.Location = new System.Drawing.Point(12, 43);
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(554, 20);
            this.taskDescription.TabIndex = 1;
            // 
            // checkDoneCkBx
            // 
            this.checkDoneCkBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkDoneCkBx.AutoSize = true;
            this.checkDoneCkBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDoneCkBx.Location = new System.Drawing.Point(506, 11);
            this.checkDoneCkBx.Name = "checkDoneCkBx";
            this.checkDoneCkBx.Size = new System.Drawing.Size(60, 20);
            this.checkDoneCkBx.TabIndex = 2;
            this.checkDoneCkBx.Text = "Done";
            this.checkDoneCkBx.UseVisualStyleBackColor = true;
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
            this.removeTaskBtn.Location = new System.Drawing.Point(470, 6);
            this.removeTaskBtn.Name = "removeTaskBtn";
            this.removeTaskBtn.Size = new System.Drawing.Size(30, 30);
            this.removeTaskBtn.TabIndex = 3;
            this.removeTaskBtn.Text = "-";
            this.removeTaskBtn.UseVisualStyleBackColor = false;
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
            this.addSubTaskBtn.Location = new System.Drawing.Point(434, 6);
            this.addSubTaskBtn.Name = "addSubTaskBtn";
            this.addSubTaskBtn.Size = new System.Drawing.Size(30, 30);
            this.addSubTaskBtn.TabIndex = 4;
            this.addSubTaskBtn.Text = "+";
            this.addSubTaskBtn.UseVisualStyleBackColor = false;
            // 
            // SubTaskPanel
            // 
            this.SubTaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubTaskPanel.Location = new System.Drawing.Point(12, 70);
            this.SubTaskPanel.Name = "SubTaskPanel";
            this.SubTaskPanel.Size = new System.Drawing.Size(554, 44);
            this.SubTaskPanel.TabIndex = 5;
            // 
            // subTaskBindingSource
            // 
            this.subTaskBindingSource.DataSource = typeof(Todo.SubTask);
            // 
            // MainTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.SubTaskPanel);
            this.Controls.Add(this.addSubTaskBtn);
            this.Controls.Add(this.removeTaskBtn);
            this.Controls.Add(this.checkDoneCkBx);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.taskName);
            this.DoubleBuffered = true;
            this.Name = "MainTaskControl";
            this.Size = new System.Drawing.Size(583, 126);
            ((System.ComponentModel.ISupportInitialize)(this.subTaskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.TextBox taskDescription;
        private System.Windows.Forms.CheckBox checkDoneCkBx;
        private System.Windows.Forms.Button removeTaskBtn;
        private System.Windows.Forms.Button addSubTaskBtn;
        private System.Windows.Forms.BindingSource subTaskBindingSource;
        private System.Windows.Forms.Panel SubTaskPanel;
    }
}
