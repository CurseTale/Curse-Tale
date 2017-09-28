using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class AbilityCard : MonoBehaviour
{

	[Tooltip("Select Card Front")] public Sprite CardFront;
	[Tooltip("Select Card Back")] public Sprite CardBack;

	private Image _image;
	private bool _flipped;
	
	// Use this for initialization
	void Start ()
	{
		_image = GetComponent<Image>();
		_image.sprite = CardFront;
	}
	
	public void FlipCard()
	{
		Debug.Log("Flipped " + name);
		_flipped = !_flipped;
		_image.sprite = _flipped ? CardBack : CardFront;
	}
}
