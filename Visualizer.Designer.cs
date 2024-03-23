namespace BalancedTreeLab
{
    partial class Visualizer
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
            /*if (disposing && (components != null))
            {
                components.Dispose();
            }*/
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxView = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxView
            // 
            textBoxView.Font = new Font("Microsoft Sans Serif", 16F);
            textBoxView.Location = new Point(3, 58);
            textBoxView.Margin = new Padding(4, 5, 4, 5);
            textBoxView.Multiline = true;
            textBoxView.Name = "textBoxView";
            textBoxView.ReadOnly = true;
            textBoxView.ScrollBars = ScrollBars.Both;
            textBoxView.Size = new Size(869, 600);
            textBoxView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.Location = new Point(3, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 39);
            label1.TabIndex = 2;
            label1.Text = "Current Tree:";
            // 
            // Visualizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 663);
            Controls.Add(label1);
            Controls.Add(textBoxView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Visualizer";
            Text = "Visualizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxView;
        private System.Windows.Forms.Label label1;
    }
}