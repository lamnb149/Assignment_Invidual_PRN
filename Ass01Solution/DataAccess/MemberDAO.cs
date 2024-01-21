using BusinessObject;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<Member> _memberList = new List<Member>() {
            new Member()
            {
                MemberID = 1,
                MemberName = "Nguyễn Văn A",
                Email = "nguyenvana@gmail.com",
                Password = "A123456",
                City = "Hà Nội",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 2,
                MemberName = "Trần Thị B",
                Email = "tranthibb@yahoo.com",
                Password = "A123456",
                City = "Hồ Chí Minh",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 3,
                MemberName = "Lê Văn C",
                Email = "levanthanhcong@hotmail.com",
                Password = "A123456",
                City = "Đà Nẵng",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 4,
                MemberName = "Phạm Thị D",
                Email = "phamthid@outlook.com",
                Password = "A123456",
                City = "Huế",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 5,
                MemberName = "Hoàng Văn E",
                Email = "hoangvane@fstore.com",
                Password = "A123456",
                City = "Nha Trang",
                Country = "Việt Nam"
            }
        };
        //--------------------------------------------
        private static MemberDAO instance = null;
        private static readonly object _instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock(_instanceLock)
                {
                    if (instance == null) 
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Member> GetMemberList => _memberList;
        public Member GetMemberByID(int memberID)
        {
            Member member = _memberList.SingleOrDefault(emp => emp.MemberID == memberID);
            return member;
        }
        public void AddNew(Member member)
        {
            Member emp = GetMemberByID(member.MemberID);
            if (emp == null)
            {
                _memberList.Add(member);
            }
            else
            {
                throw new Exception("Member is already exists.");
            }
        }
        public void Update(Member member)
        {
            Member emp = GetMemberByID(member.MemberID);
            if (emp != null) 
            {
                int index = _memberList.IndexOf(emp);
                _memberList[index] = member;
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
        public void Remove(int memberID) 
        {
            Member emp = GetMemberByID(memberID);
            if (emp != null) 
            {
                _memberList.Remove(emp);
            }
            else
            {
                throw new Exception("Member does not already exists.");
            }
        }
    }
}
