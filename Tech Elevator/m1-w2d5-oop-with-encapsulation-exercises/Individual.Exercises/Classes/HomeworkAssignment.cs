using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        private int totalMarks;
        private int possibleMarks;
        private string submitterName;

        public int TotalMarks
        {
            get { return totalMarks; }
            set { totalMarks = value; }
        }
        public int PossibleMarks
        {
            get { return possibleMarks; }
        }
        public string SubmitterName
        {
            get { return submitterName; }
            set { submitterName = value; }
        }
        public string LetterGrade
        {
            get
            {
                if ((double)totalMarks / possibleMarks >= .90)
                {
                    return "A";
                }
                else if ((double)totalMarks / possibleMarks >= .80 && totalMarks / possibleMarks < .90)
                {
                    return "B";
                }
                else if ((double)totalMarks / possibleMarks >= .70 && totalMarks / possibleMarks < .80)
                {
                    return "C";
                }
                else if ((double)totalMarks / possibleMarks >= .60 && totalMarks / possibleMarks < .70)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }

        public HomeworkAssignment(int possibleMarks)
        {
            this.possibleMarks = possibleMarks;
        }
    }
}
