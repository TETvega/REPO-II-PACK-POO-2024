using Newtonsoft.Json;

namespace RepoPOO.Database
{
    public class Sedder
    {
        //public static async Task LoadDataAsync(RepoPOOContext context, ILoggerFactory loggerFactory)
        //{
        //    try
        //    {
        //        //await LoadCategoriesProductAsync(loggerFactory, context);
        //        //await LoadClientsTypesAsync(loggerFactory, context);

        //    }
        //    catch (Exception e)
        //    {
        //        var logger = loggerFactory.CreateLogger<Sedder>();
        //        logger.LogError(e, "Error inicializando la data del API.");
        //    }

        //}

        // aqui en adelante son los archivos a cargar
        //seed de los Users
        //public static async Task LoadUsersAsync(ILoggerFactory loggerFactory, InmobiliariaUNAHContext context)
        //{
        //    try
        //    {
        //        var jsonFilePath = "SeedData/users.json";
        //        var jsonContent = await File.ReadAllTextAsync(jsonFilePath);
        //        var users = JsonConvert.DeserializeObject<List<UserEntity>>(jsonContent);

        //        if (!await context.Users.AnyAsync())
        //        {
        //            context.AddRange(users);
        //            await context.SaveChangesAsync();
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        var logger = loggerFactory.CreateLogger<InmobiliariaUNAHContext>();
        //        logger.LogError(e, "Error al ejecutar el Seed de Users");
        //    }
        //}
        //seed de los eventos 

    }
}
