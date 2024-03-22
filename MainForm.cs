using BalacnedTree;

namespace BalancedTreeLab
{
    public partial class MainForm : Form
    {
        UnmutableTree<int> unmutableTreeInt;
        UnmutableTree<string> unmutableTreeStr;

        ITree<int> _treeInt; // основа для дерева, состоящего из чисел
        ITree<string> _treeStr; // основа для дерева, состоящего из строк

        bool unmutable = false;
        string type = string.Empty;

        delegate void ModificationDelegate<T>(T data);
        delegate void UtilsActionDelegate<T>(Node<T> node);

        private string TreeVisuals = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }
        public string PrintTree<T>(Node<T> root) where T : IComparable<T>
        {
            return PrintTreeRec(root, 0);
        }

        private string PrintTreeRec<T>(Node<T> node, int level) where T : IComparable<T>
        {
            string result = string.Empty;
            if (node != null)
            {
                result += PrintTreeRec(node.Right, level + 1);
                result += "\r\n";
                for (int i = 0; i < level; i++)
                    result += $"       ";
                result += node.Data.ToString();
                result += PrintTreeRec(node.Left, level + 1);
            }
            return result;
        }

        private void ViewExecution<T>(ITree<T> tree) where T : IComparable<T>
        {
            TreeVisuals = tree.IsEmpty ? "Empty balanced tree" : PrintTree(tree.Nodes.First());
        }

        private void CreateArrayTreeInt_Click(object sender, EventArgs e)
        {
            _treeInt = new ArrayTree<int>();
            textBox.Text = $"Created tree ArrayTree<int>.\r\n";
            ViewExecution(_treeInt);

            unmutable = false;
            type = "int";
        }

        private void CreateLinkedTreeInt_Click(object sender, EventArgs e)
        {
            _treeInt = new LinkedTree<int>();
            textBox.Text = $"Created tree LinkedTree<int>.\r\n";
            ViewExecution(_treeInt);

            unmutable = false;
            type = "int";
        }

        private void CreateUnmutableTreeInt_Click(object sender, EventArgs e)
        {
            _treeInt = new ArrayTree<int>();
            Filler.FillTree(_treeInt);
            unmutableTreeInt = new UnmutableTree<int>(_treeInt);
            ViewExecution(unmutableTreeInt);

            textBox.Text = $"Created tree UnmutableTree<int>.\r\n";

            unmutable = true;
            type = "int";
        }

        private void CreateArrayTreeStr_Click(object sender, EventArgs e)
        {
            _treeStr = new ArrayTree<string>();
            textBox.Text = $"Created tree ArrayTree<string>.\r\n";
            ViewExecution(_treeStr);

            unmutable = false;
            type = "string";
        }

        private void CreateLinkedTreeStr_Click(object sender, EventArgs e)
        {
            _treeStr = new LinkedTree<string>();
            textBox.Text = $"Created tree LinkedTree<string>.\r\n";
            ViewExecution(_treeStr);

            unmutable = false;
            type = "string";
        }

        private void CreateUnmutableTreeStr_Click(object sender, EventArgs e)
        {
            _treeStr = new ArrayTree<string>();
            Filler.FillTree(_treeStr);
            unmutableTreeStr = new UnmutableTree<string>(_treeStr);
            ViewExecution(unmutableTreeStr);

            textBox.Text = $"Created tree UnmutableTree<string>.\r\n";

            unmutable = true;
            type = "string";
        }

        private void ModifyTree<T>(T data, ITree<T> tree, ModificationDelegate<T> modify) where T : IComparable<T>
        {
            try
            {
                modify.Invoke(data);
                ViewExecution(tree);
                textBox.Text += "Success!\r\n";
            }
            catch (TreeException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text += "Failure!\r\n";
            }
        }

