using DataAccess;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Internal;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter Username";

        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter Password";
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            string _configUsername = config["AdminAccount:Username"];
            string _configPassword = config["AdminAccount:Password"];
            if (username.Equals(_configUsername))
            {
                if (password.Equals(_configPassword))
                {
                    MessageBox.Show("Login Successfully!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain mainFrm = new frmMain();
                    mainFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Fail!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (isLogin(username, password, out int memberID))
                {
                    MessageBox.Show("Login Successfully!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain mainFrm = new frmMain()
                    {
                        isAdmin = false,
                        memberValue = memberRepository.GetMemberByID(memberID)
                    };
                    mainFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Fail!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool isLogin(string username, string password, out int memberId)
        {
            memberRepository = new MemberRepository();
            foreach (var member in memberRepository.GetMembers())
            {
                if (member.Email.Equals(username) && member.Password.Equals(password))
                {
                    memberId = member.MemberId;
                    return true;
                }
            }
            memberId = -1;
            return false;
        }
    }
}
