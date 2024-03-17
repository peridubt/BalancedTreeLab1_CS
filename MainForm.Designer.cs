namespace BalancedTreeLab
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.linkedTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedTreeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unmutableTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayTreeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.linkedTreeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.unmutableTreeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contains10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oddevenValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startingWithLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oddValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startingWithSubstringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forEachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseBy1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseBy1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyOddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.oddToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyEvenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox.Location = new System.Drawing.Point(0, 27);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(686, 167);
            this.textBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkedTreeToolStripMenuItem,
            this.editToolStripMenuItem,
            this.utilsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // linkedTreeToolStripMenuItem
            // 
            this.linkedTreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integerToolStripMenuItem,
            this.stringToolStripMenuItem});
            this.linkedTreeToolStripMenuItem.Name = "linkedTreeToolStripMenuItem";
            this.linkedTreeToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.linkedTreeToolStripMenuItem.Text = "Tree";
            // 
            // integerToolStripMenuItem
            // 
            this.integerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayTreeToolStripMenuItem,
            this.linkedTreeToolStripMenuItem1,
            this.unmutableTreeToolStripMenuItem});
            this.integerToolStripMenuItem.Name = "integerToolStripMenuItem";
            this.integerToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.integerToolStripMenuItem.Text = "integer";
            // 
            // arrayTreeToolStripMenuItem
            // 
            this.arrayTreeToolStripMenuItem.Name = "arrayTreeToolStripMenuItem";
            this.arrayTreeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.arrayTreeToolStripMenuItem.Text = "Array Tree";
            this.arrayTreeToolStripMenuItem.Click += new System.EventHandler(this.CreateArrayTreeInt_Click);
            // 
            // linkedTreeToolStripMenuItem1
            // 
            this.linkedTreeToolStripMenuItem1.Name = "linkedTreeToolStripMenuItem1";
            this.linkedTreeToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.linkedTreeToolStripMenuItem1.Text = "Linked Tree";
            this.linkedTreeToolStripMenuItem1.Click += new System.EventHandler(this.CreateLinkedTreeInt_Click);
            // 
            // unmutableTreeToolStripMenuItem
            // 
            this.unmutableTreeToolStripMenuItem.Name = "unmutableTreeToolStripMenuItem";
            this.unmutableTreeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.unmutableTreeToolStripMenuItem.Text = "Unmutable Tree";
            this.unmutableTreeToolStripMenuItem.Click += new System.EventHandler(this.CreateUnmutableTreeInt_Click);
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayTreeToolStripMenuItem1,
            this.linkedTreeToolStripMenuItem2,
            this.unmutableTreeToolStripMenuItem1});
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.stringToolStripMenuItem.Text = "string";
            // 
            // arrayTreeToolStripMenuItem1
            // 
            this.arrayTreeToolStripMenuItem1.Name = "arrayTreeToolStripMenuItem1";
            this.arrayTreeToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.arrayTreeToolStripMenuItem1.Text = "Array Tree";
            this.arrayTreeToolStripMenuItem1.Click += new System.EventHandler(this.CreateArrayTreeStr_Click);
            // 
            // linkedTreeToolStripMenuItem2
            // 
            this.linkedTreeToolStripMenuItem2.Name = "linkedTreeToolStripMenuItem2";
            this.linkedTreeToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.linkedTreeToolStripMenuItem2.Text = "Linked Tree";
            this.linkedTreeToolStripMenuItem2.Click += new System.EventHandler(this.CreateLinkedTreeStr_Click);
            // 
            // unmutableTreeToolStripMenuItem1
            // 
            this.unmutableTreeToolStripMenuItem1.Name = "unmutableTreeToolStripMenuItem1";
            this.unmutableTreeToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.unmutableTreeToolStripMenuItem1.Text = "Unmutable Tree";
            this.unmutableTreeToolStripMenuItem1.Click += new System.EventHandler(this.CreateUnmutableTreeStr_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNodeToolStripMenuItem,
            this.removeNodeToolStripMenuItem,
            this.clearTreeToolStripMenuItem,
            this.contains10ToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNodeToolStripMenuItem
            // 
            this.addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            this.addNodeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addNodeToolStripMenuItem.Text = "Add Node";
            this.addNodeToolStripMenuItem.Click += new System.EventHandler(this.AddNode_Click);
            // 
            // removeNodeToolStripMenuItem
            // 
            this.removeNodeToolStripMenuItem.Name = "removeNodeToolStripMenuItem";
            this.removeNodeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeNodeToolStripMenuItem.Text = "Remove Node";
            this.removeNodeToolStripMenuItem.Click += new System.EventHandler(this.RemoveNode_Click);
            // 
            // clearTreeToolStripMenuItem
            // 
            this.clearTreeToolStripMenuItem.Name = "clearTreeToolStripMenuItem";
            this.clearTreeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.clearTreeToolStripMenuItem.Text = "Clear Tree";
            this.clearTreeToolStripMenuItem.Click += new System.EventHandler(this.ClearTree_Click);
            // 
            // contains10ToolStripMenuItem
            // 
            this.contains10ToolStripMenuItem.Name = "contains10ToolStripMenuItem";
            this.contains10ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.contains10ToolStripMenuItem.Text = "Contains";
            this.contains10ToolStripMenuItem.Click += new System.EventHandler(this.ContainsNode_Click);
            // 
            // utilsToolStripMenuItem
            // 
            this.utilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.existsToolStripMenuItem,
            this.findAllToolStripMenuItem,
            this.forEachToolStripMenuItem,
            this.checkForAllToolStripMenuItem});
            this.utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            this.utilsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.utilsToolStripMenuItem.Text = "Utils";
            // 
            // existsToolStripMenuItem
            // 
            this.existsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oddevenValueToolStripMenuItem,
            this.startingWithLetterToolStripMenuItem});
            this.existsToolStripMenuItem.Name = "existsToolStripMenuItem";
            this.existsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.existsToolStripMenuItem.Text = "Exists";
            // 
            // oddevenValueToolStripMenuItem
            // 
            this.oddevenValueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evenToolStripMenuItem,
            this.oddToolStripMenuItem});
            this.oddevenValueToolStripMenuItem.Name = "oddevenValueToolStripMenuItem";
            this.oddevenValueToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.oddevenValueToolStripMenuItem.Text = "Even/odd value";
            // 
            // evenToolStripMenuItem
            // 
            this.evenToolStripMenuItem.Name = "evenToolStripMenuItem";
            this.evenToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.evenToolStripMenuItem.Text = "Even";
            this.evenToolStripMenuItem.Click += new System.EventHandler(this.ExistsEvenValue_Click);
            // 
            // oddToolStripMenuItem
            // 
            this.oddToolStripMenuItem.Name = "oddToolStripMenuItem";
            this.oddToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.oddToolStripMenuItem.Text = "Odd";
            this.oddToolStripMenuItem.Click += new System.EventHandler(this.ExistsOddValue_Click);
            // 
            // startingWithLetterToolStripMenuItem
            // 
            this.startingWithLetterToolStripMenuItem.Name = "startingWithLetterToolStripMenuItem";
            this.startingWithLetterToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.startingWithLetterToolStripMenuItem.Text = "With substring";
            this.startingWithLetterToolStripMenuItem.Click += new System.EventHandler(this.ExistsWithSubstring_Click);
            // 
            // findAllToolStripMenuItem
            // 
            this.findAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oddValuesToolStripMenuItem,
            this.startingWithSubstringToolStripMenuItem});
            this.findAllToolStripMenuItem.Name = "findAllToolStripMenuItem";
            this.findAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findAllToolStripMenuItem.Text = "Find All";
            // 
            // oddValuesToolStripMenuItem
            // 
            this.oddValuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evenToolStripMenuItem1,
            this.oddToolStripMenuItem1});
            this.oddValuesToolStripMenuItem.Name = "oddValuesToolStripMenuItem";
            this.oddValuesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.oddValuesToolStripMenuItem.Text = "Even/odd values";
            // 
            // evenToolStripMenuItem1
            // 
            this.evenToolStripMenuItem1.Name = "evenToolStripMenuItem1";
            this.evenToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.evenToolStripMenuItem1.Text = "Even";
            this.evenToolStripMenuItem1.Click += new System.EventHandler(this.FindAllEvenValues_Click);
            // 
            // oddToolStripMenuItem1
            // 
            this.oddToolStripMenuItem1.Name = "oddToolStripMenuItem1";
            this.oddToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.oddToolStripMenuItem1.Text = "Odd";
            this.oddToolStripMenuItem1.Click += new System.EventHandler(this.FindAllOddValues_Click);
            // 
            // startingWithSubstringToolStripMenuItem
            // 
            this.startingWithSubstringToolStripMenuItem.Name = "startingWithSubstringToolStripMenuItem";
            this.startingWithSubstringToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.startingWithSubstringToolStripMenuItem.Text = "With substring";
            this.startingWithSubstringToolStripMenuItem.Click += new System.EventHandler(this.FindAllValuesWithSubstr_Click);
            // 
            // forEachToolStripMenuItem
            // 
            this.forEachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseBy1ToolStripMenuItem,
            this.decreaseBy1ToolStripMenuItem});
            this.forEachToolStripMenuItem.Name = "forEachToolStripMenuItem";
            this.forEachToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forEachToolStripMenuItem.Text = "For Each";
            // 
            // increaseBy1ToolStripMenuItem
            // 
            this.increaseBy1ToolStripMenuItem.Name = "increaseBy1ToolStripMenuItem";
            this.increaseBy1ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.increaseBy1ToolStripMenuItem.Text = "Increase by value";
            this.increaseBy1ToolStripMenuItem.Click += new System.EventHandler(this.ForEachIncreaseByValue_Click);
            // 
            // decreaseBy1ToolStripMenuItem
            // 
            this.decreaseBy1ToolStripMenuItem.Name = "decreaseBy1ToolStripMenuItem";
            this.decreaseBy1ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.decreaseBy1ToolStripMenuItem.Text = "Add string to the end";
            this.decreaseBy1ToolStripMenuItem.Click += new System.EventHandler(this.ForEachAddStringToEnd);
            // 
            // checkForAllToolStripMenuItem
            // 
            this.checkForAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlyOddToolStripMenuItem,
            this.onlyEvenToolStripMenuItem});
            this.checkForAllToolStripMenuItem.Name = "checkForAllToolStripMenuItem";
            this.checkForAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForAllToolStripMenuItem.Text = "Check For All";
            // 
            // onlyOddToolStripMenuItem
            // 
            this.onlyOddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evenToolStripMenuItem2,
            this.oddToolStripMenuItem2});
            this.onlyOddToolStripMenuItem.Name = "onlyOddToolStripMenuItem";
            this.onlyOddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onlyOddToolStripMenuItem.Text = "Only even/odd";
            // 
            // evenToolStripMenuItem2
            // 
            this.evenToolStripMenuItem2.Name = "evenToolStripMenuItem2";
            this.evenToolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.evenToolStripMenuItem2.Text = "Even";
            this.evenToolStripMenuItem2.Click += new System.EventHandler(this.CheckForAllOnlyEven_Click);
            // 
            // oddToolStripMenuItem2
            // 
            this.oddToolStripMenuItem2.Name = "oddToolStripMenuItem2";
            this.oddToolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.oddToolStripMenuItem2.Text = "Odd";
            this.oddToolStripMenuItem2.Click += new System.EventHandler(this.CheckForAllOnlyOdd_Click);
            // 
            // onlyEvenToolStripMenuItem
            // 
            this.onlyEvenToolStripMenuItem.Name = "onlyEvenToolStripMenuItem";
            this.onlyEvenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onlyEvenToolStripMenuItem.Text = "Only with substring";
            this.onlyEvenToolStripMenuItem.Click += new System.EventHandler(this.CheckForAllOnlyWithSubstr_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.View_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 196);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "BalancedTreeLab";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem linkedTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forEachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oddValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseBy1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseBy1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyOddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyEvenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contains10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkedTreeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unmutableTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayTreeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem linkedTreeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem unmutableTreeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem existsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oddevenValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startingWithLetterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startingWithSubstringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem evenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem oddToolStripMenuItem2;
    }
}

