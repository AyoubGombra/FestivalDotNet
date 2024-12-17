using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ConcertService : Service<Concert>, IServiceConcert
    {
        public ConcertService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public double CalculeCachet(Festival f)
        {
            return f.Concerts.Max(concert => concert.Cachet);
        }
    }
}
