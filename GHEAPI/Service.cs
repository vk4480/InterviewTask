using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit;

namespace GHEAPI
{
    public class GHEAPIService
    {
        public Credentials Credentials { get; private set; }
        //const string clientId = "15004a6aa7ba81e8aa63";
        //private const string clientSecret = "17e78978d97e0095dda99181a345f766fdc72eca";
        //readonly GitHubClient client =  new GitHubClient(new ProductHeaderValue("vk4480"), new Uri("https://github.com/"));
        //const string code = "";
        //public async Task AuthenticateUserAsync()
        //{
        //    var token = await client.Oauth.CreateAccessToken(new OauthTokenRequest(clientId, clientSecret, code)
        //    {
        //        RedirectUri = new Uri("http://localhost:58292/home/authorize")
        //    });
        //    //Session["OAuthToken"] = token.AccessToken;
        //}

        public async Task<List<string>> GetAllCommits()
        {
            var client = new GitHubClient(new ProductHeaderValue("vk4480"));
            List<string> commitList = new List<string>();

            var token = "15004a6aa7ba81e8aa63";//ConfigurationManager.AppSettings["github_token"];
                                               //if (token != null)
                                               //{

            //var tokenAuth = new Credentials(token);
            //client.Credentials = tokenAuth;
            var repository = await client.Repository.Get("vk4480", "InterviewTask");
            var commits = await client.Repository.Commit.GetAll(repository.Id);
            var tipCommit = await client.Repository.Commit.Get("vk4480", "InterviewTask", "master");

            foreach (GitHubCommit commit in commits)
            {
                commitList.Add(commit.Commit.Message);
            }


            return commitList;
        }
    }

}
