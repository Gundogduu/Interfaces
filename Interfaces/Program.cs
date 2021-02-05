using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //tek yerden yönetim
            //yeni bir class eklendiğinde yalnızca AddPerson'a parametre olarak vermek yeterli.
            ProjectManager projectManager = new ProjectManager();
            projectManager.AddPerson(new EmployeeManager());
            
            //yarı kısıtlı
            //IPersonManager personManager1 = new CustomerManager();
            //personManager1.Add();
            //personManager1.Update();

            //kısıtlı
            //EmployeeManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            //employeeManager.Update();

            
            Console.ReadLine();
        }
    }
    // interface'ler new'lenemez!
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    
    }

    class ProjectManager
    {
        public void AddPerson(IPersonManager personManager)
        {
            //Main'de parametre olarak new'lediğimiz class'ın add operasyonu çalışacak.
            personManager.Add();
        }
    }

}
