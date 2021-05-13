using System;
using System.Collections.Generic;
using System.Text;

namespace Grade_Point_Average_Calculator
{
    class Course_Model
    {

        public string Code { get; set; }
        public int Unit { get; set; }
        public int Score { get; set; }

        public char Grade(int Score)
        {

            if (Score > 69) { return 'A'; }

            else if (Score > 59) { return 'B'; }

            else if (Score > 49) { return 'C'; }

            else if (Score > 44) { return 'D'; }

            else if (Score > 40) { return 'E'; }
            else { return 'F'; }
        }


        public int Grade_unit(char grade)
        {
            

            switch (grade)
            {
                case 'A':
                    return 5; 


                case 'B':
                    return  4;


                case 'C':
                    return  3;


                case 'D':
                    return  2;

                case 'E':
                    return  1;

                default:
                    return 0;
            }
            
                    
                   

                    


           
            

        }
        
    }

}


                   
                
            





