using System;
namespace InventoryConsole.Menues
{
	public class Menu
	{
		public string Title { get; set; } = null!;
        public Action Action { get; set; } = null!;
	}
}

