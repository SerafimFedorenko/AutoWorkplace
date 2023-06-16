using AutoWorkplaceLib.Data;

AutoWorkplaceContext context = new AutoWorkplaceContext();
DbInitializer.Initialize(context);
Console.WriteLine("База данных успешно создана");