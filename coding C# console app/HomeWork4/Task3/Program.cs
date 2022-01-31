namespace Task3
{


    class Program
    {
      
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1,"Benjamin","Amazon");
            customer1.PrintInfo();
            customer1.Article = "Mouse"; // товар - компьютерная мышка
            customer1.Quantity = 5; // 5 шт. количество

            customer1.CalcNds(300); // выводит инфу о прайсе с НДС и без НДС , передаем в метод стоимость за одну единицу товара
        }
    }
}
