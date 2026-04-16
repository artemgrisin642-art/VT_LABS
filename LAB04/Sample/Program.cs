using OOP_COLLECTIONS;
using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // 1. Cоздать отдел с названием "IT"
        // =========================
        Department itDepartment = new Department("IT");

        // =========================
        // 2. Cоздать 2-х рабочих
        // =========================
        Worker worker1 = new Worker("Артём", 1000, 22);
        Worker worker2 = new Worker("Стрей", 1100, 18);
        // =========================
        // 3. Cоздать 2-х программистов
        // =========================
        Programmer programmer1 = new Programmer("Владимир", 2000, "Junior");
        Programmer programmer2 = new Programmer("Макрон", 3000, "Senior");

        // =========================
        // 4. Cоздать 1-го менеджера
        // =========================
        Manager manager1 = new Manager("Ланселот", 3500, 8);


        Console.WriteLine(itDepartment.Employees.Count);

        // =========================
        // 5. Добавить всех сотрудников в отдел
        // =========================

        itDepartment.AddEmployee(manager1);
        itDepartment.AddEmployee(worker1);
        itDepartment.AddEmployee(worker2);
        itDepartment.AddEmployee(programmer1);
        itDepartment.AddEmployee(programmer2);

        Console.WriteLine(itDepartment.Employees.Count);



        // =========================
        // 6. Вывести всех сотрудников отдела
        // =========================

        Console.WriteLine(" Все сотрудники отдела ");
        itDepartment.ShowAllEmployees();

       // =========================
        // 7. Найти сотрудников с Id 1, 3, 7 и вывести информацию о них
        // =========================
        Console.WriteLine("\n Тестируем поиск сотрудника ");
        int[] ids = { 1, 3, 7 };
        foreach (int id in ids)
        {
            Employee emp = itDepartment.FindEmployeeById(id);
            if (emp != null)
            {
                emp.DisplayInfo();
            }
            else
            {
                Console.WriteLine($"Сотрудник с таким айди не существует.");
            }
        }

        // =========================
        // 8. Удалить сотрудника с Id = 2
        // =========================
        Console.WriteLine("\n Тестируем удаление сотрудника ");
        bool removed = itDepartment.RemoveEmployeeById(2);
        Console.WriteLine(removed ? "Сотрудник удален." : "Сотрудник не найден.");

        // =========================
        // 9. Вывести всех сотрудников отдела после удаления
        // =========================
        Console.WriteLine("\n После удаления ");
        itDepartment.ShowAllEmployees();

        // =========================
        // 10. Вывести на экран сводную информацию об отделе
        // =========================
        Console.WriteLine("\n Статистика Отдела ");
        itDepartment.GetDepartmentInfo();
        
    }
}