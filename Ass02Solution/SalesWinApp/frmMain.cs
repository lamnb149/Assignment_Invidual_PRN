using BusinessObject;
using DataAccess.Repository;
using MyStoreWinApp;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public bool isAdmin { set; get; } = true;
        public MemberObject memberValue { set; get; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmMembers frmMembers = new frmMembers()
            {
                memberRepository = new MemberRepository(),
                IsAdmin = isAdmin,
                memberValue = memberValue
            };
            frmMembers.ShowDialog();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frmProducts frmProduct = new frmProducts()
            {
                productRepository = new ProductRepository(),
                IsAdmin = isAdmin,
                memberValue = memberValue
            };
            frmProduct.ShowDialog();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            frmOrders frmOrders = new frmOrders()
            {
                OrderRepository = new OrderRepository(),
                OrderDetailRepository = new OrderDetailRepository(),
                IsAdmin= isAdmin,
                MemberValue = memberValue
            };
            frmOrders.ShowDialog();
        }
    }
}
