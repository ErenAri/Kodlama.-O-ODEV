using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlama.İO_Ödev
{
    class AmatörOyuncular : IOyuncuManager
    {
        public void Güncelle()
        {
            
            Console.WriteLine("Oyuncu bilgileri güncellendi");
        }

        public void KayıtOl()
        {
            
            Console.WriteLine("Oyuncu bilgileri eklendi");
        }

        public void Sil()
        {
            
            Console.WriteLine("Oyuncu bilgileri silindi");
        }
    }
}
