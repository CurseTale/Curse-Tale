using UnityEngine;

/// <summary>
/// Just used for drawing placeholders in Unity Editor
/// </summary>
public class CardSlot : MonoBehaviour {
	private void OnDrawGizmos()
	{
		Gizmos.DrawWireCube(transform.position, new Vector3(90, 135, 1));
	}
}
