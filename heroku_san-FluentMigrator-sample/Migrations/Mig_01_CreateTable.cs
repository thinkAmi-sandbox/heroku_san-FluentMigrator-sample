using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentMigrator;

namespace heroku_san_FluentMigrator_sample.Migrations
{
    [Migration(1)]
    public class Mig_01_CreateTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("my_table")
                .WithColumn("pk_col").AsInt32().PrimaryKey()
                .WithColumn("content_col").AsString();
        }
    }
}
