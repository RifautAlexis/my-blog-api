using Api.Entities;

namespace Api.DataAccess
{
    public partial class BlogDbContext
    {
        public async Task Seed(BlogDbContext context)
        {

            Console.WriteLine("Deleting data from the database...");
            await context.Database.EnsureDeletedAsync();
            Console.WriteLine("Ensure that the database exists...");
            await context.Database.EnsureCreatedAsync();
            Console.WriteLine("Check done");

            using var transaction = context.Database.BeginTransaction();
            Console.WriteLine("Start of database seeding");

            try
            {
                var tags = new List<Tag>
                {
                    new Tag {
                        Name = "C#",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now.AddDays(3),
                    },
                    new Tag {
                        Name = ".NET",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    },
                    new Tag {
                        Name = "ASP.NET Core",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    },
                    new Tag {
                        Name = "Typescript",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now.AddDays(5),
                    },
                    new Tag {
                        Name = "Angular",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now.AddDays(25),
                    },
                };

                context.Tags.AddRange(tags);
                await SaveChangesAsync();
                Console.WriteLine("Tags have been added successfully.");

                var articles = new List<Article>
                {
                    new Article
                    {
                        Slug = "C# 9.0",
                        Title = "C# 9.0",
                        Content = "C# 9.0 is the latest version of C#",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    },
                    new Article
                    {
                        Slug = "C# 8.0",
                        Title = "C# 8.0",
                        Content = "C# 8.0 is the latest version of C#",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    },
                    new Article
                    {
                        Slug = "C# 3.5",
                        Title = "C# 3.5",
                        Content = "C# 3.5 is the latest version of C#",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now.AddDays(56),
                    },
                    new Article
                    {
                        Slug = "ASP.NET Core 5.0",
                        Title = "ASP.NET Core 5.0",
                        Content = "ASP.NET Core 5.0 is the latest version of ASP.NET Core",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now.AddDays(61),
                    },
                    new Article
                    {
                        Slug = "ASP.NET Core Authentication",
                        Title = "ASP.NET Core Authentication",
                        Content = "ASP.NET Core Authentication",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now.AddDays(1),
                    },
                    new Article
                    {
                        Slug = "Angular 11",
                        Title = "Angular 11",
                        Content = "Angular 11 is the latest version of Angular",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now.AddDays(1),
                    },
                    new Article
                    {
                        Slug = "Angular 18: First Course",
                        Title = "Angular 18: First Course",
                        Content = "Content of the First Course",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    },
                    new Article
                    {
                        Slug = "Angular 18: Second Course",
                        Title = "Angular 18: Second Course",
                        Content = "Content of the Second Course",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    },
                    new Article
                    {
                        Slug = "Angular 18: Third Course",
                        Title = "Angular 18: Third Course",
                        Content = "Content of the Third Course",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    }
                };

                context.Articles.AddRange(articles);
                await SaveChangesAsync();
                Console.WriteLine("Articles have been added successfully.");

                var stories = new List<Story>
                {
                    new Story
                    {
                        Title = "Angular Course",
                        Description = "Angular Course",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    },
                    new Story
                    {
                        Title = "C# News",
                        Description = "C# News",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    },
                };

                context.Stories.AddRange(stories);
                await SaveChangesAsync();
                Console.WriteLine("Stories have been added successfully.");

                var articleTags = new List<ArticleTag>
                {
                    new ArticleTag { Article = articles[0], Tag = tags[0] },
                    new ArticleTag { Article = articles[1], Tag = tags[0] },
                    new ArticleTag { Article = articles[2], Tag = tags[0] },

                    new ArticleTag { Article = articles[3], Tag = tags[0] },
                    new ArticleTag { Article = articles[3], Tag = tags[1] },
                    new ArticleTag { Article = articles[3], Tag = tags[2] },

                    new ArticleTag { Article = articles[4], Tag = tags[0] },
                    new ArticleTag { Article = articles[4], Tag = tags[1] },
                    new ArticleTag { Article = articles[4], Tag = tags[2] },

                    new ArticleTag { Article = articles[5], Tag = tags[3] },
                    new ArticleTag { Article = articles[5], Tag = tags[4] },
                    new ArticleTag { Article = articles[6], Tag = tags[3] },
                    new ArticleTag { Article = articles[6], Tag = tags[4] },
                    new ArticleTag { Article = articles[7], Tag = tags[3] },
                    new ArticleTag { Article = articles[7], Tag = tags[4] },
                    new ArticleTag { Article = articles[8], Tag = tags[3] },
                    new ArticleTag { Article = articles[8], Tag = tags[4] },
                };

                context.ArticleTags.AddRange(articleTags);
                await SaveChangesAsync();
                Console.WriteLine("Article Tags have been added successfully.");

                var storyArticles = new List<StoryArticle>
                {
                    new StoryArticle { Story = stories[0], Article = articles[5], ReadingOrder = 1 },
                    new StoryArticle { Story = stories[0], Article = articles[6], ReadingOrder = 2 },
                    new StoryArticle { Story = stories[0], Article = articles[7], ReadingOrder = 3 },
                    new StoryArticle { Story = stories[0], Article = articles[8], ReadingOrder = 4 },
                    new StoryArticle { Story = stories[1], Article = articles[0], ReadingOrder = 1 },
                    new StoryArticle { Story = stories[1], Article = articles[1], ReadingOrder = 2 },
                    new StoryArticle { Story = stories[1], Article = articles[2], ReadingOrder = 3 },
                };

                context.StoryArticles.AddRange(storyArticles);
                await SaveChangesAsync();
                Console.WriteLine("Story Articles have been added successfully.");

                transaction.Commit();

                Console.WriteLine("Database has been seeded successfully.");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine($"Error during seeding: {ex.Message}");
            }
        }
    }
}
