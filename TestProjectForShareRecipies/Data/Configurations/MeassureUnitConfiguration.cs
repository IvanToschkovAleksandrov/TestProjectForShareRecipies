using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectForShareRecipies.Data.Entities;

namespace TestProjectForShareRecipies.Data.Configurations
{
    public class MeassureUnitConfiguration : IEntityTypeConfiguration<MeassureUnit>
    {
        public void Configure(EntityTypeBuilder<MeassureUnit> builder)
        {
            builder.HasData(SeedMeassureUnit());
        }

        private MeassureUnit[] SeedMeassureUnit()
        {
            return new MeassureUnit[]
                {
                    new MeassureUnit() 
                    {
                        Id = 1,
                        Name = "kg"
                    },

                    new MeassureUnit()
                    {
                        Id = 2,
                        Name = "l"
                    },

                    new MeassureUnit()
                    {
                        Id = 3,
                        Name = "grams"
                    },

                    new MeassureUnit()
                    {
                        Id = 4,
                        Name = "ml"
                    },

                    new MeassureUnit()
                    {
                        Id = 5,
                        Name = "count"
                    },
                };

            
        }
    }
}
