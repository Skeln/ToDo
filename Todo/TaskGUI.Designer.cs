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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(523, 13);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(134, 23);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 326);
            this.panel1.TabIndex = 1;
            // 
            // TaskGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addTaskButton);
            this.Name = "TaskGUI";
            this.Text = "ToDo-Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Panel panel1;
    }
}