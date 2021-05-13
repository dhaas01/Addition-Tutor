namespace Addition_Tutor__10_
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
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.answerTextLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.checkAnswerLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.checkAnswerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(53, 41);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(116, 13);
            this.questionTextLabel.TabIndex = 0;
            this.questionTextLabel.Text = "Calculate the following:";
            // 
            // answerTextLabel
            // 
            this.answerTextLabel.AutoSize = true;
            this.answerTextLabel.Location = new System.Drawing.Point(50, 105);
            this.answerTextLabel.Name = "answerTextLabel";
            this.answerTextLabel.Size = new System.Drawing.Size(119, 13);
            this.answerTextLabel.TabIndex = 1;
            this.answerTextLabel.Text = "Enter your answer here:";
            // 
            // questionLabel
            // 
            this.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionLabel.Location = new System.Drawing.Point(208, 36);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(190, 23);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkAnswerLabel
            // 
            this.checkAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkAnswerLabel.Location = new System.Drawing.Point(53, 159);
            this.checkAnswerLabel.Name = "checkAnswerLabel";
            this.checkAnswerLabel.Size = new System.Drawing.Size(345, 23);
            this.checkAnswerLabel.TabIndex = 3;
            this.checkAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(208, 102);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(190, 20);
            this.answerTextBox.TabIndex = 4;
            // 
            // checkAnswerButton
            // 
            this.checkAnswerButton.Location = new System.Drawing.Point(53, 210);
            this.checkAnswerButton.Name = "checkAnswerButton";
            this.checkAnswerButton.Size = new System.Drawing.Size(140, 42);
            this.checkAnswerButton.TabIndex = 5;
            this.checkAnswerButton.Text = "Check Answer";
            this.checkAnswerButton.UseVisualStyleBackColor = true;
            this.checkAnswerButton.Click += new System.EventHandler(this.CheckAnswerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(323, 210);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 42);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hint: Enter 0 to begin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 274);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkAnswerButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.checkAnswerLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerTextLabel);
            this.Controls.Add(this.questionTextLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Label answerTextLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label checkAnswerLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button checkAnswerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

