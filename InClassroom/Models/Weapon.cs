using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassroom.Models
{
    internal class Weapon
    {
        int _bulletCapacity = 50;
        int repeatFill;
        int _bulletlength;
        int _combdDischargeSecond;
        public int BulletCapacity { get => _bulletCapacity; set => _bulletCapacity = value; }
        public int Bulletlength { get => _bulletlength; set => _bulletlength = value; }
        public int CombdDischargeSecond { get => _combdDischargeSecond; set => _combdDischargeSecond = value; }


        public void Shoot()
        {
            if (BulletCapacity > 0)
            {

                Console.WriteLine("Ates acildi..");
                BulletCapacity--;
                Console.WriteLine($"Daraqdaki gulle sayi: {BulletCapacity}");
            }

            else
            {
                Console.WriteLine("Gulle yoxdur.");
            }
        }

        public void Reload()
        {
            repeatFill = BulletCapacity;
            Console.WriteLine($"Daragdaki gulle yenilendi.");
        }
        
        

    }
}
