using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Repository
{
    public interface IRepository
    {
        public Question GetQuestion(string id);
        public List<Answer> GetAnswer(string id);
    }
}
