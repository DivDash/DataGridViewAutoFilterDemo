using System;
using System.Collections.Generic;

namespace DataGridViewAutoFilterDemo
{
    public class Person
    {
        private readonly Random random = new Random();
        public int Rank { get; set; }
        public string Occupation { get; set; }
        public double Jobs { get; set; }
        public double Salary { get; set; }
        public double Rate { get; set; }
        public DateTime DateTime { get; set; }
        public Person()
        {
        }
        public Person(int rank, string occupation, double jobs, double salary, double rate, DateTime dateTime)
        {
            Rank = rank;
            Occupation = occupation;
            Jobs = jobs;
            Salary = salary;
            Rate = rate;
            DateTime = dateTime;
        }
      
        /// <summary>
        /// Generates a random date
        /// </summary>
        /// <returns></returns>
        private DateTime RandomDate()
        {
            var start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
        /// <summary>
        /// Populates the list with generated data 
        /// </summary>
        /// <param name="persons"></param>
        public void PopulateList(List<Person> persons)
        {
            persons.Add(new Person(1, "Dentist", 27600, 142750, 0.70, RandomDate()));
            persons.Add(new Person(2, "Registerar", 712900, 65790, 2.00, RandomDate()));
            persons.Add(new Person(3, "Pharmacist", 69740, 113410, 3.20, RandomDate()));
            persons.Add(new Person(4, "Computer Systems Analyst", 120440, 78670.00, 0.025, RandomDate()));
            persons.Add(new Person(5, "Physician", 168330, 183270.00, 0.007, RandomDate()));
            persons.Add(new Person(6, "Database Administrator", 33600, 75390.00, 0.013, RandomDate()));
            persons.Add(new Person(7, "Software Developer", 143400, 89530.00, 0.04, RandomDate()));
            persons.Add(new Person(8, "Physical Therapist", 65740, 77930.00, 0.047, RandomDate()));
            persons.Add(new Person(9, "Web Developer", 65740, 77390.00, 0.047, RandomDate()));
            persons.Add(new Person(10, "Dental Hygienist", 68300, 69480.00, 0.028, RandomDate()));
            persons.Add(new Person(11, "Occupational Therapist", 36420, 74820.00, 0.004, RandomDate()));
            persons.Add(new Person(12, "Veterinarian", 23000, 82940.00, 0.006, RandomDate()));
            persons.Add(new Person(13, "Computer Programmer", 43730, 72230.00, 0.037, RandomDate()));
            persons.Add(new Person(14, "School Psychologist", 31700, 67830.00, 0.014, RandomDate()));
            persons.Add(new Person(15, "Physical Therapist Assistant", 30300, 51340.00, 0.034, RandomDate()));
            persons.Add(new Person(16, "Interpreter & Translator", 24620, 44260.00, 0.017, RandomDate()));
            persons.Add(new Person(17, "Mechanical Engineer", 21200, 79220.00, 0.024, RandomDate()));
            persons.Add(new Person(18, "Veterinary Technologist & Technician", 41700, 30140.00, 0.028, RandomDate()));
            persons.Add(new Person(19, "Epidemiologist", 37630, 64320.00, 0.034, RandomDate()));
            persons.Add(new Person(20, "IT Manager", 55830, 118310.00, 0.029, RandomDate()));
            persons.Add(new Person(21, "Market Research Analyst", 116400, 60350.00, 0.057, RandomDate()));
            persons.Add(new Person(22, "Diagnostic Medical Sonographer", 23300, 65410.00, 0.044, RandomDate()));
            persons.Add(new Person(23, "Computer Systems Administrator", 96600, 70970.00, 0.039, RandomDate()));
            persons.Add(new Person(24, "Respiratory Therapist", 31300, 55350.00, 0.029, RandomDate()));
            persons.Add(new Person(25, "Medical Secretary", 210240, 31460.00, 0.057, RandomDate()));
            persons.Add(new Person(26, "Civil Engineer", 51400, 77940.00, 0.048, RandomDate()));
            persons.Add(new Person(27, "Substance Abuse Counselor", 23450, 38540.00, 0.046, RandomDate()));
            persons.Add(new Person(28, "Speech-Language Pathologist", 28850, 69150.00, 0.017, RandomDate()));
            persons.Add(new Person(29, "Landscaper & Groundskeeper", 240850, 23510.00, 0.053, RandomDate()));
            persons.Add(new Person(30, "Radiologic Technologist", 61500, 55520.00, 0.028, RandomDate()));
            persons.Add(new Person(31, "Cost Estimator", 67400, 58440.00, 0.058, RandomDate()));
            persons.Add(new Person(32, "Financial Advisor", 66440, 66480.00, 0.024, RandomDate()));
            persons.Add(new Person(33, "Marriage & Family Therapist", 14840, 46440.00, 0.017, RandomDate()));
            persons.Add(new Person(34, "Medical Assistant", 162930, 29300.00, 0.067, RandomDate()));
            persons.Add(new Person(35, "Lawyer", 73630, 113330.00, 0.024, RandomDate()));
            persons.Add(new Person(36, "Accountant", 190740, 62450.00, 0.044, RandomDate()));
            persons.Add(new Person(37, "Compliance Officer", 32440, 60440.00, 0.024, RandomDate()));
            persons.Add(new Person(38, "High School Teacher", 71930, 54370.00, 0.033, RandomDate()));
            persons.Add(new Person(39, "Clinical Laboratory Technician", 23840, 36940.00, 0.044, RandomDate()));
            persons.Add(new Person(40, "Maintenance & Repair Worker", 142300, 35330.00, 0.073, RandomDate()));
            persons.Add(new Person(41, "Bookkeeping, Accounting, & Audit Clerk", 259000, 34730.00, 0.063, RandomDate()));
            persons.Add(new Person(42, "Financial Manager", 46360, 107660.00, 0.036, RandomDate()));
            persons.Add(new Person(43, "Recreation & Fitness Worker", 124730, 31330.00, 0.064, RandomDate()));
            persons.Add(new Person(44, "Insurance Agent", 90200, 47450.00, 0.055, RandomDate()));
            persons.Add(new Person(45, "Elementary School Teacher", 248810, 52810.00, 0.041, RandomDate()));
            persons.Add(new Person(46, "Dental Assistant", 91600, 34140.00, 0.044, RandomDate()));
            persons.Add(new Person(47, "Management Analyst", 157400, 78440.00, 0.054, RandomDate()));
            persons.Add(new Person(48, "Home Health Aide", 706300, 20310.00, 0.091, RandomDate()));
            persons.Add(new Person(49, "Pharmacy Technician", 108200, 29940.00, 0.099, RandomDate()));
            persons.Add(new Person(50, "Construction Manager", 86640, 84440.00, 0.07, RandomDate()));
            persons.Add(new Person(51, "Public Relations Specialist", 58230, 54130.00, 0.026, RandomDate()));
            persons.Add(new Person(52, "Middle School Teacher", 108340, 53140.00, 0.041, RandomDate()));
            persons.Add(new Person(53, "Massage Therapist", 30940, 35840.00, 0.062, RandomDate()));
            persons.Add(new Person(54, "Paramedic", 75440, 30740.00, 0.032, RandomDate()));
            persons.Add(new Person(55, "Preschool Teacher", 113630, 26640.00, 0.054, RandomDate()));
            persons.Add(new Person(56, "Hairdresser", 98430, 22540.00, 0.055, RandomDate()));
            persons.Add(new Person(57, "Marketing Manager", 24250, 116510.00, 0.062, RandomDate()));
            persons.Add(new Person(58, "Patrol Officer", 54600, 54330.00, 0.022, RandomDate()));
            persons.Add(new Person(59, "School Counselor", 53430, 54630.00, 0.046, RandomDate()));
            persons.Add(new Person(60, "Executive Assistant", 156600, 45680.00, 0.063, RandomDate()));
            persons.Add(new Person(61, "Financial Analyst", 54300, 75630.00, 0.055, RandomDate()));
            persons.Add(new Person(62, "Personal Care Aide", 607500, 19750.00, 0.053, RandomDate()));
            persons.Add(new Person(63, "Clinical Social Worker", 51200, 48620.00, 0.06, RandomDate()));
            persons.Add(new Person(64, "Business Operations Manager", 81620, 95250.00, 0.054, RandomDate()));
            persons.Add(new Person(65, "Loan Officer", 41500, 58530.00, 0.085, RandomDate()));
            persons.Add(new Person(66, "Meeting, Convention & Event Planner", 31500, 46520.00, 0.077, RandomDate()));
            persons.Add(new Person(67, "Mental Health Counselor", 43700, 39170.00, 0.047, RandomDate()));
            persons.Add(new Person(68, "Nursing Aide", 302700, 24170.00, 0.091, RandomDate()));
            persons.Add(new Person(69, "Sales Representative", 223700, 53740.00, 0.061, RandomDate()));
            persons.Add(new Person(70, "Architect", 27940, 73440.00, 0.074, RandomDate()));
            persons.Add(new Person(71, "Sales Manager", 40500, 101650.00, 0.062, RandomDate()));
            persons.Add(new Person(72, "HR Specialist", 61640, 54410.00, 0.06, RandomDate()));
            persons.Add(new Person(73, "Plumber", 107640, 47450.00, 0.151, RandomDate()));
            persons.Add(new Person(74, "Real Estate Agent", 45400, 39470.00, 0.052, RandomDate()));
            persons.Add(new Person(75, "Glazier", 41940, 37450.00, 0.126, RandomDate()));
            persons.Add(new Person(76, "Art Director", 6730, 81360.00, 0.09, RandomDate()));
            persons.Add(new Person(77, "Customer Service Representative", 338300, 30630.00, 0.09, RandomDate()));
            persons.Add(new Person(78, "Logistician", 27830, 71930.00, 0.079, RandomDate()));
            persons.Add(new Person(79, "Auto Mechanic", 124800, 36180.00, 0.083, RandomDate()));
            persons.Add(new Person(80, "Bus Driver", 83000, 35720.00, 0.064, RandomDate()));
            persons.Add(new Person(81, "Restaurant Cook", 117800, 22080.00, 0.076, RandomDate()));
            persons.Add(new Person(82, "Child & Family Social Worker", 58200, 40680.00, 0.061, RandomDate()));
            persons.Add(new Person(83, "Administrative Assistant", 118500, 31870.00, 0.064, RandomDate()));
            persons.Add(new Person(84, "Receptionist", 248540, 25340.00, 0.091, RandomDate()));
            persons.Add(new Person(85, "Paralegal", 46930, 46730.00, 0.065, RandomDate()));
            persons.Add(new Person(86, "Cement Mason & Concrete Finisher", 50500, 35500.00, 0.195, RandomDate()));
            persons.Add(new Person(87, "Painter", 72600, 35630.00, 0.166, RandomDate()));
            persons.Add(new Person(88, "Sports Coach", 71500, 28570.00, 0.09, RandomDate()));
            persons.Add(new Person(89, "Teacher Assistant", 191500, 23680.00, 0.066, RandomDate()));
            persons.Add(new Person(90, "Brickmason & Blockmason", 36400, 46840.00, 0.26, RandomDate()));
            persons.Add(new Person(91, "Cashier", 250230, 18830.00, 0.138, RandomDate()));
            persons.Add(new Person(92, "Janitor", 246440, 22470.00, 0.108, RandomDate()));
            persons.Add(new Person(93, "Electrician", 133730, 49330.00, 0.122, RandomDate()));
            persons.Add(new Person(94, "Delivery Truck Driver", 125620, 29280.00, 0.092, RandomDate()));
            persons.Add(new Person(95, "Maid & Housekeeper", 111620, 19290.00, 0.112, RandomDate()));
            persons.Add(new Person(96, "Carpenter", 196200, 40210.00, 0.16, RandomDate()));
            persons.Add(new Person(97, "Security Guard", 195300, 23930.00, 0.113, RandomDate()));
            persons.Add(new Person(98, "Construction Worker", 212500, 29450.00, 0.212, RandomDate()));
            persons.Add(new Person(99, "Fabricator", 12500, 35570.00, 0.143, RandomDate()));
            persons.Add(new Person(100, "Telemarketer", 21500, 23570.00, 0.313, RandomDate()));
            persons.Add(new Person(101, "Dentist", 27600, 12414.1230, 0.60, RandomDate()));
            persons.Add(new Person(102, "Dentist", 21351, 141350.134, 0.30, RandomDate()));
            persons.Add(new Person(103, "Physician", 168330, 183270.00, 0.007, RandomDate()));
            persons.Add(new Person(104, "Physician", 168330, 183270.00, 0.007, RandomDate()));
            persons.Add(new Person(105, "Physician", 168330, 183270.00, 0.007, RandomDate()));
        }
    }
}