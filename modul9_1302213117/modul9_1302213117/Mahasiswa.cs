namespace modul9_1302213117
{
    public class Mahasiswa
    {
        public string Name { get; set; }
        public string Nim { get; set; }
        public List<string> Course { get; set; }
        public int Year { get; set; }

        public Mahasiswa() { }

        public Mahasiswa(string Name, string Nim, List<string> course, int year)
        {
            this.Name = Name;
            this.Nim = Nim;
            this.Course = course;
            this.Year = year;
        }
    }
}
