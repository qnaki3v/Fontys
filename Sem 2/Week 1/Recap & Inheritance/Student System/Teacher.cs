using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System
{
    public class Teacher : Person
    {
        private JobPosition position;
        private double salary;

        public Teacher(int age, string name, int pcn, JobPosition position, double salary) : base(age,name,pcn)
        {
            this.position = position;
            this.salary = salary;
        }

        public override void StartAnotherSchoolyear()
        {
            base.StartAnotherSchoolyear();
            if (base.yearsAtSchool % 3 == 0)
            {
                salary *= 1.1;
            }
        }

        public void MakePromotion()
        {
            switch (position) 
            {
                case JobPosition.JUNIOR_TEACHER:
                    position = JobPosition.TEACHER1;
                    break;
                case JobPosition.TEACHER1:
                    position = JobPosition.TEACHER2;
                    break;
                case JobPosition.TEACHER2:
                    position = JobPosition.TEACHER3;
                    break;
                case JobPosition.TEACHER3:
                    position = JobPosition.COORDINATOR;
                    break;
                case JobPosition.COORDINATOR:
                    position = JobPosition.DIRECTOR;
                    break;
            }
        }
    }
}
