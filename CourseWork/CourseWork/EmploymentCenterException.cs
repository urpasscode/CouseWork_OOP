using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class EmploymentCenterException : Exception
    {
        public double wrongValue;
        public EmploymentCenterException() : base()
        { }
        public EmploymentCenterException(string message) : base(message)
        { }

        public EmploymentCenterException(string message, double value) : base(message)
        {
            this.wrongValue = value;
        }
    }
}
