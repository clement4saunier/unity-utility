using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityUtility.Animation;

[CustomEditor(typeof(TransformAnimator), true)]
public class TransformAnimatorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        TransformAnimator animator = target as TransformAnimator;

        GUILayout.Space(8);
        if (GUILayout.Button("Play"))
        {
            animator.Play();
        }
    }
}
