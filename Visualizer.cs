using BalacnedTree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
