using System;
using System.Collections.Generic;

namespace Kodlama.İO_Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOyuncuManager> oyuncular = new List<IOyuncuManager> { new AmatörOyuncular(), new ProfesyonelOyuncular() };
            List<ILoggerService> loggers = new List<ILoggerService> { new LoggerService() };
            List<IKampanyaService> kampanyalar = new List<IKampanyaService> { new Kampanya() };

            KayıtManager kayıtManager = new KayıtManager();
            kayıtManager.KayıtOl(new AmatörOyuncular(), loggers);
            kayıtManager.BilgileriSil(new AmatörOyuncular(), loggers);
            kayıtManager.BilgileriGüncelle(new AmatörOyuncular(), loggers);


            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.KampanyaEkle(new Kampanya(),kampanyalar);
            kampanyaManager.KampanyaSil(new Kampanya(), kampanyalar);
            kampanyaManager.KampanyaGüncelle(new Kampanya(), kampanyalar);

        }
    }
}
