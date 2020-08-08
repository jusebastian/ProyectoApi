using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
namespace ProyectoApi.Models
{
  public class TodoContext : DbContext
  {
      public TodoContext(DbContextOptions<TodoContext> options) 
          : base(options)
      {
      }

      public DbSet<TodoItem> TodoItems {get; set;}
      
  }
}