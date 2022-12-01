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

        private void widthinput_TextChanged(object sender, EventArgs e)
        {
            string s = widthinput.Text;

            if (s.Length > 0 && !IsValidCharcater(s[s.Length - 1]))
            {
                e.Handled = true;
            }
        }

        private bool IsValidCharcater(char character) 
        {
            return char.IsDigit(character);
        
        }
    }
}