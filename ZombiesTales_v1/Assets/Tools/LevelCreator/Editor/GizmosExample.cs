using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GizmosExample : MonoBehaviour {

        // This emulates OnDrawGizmos
        [DrawGizmo(GizmoType.NotInSelectionHierarchy |
        GizmoType.InSelectionHierarchy |
        GizmoType.Selected |
        GizmoType.Active |
        GizmoType.Pickable)]
        private static void MyCustomOnDrawGizmos(TargetExample targetExample, GizmoType gizmoType) {
            Gizmos.color = Color.white;
            Gizmos.DrawCube(
            targetExample.transform.position, Vector3.one);
        }


}
