using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
	[SerializeField] private Transform player;
	[SerializeField] private float radius;

	private void OnDrawGizmos()
	{
		Gizmos.DrawSphere(transform.position, radius);
	}
}
