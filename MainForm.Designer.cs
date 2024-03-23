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
            textBox = new TextBox();
            menuStrip1 = new MenuStrip();
            linkedTreeToolStripMenuItem = new ToolStripMenuItem();
            integerToolStripMenuItem = new ToolStripMenuItem();
            arrayTreeToolStripMenuItem = new ToolStripMenuItem();
            linkedTreeToolStripMenuItem1 = new ToolStripMenuItem();
            unmutableTreeToolStripMenuItem = new ToolStripMenuItem();
            stringToolStripMenuItem = new ToolStripMenuItem();
            arrayTreeToolStripMenuItem1 = new ToolStripMenuItem();
            linkedTreeToolStripMenuItem2 = new ToolStripMenuItem();
            unmutableTreeToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addNodeToolStripMenuItem = new ToolStripMenuItem();
            removeNodeToolStripMenuItem = new ToolStripMenuItem();
            clearTreeToolStripMenuItem = new ToolStripMenuItem();
            contains10ToolStripMenuItem = new ToolStripMenuItem();
            utilsToolStripMenuItem = new ToolStripMenuItem();
            existsToolStripMenuItem = new ToolStripMenuItem();
            oddevenValueToolStripMenuItem = new ToolStripMenuItem();
            evenToolStripMenuItem = new ToolStripMenuItem();
            oddToolStripMenuItem = new ToolStripMenuItem();
            startingWithLetterToolStripMenuItem = new ToolStripMenuItem();
            findAllToolStripMenuItem = new ToolStripMenuItem();
            oddValuesToolStripMenuItem = new ToolStripMenuItem();
            evenToolStripMenuItem1 = new ToolStripMenuItem();
            oddToolStripMenuItem1 = new ToolStripMenuItem();
            startingWithSubstringToolStripMenuItem = new ToolStripMenuItem();
            forEachToolStripMenuItem = new ToolStripMenuItem();
            increaseBy1ToolStripMenuItem = new ToolStripMenuItem();
            decreaseBy1ToolStripMenuItem = new ToolStripMenuItem();
            checkForAllToolStripMenuItem = new ToolStripMenuItem();
            onlyOddToolStripMenuItem = new ToolStripMenuItem();
            evenToolStripMenuItem2 = new ToolStripMenuItem();
            oddToolStripMenuItem2 = new ToolStripMenuItem();
            onlyEvenToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Font = new Font("Microsoft Sans Serif", 20F);
            textBox.Location = new Point(0, 42);
            textBox.Margin = new Padding(4, 5, 4, 5);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Size = new Size(913, 341);
            textBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { linkedTreeToolStripMenuItem, editToolStripMenuItem, utilsToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 3, 0, 3);
            menuStrip1.Size = new Size(920, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // linkedTreeToolStripMenuItem
            // 
            linkedTreeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { integerToolStripMenuItem, stringToolStripMenuItem });
            linkedTreeToolStripMenuItem.Name = "linkedTreeToolStripMenuItem";
            linkedTreeToolStripMenuItem.Size = new Size(51, 24);
            linkedTreeToolStripMenuItem.Text = "Tree";
            // 
            // integerToolStripMenuItem
            // 
            integerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrayTreeToolStripMenuItem, linkedTreeToolStripMenuItem1, unmutableTreeToolStripMenuItem });
            integerToolStripMenuItem.Name = "integerToolStripMenuItem";
            integerToolStripMenuItem.Size = new Size(139, 26);
            integerToolStripMenuItem.Text = "integer";
            // 
            // arrayTreeToolStripMenuItem
            // 
            arrayTreeToolStripMenuItem.Name = "arrayTreeToolStripMenuItem";
            arrayTreeToolStripMenuItem.Size = new Size(197, 26);
            arrayTreeToolStripMenuItem.Text = "Array Tree";
            arrayTreeToolStripMenuItem.Click += CreateArrayTreeInt_Click;
            // 
            // linkedTreeToolStripMenuItem1
            // 
            linkedTreeToolStripMenuItem1.Name = "linkedTreeToolStripMenuItem1";
            linkedTreeToolStripMenuItem1.Size = new Size(197, 26);
            linkedTreeToolStripMenuItem1.Text = "Linked Tree";
            linkedTreeToolStripMenuItem1.Click += CreateLinkedTreeInt_Click;
            // 
            // unmutableTreeToolStripMenuItem
            // 
            unmutableTreeToolStripMenuItem.Name = "unmutableTreeToolStripMenuItem";
            unmutableTreeToolStripMenuItem.Size = new Size(197, 26);
            unmutableTreeToolStripMenuItem.Text = "Unmutable Tree";
            unmutableTreeToolStripMenuItem.Click += CreateUnmutableTreeInt_Click;
            // 
            // stringToolStripMenuItem
            // 
            stringToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrayTreeToolStripMenuItem1, linkedTreeToolStripMenuItem2, unmutableTreeToolStripMenuItem1 });
            stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            stringToolStripMenuItem.Size = new Size(139, 26);
            stringToolStripMenuItem.Text = "string";
            // 
            // arrayTreeToolStripMenuItem1
            // 
            arrayTreeToolStripMenuItem1.Name = "arrayTreeToolStripMenuItem1";
            arrayTreeToolStripMenuItem1.Size = new Size(197, 26);
            arrayTreeToolStripMenuItem1.Text = "Array Tree";
            arrayTreeToolStripMenuItem1.Click += CreateArrayTreeStr_Click;
            // 
            // linkedTreeToolStripMenuItem2
            // 
            linkedTreeToolStripMenuItem2.Name = "linkedTreeToolStripMenuItem2";
            linkedTreeToolStripMenuItem2.Size = new Size(197, 26);
            linkedTreeToolStripMenuItem2.Text = "Linked Tree";
            linkedTreeToolStripMenuItem2.Click += CreateLinkedTreeStr_Click;
            // 
            // unmutableTreeToolStripMenuItem1
            // 
            unmutableTreeToolStripMenuItem1.Name = "unmutableTreeToolStripMenuItem1";
            unmutableTreeToolStripMenuItem1.Size = new Size(197, 26);
            unmutableTreeToolStripMenuItem1.Text = "Unmutable Tree";
            unmutableTreeToolStripMenuItem1.Click += CreateUnmutableTreeStr_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNodeToolStripMenuItem, removeNodeToolStripMenuItem, clearTreeToolStripMenuItem, contains10ToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addNodeToolStripMenuItem
            // 
            addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            addNodeToolStripMenuItem.Size = new Size(187, 26);
            addNodeToolStripMenuItem.Text = "Add Node";
            addNodeToolStripMenuItem.Click += AddNode_Click;
            // 
            // removeNodeToolStripMenuItem
            // 
            removeNodeToolStripMenuItem.Name = "removeNodeToolStripMenuItem";
            removeNodeToolStripMenuItem.Size = new Size(187, 26);
            removeNodeToolStripMenuItem.Text = "Remove Node";
            removeNodeToolStripMenuItem.Click += RemoveNode_Click;
            // 
            // clearTreeToolStripMenuItem
            // 
            clearTreeToolStripMenuItem.Name = "clearTreeToolStripMenuItem";
            clearTreeToolStripMenuItem.Size = new Size(187, 26);
            clearTreeToolStripMenuItem.Text = "Clear Tree";
            clearTreeToolStripMenuItem.Click += ClearTree_Click;
            // 
            // contains10ToolStripMenuItem
            // 
            contains10ToolStripMenuItem.Name = "contains10ToolStripMenuItem";
            contains10ToolStripMenuItem.Size = new Size(187, 26);
            contains10ToolStripMenuItem.Text = "Contains";
            contains10ToolStripMenuItem.Click += ContainsNode_Click;
            // 
            // utilsToolStripMenuItem
            // 
            utilsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { existsToolStripMenuItem, findAllToolStripMenuItem, forEachToolStripMenuItem, checkForAllToolStripMenuItem });
            utilsToolStripMenuItem.Name = "utilsToolStripMenuItem";
            utilsToolStripMenuItem.Size = new Size(52, 24);
            utilsToolStripMenuItem.Text = "Utils";
            // 
            // existsToolStripMenuItem
            // 
            existsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oddevenValueToolStripMenuItem, startingWithLetterToolStripMenuItem });
            existsToolStripMenuItem.Name = "existsToolStripMenuItem";
            existsToolStripMenuItem.Size = new Size(178, 26);
            existsToolStripMenuItem.Text = "Exists";
            // 
            // oddevenValueToolStripMenuItem
            // 
            oddevenValueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { evenToolStripMenuItem, oddToolStripMenuItem });
            oddevenValueToolStripMenuItem.Name = "oddevenValueToolStripMenuItem";
            oddevenValueToolStripMenuItem.Size = new Size(195, 26);
            oddevenValueToolStripMenuItem.Text = "Even/odd value";
            // 
            // evenToolStripMenuItem
            // 
            evenToolStripMenuItem.Name = "evenToolStripMenuItem";
            evenToolStripMenuItem.Size = new Size(123, 26);
            evenToolStripMenuItem.Text = "Even";
            evenToolStripMenuItem.Click += ExistsEvenValue_Click;
            // 
            // oddToolStripMenuItem
            // 
            oddToolStripMenuItem.Name = "oddToolStripMenuItem";
            oddToolStripMenuItem.Size = new Size(123, 26);
            oddToolStripMenuItem.Text = "Odd";
            oddToolStripMenuItem.Click += ExistsOddValue_Click;
            // 
            // startingWithLetterToolStripMenuItem
            // 
            startingWithLetterToolStripMenuItem.Name = "startingWithLetterToolStripMenuItem";
            startingWithLetterToolStripMenuItem.Size = new Size(195, 26);
            startingWithLetterToolStripMenuItem.Text = "With substring";
            startingWithLetterToolStripMenuItem.Click += ExistsWithSubstring_Click;
            // 
            // findAllToolStripMenuItem
            // 
            findAllToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oddValuesToolStripMenuItem, startingWithSubstringToolStripMenuItem });
            findAllToolStripMenuItem.Name = "findAllToolStripMenuItem";
            findAllToolStripMenuItem.Size = new Size(178, 26);
            findAllToolStripMenuItem.Text = "Find All";
            // 
            // oddValuesToolStripMenuItem
            // 
            oddValuesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { evenToolStripMenuItem1, oddToolStripMenuItem1 });
            oddValuesToolStripMenuItem.Name = "oddValuesToolStripMenuItem";
            oddValuesToolStripMenuItem.Size = new Size(201, 26);
            oddValuesToolStripMenuItem.Text = "Even/odd values";
            // 
            // evenToolStripMenuItem1
            // 
            evenToolStripMenuItem1.Name = "evenToolStripMenuItem1";
            evenToolStripMenuItem1.Size = new Size(123, 26);
            evenToolStripMenuItem1.Text = "Even";
            evenToolStripMenuItem1.Click += FindAllEvenValues_Click;
            // 
            // oddToolStripMenuItem1
            // 
            oddToolStripMenuItem1.Name = "oddToolStripMenuItem1";
            oddToolStripMenuItem1.Size = new Size(123, 26);
            oddToolStripMenuItem1.Text = "Odd";
            oddToolStripMenuItem1.Click += FindAllOddValues_Click;
            // 
            // startingWithSubstringToolStripMenuItem
            // 
            startingWithSubstringToolStripMenuItem.Name = "startingWithSubstringToolStripMenuItem";
            startingWithSubstringToolStripMenuItem.Size = new Size(201, 26);
            startingWithSubstringToolStripMenuItem.Text = "With substring";
            startingWithSubstringToolStripMenuItem.Click += FindAllValuesWithSubstr_Click;
            // 
            // forEachToolStripMenuItem
            // 
            forEachToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { increaseBy1ToolStripMenuItem, decreaseBy1ToolStripMenuItem });
            forEachToolStripMenuItem.Name = "forEachToolStripMenuItem";
            forEachToolStripMenuItem.Size = new Size(178, 26);
            forEachToolStripMenuItem.Text = "For Each";
            // 
            // increaseBy1ToolStripMenuItem
            // 
            increaseBy1ToolStripMenuItem.Name = "increaseBy1ToolStripMenuItem";
            increaseBy1ToolStripMenuItem.Size = new Size(233, 26);
            increaseBy1ToolStripMenuItem.Text = "Increase by value";
            increaseBy1ToolStripMenuItem.Click += ForEachIncreaseByValue_Click;
            // 
            // decreaseBy1ToolStripMenuItem
            // 
            decreaseBy1ToolStripMenuItem.Name = "decreaseBy1ToolStripMenuItem";
            decreaseBy1ToolStripMenuItem.Size = new Size(233, 26);
            decreaseBy1ToolStripMenuItem.Text = "Add string to the end";
            decreaseBy1ToolStripMenuItem.Click += ForEachAddStringToEnd;
            // 
            // checkForAllToolStripMenuItem
            // 
            checkForAllToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { onlyOddToolStripMenuItem, onlyEvenToolStripMenuItem });
            checkForAllToolStripMenuItem.Name = "checkForAllToolStripMenuItem";
            checkForAllToolStripMenuItem.Size = new Size(178, 26);
            checkForAllToolStripMenuItem.Text = "Check For All";
            // 
            // onlyOddToolStripMenuItem
            // 
            onlyOddToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { evenToolStripMenuItem2, oddToolStripMenuItem2 });
            onlyOddToolStripMenuItem.Name = "onlyOddToolStripMenuItem";
            onlyOddToolStripMenuItem.Size = new Size(218, 26);
            onlyOddToolStripMenuItem.Text = "Only even/odd";
            // 
            // evenToolStripMenuItem2
            // 
            evenToolStripMenuItem2.Name = "evenToolStripMenuItem2";
            evenToolStripMenuItem2.Size = new Size(123, 26);
            evenToolStripMenuItem2.Text = "Even";
            evenToolStripMenuItem2.Click += CheckForAllOnlyEven_Click;
            // 
            // oddToolStripMenuItem2
            // 
            oddToolStripMenuItem2.Name = "oddToolStripMenuItem2";
            oddToolStripMenuItem2.Size = new Size(123, 26);
            oddToolStripMenuItem2.Text = "Odd";
            oddToolStripMenuItem2.Click += CheckForAllOnlyOdd_Click;
            // 
            // onlyEvenToolStripMenuItem
            // 
            onlyEvenToolStripMenuItem.Name = "onlyEvenToolStripMenuItem";
            onlyEvenToolStripMenuItem.Size = new Size(218, 26);
            onlyEvenToolStripMenuItem.Text = "Only with substring";
            onlyEvenToolStripMenuItem.Click += CheckForAllOnlyWithSubstr_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += View_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 385);
            Controls.Add(textBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "BalancedTreeLab";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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

