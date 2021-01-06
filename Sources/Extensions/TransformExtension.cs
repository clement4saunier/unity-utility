using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtility.Animation
{
    public static class TransformExtension
    {
        public static void SetPositionX(this Transform transform, float xValue)
        {
            Vector3 position = transform.position;

            position.x = xValue;
            transform.position = position;
        }

        public static void SetPositionY(this Transform transform, float yValue)
        {
            Vector3 position = transform.position;

            position.y = yValue;
            transform.position = position;
        }

        public static void SetPositionZ(this Transform transform, float zValue)
        {
            Vector3 position = transform.position;

            position.z = zValue;
            transform.position = position;
        }

        public static void DestroyAllChilds(this Transform transform)
        {
            List<Transform> childs = new List<Transform>();

            foreach (Transform child in transform)
            {
                childs.Add(child);
            }
            foreach (Transform child in childs)
            {
                Object.Destroy(child.gameObject);
            }
        }
    }
}