#nullable disable

namespace WebApiEF_react_termekek.Models
{
    public partial class Termekek
    {
        public int Id { get; set; }
        public string Név { get; set; }
        public string Leírás { get; set; }
        public int Ár { get; set; }
        public string Kép { get; set; }
    }
}
