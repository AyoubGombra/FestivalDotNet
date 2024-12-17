using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ChansonService : Service<Chanson>, IServiceChanson
    {
        public ChansonService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public IEnumerable<string> ListDesTitreChanson(Artiste artiste)
        {
            DateTime limiteDate = DateTime.Now.AddYears(-2);
            return artiste.Chansons.Where(chanson => chanson.DateSortie > limiteDate)
            .OrderByDescending(chanson => chanson.VuesYoutube)
            .Take(5)
            .Select(chanson => chanson.Titre)
            .ToList();
        }

        public IEnumerable<Chanson> SortChanson()
        {
            return GetMany().OrderBy(f => f.VuesYoutube);
        }

    }
}
