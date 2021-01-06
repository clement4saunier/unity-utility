using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtility.Animation
{
    public abstract class TransformAnimator : MonoBehaviour
    {
        [Header("Animation")]
        [SerializeField] AnimationCurve curve = AnimationCurve.Linear(0, 0, 1, 1);
        [SerializeField] float duration = 1;
        [SerializeField] bool playOnEnable = false;
        [SerializeField] bool loop = false;
        [SerializeField] bool reverse = false;

        [Header("Settings")]
        [SerializeField] Vector3 start;
        [SerializeField] Vector3 target;
        [SerializeField] bool useStartPosition = true;
        [SerializeField] bool isTargetRelative = false;

        protected bool played = false;
        private bool reversed = false;
        private float time = 0;
        protected Vector3 startVector;
        protected Vector3 finalVector;

        private void OnEnable()
        {
            if (playOnEnable)
                Play();
        }

        public void Update()
        {
            if (played)
            {
                time += Time.deltaTime;
                float evaluation = curve.Evaluate(time / duration);
                if (reversed)
                    evaluation = 1 - evaluation;
                Apply(evaluation);

                if (time >= duration)
                {
                    Apply(curve.Evaluate(reversed ? 0 : 1));
                    End();
                }
            }
        }

        public abstract void Apply(float evaluation);
        public abstract Vector3 GetCurrentVector();

        public virtual void End()
        {
            played = false;
            time = 0;

            if (reverse && !reversed)
            {
                reversed = true;
                Play();
            }
            else if (loop)
            {
                if (reverse)
                    reversed = !reversed;
                Play();
            }
        }

        [ContextMenu("Play")]
        public virtual void Play()
        {
            played = true;
            startVector = useStartPosition ? start : GetCurrentVector();
            finalVector = isTargetRelative ? (startVector + target) : target;
        }
    }
}
