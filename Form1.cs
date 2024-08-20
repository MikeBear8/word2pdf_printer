using System.Windows.Forms;

namespace word2pdf_printer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            //    return;
            //// получаем выбранный файл
            //string filename = openFileDialog1.FileName;
            //// читаем файл в строку
            //string fileText = System.IO.File.ReadAllText(filename);
            //textBox1.Text = fileText;
            //MessageBox.Show("Файл открыт");
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.InitialDirectory = @"C:\";//--"C:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Документы Word (*.doc, *.docx)|*.doc;*.docx";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { textBox1.Text = openFileDialog1.FileName; }
            else
            { textBox1.Text = "Вы не выбрали файл!"; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
        }
    }
}
