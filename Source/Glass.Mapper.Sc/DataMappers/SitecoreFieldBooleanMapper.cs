﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glass.Mapper.Sc.Configuration;
using Sitecore.Data.Fields;

namespace Glass.Mapper.Sc.DataMappers
{
    public class SitecoreFieldBooleanMapper : AbstractSitecoreFieldMapper
    {
        public SitecoreFieldBooleanMapper() : base(typeof (bool))
        {

        }

        public override object GetFieldValue(string fieldValue, SitecoreFieldConfiguration config, SitecoreDataMappingContext context)
        {
            return fieldValue == "1";
        }

        public override void SetField(Field field, object value, SitecoreFieldConfiguration config, SitecoreDataMappingContext context)
        {
            bool actual = (bool) value;
            field.Value = actual ? "1" : "0";
        }
    }
}
