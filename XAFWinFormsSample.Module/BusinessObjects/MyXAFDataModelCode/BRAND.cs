using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace XAFWinFormsSample.Module.BusinessObjects.Database
{
    [DefaultClassOptions, ImageName("BO_BRAND")]
    public partial class BRAND
    {
        public BRAND(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
