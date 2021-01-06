using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityUtility.Animation;

namespace UnityUtility.Animation
{
    public class ScaleAnimator : TransformAnimator
    {
        public override void Apply(float evaluation)
        {
            transform.localScale = Vector3.Lerp(startVector, finalVector, evaluation);
        }

        public override Vector3 GetCurrentVector()
        {
            return (transform.localScale);
        }
    }
}