        private void AddNode_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type == "string")
                {
                    var form = new ElementEntry<string>();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string elem = ElementEntry<string>.Element;
                        if (unmutable == false)
                            ModifyTree(elem, _treeStr, _treeStr.Add);
                        else
                            ModifyTree(elem, unmutableTreeStr, unmutableTreeStr.Add);
                    }
                }
                else
                {
                    var form = new ElementEntry<int>();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        int elem = ElementEntry<int>.Element;
                        if (unmutable == false)
                            ModifyTree(elem, _treeInt, _treeInt.Add);
                        else
                            ModifyTree(elem, unmutableTreeInt, unmutableTreeInt.Add);
                    }
                }
            }
        }

        private void RemoveNode_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type == "string")
                {
                    var form = new ElementEntry<string>();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string elem = ElementEntry<string>.Element;
                        if (unmutable == false)
                            ModifyTree(elem, _treeStr, _treeStr.Remove);
                        else
                            ModifyTree(elem, unmutableTreeStr, unmutableTreeStr.Remove);
                    }
                }
                else
                {
                    var form = new ElementEntry<int>();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        int elem = ElementEntry<int>.Element;
                        if (unmutable == false)
                            ModifyTree(elem, _treeInt, _treeInt.Remove);
                        else
                            ModifyTree(elem, unmutableTreeInt, unmutableTreeInt.Remove);
                    }
                }
            }
        }

        private void ClearTree<T>(ITree<T> tree) where T : IComparable<T>
        {
            try
            {
                tree.Clear();
                ViewExecution(tree);
                textBox.Text = "Tree has been cleared!\r\n";
            }
            catch (TreeException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTree_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type == "string")
                {
                    if (unmutable)
                        ClearTree(unmutableTreeStr);
                    else
                        ClearTree(_treeStr);
                }
                else
                {
                    if (unmutable)
                        ClearTree(unmutableTreeInt);
                    else
                        ClearTree(_treeInt);
                }
            }
        }

        private void ContainsNode<T>(ITree<T> tree, T elem) where T : IComparable<T>
        {
            try
            {
                if (tree.Contains(elem))
                    textBox.Text = $"Node {elem} was found!\r\n";
                else
                    textBox.Text = $"Node {elem} was NOT found!\r\n";
            }
            catch (TreeException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContainsNode_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type == "string")
                {
                    var form = new ElementEntry<string>();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string elem = ElementEntry<string>.Element;
                        if (unmutable == true)
                            ContainsNode(unmutableTreeStr, elem);
                        else
                            ContainsNode(_treeStr, elem);
                    }
                }
                else
                {
                    var form = new ElementEntry<int>();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        int elem = ElementEntry<int>.Element;
                        if (unmutable == true)
                            ContainsNode(unmutableTreeInt, elem);
                        else
                            ContainsNode(_treeInt, elem);
                    }
                }
            }
        }
        private void ExistsEvenValue_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "int")
                    MessageBox.Show($"Tree node target type is not integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        bool exists;
                        if (unmutable)
                            exists = TreeUtils<int>.Exists(unmutableTreeInt, node => node.Data % 2 == 0);
                        else
                            exists = TreeUtils<int>.Exists(_treeInt, node => node.Data % 2 == 0);
                        textBox.Text = $"Tree contains at least one even value: {exists}";
                    }
                    catch (TreeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExistsOddValue_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "int")
                    MessageBox.Show($"Tree node target type is not integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        bool exists;
                        if (unmutable)
                            exists = TreeUtils<int>.Exists(unmutableTreeInt, node => node.Data % 2 == 1);
                        else
                            exists = TreeUtils<int>.Exists(_treeInt, node => node.Data % 2 == 1);
                        textBox.Text = $"Tree contains at least one even value: {exists}";
                    }
                    catch (TreeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExistsWithSubstring_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "string")
                    MessageBox.Show("Tree node type is not string!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    { 
                    bool exists;
                    var form = new ElementEntry<string>();
                    string elem = string.Empty;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            elem = ElementEntry<string>.Element;
                            if (unmutable == true)
                                exists = TreeUtils<string>.Exists(unmutableTreeStr, node => node.Data.Contains(elem));
                            else
                                exists = TreeUtils<string>.Exists(_treeStr, node => node.Data.Contains(elem));
                            textBox.Text = $"Tree contains at least one value with substring \"{elem}\": {exists}";
                        }
                    }
                    catch (TreeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FindAllEvenValues_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "int")
                    MessageBox.Show("Tree node type is not integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        ITree<int> tree;

                        if (unmutable)
                            tree = TreeUtils<int>.FindAll(unmutableTreeInt, node => node.Data % 2 == 0, () => new ArrayTree<int>());
                        else
                            tree = TreeUtils<int>.FindAll(_treeInt, node => node.Data % 2 == 0, () => new ArrayTree<int>());
                        ViewExecution(tree);
                        View_Click(sender, e);
                    }
                    catch (TreeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FindAllOddValues_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "int")
                    MessageBox.Show("Tree node type is not integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        ITree<int> tree;

                        if (unmutable)
                            tree = TreeUtils<int>.FindAll(unmutableTreeInt, node => node.Data % 2 == 1, () => new ArrayTree<int>());
                        else
                            tree = TreeUtils<int>.FindAll(_treeInt, node => node.Data % 2 == 1, () => new ArrayTree<int>());
                        ViewExecution(tree);
                        View_Click(sender, e);
                    }
                    catch (TreeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FindAllValuesWithSubstr_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "string")
                    MessageBox.Show($"Tree node type is not string!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        ITree<string> tree;
                        var form = new ElementEntry<string>();
                        string elem = string.Empty;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            elem = ElementEntry<string>.Element;
                            if (unmutable)
                                tree = TreeUtils<string>.FindAll(unmutableTreeStr, node => node.Data.Contains(elem), () => new ArrayTree<string>());
                            else
                                tree = TreeUtils<string>.FindAll(_treeStr, node => node.Data.Contains(elem), () => new ArrayTree<string>());
                            ViewExecution(tree);
                            View_Click(sender, e);
                        }
                    }
                    catch (TreeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ForEachExecute<T>(ITree<T> tree, T elem, UtilsActionDelegate<T> modify) where T : IComparable<T>
        {
            try
            {
                TreeUtils<T>.ForEach(tree, modify.Invoke);

                textBox.Text = $"Tree was modified by addition with element \"{elem}\"!\n\r";

                ViewExecution(tree);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForEachTemplate<T>(T elem, ITree<T> unmutableTree, ITree<T> tree, UtilsActionDelegate<T> modify) where T : IComparable<T>
        {
            if (unmutable)
                MessageBox.Show("Cannot modify unmutable tree with ForEach method", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ForEachExecute(tree, elem, modify);
        }

        private void ForEachIncreaseByValue_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "int")
                    MessageBox.Show("Tree node type is not integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ITree<int> tree;
                    var form = new ElementEntry<int>();
                    int elem;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        elem = ElementEntry<int>.Element;
                        ForEachTemplate(elem, unmutableTreeInt, _treeInt, node => node.Data += elem);
                    }
                }
            }
        }

        private void ForEachAddStringToEnd(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "string")
                    MessageBox.Show("Tree node type is not string!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var form = new ElementEntry<string>();
                    string elem;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        elem = ElementEntry<string>.Element;
                        ForEachTemplate(elem, unmutableTreeStr, _treeStr, node => node.Data += elem);
                    }
                }
            }
        }

        private void CheckForAllOnlyEven_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "int")
                    MessageBox.Show($"Tree node type is not integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        bool checkResult;
                        if (unmutable)
                            checkResult = TreeUtils<int>.CheckForAll(unmutableTreeInt, node => node.Data % 2 == 0);
                        else
                            checkResult = TreeUtils<int>.CheckForAll(_treeInt, node => node.Data % 2 == 0);
                        textBox.Text = $"Tree consists only of even values: {checkResult}.\r\n";
                    }
                    catch (TreeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CheckForAllOnlyOdd_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "int")
                    MessageBox.Show($"Tree node type is not integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        bool checkResult;
                        if (unmutable)
                            checkResult = TreeUtils<int>.CheckForAll(unmutableTreeInt, node => node.Data % 2 == 1);
                        else
                            checkResult = TreeUtils<int>.CheckForAll(_treeInt, node => node.Data % 2 == 1);
                        textBox.Text = $"Tree consists only of odd values: {checkResult}.\r\n";
                    }
                    catch (TreeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CheckForAllOnlyWithSubstr_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type != "string")
                    MessageBox.Show($"Tree node type is not integer!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        bool checkResult;
                        var form = new ElementEntry<string>();
                        string elem = string.Empty;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            elem = ElementEntry<string>.Element;
                            if (unmutable)
                                checkResult = TreeUtils<string>.CheckForAll(unmutableTreeStr, node => node.Data.Contains(elem));
                            else
                                checkResult = TreeUtils<string>.CheckForAll(_treeStr, node => node.Data.Contains(elem));
                            textBox.Text = $"Tree consists only of strings with given substring: {checkResult}.\r\n";
                        }
                    }
                    catch (TreeException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (type == "")
                MessageBox.Show("Tree node type is not chosen!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var visuals = new Visualizer();
                visuals.ShowTree(TreeVisuals);
                visuals.Show();
            }
        }


    }
}
