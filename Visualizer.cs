

namespace BalancedTreeLab
{
    public partial class Visualizer : Form
    {
        public Visualizer()
        {
            InitializeComponent();
        }

        public void ShowTree(string TreeBefore, string TreeAfter)
        {
            textBoxBefore.Text = TreeBefore;
            textBoxAfter.Text = TreeAfter;
        }
    }
}
