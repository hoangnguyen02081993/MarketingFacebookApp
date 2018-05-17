using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingFacebookApp.Extentions
{
    public static class ControlExtention
    {
        public static void AddUserRegion(this Panel panel, UserRegionControl user)
        {
            user.Location = new System.Drawing.Point(10, 50 * panel.Controls.Count + 10);
            panel.Controls.Add(user);
        }
        public static void RemoveUserRegion(this Panel panel, UserRegionControl user)
        {
            panel.Controls.Remove(user);

            List<UserRegionControl> temp = new List<UserRegionControl>();
            foreach (var control in panel.Controls)
            {
                temp.Add(control as UserRegionControl);
            }

            panel.Controls.Clear();

            foreach (var control in temp)
            {
                control.Location = new System.Drawing.Point(10, 50 * panel.Controls.Count + 10);
                panel.Controls.Add(control);
            }
        }
        public static void ClearUserRegion(this Panel panel)
        {
            panel.Controls.Clear();
        }
    }
}
