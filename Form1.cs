using System.Windows.Forms;

namespace MultilineInTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readFile_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            // ������ ��� ������ �����
            OpenFileDialog ofd = new OpenFileDialog();
            // ������ �������� ������
            ofd.Filter = "Text Files(*.txt,*.doc)|*.txt,*.doc|All files (*.*)|*.*";
            // ���� � ������� ���� ������ ������ ��
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ��������� �����
                    StreamReader sr = new StreamReader(ofd.FileName, System.Text.Encoding.Default);

                    while (!sr.EndOfStream)
                        textBox1.Text += sr.ReadLine() + Environment.NewLine;

                    sr.Close();
                }
                catch // � ������ ������ ������� MessageBox
                {
                    MessageBox.Show("���������� ������� ��������� ����", "������",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
    }
}