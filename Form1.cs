using System.Text;
using System.Windows.Forms;

namespace EncryptCode
{
    public partial class Form1 : Form
    {
        private string defaultPath = "C:\\Users\\firey\\Desktop\\CodesEncryptCode\\";
        EncryptModes encryptModes = new EncryptModes();
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEncrypt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void generateCode_Click(object sender, EventArgs e)
        {
            if (!checkAllTheInputs())
            {
                setConfigLabel("Missing some input", "Red", true);
                return;
            }

            generateCodes(textBox1.Text, textBoxShellCode.Text);
            setConfigLabel("Correct", "Green", true);
        }

        private bool checkAllTheInputs()
        {
            if (comboBoxLanguage.SelectedIndex == -1 ||
                comboBoxEncrypt.SelectedIndex == -1 ||
                textBoxShellCode.Text == ""
                )
            {
                return false;
            }
            return true;
        }

        private void setConfigLabel(string message, string color, bool isVisible)
        {
            labelInformation.Text = message;
            labelInformation.ForeColor = Color.FromName(color);
            labelInformation.Visible = isVisible;
        }

        private string generatePath(string Filename)
        {
            string extensionFile = ".txt";

            string path = $"{defaultPath}{Filename}{extensionFile}";
            return path;
        }

        private void generateCodes(string FileName, string ShellCode)
        {
            byte[] encryptBytes = encryptModes.EncryptAES(System.Text.Encoding.UTF8.GetBytes(textBoxShellCode.Text));
            string encryptString = encryptModes.ConvertByteArrayToStringCSharp(encryptBytes);

            byte[] dectrypteString = encryptModes.DecryptAES(encryptBytes);

            string hexDebug = encryptModes.ConvertByteArrayToStringCSharp(dectrypteString);
            string decryptedText = Encoding.UTF8.GetString(dectrypteString);

            string code = encryptModes.GetDecryptAESCodeAsString();

            string path = generatePath(textBox1.Text);

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(encryptModes.getKeyAndIV());
                    sw.WriteLine(Environment.NewLine + $"Original Message: {textBoxShellCode.Text}" + Environment.NewLine);
                    sw.WriteLine(Environment.NewLine + $"Encrypt Message: byte[] encrypt = {{ {encryptString} }};" + Environment.NewLine);
                    sw.WriteLine(Environment.NewLine + $"Decrypt Message: {decryptedText}" + Environment.NewLine);
                    sw.WriteLine(Environment.NewLine + $"Code to Decrypt: {code}" + Environment.NewLine);
                }
            }
        }
    }
}
