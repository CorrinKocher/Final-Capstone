using System;
using System.Collections.Generic;
using System.Text;

namespace Individual.Exercises.Classes
{
   

    public class HomeworkAssignment
    {
        private int earnedMarks;
        private int possibleMarks;
        private string letterGrade;
        private string submitterName;
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;
        }
        public int EarnedMarks { get; set; }


        public int PossibleMarks { get; }

        public string SubmitterName { get; }

        public string LetterGrade
        {
            get

            {
                if ((double)this.EarnedMarks >= 90 && (double)this.EarnedMarks <= 100)
                {
                    return "A";
                }
                if ((double)this.EarnedMarks >= 80 && (double)this.EarnedMarks <= 89)
                {
                    return "B";
                }
                if((double)this.EarnedMarks >= 70 && (double)this.EarnedMarks <= 79)
                {
                    return "C";
                }
                if((double)this.EarnedMarks >= 60 && (double)this.EarnedMarks <= 69)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
                
            }
        }
        
        
        


    }
}
