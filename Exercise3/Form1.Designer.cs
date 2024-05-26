namespace Exercise3
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
            HelloButton = new Button();
            WorldButton = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // HelloButton
            // 
            HelloButton.Location = new Point(54, 91);
            HelloButton.Name = "HelloButton";
            HelloButton.Size = new Size(131, 40);
            HelloButton.TabIndex = 0;
            HelloButton.Text = "\"Hello, \"";
            HelloButton.UseVisualStyleBackColor = true;
            HelloButton.Click += HelloButton_Click;
            // 
            // WorldButton
            // 
            WorldButton.Location = new Point(212, 91);
            WorldButton.Name = "WorldButton";
            WorldButton.Size = new Size(131, 40);
            WorldButton.TabIndex = 1;
            WorldButton.Text = "\"World! \"";
            WorldButton.UseVisualStyleBackColor = true;
            WorldButton.Click += WorldButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(364, 91);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(131, 40);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 247);
            Controls.Add(ClearButton);
            Controls.Add(WorldButton);
            Controls.Add(HelloButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button HelloButton;
        private Button WorldButton;
        private Button ClearButton;
    }
}
