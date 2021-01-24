using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.İO_Ödev
{
    class KayıtManager
    {
        public void KayıtOl(IOyuncuManager oyuncuManager,List<ILoggerService> loggerServices)
        {
            oyuncuManager.KayıtOl();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void BilgileriGüncelle(IOyuncuManager oyuncuManager, List<ILoggerService> loggerServices) 
        {
            oyuncuManager.Güncelle();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }


        public void BilgileriSil(IOyuncuManager oyuncuManager, List<ILoggerService> loggerServices)
        {
            oyuncuManager.Sil();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
    }
}
