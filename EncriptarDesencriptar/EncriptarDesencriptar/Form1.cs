namespace EncriptarDesencriptar
{
    public partial class Form1 : Form
    {
        string filename {  get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofn = new OpenFileDialog();
            var result = ofn.ShowDialog(this);
            filename = ofn.FileName;
            if (result == DialogResult.OK) 
            {
                string text = File.ReadAllText(filename);
                textBox1.Text = text;
                label1.Text = filename;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
           if (string.IsNullOrEmpty(filename))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                var result = sfd.ShowDialog(this);
                if (result != DialogResult.OK) return;

                filename = sfd.FileName;
                label1.Text = filename;
                if (!File.Exists(filename)) File.Create(filename).Close();
            }

           File.WriteAllText(filename, textBox1.Text);
           MessageBox.Show("Arquivo salvo com sucesso.");
        }

        private string encriptar(string text)
        {
            string result = "";
            foreach (char c in text)
            {
                result += (char)(c + 4);
            }
            return result;
        }

        private string decriptar(string text)
        {
            string result = "";
            foreach(char c in text)
            {
                result += (char)(c - 4);
            }
            return result;
        }

        private void buttonEncriptar_Click(object sender, EventArgs e)
        {
            textBox1.Text = encriptar(textBox1.Text);
        }

        private void buttonDesencriptar_Click(object sender, EventArgs e)
        {
            textBox1.Text = decriptar(textBox1.Text);
        }
    }
}
