using InClassroom.Models;

namespace InClassroom
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();
            Console.WriteLine("0 - İnformasiya almaq üçün\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\n3 - GetRemainBulletCount metodu üçün\n4 - Reload metodu üçün\n5 - ChangeFireMode metodu üçün\n6 - Proqramdan dayandırmaq üçün\n");
            repeat:
            Console.Write("Seciminiz: ");
            int key = int.Parse(Console.ReadLine().Trim());

            do
            {
                
                switch (key)
                {
                    case 0:
                        Console.WriteLine("1 - Shoot metodu hər çağırıldıqda 1 güllə atır");
                        Console.WriteLine("2 - Fire metodu daraqdakı güllələr hamısı atəşlənir və neçə saniyəyə bitdiyi qeyd olunur.");
                        Console.WriteLine("3 - GetRemainBulletCount darağın tam dolması üçün lazım olan güllə sayını qaytarır.");
                        Console.WriteLine("4 - Reload darağı yenidən doldurur.");
                        Console.WriteLine("5 - ChangeFireMode atış modunu dəyişir.");
                        break;
                    case 1:
                        Console.WriteLine("Shoot metodu cagirildi");
                        weapon.Shoot();
                        break;
                    //case 2:
                    //    Console.WriteLine("Fire metodu cagirildi");
                    //    weapon.Fire();
                    //    break;
                    //case 3:
                    //    Console.WriteLine("GetRemainBulletCount metodu cagirildi");
                    //    weapon.Shoot();
                    //    break;
                    case 4:
                        Console.WriteLine("Reload metodu cagirildi");
                        weapon.Reload();
                        break;
                        //case 5:
                        //    Console.WriteLine("ChangeFireMode metodu cagirildi");
                        //    weapon.Shoot();
                        //    break;

                }

                if (key < 6)
                {
                    goto repeat;
                }

            } while (key != 6);

        }
    }
}