﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int memberID);
        void InsertMember(Member member);
        void DeleteMember(int memberID);
        void UpdateMember(Member member);
        List<Member> GetMemberByName(string name);
        Member GetMemberByUsername(string username);
    }
}
