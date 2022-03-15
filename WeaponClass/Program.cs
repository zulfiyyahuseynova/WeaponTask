using System;
using WeaponClass.Model;

namespace WeaponClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Darağın güllə tutumunu daxil edin:");
            int bulletCapacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daraqdakı güllə sayını daxil edin:");
            int currentBullet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Darağın boşalma saniyəsini daxil edin:");
            double dischargeSecond = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Atış modunu daxil edin:");
            bool shootMode = Convert.ToBoolean(Console.ReadLine());
            Weapon gun = new Weapon(bulletCapacity,currentBullet,dischargeSecond,shootMode);
            Console.WriteLine("İnformasiya almaq üçün 0 seçin");

            int key = 0;
            do
            {
                Console.WriteLine("Rəqəm daxil edin:");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        gun.ShowInfo();
                        break;
                    case 1:
                        gun.Shoot();
                        break;
                    case 2:
                        gun.Fire();
                        break;
                    case 3:
                        gun.GetRemainBulletCount();
                        break;
                    case 4:
                        gun.Reload();
                        break;
                    case 5:
                        gun.changeFireMode();
                        break;
                    case 6:
                        Console.WriteLine("Proqram dayandırıldı");
                        break;
                    default:
                        Console.WriteLine("Belə bir metod yoxdur");
                        break;
                }

            } while (key != 6);
        }
    }
}
