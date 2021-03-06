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
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading;

namespace BizOneShot.Light.Models.WebModels
{
    // RPT_MNG_CODE
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.15.1.0")]
    public class RptMngCode
    {
        public string DetailCd { get; set; } // DETAIL_CD (Primary key)
        public string LagreClassCd { get; set; } // LAGRE_CLASS_CD
        public string MidiumClassCd { get; set; } // MIDIUM_CLASS_CD
        public string SmallClassCd { get; set; } // SMALL_CLASS_CD
        public string Title { get; set; } // TITLE
        public string Content1 { get; set; } // CONTENT1
        public string Content2 { get; set; } // CONTENT2
        public string Status { get; set; } // STATUS

        // Reverse navigation
        public virtual ICollection<RptMngComment> RptMngComments { get; set; } // Many to many mapping
        
        public RptMngCode()
        {
            RptMngComments = new List<RptMngComment>();
        }
    }

}
