using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyStoreWinApp
{
    public partial class frmMembers : Form
    {
        public IMemberRepository memberRepository { set; get; }
        public BindingSource source;
        public bool IsAdmin { set; get; }
        public MemberObject memberValue { set; get; }
        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            txtMemberId.Enabled = false;
            if (!IsAdmin)
            {
                btnDelete.Visible = false;
                btnAdd.Visible = false;
            }
            LoadMemberList();
        }

        private void LoadMemberList()
        {
            IEnumerable<MemberObject> members = memberRepository.GetMembers();

            try
            {
                source = new BindingSource();
                if (IsAdmin)
                {
                    source.DataSource = members;
                }
                else
                {
                    source.DataSource = memberRepository.GetMemberByID(memberValue.MemberId);
                }
                txtMemberId.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtCity.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberID");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dvgMemberList.DataSource = null;
                dvgMemberList.DataSource = source;
                
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
                source.Position = source.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
        } // End

        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject()
                {
                    MemberId = int.Parse(txtMemberId.Text),
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    CompanyName = txtCompanyName.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Car");
            }
            return member;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberId);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.UpdateMember(member);
                MessageBox.Show($"Update Member {member.MemberId} successfully!");
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update a member");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            { 
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
            }
        }
    }
}
