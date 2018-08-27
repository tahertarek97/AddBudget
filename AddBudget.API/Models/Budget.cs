using System;


namespace AddBudget.API.Models
{
    public class Budget 
    {
        public int BudgetId { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string EnglishDescrption { get; set; }
        public string ArabicDescrption { get; set; }
        public int NumberOfBranchesAlreadyPerformed { get; set; }
        public int NumberOfBranchesUnderConstruction { get; set; }
        public int NumberOfForecastedBranches { get; set; }
        public string Comment { get; set; }
        public DateTime EstimatedDeadline { get; set; }
        public DateTime ActualDeadline { get; set; }
        public bool ActiveFlag { get; set; }
        public bool DeleteFlag { get; set; }
        public string EntryUser { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime EntryTime { get; set; }//needs to be time
        public string LastModificationUser { get; set; }
        public DateTime LastModificationDate { get; set; }
        public DateTime LastModificationTime { get; set; }// needs to be only time
        public string DeleteUser { get; set; }
        public DateTime DeleteDate { get; set; }
        public DateTime DeleteTime { get; set; }// needs to be only time
    }
}