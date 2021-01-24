using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.İO_Ödev
{
    class Kampanya: IKampanyaService
    {
        public void KampanyaEkle()
        {
            Console.WriteLine("Kampanya eklendi");
        }
        public void KampanyaSil()
        {
            Console.WriteLine("Kampanya Silindi");
        }
        public void KampanyaGüncelle()
        {
            Console.WriteLine("Kampanya Güncellendin");
        }
    }
}
