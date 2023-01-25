using ConsoleAppPractice.Modells;
using ConsoleAppPractice.Servicces.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice.Servicces
{
    internal class StudentManager : ICrudService, IPrintService
    {

        private Student[] _students = new Student[21];
        private int _currentStudent = 0;

        public void Add(Entity entity)
        {
            if (_currentStudent > 19)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 20 Telebe elave etmek olar");

                return;
            }
            _students[_currentStudent++] = (Student)entity;
            Console.WriteLine($"{entity.Id} Id li Telebe elave olundu");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                    continue;

                if (id == _students[i].Id)
                {
                    found = true;

                    for (int j = i; j < _students.Length - 1; j++)
                    {

                        _students[j] = _students[j + 1];
                    }
                    _currentStudent--;

                    Console.WriteLine($"ID: {id}, Telebe silindi!");
                    return;
                }
            }

            if (!found)
                Console.WriteLine($"ID: {id}, Telebe tapilmadi");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null) continue;

                if (_students[i].Id == id)
                {
                    return _students[i];
                }
            }

            Console.WriteLine($"ID: {id}, Telebe yoxdur!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _students;
        }

        public void Print()
        {
            foreach (var item in _students)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null) continue;

                if (_students[i].Id == id)
                {
                    _students[i] = (Student)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }

            Console.WriteLine("Taplmadi!");
        }
    }
}
