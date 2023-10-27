using System;

namespace Working_With_Inheritance
{
    public class SubjectTeacher : Teacher
    {
        private Subject whichSubject;

        public Subject WhichSubject
        {
            get { return whichSubject; }
            set { whichSubject = value; }
        }
    }

}
