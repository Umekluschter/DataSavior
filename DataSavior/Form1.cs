using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSavior
{
    public partial class Form : System.Windows.Forms.Form
    {
        string filePath;
        string folderPath;
        string fileName;
        string[] filePathSplit;

        public Form()
        {
            InitializeComponent();
            btn_tab_encrypt.BackColor = Color.FromArgb(56, 54, 96);
            pnl_decrypt.Visible = false;
        }

        private void btn_choose_file_encrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\josia\\Desktop";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    filePathSplit = filePath.Split('\\');
                    fileName = filePathSplit[filePathSplit.Length - 1];
                    lbl_input_encrypt.Text = $"Input: {fileName}";
                    lbl_data_encrypt.Text = "Data: File";
                }
            }
        }

        private void btn_choose_folder_encrypt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowser.ShowNewFolderButton = true;

            // Show the FolderBrowserDialog.  
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPath = folderBrowser.SelectedPath;
                var folderPathSplit = folderPath.Split('\\');
                lbl_input_encrypt.Text = $"Input: {folderPathSplit[folderPathSplit.Length - 1]}";
                lbl_data_encrypt.Text = "Data: Folder";
            }
        }

        private void btn_method_1_encrypt_Click(object sender, EventArgs e)
        {
            SHA512 shaM = new SHA512Managed();

            var password = GetPassword();
            var passwordBytes = Encoding.ASCII.GetBytes(password);
            var passwordHashed = shaM.ComputeHash(passwordBytes);

            var fileData = File.ReadAllBytes(filePath);
            var computedData = GetComputedBytes(fileData, passwordBytes);

            File.CreateText(filePath.Substring(0, filePath.Length - 4) + "_encrypted_Viginere.txt");

            File.WriteAllText(filePath.Substring(0, filePath.Length - 4) + "_encrypted_Viginere.txt", GetHashString(passwordHashed) + "\n" + Encoding.UTF8.GetString(computedData));
        }

        private string GetHashString(byte[] byteArray)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteArray)
                sb.Append(b.ToString("x2"));

            return sb.ToString();
        }

        private byte[] GetComputedBytes(byte[] fileData, byte[] passwordBytes)
        {
            var fileIndex = 0;
            for (int i = 0; i < (fileData.Length / passwordBytes.Length); i++)
            {
                for (int o = 0; o < passwordBytes.Length; o++)
                {
                    fileData[fileIndex] += passwordBytes[o];

                    if (fileData[fileIndex] > 127)
                    {
                        fileData[fileIndex] -= 127;
                    }
                    fileIndex++;
                }
            }
            return fileData;
        }


        private void btn_method_2_encrypt_Click(object sender, EventArgs e)
        {
            var password = GetPassword();

            if (!password.Equals(""))
            {
                SHA512 shaM = new SHA512Managed();
                var passwordBytes = Encoding.ASCII.GetBytes(password);
                var passwordHashed = shaM.ComputeHash(passwordBytes);

                FileEncryptAES(filePath, GetHashString(passwordHashed), password);
            }
        }

        private void btn_method_3_encrypt_Click(object sender, EventArgs e)
        {
            var password = GetPassword();

            if (!password.Equals(""))
            {
                FileEncryptDES(filePath, password);
            }
        }

        private static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }
            return data;
        }

        private void btn_tab_encrypt_Click(object sender, EventArgs e)
        {
            btn_tab_encrypt.BackColor = Color.FromArgb(56, 54, 96);
            btn_tab_decrypt.BackColor = Color.FromArgb(149, 147, 193);
            pnl_decrypt.Visible = false;
        }

        private void btn_tab_decrypt_Click(object sender, EventArgs e)
        {
            btn_tab_decrypt.BackColor = Color.FromArgb(56, 54, 96);
            btn_tab_encrypt.BackColor = Color.FromArgb(149, 147, 193);
            pnl_decrypt.Visible = true;
        }

        private string GetPassword()
        {
            var password = "";

            var regex = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\config.txt");
            var regexSplit = regex.Split('x');
            var regexNumber = new Regex(regexSplit[0]);
            var regexUpperChar = new Regex(regexSplit[1]);
            var regexLength = new Regex(regexSplit[2]);

            if (txt_password_encrypt.Text.Length > 0)
            {
                password = txt_password_encrypt.Text;
            }
            else if (txt_password_decrypt.Text.Length > 0)
            {
                password = txt_password_decrypt.Text;
            }

            if (regexLength.IsMatch(password))
            {
                if (regexNumber.IsMatch(password))
                {
                    if (regexUpperChar.IsMatch(password))
                    {
                        lbl_warning_password.Text = "";
                        txt_password_encrypt.Text = "";
                        txt_password_decrypt.Text = "";
                        return password;
                    }
                    else
                    {
                        lbl_warning_password.Text = "Password needs to contain at least one upper char!";
                        txt_password_encrypt.Text = "";
                        txt_password_decrypt.Text = "";
                    }
                }
                else
                {
                    lbl_warning_password.Text = "Password needs to contain at least one digit!";
                    txt_password_encrypt.Text = "";
                    txt_password_decrypt.Text = "";
                }
            }
            else
            {
                lbl_warning_password.Text = "Password needs to contain at least 8 characters!";
                txt_password_encrypt.Text = "";
                txt_password_decrypt.Text = "";
            }
            return "";
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            var password = GetPassword();

            if (!password.Equals(""))
            {
                if (filePath.Contains("Viginere"))
                {

                }
                else if (filePath.Contains("AES"))
                {
                    FileDecryptAES(filePath, filePath.Substring(0, filePath.Length - 4) + "_decrypted.txt", password);
                }
                else if (filePath.Contains("DES"))
                {
                    FileDecryptDES(filePath, password);
                }
            }
        }

        private void FileEncryptAES(string inputFile, string passwordHashed, string passwordPlain)
        {
            byte[] salt = GenerateRandomSalt();

            FileStream fsCrypt = new FileStream(filePath.Substring(0, filePath.Length - 4) + "_encrypted_AES.txt", FileMode.Create);

            byte[] passwordBytes = Encoding.UTF8.GetBytes(passwordHashed);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CBC;

            fsCrypt.Write(salt, 0, salt.Length);

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    cs.Write(buffer, 0, read);
                }

                // Close up
                fsIn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cs.Close();
                fsCrypt.Close();
            }
            AddMAC(filePath.Substring(0, filePath.Length - 4) + "_encrypted_AES.txt", passwordPlain);
        }

        private void FileDecryptAES(string inputFile, string outputFile, string password)
        {
            if (CheckMAC(password))
            {
                RemoveMAC(inputFile);

                SHA512 shaM = new SHA512Managed();
                var passwordBytes = Encoding.ASCII.GetBytes(password);
                var passwordHashed = shaM.ComputeHash(passwordBytes);

                byte[] passwordHashedBytes = Encoding.UTF8.GetBytes(GetHashString(passwordHashed));
                byte[] salt = new byte[32];

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
                fsCrypt.Read(salt, 0, salt.Length);

                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                var key = new Rfc2898DeriveBytes(passwordHashedBytes, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);
                //AES.Padding = PaddingMode.PKCS7;
                AES.Mode = CipherMode.CBC;

                CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int read;
                byte[] buffer = new byte[1048576];

                try
                {
                    while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        Application.DoEvents();
                        fsOut.Write(buffer, 0, read);
                    }
                }
                catch (CryptographicException ex_CryptographicException)
                {
                    Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                try
                {
                    cs.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
                }
                finally
                {
                    fsOut.Close();
                    fsCrypt.Close();
                }
            } 
            else
            {
                lbl_message_decrypt.Text = "Wrong Password!";
            }
        }

        public void FileEncryptDES(string inputFile, string passwordPlain)
        {
            TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

            byte[] byteHash;
            byte[] byteBuff;
            byte[] desIVKey = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };

            byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(passwordPlain));
            desCryptoProvider.Key = byteHash;
            desCryptoProvider.Mode = CipherMode.CBC;
            desCryptoProvider.IV = desIVKey;
            byteBuff = File.ReadAllBytes(inputFile);

            File.WriteAllBytes(filePath.Substring(0, filePath.Length - 4) + "_encrypted_DES.txt", desCryptoProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            AddMAC(filePath.Substring(0, filePath.Length - 4) + "_encrypted_DES.txt", passwordPlain);
        }

        public void FileDecryptDES(string inputFile, string password)
        {
            if (CheckMAC(password))
            {
                RemoveMAC(inputFile);

                TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

                byte[] byteHash;
                byte[] byteBuff;
                byte[] desIVKey = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };

                byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(password));
                desCryptoProvider.Key = byteHash;
                desCryptoProvider.Mode = CipherMode.CBC;
                desCryptoProvider.IV = desIVKey;
                byteBuff = File.ReadAllBytes(inputFile);

                File.WriteAllBytes(inputFile.Substring(0, inputFile.Length - 4) + "_decrypted.txt", desCryptoProvider.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            }
            else
            {
                lbl_message_decrypt.Text = "Wrong Password!";
            }
        }

        private void Form_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            filePath = files[0];

            filePathSplit = filePath.Split('\\');
            fileName = filePathSplit[filePathSplit.Length - 1];
            lbl_input_encrypt.Text = $"Input: {fileName}";
            lbl_data_encrypt.Text = "Data: File";
        }

        private void AddMAC(string fileAddMAC, string password)
        {
            SHA512 shaM = new SHA512Managed();
            var passwordBytes = Encoding.ASCII.GetBytes(password + "-MAC");
            var passwordHashed = shaM.ComputeHash(passwordBytes);

            var fileContent = File.ReadAllBytes(fileAddMAC);

            var fileContentMAC = fileContent.Concat(passwordHashed).ToArray();

            File.WriteAllBytes(fileAddMAC, fileContentMAC);
        }

        private bool CheckMAC(string password)
        {
            SHA512 shaM = new SHA512Managed();
            var passwordBytes = Encoding.ASCII.GetBytes(password + "-MAC");
            var passwordHashed = shaM.ComputeHash(passwordBytes);

            var fileContent = File.ReadAllBytes(filePath);

            var counter = 63;

            for (int i = fileContent.Length - 1; i > (fileContent.Length - 1) - 64; i--)
            {
                if (!fileContent[i].Equals(passwordHashed[counter]))
                {
                    return false;
                }
                counter--;
            }
            return true;
        }

        private void RemoveMAC(string inputFile)
        {
            var fileContentWithMAC = File.ReadAllBytes(inputFile);

            byte[] fileContentOnly = new byte[fileContentWithMAC.Length - 64];

            for (int i = 0; i < fileContentWithMAC.Length - 64; i++)
            {
                fileContentOnly[i] = fileContentWithMAC[i];
            }

            File.WriteAllBytes(filePath, fileContentOnly);
        }
    }
}
