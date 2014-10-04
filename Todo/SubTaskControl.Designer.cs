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
      this.SubTaskLabel = new System.Windows.Forms.Label();
      this.doneCkBx = new System.Windows.Forms.CheckBox();
      this.removeSubTaskBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // SubTaskLabel
      // 
      this.SubTaskLabel.AutoSize = true;
      this.SubTaskLabel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SubTaskLabel.Location = new System.Drawing.Point(8, 6);
      this.SubTaskLabel.Name = "SubTaskLabel";
      this.SubTaskLabel.Size = new System.Drawing.Size(54, 13);
      this.SubTaskLabel.TabIndex = 0;
      this.SubTaskLabel.Text = "SubTask";
      // 
      // doneCkBx
      // 
      this.doneCkBx.AutoSize = true;
      this.doneCkBx.Location = new System.Drawing.Point(381, 4);
      this.doneCkBx.Name = "doneCkBx";
      this.doneCkBx.Size = new System.Drawing.Size(52, 17);
      this.doneCkBx.TabIndex = 1;
      this.doneCkBx.Text = "Done";
      this.doneCkBx.UseVisualStyleBackColor = true;
      // 
      // removeSubTaskBtn
      // 
      this.removeSubTaskBtn.BackColor = System.Drawing.Color.Crimson;
      this.removeSubTaskBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.removeSubTaskBtn.FlatAppearance.BorderSize = 0;
      this.removeSubTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.removeSubTaskBtn.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.removeSubTaskBtn.ForeColor = System.Drawing.Color.White;
      this.removeSubTaskBtn.Location = new System.Drawing.Point(356, 3);
      this.removeSubTaskBtn.Name = "removeSubTaskBtn";
      this.removeSubTaskBtn.Size = new System.Drawing.Size(19, 19);
      this.removeSubTaskBtn.TabIndex = 2;
      this.removeSubTaskBtn.Text = "-";
      this.removeSubTaskBtn.UseVisualStyleBackColor = false;
      // 
      // SubTaskControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.removeSubTaskBtn);
      this.Controls.Add(this.doneCkBx);
      this.Controls.Add(this.SubTaskLabel);
      this.Name = "SubTaskControl";
      this.Size = new System.Drawing.Size(437, 27);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubTaskLabel;
        private System.Windows.Forms.CheckBox doneCkBx;
        private System.Windows.Forms.Button removeSubTaskBtn;
    }
}
