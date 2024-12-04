using System.Text;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;

namespace HashApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            radioButtonHex.Visible = false;
            radioButtonText.Visible = false;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string formatData = comboBoxFormatData.Text;
            if (formatData.Equals("Text"))
            {

                string data = textBoxData.Text;
                if (checkBoxMD5.Checked)
                {
                    textBoxMD5.Text = ComputeMD5Hash(data);
                }
                if (checkBoxSHA1.Checked)
                {
                    textBoxSHA1.Text = ComputeSha1Hash(data);
                }
                if (checkBoxSHA2.Checked)
                {
                    textBoxSHA256.Text = ComputeSha256Hash(data);
                }

            }
            else if (formatData.Equals("Hex"))
            {
                
                string data = textBoxData.Text;
                if (data.Length % 2 != 0)
                {
                    MessageBox.Show("Data invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (checkBoxMD5.Checked)
                {
                    // textBoxMD5.Text = ComputeMD5Hash(dataHex);
                    try
                    {
                        textBoxMD5.Text = ComputeMD5HashFromHex(data);
                    }
                    catch
                    {
                        MessageBox.Show("Error data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                }
                if (checkBoxSHA1.Checked)
                {
                    try
                    {
                        textBoxSHA1.Text = ComputeSHA1HashFromHex(data);
                    }
                    catch
                    {
                        MessageBox.Show("Error data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                if (checkBoxSHA2.Checked)
                {
                    try
                    {
                        textBoxSHA256.Text = ComputeSHA256HashFromHex(data);
                    }
                    catch
                    {
                        MessageBox.Show("Error data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                string pathFile = textBoxData.Text;
                string fileContent = File.ReadAllText(pathFile);
               
                if (!radioButtonHex.Checked && !radioButtonText.Checked)
                {
                    MessageBox.Show("Please choose content type of your file ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (radioButtonHex.Checked)
                {
                    if (fileContent.Length % 2 != 0)
                    {
                        MessageBox.Show("Data invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }                    
                    if (checkBoxMD5.Checked)
                    {
                        try
                        {
                            textBoxMD5.Text = ComputeMD5HashFromHex(fileContent);
                        }
                        catch
                        {
                            MessageBox.Show("Error data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                    }
                    if (checkBoxSHA1.Checked)
                    {
                        try
                        {
                            textBoxSHA1.Text = ComputeSHA1HashFromHex(fileContent);
                        }
                        catch
                        {
                            MessageBox.Show("Error data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (checkBoxSHA2.Checked)
                    {
                        try
                        {
                            textBoxSHA256.Text = ComputeSHA256HashFromHex(fileContent);
                        }
                        catch
                        {
                            MessageBox.Show("Error data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                    }
                }
                else
                {
                    if (checkBoxMD5.Checked)
                    {
                        try
                        {
                            textBoxMD5.Text = ComputeMD5Hash(fileContent);
                        }
                        catch
                        {
                            MessageBox.Show("Error data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (checkBoxSHA1.Checked)
                    {
                        try
                        {
                            textBoxSHA1.Text = ComputeSha1Hash(fileContent);
                        }
                        catch
                        {
                            MessageBox.Show("Error data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    if (checkBoxSHA2.Checked)
                    {
                        try
                        {
                            textBoxSHA256.Text = ComputeSha256Hash(fileContent);
                        }
                        catch
                        {
                            MessageBox.Show("Error data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
               

            }


        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private string ComputeSha1Hash(string rawData)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] bytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        private string ComputeMD5Hash(string rawData)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes = md5.ComputeHash(Encoding.ASCII.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }


        private string ComputeMD5HashFromHex(string hexData)
        {
            
            using (MD5 md5 = MD5.Create())
            {
                
                byte[] bytes = Enumerable.Range(0, hexData.Length / 2)
                                            .Select(i => Convert.ToByte(hexData.Substring(i * 2, 2), 16))
                                            .ToArray();

                
                byte[] hashBytes = md5.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
            
           
            
        }

        private string ComputeSHA1HashFromHex(string hexData)
        {
            
            using (SHA1 sha = SHA1.Create())
            {
                
                byte[] bytes = Enumerable.Range(0, hexData.Length / 2)
                                            .Select(i => Convert.ToByte(hexData.Substring(i * 2, 2), 16))
                                            .ToArray();

                
                byte[] hashBytes = sha.ComputeHash(bytes);

                
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
           
            
        }

        private string ComputeSHA256HashFromHex(string hexData)
        {
            
            using (SHA256 sha256 = SHA256.Create())
            {
                
                byte[] bytes = Enumerable.Range(0, hexData.Length / 2)
                                            .Select(i => Convert.ToByte(hexData.Substring(i * 2, 2), 16))
                                            .ToArray();

                
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
            
           
           
        }

        private string HexToString(string hex)
        {

            int numberChars = hex.Length;


            byte[] bytes = new byte[numberChars / 2];


            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }


            //MessageBox.Show(Encoding.ASCII.GetString(bytes));
            return Encoding.ASCII.GetString(bytes);
        }



        private void comboBoxFormatData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFormatData.SelectedIndex == 2)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Select file";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    textBoxData.Text = filePath;
                    displayGroupBox();

                }
                
            }
            else
            {
                hiddenGroupBox();
            }
        }

        private void displayGroupBox()
        {
            groupBox1.Visible = true;
            radioButtonHex.Visible = true;
            radioButtonText.Visible=true;
        }

        private void hiddenGroupBox()
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
                radioButtonHex.Visible = false;
                radioButtonText.Visible = false;
            }
            
        }

     
    }
}
