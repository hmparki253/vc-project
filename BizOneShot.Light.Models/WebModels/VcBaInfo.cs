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
    // VC_BA_INFO
    public class VcBaInfo
    {
        public int BaSn { get; set; } // BA_SN (Primary key)
        public string RegistrationNo { get; set; } // REGISTRATION_NO
        public int TcmsLoginKey { get; set; } // TCMS_LOGIN_KEY
        public string BaNm { get; set; } // BA_NM
        public string BaOwnNm { get; set; } // BA_OWN_NM
        public string BaEmail { get; set; } // BA_EMAIL
        public string BaTelNo { get; set; } // BA_TEL_NO
        public DateTime? RegDt { get; set; } // REG_DT
        public DateTime? UpdDt { get; set; } // UPD_DT
    }

}
