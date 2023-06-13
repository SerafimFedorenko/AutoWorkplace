using AutoWorkplaceLib.Data;
using AutoWorkplaceLib.Models;

using (AutoWorkplaceContext context = new AutoWorkplaceContext())
{
    DbInitializer.Initialize(context);
    Console.WriteLine("База данных успешно создана");
}
