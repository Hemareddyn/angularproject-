using System;
using System.Collections.Generic;
using UserAPIModel;

namespace MethodsforAPI
{
    public interface ISignUpClass
    {
        // Registration Page
        bool InsertUserDetailsIntoSignUpForm(UserDetailsRegister _UserDetailsRegister);

        //Login Page
        bool UserLogin(UserDetailaLogin _userdetailalogin);
        //ForgetPassword
        public string ForgetPassword(string _EmailId);
        // Inserted Questions

        public bool AllQuestions(AllQuestions questions);

        public IEnumerable<GetAllQuestions>_getallquestions();
        public IEnumerable<GetOneQuestion>  _GetOneQuestion(int Id);

        public bool Tags(InsertTags _inserttags);

        public IEnumerable<GetTags> _gettags();

        public string Users(int Id);
        

        

        


    }
}
