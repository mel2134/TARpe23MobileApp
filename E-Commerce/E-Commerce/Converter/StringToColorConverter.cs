﻿using CommunityToolkit.Maui.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Converter
{
    public class StringToColorConverter : BaseConverterOneWay<string,Color>
    {
        public override Color DefaultConvertReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Color ConvertFrom(string value, CultureInfo culture) => Color.FromHex(value);
    }
}
