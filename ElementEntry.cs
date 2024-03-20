
namespace BalancedTreeLab
{
    public partial class ElementEntry<T> : Form  where T : IParsable<T>
    {
        public static T Element { get; set; }
        public ElementEntry()
        {
            InitializeComponent();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Element = T.Parse(textBoxEntry.Text, null);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
