using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubPlanningPoker
{
    public class Id
    {
        private readonly string hash;

        public Id(string hash)
        {
            this.hash = hash;
        }

        public string Hash
        {
            get { return hash; }
        }
    }
}
