using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Hunter : Characteristici
    {
        public Hunter(int health, int uron, int maxspeed, int ataka, int sleep)
        {
            _dmg = uron;
            _maxspeed = maxspeed;
            _health = health;
            _ataka = ataka;
        }

        public void Movement()
        {
            Console.WriteLine("Я отправляюсь на охоту за демонами.");
        }

        public void Shoot()
        {
            Console.WriteLine("Нечисть в поле зрения. Готовлюсь атаковать.");
            if (_ataka >= 3 & _health >= 2)
            {
                _ataka -= 5;
                _health -= 2;
            }
            else
            {
                if (_health < 2)
                {
                    Console.WriteLine("Сила атаки понижена на 6%.");
                }
                if (_ataka < 5)
                {
                    Console.WriteLine($"Сила атаки увеличена на 12%, шанс критического урона 15%.");
                }
            }
        }
        
    }
}
