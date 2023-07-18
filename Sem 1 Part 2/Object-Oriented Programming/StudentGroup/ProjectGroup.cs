using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    public class ProjectGroup
    {
		private int id;
		private string name;
		private List<Member> members;

		public ProjectGroup(string name)
		{
			Name = name;
			Members = new List<Member>();
		}
		public ProjectGroup(int id, string name)
		{ 
			Id= id;
			Name = name;
			Members= new List<Member>();
		}
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public List<Member> Members
		{	
			get { return members; }
			set { members = value; }
		}
		public void AddMember(Member member)
		{ 
			members.Add(member);
		}
		public void RemoveMember(Member member)
		{
			members.Remove(member);
		}
        public override string ToString()
        {
            return Name;
        }
    }
}
