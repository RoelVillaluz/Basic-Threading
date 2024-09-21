namespace _04Laboratory_Exercise
{
    partial class FrmBasicThread
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblThread = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Font = new Font("Segoe UI", 20F);
            lblThread.Location = new Point(46, 55);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(310, 37);
            lblThread.TabIndex = 0;
            lblThread.Text = "- Before starting thread -";
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Segoe UI", 14F);
            btnRun.Location = new Point(139, 139);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(100, 41);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 239);
            Controls.Add(btnRun);
            Controls.Add(lblThread);
            Name = "FrmBasicThread";
            Text = "Basic Thread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThread;
        private Button btnRun;
    }
}
