using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }

        //商品
        public int GoodId { get; set; }
        //发送者id
        public int SenderId { get; set; }
        //接收者id
        public int ReceiverId { get; set; }
        //聊天信息类型
        public String InfoType { get; set; }
        //文字信息
        public string WordRecords { get; set; }
        //图片信息
        public Image Image { get; set; }
        public byte[] ImageByte { set; get; }

        public DateTime Time { get; set; }

        public Comment(int goodId,int senderId,int receiverId, DateTime time)
        {
            this.GoodId = goodId;
            this.SenderId = senderId;
            this.ReceiverId = receiverId;
            this.Time = time;
        }
    }
}
