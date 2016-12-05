using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
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

    class LoginEncoder
    {
        private string username;
        private string password;
        private FileManager toEncodeFile;
        public LoginEncoder(string username, string password)
        {
            this.username = username;
            this.password = password;
            toEncodeFile = new FileManager(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\LoginStorage\\Users\\" + username + ".ls");
        }

        public bool Save(List<LoginFormular> loginList)
        {
            try
            {
                string jsonLoginList = Newtonsoft.Json.JsonConvert.SerializeObject(loginList);
                toEncodeFile.WriteFile(EncryptString(jsonLoginList, password));
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string EncryptString(string plainText, string password)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, new byte[0]);
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider
            {
                IV = new byte[8],
                Key = pdb.CryptDeriveKey("3DES", "SHA512", 168, new byte[8])
            };
            MemoryStream ms = new MemoryStream(plainText.Length * 2);
            CryptoStream encStream = new CryptoStream(ms, tdes.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            encStream.Write(plainBytes, 0, plainBytes.Length);
            encStream.FlushFinalBlock();
            byte[] encryptedBytes = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(encryptedBytes, 0, (int)ms.Length);
            encStream.Close();
            return Convert.ToBase64String(encryptedBytes);
        }

    }
}
