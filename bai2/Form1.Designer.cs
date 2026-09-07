namespace bai2
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
            btnClickMe = new Button();
            SuspendLayout();
            // 
            // btnClickMe
            // 
            btnClickMe.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClickMe.ForeColor = Color.Red;
            btnClickMe.Location = new Point(174, 107);
            btnClickMe.Name = "btnClickMe";
            btnClickMe.Size = new Size(469, 220);
            btnClickMe.TabIndex = 0;
            btnClickMe.Text = "Click me";
            btnClickMe.UseVisualStyleBackColor = true;
            btnClickMe.Click += btnClick_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClickMe);
            Name = "Form1";
            Text = "Simple Event Exanple";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button btnClickMe;
    }
}
