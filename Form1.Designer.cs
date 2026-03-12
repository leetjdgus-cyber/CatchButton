namespace CatchButton
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
            RunButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // RunButton
            // 
            RunButton.BackColor = SystemColors.ActiveCaption;
            RunButton.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            RunButton.Location = new Point(339, 172);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(143, 75);
            RunButton.TabIndex = 0;
            RunButton.Text = "나를 잡아봐";
            RunButton.UseVisualStyleBackColor = false;
            RunButton.Click += RunButton_Click;
            RunButton.MouseEnter += button1_MouseEnter;
            // 
            // button1
            // 
            button1.Location = new Point(102, 388);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "다시 시작";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(RunButton);
            Name = "Form1";
            Text = "ㅌ";
            Load += Form1_Load;
            MouseEnter += Form1_MouseEnter;
            ResumeLayout(false);
        }

        #endregion

        private Button RunButton;
        private Button button1;
    }
}
