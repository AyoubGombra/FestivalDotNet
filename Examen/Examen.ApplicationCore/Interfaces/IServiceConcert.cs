using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceConcert :IService<Concert>
    {
        public double CalculeCachet(Festival f);
    }
}
