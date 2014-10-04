namespace Todo
{
    partial class TodoGUI
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
            this.mainTaskPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTaskButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTaskButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addTaskButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addTaskButton.Location = new System.Drawing.Point(490, 12);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(134, 33);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Add task";
            this.addTaskButton.UseVisualStyleBackColor = false;
            // 
            // mainTaskPanel
            // 
            this.mainTaskPanel.AutoScroll = true;
            this.mainTaskPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainTaskPanel.Location = new System.Drawing.Point(12, 64);
            this.mainTaskPanel.Name = "mainTaskPanel";
            this.mainTaskPanel.Size = new System.Drawing.Size(612, 328);
            this.mainTaskPanel.TabIndex = 2;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(636, 430);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.White;
            this.lineShape1.X1 = 14;
            this.lineShape1.X2 = 623;
            this.lineShape1.Y1 = 52;
            this.lineShape1.Y2 = 53;
            // 
            // TaskGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(636, 430);
            this.Controls.Add(this.mainTaskPanel);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaskGUI";
            this.Text = "ToDo-Application";
            this.MouseEnter += new System.EventHandler(this.FocusPanel);
            this.MouseHover += new System.EventHandler(this.FocusPanel);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainTaskPanel;
        private System.Windows.Forms.Button addTaskButton;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;

    }
}