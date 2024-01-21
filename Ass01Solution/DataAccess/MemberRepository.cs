using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberID) => MemberDAO.Instance.Remove(memberID);

        public Member GetMemberByID(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMemberList;

        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);

        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);

    }
}
