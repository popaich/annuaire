using DataProvider;
using DataProvider.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApi.Controllers
{

    public class EtablissementController : Controller
    {
        private readonly MongoDbService data;

        public EtablissementController(MongoDbService data)
        {
            this.data = data;
        }

        public IEnumerable<Etablissement> GetEtablissementsCommune(string depet, string comet)
        {
            return data.GetEtablissementsCommune(depet, comet);
        }
    }
}
