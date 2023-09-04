using System;
using UnityEngine;

public class SpaceTransform : MonoBehaviour
{
    [SerializeField] private Vector2 point;
    
    private void OnDrawGizmos()
    {
        DrawBasicVector(transform.position, transform.right, transform.up);
        DrawBasicVector(Vector2.zero, Vector2.right, Vector2.up);

        var worldSpacePos = LocalToWorld(point);

        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(worldSpacePos, 0.1f);
    }

    private void DrawBasicVector(Vector2 pos, Vector2 right, Vector2 up)
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(pos, right);
        Gizmos.color = Color.green;
        Gizmos.DrawRay(pos, up);
        Gizmos.color = Color.white;
    }

    private Vector2 LocalToWorld(Vector2 pt)
    {
        Vector2 localWorldOffset = transform.right * pt.x + transform.up * pt.y;
        return (Vector2)transform.position + localWorldOffset;
    }
}
