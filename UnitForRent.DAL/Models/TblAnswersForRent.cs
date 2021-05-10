using System;
using System.Collections.Generic;

#nullable disable

namespace UnitForRent.DAL.Models
{
    public partial class TblAnswersForRent
    {
        public int AnswersId { get; set; }
        public int QuestionsId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public virtual TblHousingUnit Answers { get; set; }
        public virtual TblQuestionsForRent Questions { get; set; }
    }
}
