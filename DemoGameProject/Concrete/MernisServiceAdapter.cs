using DemoGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGameProject.Concrete
{
    public class MernisServiceAdapter
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync

         (new TCKimlikNoDogrulaRequest
         (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(player.NationalityId),
         player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;


        }

        internal bool CheckIfRealPerson(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
