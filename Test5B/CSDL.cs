namespace Test5B
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Test5B.DTO;

    public class CSDL : DbContext
    {
        // Your context has been configured to use a 'CSDL' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Test5B.CSDL' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CSDL' 
        // connection string in the application configuration file.
        public CSDL()
            : base("name=CSDL")
        {
            Database.SetInitializer<CSDL>(new CreateDB());
        }
        public virtual DbSet<SV> SVs { get; set; }
        public virtual DbSet<BangDiem> BangDiems { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LSH> LSHes { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BangDiem>().HasKey(vf => new { vf.MMH, vf.MSSV });
        }
    }


    // Add a DbSet for each entity type that you want to include in your model. For more information 
    // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

    // public virtual DbSet<MyEntity> MyEntities { get; set; }


    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}