using MarketingFacebookApp.Extentions;
using MarketingFacebookApp.Helpers;
using MarketingFacebookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingFacebookApp
{
    public partial class Form1 : Form
    {
        private JsonDBHelper db = new JsonDBHelper();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.ReadData();
            LoadUserOnRegion(db.GetUsers());
            LoadData();
        }
        private void LoadData()
        {
            tp_addfriend_type.SelectedIndex = 0;
        }
        private void LoadUserOnRegion(IEnumerable<User> users)
        {
            pn_user.ClearUserRegion();
            foreach (var item in users)
            {
                UserRegionControl control = new UserRegionControl(item.Id, item.PathImage, item.FullName);
                control.OnLogout += Control_OnLogout;
                pn_user.AddUserRegion(control);
            }
        }

        private void Control_OnLogout(object sender, string id)
        {
            User user = new User()
            {
                Id = id
            };
            if(db.UserAction(user, ActionType.Remove))
            {
                pn_user.RemoveUserRegion(sender as UserRegionControl);
            }
            else
            {
                Until.ShowErrorBox("Không thể logout user");
            }
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            using (LoginPreview form = new LoginPreview())
            {
                
            }
        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {

        }

        private void tp_addfriend_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tp_addfriend_getlist_Click(object sender, EventArgs e)
        {
            switch(tp_addfriend_type.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
        }
    }
}
