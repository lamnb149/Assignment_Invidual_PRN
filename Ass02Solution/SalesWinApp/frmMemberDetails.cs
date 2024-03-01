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
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject {
                    MemberId = int.Parse(txtMemberId.Text),
                    CompanyName = txtCompanyName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text,
                    City = txtCity.Text.Trim(),
                    Country = txtCountry.Text.Trim()
                };
                MemberRepository.InsertMember(member);
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add a new member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
