// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using BizOneShot.Light.Models.WebModels;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace BizOneShot.Light.Dao.WebConfiguration
{
    // RPT_MENTOR_CHECK
    internal partial class RptMentorCheckConfiguration : EntityTypeConfiguration<RptMentorCheck>
    {
        public RptMentorCheckConfiguration()
            : this("dbo")
        {
        }
 
        public RptMentorCheckConfiguration(string schema)
        {
            ToTable(schema + ".RPT_MENTOR_CHECK");
            HasKey(x => new { x.QuestionSn, x.NumSn, x.BasicYear, x.DetailCd });

            Property(x => x.QuestionSn).HasColumnName("QUESTION_SN").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.NumSn).HasColumnName("NUM_SN").IsRequired().HasColumnType("nvarchar").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.BasicYear).HasColumnName("BASIC_YEAR").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.DetailCd).HasColumnName("DETAIL_CD").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(8).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CheckVal).HasColumnName("CHECK_VAL").IsOptional().HasColumnType("bit");

            // Foreign keys
            HasRequired(a => a.RptCheckList).WithMany(b => b.RptMentorChecks).HasForeignKey(c => c.DetailCd); // FK_RPT_CHECK_LIST_TO_RPT_MENTOR_CHECK
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
