﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    public class OverripeBanana : Banana
    {
        public new string Blend()
        {
            return "Foo";
        }
    }
}
