using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exam_A.Models
{
    public class Exam_AContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Exam_AContext() : base("name=Exam_AContext")
        {
        }

        public System.Data.Entity.DbSet<Exam_A.Models.Exam> Exams { get; set; }
    }
}
