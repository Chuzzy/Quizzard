namespace Quizzard
{
    partial class QuestionForm
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
            this.questionBox = new System.Windows.Forms.RichTextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(12, 12);
            this.questionBox.Name = "questionBox";
            this.questionBox.ReadOnly = true;
            this.questionBox.Size = new System.Drawing.Size(307, 96);
            this.questionBox.TabIndex = 0;
            this.questionBox.Text = "Nice and \\b bold\\b0, but \\i smooth \\i0 as a snake.";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(12, 114);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 1;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeButton2
            // 
            this.changeButton2.Location = new System.Drawing.Point(93, 114);
            this.changeButton2.Name = "changeButton2";
            this.changeButton2.Size = new System.Drawing.Size(101, 23);
            this.changeButton2.TabIndex = 2;
            this.changeButton2.Text = "Format selected";
            this.changeButton2.UseVisualStyleBackColor = true;
            this.changeButton2.Click += new System.EventHandler(this.changeButton2_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.changeButton2);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.questionBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuestionForm";
            this.ShowIcon = false;
            this.Text = "QuestionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox questionBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button changeButton2;
    }
}