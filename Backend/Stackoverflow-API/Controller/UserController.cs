using MethodsforAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPIModel;

namespace Stackoverflow_API.Controller
{
    // [Route("api/[controller]")]
    // [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ISignUpClass _SignUpClass;
        public UserController(ISignUpClass signupclass)
        {
            _SignUpClass = signupclass;
        }
        //Insert UserDetails into RegistrationPage
        [HttpPost, Route("api/UserController/InsertUserDetailsIntoSignUpForm")]
        public bool Register(UserDetailsRegister _UserDetailsRegister)
        {
            if (_SignUpClass.InsertUserDetailsIntoSignUpForm(_UserDetailsRegister))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //
        [HttpGet, Route("api/User/UserDetailaLogin")]
        public bool UserDetailaLogin(UserDetailaLogin _userdetailalogin)
        {

            if (_SignUpClass.UserLogin(_userdetailalogin))
            {
                return true;
            }

            else
            {
                return false;
            }



        }
        [HttpPut, Route("api/UserDetailsRegister/ForgetPassword/{_Password}")]
        public string ForgetPassword(string _EmailId)
        {

            return _SignUpClass.ForgetPassword(_EmailId);



        }
        [HttpPost, Route("api/User/AllQuestions")]
        public bool AllQuestions(AllQuestions questions)
        {
            if (_SignUpClass.AllQuestions(questions))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        [HttpGet, Route("api/UsesrController/GetAllQuestions")]
        public IEnumerable<GetAllQuestions> _getallquestions()
        {
            return _SignUpClass._getallquestions();
        }

        [HttpGet, Route("api/UsesrController/GetOneQuestion")]
        public IEnumerable<GetOneQuestion> _GetOneQuestion(int Id)
        {
            return _SignUpClass._GetOneQuestion(Id);
        }

        [HttpPost, Route("api/UserController/Tags")]
        public bool Tags(InsertTags _inserttags)
        {
            if (_SignUpClass.Tags(_inserttags))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet, Route("api/UserController/GetTags")]
        public IEnumerable<GetTags> _gettags()

        {
            return _SignUpClass._gettags();

        }



        [HttpGet, Route("api/UserController/Users")]
        public string Users(int Id)
        {


            return _SignUpClass.Users(Id);



        }

    }
}
    

