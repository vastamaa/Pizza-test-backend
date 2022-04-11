//using System.Collections.Generic;
//using System.Linq;
//using WebApiEF_react_termekek.Models;

//namespace WebApiEF_react_termekek.Services
//{
//    public class TermekService
//    {
//        private readonly AppDbContext _context;

//        public TermekService(AppDbContext context)
//        {
//            _context = context;
//        }

//        public IEnumerable<Termekek> GetTermekek()
//        {
//            _context.
//        }

//        public Termekek GetTermekById(int id)
//        {
//            return context.Termekeks.Where(t => t.Id == id).FirstOrDefault();

//        }

//        public string AddTermek(Termekek termek)
//        {
//            context.Termekeks.Add(termek);
//            context.SaveChanges();
//            return ($"{termek.Nev} hozzáadva.");
//        }

//        public string UpdateTermek(Termekek termek)
//        {
//            context.Termekeks.Update(termek);
//            context.SaveChanges();
//            return ($"{termek.Nev} frissítve.");
//        }

//        public string DeleteTermek(int id)
//        {
//            Termekek termek = context.Termekeks.Where(t => t.Id == id).First();
//            if (termek == null)
//            {
//                return $"{termek.Nev} törlése nem sikerült";
//            }
//            else
//            {
//                context.Termekeks.Remove(termek);
//                context.SaveChanges();
//                return $"{termek.Nev} törölve";
//            }

//        }

//    }
//}
