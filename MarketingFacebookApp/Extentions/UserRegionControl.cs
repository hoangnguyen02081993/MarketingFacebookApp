using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingFacebookApp.Extentions
{
    public class UserRegionControl : Panel
    {
        public delegate void Logout(object sender, string id);
        public event Logout OnLogout;

        private PictureBox pic = new PictureBox();
        private Label lable = new Label();
        private Button btn_logout = new Button();
        private string Id { set; get; }
        public UserRegionControl(string id, string image, string name) : base()
        {
            this.Width = 170;
            this.Height = 45;

            pic.Size = new System.Drawing.Size(40, 40);
            pic.Location = new System.Drawing.Point(0, 0);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Load(image);
            this.Controls.Add(pic);

            lable.Location = new Point(50, 2);
            lable.Size = new Size(120, 15);
            lable.Text = name;
            lable.ForeColor = Color.Red;
            this.Controls.Add(lable);

            Id = id;

            btn_logout.Location = new Point(50, 20);
            btn_logout.Size = new Size(100, 21);
            btn_logout.Text = "Đăng xuất";
            btn_logout.Click += Btn_logout_Click;
            this.Controls.Add(btn_logout);
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            OnLogout?.Invoke(this, Id);
        }
    }
}
