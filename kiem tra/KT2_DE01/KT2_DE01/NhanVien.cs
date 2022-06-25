namespace KT2_DE01
{
    public class NhanVien
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int workDays { get; set; }
        public double salary { get; set; }

        public NhanVien(string name, string gender, int workDays, double salary)
        {
            this.name = name;
            this.gender = gender;
            this.workDays = workDays;
            this.salary = salary;           
        }

        public double bonus()
        {
            if(workDays >= 27)
            {
                return 0.1 * salary;
            } else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name} - {gender} - {workDays} - {salary} - {bonus()}";
        }
    }
}