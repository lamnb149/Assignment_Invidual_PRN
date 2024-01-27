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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyStoreWinApp
{
    public partial class frmMemberManagements : Form
    {
        public IMemberRepository memberRepository { set; get; }
        public BindingSource source;
        public bool IsAdmin { set; get; }
        public string username { set; get; }
        public frmMemberManagements()
        {
            InitializeComponent();
        }

        //-----LOAD FORM----------------------------------------------------
        private void frmMemberManagements_Load(object sender, EventArgs e)
        {

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            if (IsAdmin)
            {
                btnAdd.Enabled = true;
                txtSearchID.Enabled = false;
                txtSearchName.Enabled = false;
                cboCity.Enabled = false;
                cboCountry.Enabled = false;
            }
            else
            {
                txtSearchID.Visible = false;
                txtSearchName.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                btnSort.Visible = false;
                btnSearchName.Visible = false;
                cboCity.Visible = false;
                cboCountry.Visible = false;
                lbFilter.Visible = false;
            }

            dvgMemberList.CellDoubleClick += DvgMemberList_CellDoubleClick;
        } // End 
        //----------------------------------------------------------------------------------
        private void DvgMemberList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        } // End 
        //----------------------------------------------------------------------------------
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
            if (IsAdmin)
            {
                txtSearchID.Enabled = true;
                txtSearchName.Enabled = true;
                AddItemCboCountry();
                AddItemCboCity();
                cboCity.Enabled = true;
                cboCountry.Enabled = true;
            }
        } // End
        //----------------------------------------------------------------------------------
        private void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
        } // End
        //----Get Member Object-----------------------------------------------------------------
        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberID = int.Parse(txtMemberId.Text),
                    MemberName = txtName.Text,
                    Email = txtEmail.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        } // end
        //----------------------------------------------------------------------------------
        private void LoadMemberList()
        {
            IEnumerable<Member> members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                if (IsAdmin)
                {
                    source.DataSource = members;
                }
                else
                {
                    source.DataSource = memberRepository.GetMemberByUsername(username.Trim());
                }
                txtMemberId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtCity.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "MemberID");
                txtName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dvgMemberList.DataSource = null;
                dvgMemberList.DataSource = source;
                if (IsAdmin)
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails()
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void SearchByID()
        {
            int searchID;
            if (int.TryParse(txtSearchID.Text, out searchID))
            {
                try
                {
                    Member member = memberRepository.GetMemberByID(searchID);
                    if (member != null)
                    {
                        source.DataSource = member;
                    }
                    else
                    {
                        MessageBox.Show("Member not found with ID: " + searchID, "Search Result");
                        ClearText();
                        txtSearchID.Text = string.Empty;
                        LoadMemberList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search by ID");
                }
            }
            else if (txtSearchID.Text != "")
            {
                MessageBox.Show("Invalid ID format. Please enter a valid integer.", "Search Error");
                txtSearchID.Text = string.Empty;
            }
            else
            {
                LoadMemberList();
            }
        }

        private List<string> GetCountryList()
        {
            List<string> countryList = new();
            foreach (var item in memberRepository.GetMembers())
            {
                if (!countryList.Contains(item.Country))
                {
                    countryList.Add(item.Country);
                }
            }
            return countryList;
        }

        private void AddItemCboCountry()
        {
            List<string> countryList = GetCountryList();
            countryList.Add("All");
            cboCountry.Items.Clear();

            foreach (string country in countryList)
            {
                cboCountry.Items.Add(country);
            }
            cboCountry.SelectedItem = countryList[countryList.Count - 1];
        }

        private List<string> GetCityList()
        {
            List<string> cityList = new();
            foreach (var item in memberRepository.GetMembers())
            {
                if (!cityList.Contains(item.City))
                {
                    cityList.Add(item.City);
                }
            }
            return cityList;
        }

        private void AddItemCboCity()
        {
            List<string> cityList = GetCityList();
            cityList.Add("All");
            cboCity.Items.Clear();

            foreach (string city in cityList)
            {
                cboCity.Items.Add(city);
            }
            cboCity.SelectedItem = cityList[cityList.Count - 1];
        }

        private void SearchByName()
        {
            txtSearchID.Text = string.Empty;
            string searchName = txtSearchName.Text.Trim();
            List<Member> members = source.Cast<Member>().Where(emp => emp.MemberName.Contains(searchName)).ToList();
            if (searchName != null)
            {
                source.DataSource = members;
            }
            else
            {
                LoadMemberList();
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            SearchByName();
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            SearchByID();
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchID.Text = string.Empty;
            List<Member> _discardedList; 
            FilterCountry(out _discardedList);
        }

        private void FilterCountry(out List<Member> list)
        {
            string filter = cboCountry.Text;
            List<Member> filterCountry = memberRepository.GetMembers().Cast<Member>().Where(emp => emp.Country.Equals(filter)).ToList();
            list = filterCountry;
            if (filter.Equals("All"))
            {
                LoadMemberList();
            }
            else
            {
                source.DataSource = filterCountry;
            }
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchID.Text = string.Empty;
            FilterCity();
        }

        private void FilterCity()
        {
            List<Member> filteredCountry;
            FilterCountry(out filteredCountry);
            string selectedCity = cboCity.Text;
            if (selectedCity.Equals("All"))
            {
                LoadMemberList();
                cboCountry.Text = string.Empty;
            }
            else
            {
                List<Member> filterCity = filteredCountry.Cast<Member>().Where(emp => emp.City.Equals(selectedCity)).ToList();
                source.DataSource = filterCity;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortDescending();
        }

        private void SortDescending()
        {
            if (source != null)
            {
                List<Member> members = source.Cast<Member>().ToList();
                if (members != null)
                {
                    members.Sort((m1, m2) => m2.MemberName.CompareTo(m1.MemberName));

                    source.DataSource = members;
                }
            }
        }
    }
}
