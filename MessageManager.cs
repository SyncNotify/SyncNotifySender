using Newtonsoft.Json;
using SyncNotifySender.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SyncNotifySender
{
    internal class MessageManager
    {
        public void SaveMessageToFile(Message message)
        {

            string text = JsonConvert.SerializeObject(message, Formatting.Indented);
            MessageBox.Show(text);
            try
            {
                System.IO.File.WriteAllText(@"D:\sync\通知\" + DateTime.Now + ".json", text);
            }
            catch { }
        }
    }
}
