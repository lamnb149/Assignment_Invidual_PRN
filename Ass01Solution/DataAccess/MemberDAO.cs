using BusinessObject;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<Member> _memberList = new List<Member>() {
            new Member()
            {
                MemberID = 1,
                MemberName = "Nguyễn Văn A",
                Email = "anv1@gmail.com",
                Password = "A123",
                City = "Hà Nội",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 2,
                MemberName = "Trần Thị Bình",
                Email = "binhtt2@gmail.com",
                Password = "A123",
                City = "Hồ Chí Minh",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 3,
                MemberName = "Lê Văn Công",
                Email = "conglv3@gmail.com",
                Password = "A123",
                City = "Đà Nẵng",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 4, 
                MemberName = "Phạm Thị Thảo", 
                Email = "thaopt4@gmail.com",
                Password = "A123",
                City = "Hải Phòng",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 5, 
                MemberName = "Hoàng Văn Dũng", 
                Email = "dunghv5@gmail.com",
                Password = "A123",
                City = "Tokyo",
                Country = "Japan"
            },
            new Member()
            {
                MemberID = 6,
                MemberName = "Trần Đức Minh",
                Email = "minhtd@yahoo.com",
                Password = "A123",
                City = "Hà Nội",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 7,
                MemberName = "Phạm Thị Ngọc Lan",
                Email = "lanptn@outlook.com",
                Password = "A123",
                City = "Hà Nội",
                Country = "Việt Nam"
            },
            new Member()
            {
                MemberID = 8,
                MemberName = "Nguyễn Hoàng Nam",
                Email = "namnh@hotmail.com",
                Password = "A123",
                City = "Tokyo",
                Country = "Japan"
            },
            new Member()
            {
                MemberID = 9,
                MemberName = "Lê Thị Thu Trang",
                Email = "trangltt@gmail.com",
                Password = "A123",
                City = "Đà Nẵng",
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
                lock (_instanceLock)
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
        public List<Member> GetMemberByName(string name)
        {
            if (name == null) 
            {
                return null;
            }
            List<Member> list = null;
            foreach (Member member in _memberList) 
            { 
                if (member.MemberName.Contains(name))
                {
                    list.Add(member);
                }
            }
            return list;
        }
        public Member GetMemberByUsername(string username)
        {
            Member member = _memberList.SingleOrDefault(emp => emp.Email.Equals(username));
            return member;
        }
    }
}
