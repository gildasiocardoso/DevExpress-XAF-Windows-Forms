﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace XAFWinFormsSample.Module.BusinessObjects.Database
{

    public partial class ORDER_ITEM
    {
        public ORDER_ITEM(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
