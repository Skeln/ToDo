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
            this.button1 = new System.Windows.Forms.Button();
            this.subTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubTaskPanel = new System.Windows.Forms.Panel();
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
            this.taskDescription.Location = new System.Drawing.Point(12, 43);
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(450, 20);
            this.taskDescription.TabIndex = 1;
            // 
            // checkDoneCkBx
            // 
            this.checkDoneCkBx.AutoSize = true;
            this.checkDoneCkBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDoneCkBx.Location = new System.Drawing.Point(410, 13);
            this.checkDoneCkBx.Name = "checkDoneCkBx";
            this.checkDoneCkBx.Size = new System.Drawing.Size(60, 20);
            this.checkDoneCkBx.TabIndex = 2;
            this.checkDoneCkBx.Text = "Done";
            this.checkDoneCkBx.UseVisualStyleBackColor = true;
            // 
            // removeTaskBtn
            // 
            this.removeTaskBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTaskBtn.Location = new System.Drawing.Point(377, 9);
            this.removeTaskBtn.Name = "removeTaskBtn";
            this.removeTaskBtn.Size = new System.Drawing.Size(27, 24);
            this.removeTaskBtn.TabIndex = 3;
            this.removeTaskBtn.Text = "-";
            this.removeTaskBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // subTaskBindingSource
            // 
            this.subTaskBindingSource.DataSource = typeof(Todo.SubTask);
            // 
            // SubTaskPanel
            // 
            this.SubTaskPanel.Location = new System.Drawing.Point(12, 70);
            this.SubTaskPanel.Name = "SubTaskPanel";
            this.SubTaskPanel.Size = new System.Drawing.Size(450, 63);
            this.SubTaskPanel.TabIndex = 5;
            // 
            // MainTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubTaskPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeTaskBtn);
            this.Controls.Add(this.checkDoneCkBx);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.taskName);
            this.Name = "MainTaskControl";
            this.Size = new System.Drawing.Size(476, 142);
            ((System.ComponentModel.ISupportInitialize)(this.subTaskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.TextBox taskDescription;
        private System.Windows.Forms.CheckBox checkDoneCkBx;
        private System.Windows.Forms.Button removeTaskBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource subTaskBindingSource;
        private System.Windows.Forms.Panel SubTaskPanel;
    }
}
