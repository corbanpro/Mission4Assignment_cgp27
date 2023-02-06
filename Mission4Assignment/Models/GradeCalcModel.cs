using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    public class GradeCalcModel
    {
        /* grade calculator values. All are required, all between 0 and 100*/
        [Required][Range(0, 100)]
        public double assignments { get; set; }

        [Required][Range(0, 100)]
        public double group_projects { get; set; }

        [Required][Range(0, 100)]
        public double quizzes { get; set; }

        [Required][Range(0, 100)]
        public double midterm { get; set; }

        [Required][Range(0, 100)]
        public double final { get; set; }

        [Required][Range(0, 100)]
        public double intex { get; set; }



    }
}
