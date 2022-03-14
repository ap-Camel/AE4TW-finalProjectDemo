using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WwwPracticeDb.Models;
using WwwPracticeDb;

namespace WwwPractice01
{
    public class CustomeAuthenticationStateProvider : AuthenticationStateProvider
    {
        public CustomeAuthenticationStateProvider() 
        {

        }
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {

            //var identity = new ClaimsIdentity(new[]
            //{
            //    new Claim(ClaimTypes.Name, "ayman"),
            //}, "apiauth_type");

            //var user = new ClaimsPrincipal(identity);

            //return Task.FromResult(new AuthenticationState(user));

            //var claim = new Claim(ClaimTypes.Name, "2");

            var identity = new ClaimsIdentity();
            //identity.AddClaim(claim);

            var user = new ClaimsPrincipal(identity);
            //user.AddIdentity(identity);

            return Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAsAuthenticated(TeachersModel t)
        {

            var claim = new Claim(ClaimTypes.Name, $"{t.firstName}");

            var identity = new ClaimsIdentity(authenticationType: "test");
            identity.AddClaim(claim);

            var user = new ClaimsPrincipal();
            user.AddIdentity(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
            

            //List<TeachersModel> list = new List<TeachersModel>();

            //list = await teacherData.GetTeacher(t);

            //if(list != null)
            //{
            //    var claim = new Claim(ClaimTypes.Name, $"{t.PersonID}");

            //    var identity = new ClaimsIdentity();
            //    identity.AddClaim(claim);

            //    var user = new ClaimsPrincipal();
            //    user.AddIdentity(identity);

            //    NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));

            //}
        }
    }
}
