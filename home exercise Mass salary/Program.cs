using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_exercise_Mass_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Mass PercentPrice = new Mass(20,40);
            Console.WriteLine(PercentPrice.Result);
            Console.ReadLine();

        }
    }
    class Mass
    {
        public double Income { get; set; }
        public double WorkDays { get; set; }
        private string result { get; set; }

        public string Result
        {
            get
            {
                this.Calc();
                return this.result;
            }
        }
        public Mass (double Income, double WorkDays)
        {
            this.Income = Income;
            this.WorkDays = WorkDays;
        }
        private void Calc()
        {
            if(this.Income * this.WorkDays < 1000)
            {
                double r = (this.Income * this.WorkDays) * 18 / 100;
                this.result = Convert.ToInt32(r) + " azn tutulub";
            }else if(this.Income * this.WorkDays > 1000)
                {
                double r = (this.Income * this.WorkDays) * 22 / 100;
                this.result = Convert.ToInt32(r) + " azn tutulub ve elave 4% tutlub";
            }

        }

    }
}
