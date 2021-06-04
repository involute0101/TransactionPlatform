using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class SubPagePublish : UserControl
    {
        public SubPagePublish()
        {
            InitializeComponent();

            //一下为初始化图片，动态加载，防止选择图片时，新的不能覆盖旧的
            FileStream fs = new FileStream("addImage.png", FileMode.Open,
                              FileAccess.Read);                     //获取图片文件流
            Image img = Image.FromStream(fs);
            pictureBoxAdd.Image = img;
            fs.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)      //添加图片按钮点击
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            //MessageBox.Show(dlg.FileName);
            {
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open,
                              FileAccess.Read);                     //获取图片文件流
                Image img = Image.FromStream(fs);                   // 文件流转换成Image格式              
                pictureBoxAdd.Image = img;                          //给 图片框设置要显示的图片
                fs.Close();                                         // 关闭流，释放图片资源
            }
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {

        }
    }
}
