namespace FSG.HCM.NewModules
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("��Ŀ����δ��д�޷�����");
                return;
            }
            var projName = textBox1.Text;
            var currentDir=System.IO.Directory.GetCurrentDirectory();
            var z = 1;

        }
    }
}