using System;
using System.Security.Cryptography;  
using System.Text;
using System.IO;
namespace DBUtility
{
    /// <summary>
    /// DES����/�����ࡣ
    /// </summary>
    public class DESEncrypt
    {
        public DESEncrypt()
        {
        }

        #region ʹ�öԳƼ��ܡ�����       
        /// <summary> 
        /// ʹ�öԳ��㷨����
        /// </summary>
        /// <param name="str"></param> 
        /// <param name="encryptKey"></param>
        /// <returns></returns>
        public static string SymmetricEncrypts(string str, string encryptKey)
        {
            string result = string.Empty;
            byte[] inputData = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] IV = { 0x77, 0x70, 0x50, 0xD9, 0xE1, 0x7F, 0x23, 0x13, 0x7A, 0xB3, 0xC7, 0xA7, 0x48, 0x2A, 0x4B, 0x39 };
            try
            {
                byte[] byKey = System.Text.Encoding.UTF8.GetBytes(encryptKey);
                //����ָ�������㷨������Create()������ָ���ַ���
                //Create()�����еĲ��������ǣ�DES��RC2 System��Rijndael��TripleDES 
                //���ò�ͬ��ʵ�����IV������Ҫ��һ��(������GenerateIV()��������)���޲�����ʾ��Rijndael
                SymmetricAlgorithm Algorithm = SymmetricAlgorithm.Create();//����һ�ּ����㷨
                MemoryStream msTarget = new MemoryStream();
                //���彫���������ӵ�����ת��������
                CryptoStream encStream = new CryptoStream(msTarget, Algorithm.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
                encStream.Write(inputData, 0, inputData.Length);
                encStream.FlushFinalBlock();
                result = Convert.ToBase64String(msTarget.ToArray());
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }
        
        /// <summary>
        /// ʹ�öԳ��㷨����
        /// </summary>
        /// <param name="encryptStr"></param>
        /// <param name="encryptKey"></param>
        /// <returns></returns>
        public static string SymmectricDecrypts(string encryptStr, string encryptKey)
        {
            string result = string.Empty;
            //����ʱʹ�õ���Convert.ToBase64String(),����ʱ����ʹ��Convert.FromBase64String()
            try
            {
                byte[] encryptData = Convert.FromBase64String(encryptStr);
                byte[] byKey = System.Text.Encoding.UTF8.GetBytes(encryptKey);
                byte[] IV = { 0x77, 0x70, 0x50, 0xD9, 0xE1, 0x7F, 0x23, 0x13, 0x7A, 0xB3, 0xC7, 0xA7, 0x48, 0x2A, 0x4B, 0x39 };
                SymmetricAlgorithm Algorithm = SymmetricAlgorithm.Create();
                MemoryStream msTarget = new MemoryStream();
                CryptoStream decStream = new CryptoStream(msTarget, Algorithm.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
                decStream.Write(encryptData, 0, encryptData.Length);
                decStream.FlushFinalBlock();
                result = System.Text.Encoding.Default.GetString(msTarget.ToArray());
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }
        #endregion


    }
}
