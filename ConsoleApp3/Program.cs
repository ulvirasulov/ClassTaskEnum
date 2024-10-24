namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            int choice;
            bool f = false;
            do
            {
                Console.WriteLine("1: mehsul elave et");
                Console.WriteLine("2: mehsulu sil");
                Console.WriteLine("3: mehsulu tap");
                Console.WriteLine("4: ad uzre mehsulu tap");
                Console.WriteLine("5: type uzre mehsulu tap");
                Console.WriteLine("6: butun mehsullari getir");
                Console.WriteLine("0: cixis");
                Console.Write("secim et: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Mehsulun adi: ");
                        string name = Console.ReadLine();
                        Console.Write("mehsulun qiymeti: ");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("mehsulun type-i (1- Baker, 2- Drink, 3- Meat, 4- Diary)");
                        int type = int.Parse(Console.ReadLine());

                        Product newProduct = new Product(name, price, (ProductType)type);
                        store.AddProduct(newProduct);
                        Console.WriteLine("mehsul elave olundu.");
                        break;
                    case 2:
                        Console.Write("silmek istediyiniz mehsulun nomresini daxil edin: ");
                        int noToRemove = int.Parse(Console.ReadLine());
                        store.RemoveProductByNo(noToRemove);
                        break;
                    case 3:
                        Console.Write("axtardiginiz mehsulun nomresini daxil edin: ");
                        int noToSearch = int.Parse(Console.ReadLine());
                        store.GetProduct(noToSearch);
                        break;
                    case 4:
                        Console.Write("axtarmaq istediyiniz mehsulun adini daxil edin:");
                        string nameToFilter = Console.ReadLine();
                        store.FilterProductByName(nameToFilter);
                        break;
                    case 5:
                        Console.Write("axtarmaq istediyiniz mehsulun type-ni daxil edin:");
                        string typeToFilter = Console.ReadLine();
                        store.FilterProductByType(typeToFilter);
                        break;
                    case 6:
                        Console.WriteLine("butun mehsullar:");
                        store.GetAllProducts();
                        break;
                    case 0:
                        f = true;
                        break;
                    default:
                        Console.WriteLine("yanlis secim etdiniz.");
                        break;
                }
            } while (!f);
        }
    }
}