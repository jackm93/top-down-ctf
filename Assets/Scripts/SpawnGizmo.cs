using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGizmo : MonoBehaviour {
	[SerializeField]
	private Mesh spawnMesh;

	[SerializeField]
	private Color color;

	private void OnDrawGizmos()
	{
		Gizmos.color = color;
		Gizmos.DrawMesh(spawnMesh, 0, transform.position, transform.rotation, new Vector3(1,0.2f,1));
	}
}
