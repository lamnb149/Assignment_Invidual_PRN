using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public bool InsertOrUpdate { get; set; } // false: insert, true: update
        public Member MemberInfo { set; get; } 
        public IMemberRepository MemberRepository { get; set; }
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtMemberId.Text = MemberInfo.MemberID.ToString();
                txtName.Text = MemberInfo.MemberName.Trim();
                txtPassword.Text = MemberInfo.Password;
                txtEmail.Text = MemberInfo.Email.Trim();
                txtCountry.Text = MemberInfo.Country.Trim();
                txtCity.Text = MemberInfo.City.Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member {
                    MemberID = int.Parse(txtMemberId.Text),
                    MemberName = txtName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text,
                    City = txtCity.Text.Trim(),
                    Country = txtCountry.Text.Trim()
                };
                if (!InsertOrUpdate) 
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, !InsertOrUpdate ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
