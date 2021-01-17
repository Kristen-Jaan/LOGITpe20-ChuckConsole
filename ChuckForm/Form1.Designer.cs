
namespace ChuckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.getJokeBTN = new System.Windows.Forms.Button();
            this.JokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // getJokeBTN
            // 
            this.getJokeBTN.Location = new System.Drawing.Point(392, 34);
            this.getJokeBTN.Name = "getJokeBTN";
            this.getJokeBTN.Size = new System.Drawing.Size(112, 34);
            this.getJokeBTN.TabIndex = 0;
            this.getJokeBTN.Text = "Get Joke";
            this.getJokeBTN.UseVisualStyleBackColor = true;
            this.getJokeBTN.Click += new System.EventHandler(this.getJokeBTN_Click);
            // 
            // JokeBox
            // 
            this.JokeBox.Location = new System.Drawing.Point(311, 177);
            this.JokeBox.Name = "JokeBox";
            this.JokeBox.Size = new System.Drawing.Size(309, 234);
            this.JokeBox.TabIndex = 1;
            this.JokeBox.Text = "Get a joke. I dare you mtf";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 411);
            this.Controls.Add(this.JokeBox);
            this.Controls.Add(this.getJokeBTN);
            this.Name = "Form1";
            this.Text = "Chuck Norris Funny Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getJokeBTN;
        private System.Windows.Forms.RichTextBox JokeBox;
    }
}

