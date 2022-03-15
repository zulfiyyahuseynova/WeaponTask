using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponClass.Model
{
    class Weapon
    {
        public int bulletCapacity;
        public int currentBullet;
        public double dischargeSecond;
        public bool shootMode;

        public Weapon(int bulletCapacity, int currentBullet, double dischargeSecond, bool shootMode)
        {
            this.bulletCapacity = bulletCapacity;
            this.currentBullet = currentBullet;
            this.dischargeSecond = dischargeSecond;
            this.shootMode = shootMode;
        }
        public void ShowInfo()
        {
            Console.WriteLine("1-Shoot metodu üçün \n" + "2-Fire metodu üçün \n" + "3-GetRemainBulletCount metodu üçün \n" + "4-Reload metodu üçün \n" + "5-ChangeFireMode üçün \n" +
                "6-Proqramı dayandırmaq üçün qısayoldur");
        }
        public void Shoot()
        {
            if (currentBullet == 0)
            {
                Console.WriteLine("Daraqda güllə yoxdur");
            }
            else if(currentBullet > 0)
            {
                currentBullet -= 1;
                Console.WriteLine("1 güllə atıldı");
            }
            else
            {
                Console.WriteLine("Güllə sayı mənfi ola bilməz");
            }            
        }
        public void Fire()
        {
            if(currentBullet < bulletCapacity && currentBullet>=0 && dischargeSecond > 0 && bulletCapacity > 0)
            {
                double second = (currentBullet * dischargeSecond) / bulletCapacity;
                Console.WriteLine($"{second} saniyəyə bitir");
            }
            else
            {
                Console.WriteLine("Qiymətləri düzgün daxil edin");
            }
            
        }
        public void GetRemainBulletCount()
        {
            if (bulletCapacity > 0 && currentBullet >= 0 && currentBullet < bulletCapacity) 
            { 
            int neededBulletCount = bulletCapacity - currentBullet;
            Console.WriteLine($"Darağın tam dolması üçün {neededBulletCount} güllə lazımdır");
            }
            else
            {
                Console.WriteLine("Qiymətləri düzgün daxil edin");
            }

        }
        public void Reload()
        {
            if (bulletCapacity > 0 && currentBullet >= 0 && currentBullet < bulletCapacity)
            {
                int neededBulletCount = bulletCapacity - currentBullet;
                currentBullet += neededBulletCount;
                Console.WriteLine("Daraq yenidən dolduruldu"); 
            }
            else
            {
                Console.WriteLine("Qiymətləri düzgün daxil edin");
            }
        }
        public void changeFireMode()
        {
            if (shootMode == true)
            {
                shootMode = false;
                Console.WriteLine("Atış modu avtomatik olaraq dəyişdirildi");
            }
            else if (shootMode == false)
            {
                shootMode = true;
                Console.WriteLine("Atış modu təkli olaraq dəyişdirildi");
            }
        }
    }
}
