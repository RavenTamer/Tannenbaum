namespace Tannenbaum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
                Tanne tree = new(Convert.ToInt32(widthinput.Text), Convert.ToInt32(trunkheightinput.Text), Convert.ToInt32(crownheightinput.Text));
                drawingoutput.Text = tree.DrawTree();
        }
    }
}