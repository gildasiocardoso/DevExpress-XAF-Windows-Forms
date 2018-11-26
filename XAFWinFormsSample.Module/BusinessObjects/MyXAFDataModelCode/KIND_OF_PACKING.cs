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
    [DefaultClassOptions, ImageName("BO_KIND_OF_PACKING")]
    public partial class KIND_OF_PACKING
    {
        public KIND_OF_PACKING(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
