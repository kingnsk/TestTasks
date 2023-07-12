namespace PositionOnFloor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество этажей в доме: ");
            int floors = int.Parse(Console.ReadLine());
            Console.Write("Введите количество подъездов: ");
            int entrances = int.Parse(Console.ReadLine());
            Console.Write("Введите номер квартиры: ");
            int flatNumber = int.Parse(Console.ReadLine());

            int flatsOnFloor = 4; // количество квартир на одном этаже 
            int flatsPerEntrance = flatsOnFloor * floors; // количество квартир в одном подъезде 
            int entranceNumber = (flatNumber - 1) / flatsPerEntrance + 1; // номер подъезда 

            if(entranceNumber>entrances)
            {
                Console.WriteLine($"Ошибка! Квартиры с таким номером (№{flatNumber}) в этом доме нет!");
                return;
            }

            int flatsLeft = (flatNumber - 1) % flatsPerEntrance; // количество квартир после текущего подъезда 
            int floorNumber = flatsLeft / flatsOnFloor + 1; // номер этажа 
            int flatNumberOnFloor = (flatNumber - 1) % flatsOnFloor + 1; // номер квартиры на этаже 

            string position = "";
            switch (flatNumberOnFloor)
            {
                case 1:
                    position = "ближняя слева";
                    break;
                case 2:
                    position = "дальняя слева";
                    break;
                case 3:
                    position = "дальняя справа";
                    break;
                case 4:
                    position = "ближняя справа";
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Квартира №{flatNumber} находится в {entranceNumber} подъезде на {floorNumber} этаже.");
            Console.WriteLine($"Квартира №{flatNumber} расположена на этаже: {position}");
        }
    }
}