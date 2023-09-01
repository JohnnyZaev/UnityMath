#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    public float radius = 1f;
    public Transform bTransform;

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        Vector3 a = transform.position;
        Vector3 b = bTransform.position;

        var distance = Vector3.Distance(a, b);
        Handles.color = distance > radius ? Color.red : Color.green;
        
        Handles.DrawWireDisc(a, Vector3.forward, radius);
    }
#endif
}
