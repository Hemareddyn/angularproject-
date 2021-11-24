
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConnectionDataBase;
using UserAPIModel;
using System.Runtime.Serialization;


namespace MethodsforAPI
{
    public class SignUpDetails : ISignUpClass
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        public SignUpDetails()
        {
            _connection = new SqlConnection(ConnectionData.ConnectionString);
        }
        public bool InsertUserDetailsIntoSignUpForm(UserDetailsRegister _UserDetailsRegister)
        {
            bool Insert= false;
            try
            {
                using (_command = new SqlCommand($"INSERT INTO RegisterTable  VALUES ('" + _UserDetailsRegister.UserName + "','" + _UserDetailsRegister.EmailId + "','" + _UserDetailsRegister.Password +"','" +_UserDetailsRegister.ConformPassword +" ')", _connection))
                {

                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    _command.ExecuteNonQuery();

                    Insert = true;
                }
            }
            catch (Exception ex)
            {
                throw new UserExceptions(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }

            return Insert;
        }


        public bool  UserLogin(UserDetailaLogin _userdetailalogin)
        {


            bool isSuccess = false;

            try
            {
                using (_command = new SqlCommand($"SELECT * FROM RegisterTable where  EmailId='{_userdetailalogin.EmailId}'", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (_userdetailalogin.Password.Equals(reader[3]))
                        {
                            isSuccess = true;
                        }
                    }
                        
                }
            }
            catch (Exception ex)
            {
                throw new UserExceptions(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }


            return isSuccess;
        }

        public string  ForgetPassword(string _EmailId)
        {
            string _Password = " ";
            try
            {
                using (_command = new SqlCommand("select Password from RegisterTable where EmailId = '" + _EmailId + "' ", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();
                    _Password = Convert.ToString(_command.ExecuteScalar());

                    

                    
                }
            }
            catch (Exception ex)
            {
                throw new UserExceptions(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
            return _Password;
        }

        

         public bool AllQuestions(AllQuestions questions)
         {
            bool isSuccess = false;
            try
            {
                using (_command = new SqlCommand($"INSERT INTO Questions  VALUES ('" + questions.Question + "','" + questions.Description + "')", _connection))
                {


                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    _command.ExecuteNonQuery();

                    isSuccess= true;
                }
            }
            catch (Exception ex)
            {
                throw new UserExceptions(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }

            return isSuccess;
         }
        //public bool GetQuestions(GetQuestions getQuestions)
        //{
        //    bool isSuccess = false;

        //    try
        //    {
        //        using (_command = new SqlCommand("SELECT * FROM Questions", _connection))
        //        {
        //            {
        //                if (_connection.State == System.Data.ConnectionState.Closed)
        //                    _connection.Open();
        //                SqlDataReader Reader = _command.ExecuteReader();

        //                isSuccess = true;
        //            }
        //        }
        //    }





        //    catch (Exception ex)
        //    {
        //        throw new UserExceptions(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        if (_connection.State == System.Data.ConnectionState.Open)
        //            _connection.Close();
        //    }

        //    return isSuccess;
        //}
        public IEnumerable<GetAllQuestions> _getallquestions()
        {
            List<GetAllQuestions> _getquestions = new List<GetAllQuestions>();

            try
            {
                using (_command = new SqlCommand("SELECT * FROM Questions  ", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();
                    while (reader?.Read() ?? false)
                    {
                        _getquestions.Add(new GetAllQuestions()
                        {
                            Question = reader.GetString(1),
                            Description = reader.GetString(2)

                        }); 


                    }

                }
            }
            catch (Exception ex)
            {
                throw new UserExceptions(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }


            return _getquestions;
        }


        public IEnumerable<GetOneQuestion> _GetOneQuestion(int Id)
        {
              List<GetOneQuestion> _getonequestion = new List<GetOneQuestion>();

            try
            {
                using (_command = new SqlCommand("SELECT * FROM Questions where  Id=" + Id + " ", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();
                    while (reader?.Read() ?? false)
                    {
                        _getonequestion.Add(new GetOneQuestion()
                        {
                            Question = reader.GetString(1), Description = reader.GetString(2)

                        });


                    }

                }
            }
            catch (Exception ex)
            {
                throw new UserExceptions(ex.Message,ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }


            return _getonequestion;
        }
        public bool Tags(InsertTags _inserttags)
        {
            bool isSuccess = false;
            try
            {
                using (_command = new SqlCommand($"INSERT INTO Tags VALUES ('" + _inserttags.TagNames + "','" + _inserttags.TagDescription + "')", _connection))
                {


                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    _command.ExecuteNonQuery();

                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new UserExceptions(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }

            return isSuccess;
        }
        public IEnumerable<GetTags> _gettags()
        {
            List<GetTags> _alltags = new List<GetTags>();

            try
            {
                using (_command = new SqlCommand("SELECT * FROM Tags ", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    SqlDataReader reader = _command.ExecuteReader();
                    while (reader?.Read() ?? false)
                    {
                        _alltags.Add(new GetTags()
                        {
                            TagNames = reader.GetString(1),
                            TagDescription = reader.GetString(2)

                        });



                    }
                }
            }
            catch (Exception ex)
            {
                throw new UserExceptions(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }


            return _alltags;
        }
        public string Users(int Id)
        {
            string username = "";
            List<UserDetailsRegister> _UserName = new List<UserDetailsRegister>();
            try
            {
                using (_command = new SqlCommand("select UserName from RegisterTable where id='"+ Id+"' ", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    username = Convert.ToString(_command.ExecuteScalar());
                    
                }
            }
            catch (Exception ex)
            {
                throw new UserExceptions(ex.Message, ex);
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
            return username;
        }

    }


}








   

   

