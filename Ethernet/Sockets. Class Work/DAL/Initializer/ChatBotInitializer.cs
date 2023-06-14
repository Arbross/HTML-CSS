using System.Data.Entity;

namespace DAL
{
    public class ChatBotInitializer : CreateDatabaseIfNotExists<DALModel>
    {
        protected override void Seed(DALModel context)
        {
            base.Seed(context);

            context.Categories.Add(new Categoria() { UseCategoria = "Hello" });

            context.SaveChanges();
        }
    }
}