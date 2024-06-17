namespace 專題_勇者升級之路
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
            btnDrawCard = new Button();
            SuspendLayout();
            // 
            // btnDrawCard
            // 
            btnDrawCard.Location = new Point(297, 307);
            btnDrawCard.Name = "btnDrawCard";
            btnDrawCard.Size = new Size(157, 44);
            btnDrawCard.TabIndex = 1;
            btnDrawCard.Text = "抽落去！";
            btnDrawCard.UseVisualStyleBackColor = true;
            btnDrawCard.Click += btnDrawCard_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDrawCard);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button btnDrawCard;
    }
}
