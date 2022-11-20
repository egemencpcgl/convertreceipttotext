using ConvertReceiptToText.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConvertReceiptToText.ReceiptOperation
{
    public class ReceiptManager
    {
        #region Private Prop
        private List<Receipt> receiptInformation { get; set; }
        #endregion

        #region Public Prop
        public string path = Directory.GetCurrentDirectory() + "/response.json";

        public List<Receipt> ReceiptInformation 
        {
            get { return receiptInformation; }
            set { receiptInformation = value; }
        }
        #endregion

        #region Singleton
        private static ReceiptManager receiptManager;
        public static ReceiptManager Receiptmanager
        {
            get
            {
                if (receiptManager == null)
                {
                    receiptManager = new ReceiptManager();
                }
                return receiptManager;
            }
        }
        #endregion

        public void ReadReceiptFile()
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string json = reader.ReadToEnd();
                        ReceiptInformation = JsonConvert.DeserializeObject<List<Receipt>>(json.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("File doesn't exists");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something happened wrong during of read or convert file: "+e.Message);
            }
        }

    }
}
