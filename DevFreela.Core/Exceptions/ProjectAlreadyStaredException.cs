using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadyStaredException : Exception
    {
        public ProjectAlreadyStaredException() : base("Project is Already in Started satus")
        {
            
        }

    }
}
