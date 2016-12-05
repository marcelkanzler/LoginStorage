using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_storage.DataManager
{
    #region Open Source Attributions

    /*
    Open Source Attributions
    ------------------------
    Login Storage made use of substantial portions and/or was heavily influenced by the following open source software:
     
    JSON.NET: https://github.com/JamesNK/Newtonsoft.Json
     
        The MIT License
        Copyright (c) 2007 James Newton-King
        License available at: https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md
     */
    #endregion

    class LoginDecoder
    {
        private FileManager toDeocdeFile;
        private List<LoginFormular> loginList;
        private string password;
        public LoginDecoder(string username, string password)
        {
            this.password = password;
            toDeocdeFile = new FileManager(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LoginStorage\\Users\\" + username + ".ls");
        }

        public bool IsCorrectPassword()
        {
            string readedFile = toDeocdeFile.ReadFile();
            if (readedFile == null)
            {
                return true;
            }
            try
            {   //3DES Decode
                readedFile = EncryptString(readedFile, password);
                //JSON to List<Object>
                loginList = JsonConvert.DeserializeObject<List<LoginFormular>>(readedFile);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public List<LoginFormular> GetLoginList()
        {
            return this.loginList;
        }

        public string EncryptString(string encryptedText, string password)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[0]);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider
            {
                IV = new byte[8],
                Key = pdb.CryptDeriveKey("3DES", "SHA512", 168, new byte[8])
            };
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            MemoryStream ms = new MemoryStream(encryptedText.Length);
            CryptoStream decStream = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
            decStream.FlushFinalBlock();
            byte[] plainBytes = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(plainBytes, 0, (int)ms.Length);
            decStream.Close();
            return Encoding.UTF8.GetString(plainBytes);
        }


    }
}
