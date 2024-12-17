using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ArtisteService : Service<Artiste>, IServiceArtiste
    {
        public ArtisteService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }

   
}

