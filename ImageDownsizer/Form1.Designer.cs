namespace ImageDownsizer
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
            this.parallelRadioButton = new System.Windows.Forms.RadioButton();
            this.sequentialRadioButton = new System.Windows.Forms.RadioButton();
            this.browseButton = new System.Windows.Forms.Button();
            this.factorTextBox = new System.Windows.Forms.TextBox();
            this.downscaleButton = new System.Windows.Forms.Button();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.downscaledPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downscaledPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // parallelRadioButton
            // 
            this.parallelRadioButton.AutoSize = true;
            this.parallelRadioButton.Location = new System.Drawing.Point(392, 121);
            this.parallelRadioButton.Name = "parallelRadioButton";
            this.parallelRadioButton.Size = new System.Drawing.Size(91, 29);
            this.parallelRadioButton.TabIndex = 0;
            this.parallelRadioButton.TabStop = true;
            this.parallelRadioButton.Text = "Parallel";
            this.parallelRadioButton.UseVisualStyleBackColor = true;
            // 
            // sequentialRadioButton
            // 
            this.sequentialRadioButton.AutoSize = true;
            this.sequentialRadioButton.Location = new System.Drawing.Point(168, 121);
            this.sequentialRadioButton.Name = "sequentialRadioButton";
            this.sequentialRadioButton.Size = new System.Drawing.Size(119, 29);
            this.sequentialRadioButton.TabIndex = 1;
            this.sequentialRadioButton.TabStop = true;
            this.sequentialRadioButton.Text = "Sequential";
            this.sequentialRadioButton.UseVisualStyleBackColor = true;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(261, 43);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(112, 34);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // factorTextBox
            // 
            this.factorTextBox.Location = new System.Drawing.Point(26, 43);
            this.factorTextBox.Name = "factorTextBox";
            this.factorTextBox.Size = new System.Drawing.Size(211, 31);
            this.factorTextBox.TabIndex = 3;
            // 
            // downscaleButton
            // 
            this.downscaleButton.Location = new System.Drawing.Point(157, 250);
            this.downscaleButton.Name = "downscaleButton";
            this.downscaleButton.Size = new System.Drawing.Size(152, 34);
            this.downscaleButton.TabIndex = 4;
            this.downscaleButton.Text = "Downscale";
            this.downscaleButton.UseVisualStyleBackColor = true;
            this.downscaleButton.Click += new System.EventHandler(this.downscaleButton_Click);
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Location = new System.Drawing.Point(176, 312);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(230, 141);
            this.originalPictureBox.TabIndex = 5;
            this.originalPictureBox.TabStop = false;
            // 
            // downscaledPictureBox
            // 
            this.downscaledPictureBox.Location = new System.Drawing.Point(521, 312);
            this.downscaledPictureBox.Name = "downscaledPictureBox";
            this.downscaledPictureBox.Size = new System.Drawing.Size(222, 141);
            this.downscaledPictureBox.TabIndex = 6;
            this.downscaledPictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 530);
            this.Controls.Add(this.downscaledPictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.downscaleButton);
            this.Controls.Add(this.factorTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.sequentialRadioButton);
            this.Controls.Add(this.parallelRadioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downscaledPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton parallelRadioButton;
        private RadioButton sequentialRadioButton;
        private Button browseButton;
        private TextBox factorTextBox;
        private Button downscaleButton;
        private PictureBox originalPictureBox;
        private PictureBox downscaledPictureBox;
        private OpenFileDialog openFileDialog;
    }
}