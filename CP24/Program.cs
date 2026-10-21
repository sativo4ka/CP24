using System;

namespace CP24
{
   class Program
    {
        static void Main()
        {
            Repository<Product> products = new Repository<Product>();
            Repository<Customer> customers = new Repository<Customer>();

            Console.WriteLine("Добавление товаров");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nТовар №{i + 1}");

                Console.Write("Введите ID товара: ");
                int id = int.Parse(Console.ReadLine()!);

                Console.Write("Введите название товара: ");
                string name = Console.ReadLine()!;

                products.Add(new Product
                {
                    Id = id,
                    Name = name
                });
            }

            Console.WriteLine("\nДобавление покупателей");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nПокупатель №{i + 1}");

                Console.Write("Введите ID покупателя: ");
                int id = int.Parse(Console.ReadLine()!);

                Console.Write("Введите Email покупателя: ");
                string email = Console.ReadLine()!;

                customers.Add(new Customer
                {
                    Id = id,
                    Email = email
                });
            }

            Console.WriteLine("\nПоиск товара");

            Console.Write("Введите ID товара для поиска: ");
            int productId = int.Parse(Console.ReadLine()!);

            Product? product = products.GetById(productId);

            if (product != null)
                Console.WriteLine($"Найден товар: {product.Name}, ID: {product.Id}");
            else
                Console.WriteLine("Товар не найден (null)");

            Console.WriteLine("\nПоиск покупателя");

            Console.Write("Введите ID покупателя для поиска: ");
            int customerId = int.Parse(Console.ReadLine()!);

            Customer? customer = customers.GetById(customerId);

            if (customer != null)
                Console.WriteLine($"Найден покупатель: {customer.Email}, ID: {customer.Id}");
            else
                Console.WriteLine("Покупатель не найден (null)");
        }
    }
}