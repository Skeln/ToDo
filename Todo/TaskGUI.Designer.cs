namespace Todo
{
    partial class TaskGUI
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
      this.addTaskButton = new System.Windows.Forms.Button();
      this.mainTaskPanel = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // addTaskButton
      // 
      this.addTaskButton.BackColor = System.Drawing.Color.MediumSeaGreen;
      this.addTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addTaskButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addTaskButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.addTaskButton.Location = new System.Drawing.Point(523, 13);
      this.addTaskButton.Name = "addTaskButton";
      this.addTaskButton.Size = new System.Drawing.Size(134, 33);
      this.addTaskButton.TabIndex = 0;
      this.addTaskButton.Text = "Add task";
      this.addTaskButton.UseVisualStyleBackColor = false;
      // 
      // mainTaskPanel
      // 
      this.mainTaskPanel.AutoScroll = true;
      this.mainTaskPanel.BackColor = System.Drawing.SystemColors.ControlLight;
      this.mainTaskPanel.Location = new System.Drawing.Point(12, 64);
      this.mainTaskPanel.Name = "mainTaskPanel";
      this.mainTaskPanel.Size = new System.Drawing.Size(645, 314);
      this.mainTaskPanel.TabIndex = 1;
      // 
      // TaskGUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ClientSize = new System.Drawing.Size(669, 390);
      this.Controls.Add(this.mainTaskPanel);
      this.Controls.Add(this.addTaskButton);
      this.Name = "TaskGUI";
      this.Text = "ToDo-Application";
      this.MouseEnter += new System.EventHandler(this.FocusPanel);
      this.MouseHover += new System.EventHandler(this.FocusPanel);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Panel mainTaskPanel;
    }
}