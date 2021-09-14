using maneger.Interfaces;
using Microsoft.AspNetCore.Mvc;
using sample.Implement;
using sample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.controller
{

    public class testController : Controller
    {
        //runtime 啟動 實做 interface 
        private AuthenticationProvider _authenticationProvider ;
        private UserDetailsProvider _userDetailsProvider;

        public testController(AuthenticationProvider authenticationProvider,
            UserDetailsProvider userDetailsProvider

            )
        {
            _authenticationProvider = authenticationProvider;
            _userDetailsProvider = userDetailsProvider;

        }

        //一個request 傳入jwt

        public IActionResult Details(string jwt)
        {
            //實例化傳入建構子
            JWTAuthentication jWTAuthentication = new JWTAuthentication(jwt);
            AuthenticationManager authenticationManager = new AuthenticationManager(_authenticationProvider, _userDetailsProvider);
            //使用 method authenticate
            Authentication result = authenticationManager.authenticate(jWTAuthentication);


            return Ok(result);
        }

       
    }
}
