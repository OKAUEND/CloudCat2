using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script.Common
{
    class RectExtra
    {
        public static bool IsRectNull<T>(T rect)
        {
            return rect != null;
        }
    }
}
