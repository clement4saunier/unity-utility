using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtility
{
    public static class ListExtension
    {
        public static T Last<T>(this List<T> list)
        {
            if (list.Count == 0)
                return (default(T));
            return (list[list.Count - 1]);
        }
    }
}
