using FormSide.DBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                LoadListUserGroup();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Load list user group! " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new SampleDBContext())
                {
                    try
                    {
                        UserGroups g = new UserGroups
                        {
                            GroupName = txtGroupName.Text
                        };

                        db.UserGroups.Add(g);
                        db.SaveChanges();
                        MessageBox.Show("Add user group success");
                        LoadListUserGroup();
                    }
                    catch (Exception exIns)
                    {
                        MessageBox.Show(exIns.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadListUserGroup()
        {
            ResetContent();
            using (var db = new SampleDBContext())
            {
                var t = db.UserGroups
                    .OrderBy(_k => _k.CreatedDate)
                    .Select(x => new {
                        x.IdUserGroup,
                        x.GroupName
                    }).ToList();
                dgv_UserGroup.DataSource = t;
                dgv_UserGroup.Refresh();
            }
        }

        void ResetContent()
        {
            txtGroupName.Clear();
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {

        }
    }
}
