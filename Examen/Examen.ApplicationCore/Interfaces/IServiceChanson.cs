using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceChanson :  IService<Chanson>
    {
        public IEnumerable<string> ListDesTitreChanson(Artiste artiste);
        IEnumerable<Chanson> SortChanson();
    }
}
