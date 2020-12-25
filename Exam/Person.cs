using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Person : Characteristics
    {
        public string _name;
        Random rnd = new Random();
        public Person(int health, int agility, int strenght, int luck, string name)
        {
            _name = name;
            _health = health;
            _agility = agility;
            _strenght = strenght;
            _luck = luck;
        }
        public void Attack(Person person)
        {
            int dmg = rnd.Next(50, 100) + _strenght;
            person._health -= dmg;
            Console.WriteLine($"{_name} нанёс {dmg} урона {person.name}");
        }
        public static void Start()
        {
            Person person1 = new Person(health: 1000, agility: 10, strenght: 10, luck: 5, name:"ChuvakOdin");
            Person person2 = new Person(health: 1000, agility: 10, strenght: 10, luck: 10, name: "ChuvakDva");

            while (true)
            {
                if (Person.health > 0 )
                {
                    person2.Attack(person1);
                }
                else
                {
                    Console.WriteLine($"{person1._name} мёртв");

                }
            }
        }
    }
}

