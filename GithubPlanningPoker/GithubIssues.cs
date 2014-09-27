using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace GithubPlanningPoker
{
    public class GithubIssues
    {
        IGitHubClient github;
        public GithubIssues()
        {
            //Username and password in console - for now
            string user = Console.ReadLine();
            string pwd = Console.ReadLine();

            github = new GitHubClient(new ProductHeaderValue("GithubPlanningPoker")) { Credentials = new Credentials(user,pwd)};

        }


        public async void PostIssue(string title,string content, string username, string repo)
        {
            var issuesclient =  github.Issue;
            var repository = await github.Repository.Get(username, repo);

            NewIssue n = new NewIssue(title) { Body = content };
            var issue = await issuesclient.Create(repository.Owner.Login, repository.Name, n);

            Console.WriteLine(issue !=null ? "Succes" : "Failure");
            Console.ReadKey();
        }
    }
}
