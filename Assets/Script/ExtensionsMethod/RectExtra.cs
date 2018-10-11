using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Script
{
    static class RectExtra
    {
        public static bool IsRectNull<T>(this T rect)
        {
            return rect != null;
        }
    }
}
