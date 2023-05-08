using com.calitha.goldparser;

namespace plc
{
    public partial class Form1 : Form
    {
        MyParser p;

        public Form1()
        {
            InitializeComponent();
            p = new MyParser("language.cgt", listBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // code that uses the parser
        }


        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            p.Parse(richTextBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
