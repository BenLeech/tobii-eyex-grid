namespace TobiiEyeXGrid
{
    partial class Form1
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
            this.btnToggleGaze = new System.Windows.Forms.Button();
            this.checkBoxGridSnap = new System.Windows.Forms.CheckBox();
            this.checkboxShowGrid = new System.Windows.Forms.CheckBox();
            this.btnClearDrawing = new System.Windows.Forms.Button();
            this.panel1 = new TobiiEyeXGrid.GridPanel();
            this.SuspendLayout();
            // 
            // btnToggleGaze
            // 
            this.btnToggleGaze.Location = new System.Drawing.Point(13, 13);
            this.btnToggleGaze.Name = "btnToggleGaze";
            this.btnToggleGaze.Size = new System.Drawing.Size(200, 23);
            this.btnToggleGaze.TabIndex = 1;
            this.btnToggleGaze.Text = "Toggle Gaze Control   ( t )";
            this.btnToggleGaze.UseVisualStyleBackColor = true;
            // 
            // checkBoxGridSnap
            // 
            this.checkBoxGridSnap.AutoSize = true;
            this.checkBoxGridSnap.Checked = true;
            this.checkBoxGridSnap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGridSnap.Location = new System.Drawing.Point(231, 18);
            this.checkBoxGridSnap.Name = "checkBoxGridSnap";
            this.checkBoxGridSnap.Size = new System.Drawing.Size(85, 17);
            this.checkBoxGridSnap.TabIndex = 2;
            this.checkBoxGridSnap.Text = "Snap to Grid";
            this.checkBoxGridSnap.UseVisualStyleBackColor = true;
            // 
            // checkboxShowGrid
            // 
            this.checkboxShowGrid.AutoSize = true;
            this.checkboxShowGrid.Checked = true;
            this.checkboxShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxShowGrid.Location = new System.Drawing.Point(349, 18);
            this.checkboxShowGrid.Name = "checkboxShowGrid";
            this.checkboxShowGrid.Size = new System.Drawing.Size(103, 17);
            this.checkboxShowGrid.TabIndex = 3;
            this.checkboxShowGrid.Text = "Show Grid Lines";
            this.checkboxShowGrid.UseVisualStyleBackColor = true;
            // 
            // btnClearDrawing
            // 
            this.btnClearDrawing.Location = new System.Drawing.Point(1087, 12);
            this.btnClearDrawing.Name = "btnClearDrawing";
            this.btnClearDrawing.Size = new System.Drawing.Size(167, 23);
            this.btnClearDrawing.TabIndex = 4;
            this.btnClearDrawing.Text = "Clear Drawing";
            this.btnClearDrawing.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 602);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 656);
            this.Controls.Add(this.btnClearDrawing);
            this.Controls.Add(this.checkboxShowGrid);
            this.Controls.Add(this.checkBoxGridSnap);
            this.Controls.Add(this.btnToggleGaze);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Tobii Eye Tracking Grid Draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridPanel panel1;
        private System.Windows.Forms.Button btnToggleGaze;
        private System.Windows.Forms.CheckBox checkBoxGridSnap;
        private System.Windows.Forms.CheckBox checkboxShowGrid;
        private System.Windows.Forms.Button btnClearDrawing;
    }
}

