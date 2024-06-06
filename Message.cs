using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncNotifySender
{
    internal class Message
    {
        //文件的实体类
        [JsonProperty("property")]
        internal Property Property { get; set; } = new Property();
        [JsonProperty("display")]
        internal Display Display { get; set; } = new Display();
    }
    internal class Property
    {
        //信息的内容
        [JsonProperty("FileContent")]
        public string FileContent { get; set; }

        //信息的类型（json或是txt）
        [JsonProperty("FileType")]
        public string FileType { get; set; }

        //信息发送者
        [JsonProperty("FileSender")]
        public string FileSender { get; set; }

        //信息文件的位置
        [JsonProperty("FileLocation")]
        public string FileLocation { get ; set; }

        //信息文件的名称
        [JsonProperty("FileName")]
        public string FileName { get ; set; }

        //信息名称的创建时间
        [JsonProperty("FileCreatingDate")]
        public DateTime FileCreatingTime { get; set; }
    }
    internal class Display
    {
        //信息的展示时间
        [JsonProperty("fileDisplayTime")]
        public DateTime FileDisplayTime { get; set; }
        //信息的展示方式：现在/下课后/指定时间
        [JsonProperty("fileDisplayMode")]
        public MessagePriority.Priority FileDisplayMode { get; set; }

    }
}
