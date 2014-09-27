using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubPlanningPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            GithubIssues g = new GithubIssues();
            g.PostIssue("Test issue", "Der er kun problemer","stufkan","testpokerrepo");

            Console.ReadKey();
        }
    }
}
