
using DataAccess;
using Microsoft.Extensions.Configuration;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = txtUsername.Text.Trim();
            string _password = txtPassword.Text;
            string _usernameConf = "admin";
            string _passwordConf = "admin";
            if (_username.Equals(_usernameConf))
            {
                if (_password.Equals(_passwordConf))
                {
                    frmMemberManagements frmMemberManagements = new frmMemberManagements()
                    {
                        IsAdmin = true,
                        memberRepository = new MemberRepository(),
                    };
                    frmMemberManagements.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong email or password!", "Failed Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (isLogin(_username, _password))
            {
                frmMemberManagements frmMemberManagements = new frmMemberManagements()
                {
                    IsAdmin = false,
                    memberRepository = new MemberRepository(),
                    username = _username
                };
                frmMemberManagements.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong email or password!", "Failed Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtPassword.Text = string.Empty;
        }

        private bool isLogin(string username, string password)
        {
            memberRepository = new MemberRepository();
            foreach (var member in memberRepository.GetMembers())
            {
                if (member.Email.Equals(username) && member.Password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

    }
}
