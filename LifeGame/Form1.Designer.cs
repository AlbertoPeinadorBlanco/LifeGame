namespace LifeGame
{
    partial class Form1
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
            pbGrid = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbGrid).BeginInit();
            SuspendLayout();
            // 
            // pbGrid
            // 
            pbGrid.Location = new Point(166, 12);
            pbGrid.Name = "pbGrid";
            pbGrid.Size = new Size(801, 801);
            pbGrid.TabIndex = 0;
            pbGrid.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 944);
            Controls.Add(pbGrid);
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(1000, 1000);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbGrid;
    }
}
