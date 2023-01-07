using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.core.Source.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.core.Mapping
{
    public class AnswerMapping : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.ToTable("Answer");
            builder.HasKey(a=>a.Id);
            builder.Property<String>(a => a.Description).IsRequired();
            builder.HasOne(a => a.Question).WithOne(a => a.Answer).HasForeignKey<Answer>(a=>a.QuestionId);
        }
    }
}
