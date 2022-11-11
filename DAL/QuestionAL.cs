
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class QuestionAL : DataConnect
    {
        private static QuestionAL instance = null;
        private static readonly object instanceLock = new object();

        private QuestionAL()
        {
        }

        public static QuestionAL Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new QuestionAL();
                    }
                }

                return instance;
            }
        }

        //-------------------------------------------------------------------------

        public Question GetQuesByID(string id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand($"Select * from Question where QID = '{id}'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return new Question()
                    {
                        QID = dr.GetString(0),
                        QuesName= dr.GetString(1)
                    };
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DisconnectDB();
            }

            return null;
        }

        public List<Answer> GetAnswerQues(string id)
        {
            List<Answer> answers = new List<Answer>();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand($"Select * from answer where QID = '{id}'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    answers.Add(new Answer()
                    {
                        QID = dr.GetString(0),
                        AID = dr.GetString(1),
                        answerQues = dr.GetString(2),
                        isCorrect = dr.GetBoolean(3)
                    });
                }
                dr.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                DisconnectDB();
            }

            return answers;
        }
    }
}
