using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UnitForRent.DAL.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace UnitForRent.DAL
{
    public class TblAnswersForRentDAL : ITblAnswersForRentDAL
    {
        UnitForRentContext _context;
        //******************************************************************************
        public TblAnswersForRentDAL(UnitForRentContext context)
        {
            this._context = context;

        }
        //******************************************************************************
        //return AllAnswers to table TblAnswersForRent
        public async Task<List<TblAnswersForRent>> GetAllAnswers()
        {
            try
            {
                return await _context.TblAnswersForRents.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //******************************************************************************
        //return Answers by id to table TblAnswersForRent
        public async Task<TblAnswersForRent> GetAnswerById(int id)
        {
            try
            {
                var AnswerById = await _context.TblAnswersForRents.Where(i => i.AnswersId == id).FirstOrDefaultAsync();
                return AnswerById;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //******************************************************************************
        //add answer to table TblAnswersForRent
        public async Task AddAnswer(TblAnswersForRent addAnswer)
        {
            try
            {
                await _context.TblAnswersForRents.AddAsync(addAnswer);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //******************************************************************************
        //delete answer to table TblAnswersForRent
        public async Task DeleteAnswer(int id)
        {
            try
            {
                var AnswerTODelete = await _context.TblAnswersForRents.Where(i => i.AnswersId == id).FirstOrDefaultAsync();
                _context.TblAnswersForRents.Remove(AnswerTODelete);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //******************************************************************************
        //update answer to table TblAnswersForRent
        public async Task UpdateAnswer(TblAnswersForRent updateAnswer, int id)
        {
            try
            {
                var AnswerTODelete = await GetAnswerById(id);
                
             //   var AnswerTODelete = await _context.TblAnswersForRents.Where(i => i.AnswersId == id).FirstOrDefaultAsync();
                _context.TblAnswersForRents.Update(AnswerTODelete);
                //חסר פה את העדכון עצמו
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
