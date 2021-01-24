using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.İO_Ödev
{
    class KampanyaManager
    {
        public void KampanyaEkle(IKampanyaService kampanyaService, List<IKampanyaService> kampanyaServices)
        {
            kampanyaService.KampanyaEkle();
            //foreach(var kampanyaService1 in kampanyaServices)
            //{
            //    kampanyaService1.KampanyaEkle();
            //}
            
        }
        public void KampanyaSil(IKampanyaService kampanyaService, List<IKampanyaService> kampanyaServices)
        {
            kampanyaService.KampanyaSil();
            //foreach (var kampanyaService1 in kampanyaServices)
            //{
            //    kampanyaService1.KampanyaSil();
            //}
        }
        public void KampanyaGüncelle(IKampanyaService kampanyaService, List<IKampanyaService> kampanyaServices)
        {
            kampanyaService.KampanyaGüncelle();
            //foreach (var kampanyaService1 in kampanyaServices)
            //{
            //    kampanyaService1.KampanyaGüncelle();
            //}
        }
    }
}
