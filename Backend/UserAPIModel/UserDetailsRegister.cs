using System;

namespace UserAPIModel
{
    public class UserDetailsRegister
    {

        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string ConformPassword { get; set; }
    }

    public class UserDetailaLogin
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
    public class AllQuestions
    {
        public string Question { get; set; }
        public string Description { get; set; }

    }
    public class GetAllQuestions
    {
        public string Question { get; set; }
        public string Description { get; set; }

    }
    public class GetOneQuestion
    {
        public string Question { get; set; }
        public string Description { get; set; }

    }
    public class InsertTags
    {
        public string TagNames { get; set; }
        public string TagDescription { get; set; }
    }
    public class GetTags
    {
        public string TagNames { get; set; }
        public string TagDescription { get; set; }
    }

}
