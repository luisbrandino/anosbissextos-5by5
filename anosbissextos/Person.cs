namespace anosbissextos
{
    internal class Person
    {
        string name;
        string profession;
        int age;

        public Person(string name, string profession, int age)
        {
            this.name = name;
            this.profession = profession;
            this.age = age;
        }

        public string GetName() { return name; }
        
        public string GetProfession() { return profession; }

        public int GetAge() { return age; }

        public int GetAgeInLeapYears()
        {
            int birthYear = DateTime.Now.Year - this.age;
            int leapYears = 0;

            for (int i = birthYear; i < DateTime.Now.Year; i++)
            {
                bool isLeapYear = (i % 4 == 0 && i % 100 != 0) || (i % 400 == 0);

                if (isLeapYear)
                    leapYears++;
            }

            return leapYears;
        }

        public override string ToString()
        {
            return $"Nome: {this.name}\nProfissão: {this.profession}\nIdade: {this.age}";
        }
    }
}
