using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    public class Member
    {
        private int id;
        private string name;
        private int projectGroupId;

        public Member(string name, int projectGroupId)
        {
            Name = name;
            ProjectGroupId = projectGroupId;
        }
        public Member(int id, string name, int projectGroupId)
        {
            Id = id;
            Name = name;
            ProjectGroupId = projectGroupId;
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
        public int ProjectGroupId
        {
            get { return projectGroupId; }
            set { projectGroupId = value; }
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
