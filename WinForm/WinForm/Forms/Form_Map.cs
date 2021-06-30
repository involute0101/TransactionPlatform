using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;


namespace WinForm
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]//调用JS代码必要
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form_Map : Form
    {
        private string mapPage = "";
        public string MapLng { get; set; }
        public string MapLat { get; set; }
        public PageConsult consultForm;


        public Form_Map(PageConsult consultForm)
        {
            //发送窗口
            mapPage = "\\MapSend.html";
            MapLng = "114.375832";
            MapLat = "30.544238";
            InitializeComponent();
            this.consultForm = consultForm;
            timerShow.Enabled = false;
            btnSend.Show();
        }

        public Form_Map(string x, string y)
        {
            //接收窗口
            mapPage = "\\MapReceive.html";
            MapLng = x;
            MapLat = y;
            InitializeComponent();
            timerShow.Enabled = true;
            btnSend.Hide();
        }

        private void Form_Map_Load(object sender, EventArgs e)
        {
            try
            {
                string str_url = Application.StartupPath + mapPage;
                Uri url = new Uri(str_url);
                wbsMap.Url = url;
                wbsMap.ObjectForScripting = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MapLng = wbsMap.Document.GetElementById("mouselng").InnerText;
            MapLat = wbsMap.Document.GetElementById("mouselat").InnerText;
            consultForm.sendMap(MapLng, MapLat);
            this.Close();
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            wbsMap.Document.InvokeScript("setLocation", new object[] { double.Parse(MapLng), double.Parse(MapLat) });
            timerShow.Stop();
        }
    }
}
