using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1.	*Разработать один из классов, в соответствии с полученным вариантом.
2.	*Реализовать не менее пяти закрытых полей (различных типов), представляющих основные характеристики рассматриваемого класса.
3.	*Создать не менее трех методов управления классом и методы доступа к его закрытым полям. 
4.	*Создать метод, в который передаются аргументы по ссылке. 
5.	*Создать не менее двух статических полей (различных типов),  представляющих общие характеристики объектов данного класса. 
6.	*Обязательным требованием является реализация нескольких перегруженных конструкторов, аргументы которых определяются студентом, исходя из специфики реализуемого класса, а так же реализация конструктора по умолчанию.
7.	*Создать статический конструктор.
8.	*Создать массив (не менее 5 элементов) объектов созданного класса.
9.	*Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial. 
*/
namespace ConsoleApp1
{
    partial class Auto
    {
        private static string typeOfAuto;
        private static int countOfCylinder;
        private string mark;
        private string model;
        private string typeOfBody;
        private int maxSpeed;
        private float engineCapacity;
        private DateTime dateOfManufacture;

        public Auto()
        {
            typeOfBody = model = mark = "не указан";
        }
        
        public Auto(string mark, string model, string typeOfBody, int maxSpeed, float engineCapacity, DateTime date):this(mark, model)
        {
            SetTypeOfBody(typeOfBody);
            SetMaxSpeed(maxSpeed);
            SetEngineCapacity(engineCapacity);
            SetDateOfManufacture(date);
        }

        public Auto(string mark, string model)
        {
            SetMark(mark);
            SetModel(model);
        }

        static Auto()
        {
            typeOfAuto = "Легковой";
            countOfCylinder = 6;
        }

        public static string GetTypeOfAuto()
        {
            return typeOfAuto;
        }
        
        public void SetMark(string mark)      
        {
            this.mark = mark;
        }

        public string GetMark()
        {
            return mark;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetTypeOfBody(string typeOfBody)
        {
            this.typeOfBody = typeOfBody;
        }

        public string GetTypeOfBody()
        {
            return typeOfBody;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public int GetMaxSpeed()
        {
            return maxSpeed;
        }

        public void SetEngineCapacity(float engineCapacity)
        {
            this.engineCapacity = engineCapacity;
        }

        public float GetEngineCapacity()
        {
            return engineCapacity;
        }

        public void SetDateOfManufacture(DateTime date)
        {
            dateOfManufacture = date;
        }

        public DateTime GetDateOfManufacture()
        {
            return dateOfManufacture;
        }

        public void Show()
        {
            Console.WriteLine("Тип автомобиля: {0}", typeOfAuto);
            Console.WriteLine("Количество цилиндров: {0}", countOfCylinder);
            Console.WriteLine("Марка: {0}", mark);
            Console.WriteLine("Модель: {0}", model);
            Console.WriteLine("Тип кузова: {0}", typeOfBody);
            Console.WriteLine("Максимальная скорость: {0}", maxSpeed);
            Console.WriteLine("Объем двигателя: {0}", engineCapacity);
            Console.WriteLine("Дата выпуска: {0}", dateOfManufacture.ToShortDateString());
        }

        public void Clear()
        {
            typeOfBody = model = mark = "не указан";
            maxSpeed = 0;
            engineCapacity = 0;
            dateOfManufacture = DateTime.MinValue;
        }

        public void Clone(Auto cloneAuto)
        {
            cloneAuto.SetMark(mark);
            cloneAuto.SetModel(model);
            cloneAuto.SetTypeOfBody(typeOfBody);
            cloneAuto.SetMaxSpeed(maxSpeed);
            cloneAuto.SetEngineCapacity(engineCapacity);
            cloneAuto.SetDateOfManufacture(dateOfManufacture);
        }

        public void ReadFromAuto(ref string mark, ref string model, ref int maxSpeed)
        {
            mark = this.mark;
            model = this.model;
            maxSpeed = this.maxSpeed;
        }
    }
}
