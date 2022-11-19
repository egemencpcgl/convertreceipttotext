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
        private string path = Directory.GetCurrentDirectory() + "/response.json";
        #endregion

        #region Public Prop
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
                    //Log.Error("An error occurred while getting Link Settings.Could not find file " + dictionary.ModulePath);
                }
            }
            catch (Exception e)
            {
                //Log.Error("Link Configuration File do not created", e.Message);
            }
        }

    }
}
