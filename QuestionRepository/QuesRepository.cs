using DAL;
using DTO;

namespace Repository
{
    public class QuesRepository : IRepository
    {
        public QuesRepository()
        {

        }
        public Question GetQuestion(string id) => QuestionAL.Instance.GetQuesByID(id);

        public List<Answer> GetAnswer(string id) => QuestionAL.Instance.GetAnswerQues(id);

    }
}