using ConsoleAppPractice.Modells;
using ConsoleAppPractice.Servicces.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice.Servicces
{
    internal class DepartmentManager : ICrudService, IPrintService
    {
        private Department[] _departments = new Department[3];
        private int _currentDepartment = 0;

        public void Add(Entity entity)
        {
            if (_currentDepartment > 1)
            {
                Console.WriteLine("Limiti kecdiniz! Sadece 2 Fakulte elave etmek olar");

                return;
            }
            _departments[_currentDepartment++] = (Department)entity;
            Console.WriteLine($"{entity.Id} Id li Fakulte elave olundu");
        }

        public void Delete(int id)
        {
            bool found = false;

            for (int i = 0; i < _departments.Length; i++)
            {
                if (_departments[i] == null)
                    continue;

                if (id == _departments[i].Id)
                {
                    found = true;

                    for (int j = i; j < _departments.Length - 1; j++)
                    {

                        _departments[j] = _departments[j + 1];
                    }
                    _currentDepartment--;

                    Console.WriteLine($"ID: {id}, Fakulte silindi!");
                    return;
                }
            }

            if (!found)
                Console.WriteLine($"ID: {id}, Fakulte tapilmadi");
        }

        public Entity Get(int id)
        {
            for (int i = 0; i < _departments.Length; i++)
            {
                if (_departments[i] == null) continue;

                if (_departments[i].Id == id)
                {
                    return _departments[i];
                }
            }

            Console.WriteLine($"ID: {id}, Fakulte yoxdur!");

            return null;
        }

        public Entity[] GetAll()
        {
            return _departments;
        }

        public void Print()
        {
            foreach (var item in _departments)
            {
                if (item == null)
                    continue;

                Console.WriteLine(item);
            }
        }

        public void Update(int id, Entity entity)
        {
            for (int i = 0; i < _departments.Length; i++)
            {
                if (_departments[i] == null) continue;

                if (_departments[i].Id == id)
                {
                    _departments[i] = (Department)entity;
                    Console.WriteLine("Ugurla deyisdirildi!");

                    return;
                }
            }

            Console.WriteLine("Taplmadi!");
        }

    }
}
