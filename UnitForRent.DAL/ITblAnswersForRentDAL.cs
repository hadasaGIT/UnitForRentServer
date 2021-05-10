using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitForRent.DAL.Models;

namespace UnitForRent.DAL
{
    public interface ITblAnswersForRentDAL
    {
        Task<List<TblAnswersForRent>> GetAllAnswers();
        Task<TblAnswersForRent> GetAnswerById(int id);
        Task AddAnswer(TblAnswersForRent addAnswer);
        Task UpdateAnswer(TblAnswersForRent updateAnswer, int id);
        Task DeleteAnswer(int id);
    }
}
