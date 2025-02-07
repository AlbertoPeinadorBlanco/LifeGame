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
            components = new System.ComponentModel.Container();
            pbGrid = new PictureBox();
            btnNext = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
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
            // btnNext
            // 
            btnNext.Location = new Point(344, 852);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 1;
            btnNext.Text = "Start";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // timer1
            // 
            timer1.Interval = 700;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(512, 852);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 944);
            Controls.Add(button1);
            Controls.Add(btnNext);
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
        private Button btnNext;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}
