// <auto-generated />
namespace Vidly.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class ChangeIntToByteInGenreIdPropertyInMoviesTable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(ChangeIntToByteInGenreIdPropertyInMoviesTable));
        
        string IMigrationMetadata.Id
        {
            get { return "202106131246417_ChangeIntToByteInGenreIdPropertyInMoviesTable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}