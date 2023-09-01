using UnityEngine;

public class LookAtTrigger : MonoBehaviour
{
    [Range(0, 1)]
    public float treshold = 1f;
    public Transform bTransform;
    public float dot;

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        var transformA = transform;
        Vector3 a = transformA.position;
        Vector3 b = bTransform.position;

        Vector3 dirFromAToB = (b - a).normalized;
        dot = Vector3.Dot(dirFromAToB, transformA.right);
        Gizmos.color = dot >= treshold ? Color.green : Color.red;
        
        Gizmos.DrawLine(a, a + transformA.right.normalized);
    }
#endif
}