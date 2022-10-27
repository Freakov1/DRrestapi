using DRrestapi.Models;

namespace DRrestapi.Managers
{
    public class RecordsManager
    {
        private static int _nextId = 1;

        private static readonly List<Record> Data = new List<Record>
        {
            new Record {Id = _nextId++, Title = "Purple Rain", Artist = "Prince", Duration = 500, publicationYear = 1993},
            new Record {Id = _nextId++, Title = "Billie Jean", Artist = "Michael Jackson", Duration = 350, publicationYear = 1990},
            new Record {Id = _nextId++, Title = "Hello", Artist = "Adele", Duration = 200, publicationYear = 2008},
            new Record {Id = _nextId++, Title = "Yesterday", Artist = "The Beatles", Duration = 230, publicationYear = 1985},
        };

        public IEnumerable<Record> GetAll(int? amount, string? substring)
        {
            List<Record> nyliste = new List<Record>(Data);

            if (substring != null)
            {
                nyliste = nyliste.FindAll(record => record.Title.Contains(substring));
            }

            if (amount != null)
            {
                nyliste = nyliste.Take((int)amount).ToList();
            }
            return nyliste;
        }
    }
}
