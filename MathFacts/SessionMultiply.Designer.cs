namespace MathFacts
{
    partial class SessionMultiply
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
            this.closeButton = new System.Windows.Forms.Button();
            this.factorLabel1 = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.correctLabel = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelInstructionsStart = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(734, 436);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(131, 39);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // factorLabel1
            // 
            this.factorLabel1.AutoSize = true;
            this.factorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.factorLabel1.Location = new System.Drawing.Point(142, 91);
            this.factorLabel1.Name = "factorLabel1";
            this.factorLabel1.Size = new System.Drawing.Size(231, 69);
            this.factorLabel1.TabIndex = 11;
            this.factorLabel1.Text = "__ x __";
            this.factorLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerBox
            // 
            this.answerBox.CausesValidation = false;
            this.answerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.Location = new System.Drawing.Point(433, 85);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(164, 75);
            this.answerBox.TabIndex = 13;
            this.answerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answerBox_KeyDown);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(444, 218);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 46);
            this.scoreLabel.TabIndex = 14;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(87, 436);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(129, 41);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(256, 436);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(129, 41);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "Stop!";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctLabel.Location = new System.Drawing.Point(631, 104);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(134, 38);
            this.correctLabel.TabIndex = 19;
            this.correctLabel.Text = "Correct!";
            this.correctLabel.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(433, 176);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(136, 39);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = "Next Problem";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(82, 298);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(683, 29);
            this.labelInstructions.TabIndex = 21;
            this.labelInstructions.Text = "Enter your answer to the problem in the white box and hit enter.";
            // 
            // labelInstructionsStart
            // 
            this.labelInstructionsStart.AutoSize = true;
            this.labelInstructionsStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructionsStart.Location = new System.Drawing.Point(82, 337);
            this.labelInstructionsStart.Name = "labelInstructionsStart";
            this.labelInstructionsStart.Size = new System.Drawing.Size(337, 29);
            this.labelInstructionsStart.TabIndex = 22;
            this.labelInstructionsStart.Text = "Click the Start! button to begin!";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 505);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // SessionMultiply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(989, 524);
            this.Controls.Add(this.labelInstructionsStart);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.factorLabel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "SessionMultiply";
            this.Text = "Multiply!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SessionMultiply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label factorLabel1;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelInstructionsStart;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}