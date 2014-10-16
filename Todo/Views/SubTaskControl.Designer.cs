namespace Todo
{
    partial class SubTaskControl
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
            this.subTaskLabel = new System.Windows.Forms.Label();
            this.doneCkBx = new System.Windows.Forms.CheckBox();
            this.removeSubTaskBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subTaskLabel
            // 
            this.subTaskLabel.AutoSize = true;
            this.subTaskLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subTaskLabel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTaskLabel.Location = new System.Drawing.Point(11, 5);
            this.subTaskLabel.Name = "subTaskLabel";
            this.subTaskLabel.Size = new System.Drawing.Size(54, 13);
            this.subTaskLabel.TabIndex = 0;
            this.subTaskLabel.Text = "SubTask";
            this.subTaskLabel.Click += new System.EventHandler(this.editSubTask_Click);
            // 
            // doneCkBx
            // 
            this.doneCkBx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.doneCkBx.AutoSize = true;
            this.doneCkBx.Location = new System.Drawing.Point(308, 4);
            this.doneCkBx.Name = "doneCkBx";
            this.doneCkBx.Size = new System.Drawing.Size(52, 17);
            this.doneCkBx.TabIndex = 1;
            this.doneCkBx.Text = "Done";
            this.doneCkBx.UseVisualStyleBackColor = true;
            this.doneCkBx.Click += new System.EventHandler(this.subTaskCheck_Click);
            // 
            // removeSubTaskBtn
            // 
            this.removeSubTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSubTaskBtn.BackColor = System.Drawing.Color.Crimson;
            this.removeSubTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeSubTaskBtn.FlatAppearance.BorderSize = 0;
            this.removeSubTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSubTaskBtn.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSubTaskBtn.ForeColor = System.Drawing.Color.White;
            this.removeSubTaskBtn.Location = new System.Drawing.Point(282, 2);
            this.removeSubTaskBtn.Name = "removeSubTaskBtn";
            this.removeSubTaskBtn.Size = new System.Drawing.Size(20, 20);
            this.removeSubTaskBtn.TabIndex = 2;
            this.removeSubTaskBtn.Text = "X";
            this.removeSubTaskBtn.UseVisualStyleBackColor = false;
            this.removeSubTaskBtn.Click += new System.EventHandler(this.removeSubTaskBtn_Click);
            // 
            // SubTaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.Controls.Add(this.removeSubTaskBtn);
            this.Controls.Add(this.doneCkBx);
            this.Controls.Add(this.subTaskLabel);
            this.Name = "SubTaskControl";
            this.Size = new System.Drawing.Size(368, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subTaskLabel;
        private System.Windows.Forms.CheckBox doneCkBx;
        private System.Windows.Forms.Button removeSubTaskBtn;
    }
}
