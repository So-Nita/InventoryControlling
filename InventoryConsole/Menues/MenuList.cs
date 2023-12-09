using System;
namespace InventoryConsole.Menues;

public class MenuList
{
    public string Title { get; set; } = "";
    public List<Menu> Menues { get; set; } = new();

    public void Show()
    {
        for (int i = 0; i < Menues.Count; i++)
        {
            var menu = Menues[i];
            Console.WriteLine($"{i + 1,3} - {menu.Title}");
        }
    }
    public Menu GetMenu(string start = "")
    {
        int begin = 1;
        int end = Menues.Count;
        repeat:
            Console.Write($"  Plase choose option ({begin} to {end}) : ");
            if (int.TryParse(Console.ReadLine(), out var input) == false)
            {
                Console.WriteLine($"{start}>Invalid format of input");
                goto repeat;
            }
            if (input < begin || input > end)
            {
                Console.WriteLine($"{start}>Your input is {input}, the input index must be in [{begin}, {end}]");
                goto repeat;
            }
            return Menues[input - 1];
    }
}

