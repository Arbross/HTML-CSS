using System.Data.Entity;

namespace Tasl_Parallel_Library__TPL_.Async__await
{
    public class DBInitializer : CreateDatabaseIfNotExists<TPLModel>
    {
        protected override void Seed(TPLModel context)
        {
            base.Seed(context);

            context.Authors.Add(new Author() { Name = "qwe", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "ertert", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "ert", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "erterter", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "ertdfgdfgdf", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "dfg", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "dfgdfgd", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "qwesad", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "xcvhhkjhiuoo", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "nvbmnbnmncvb", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "bng", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "iopiop", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "jkljkl", Surname = "qwweqwe" });
            context.Authors.Add(new Author() { Name = "ytujhgv", Surname = "uytityjh" });
            context.Authors.Add(new Author() { Name = "werdfc", Surname = "ryrtrtuiykl" });

            context.Books.Add(new Book() { BookName  = "yrthghrtgjy", AuthorId = 1 });
            context.Books.Add(new Book() { BookName  = "wertergf", AuthorId = 1 });
            context.Books.Add(new Book() { BookName  = "eryfghfgjnb", AuthorId = 1 });
            context.Books.Add(new Book() { BookName  = "yerttrg", AuthorId = 1 });
            context.Books.Add(new Book() { BookName  = "yrtfgdfgdfhghrtgjy", AuthorId = 1 });
            context.Books.Add(new Book() { BookName  = "yrtdfgdfgdfghghrtgjy", AuthorId = 1 });
            context.Books.Add(new Book() { BookName  = "reyer", AuthorId = 1 });
            context.Books.Add(new Book() { BookName  = "bcvbbcvbcvbc", AuthorId = 1 });
            
            context.SaveChanges();
        }
    }
}