namespace Group3Web1.Models
{
    public class Studenti
    {
        public Studenti(string emri,string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        public string SayHello()
        {
            return $"Hello student {Emri}, {Mbiemri}";
        }
    }
}
