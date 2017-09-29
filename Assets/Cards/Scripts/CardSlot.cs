using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlot : MonoBehaviour {
	private void OnDrawGizmos()
	{
		Gizmos.DrawWireCube(transform.position, new Vector3(90, 135, 1));
	}
}
