

namespace BalancedTreeLab
{
    public partial class Visualizer : Form
    {
        public Visualizer()
        {
            InitializeComponent();
        }

        public void ShowTree(string TreeVisuals)
        {
            textBoxView.Text = TreeVisuals;
        }
    }
}
