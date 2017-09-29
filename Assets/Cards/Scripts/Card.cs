using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
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
	
	/// <summary>
	/// When called, this method flips the card over and (WIP) activates the card's action.
	/// </summary>
	/// <remarks>
	/// This method is called from the button press event on the Ability Card GameObject.
	/// </remarks>
	public void FlipCard()
	{
		Debug.Log("Flipped " + name);
		_flipped = !_flipped;
		_image.sprite = _flipped ? CardBack : CardFront;
		
		// TODO: Activate card ability
	}
}
