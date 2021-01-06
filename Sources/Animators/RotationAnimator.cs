using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityUtility.Animation;

namespace UnityUtility.Animation
{
    public class RotationAnimator : TransformAnimator
    {
        public override void Apply(float evaluation)
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(startVector, finalVector, evaluation));
        }

        public override Vector3 GetCurrentVector()
        {
            return (transform.rotation.eulerAngles);
        }
    }
}
