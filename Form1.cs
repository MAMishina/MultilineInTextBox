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

            // диалог для выбора файла
            OpenFileDialog ofd = new OpenFileDialog();
            // фильтр форматов файлов
            ofd.Filter = "Text Files(*.txt,*.doc)|*.txt,*.doc|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // загружаем текст
                    StreamReader sr = new StreamReader(ofd.FileName, System.Text.Encoding.Default);

                    while (!sr.EndOfStream)
                        textBox1.Text += sr.ReadLine() + Environment.NewLine;

                    sr.Close();
                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }
    }
}