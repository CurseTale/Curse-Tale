using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
	[Tooltip("Select Card Front")] public Sprite CardFront;
	[Tooltip("Select Card Back")] public Sprite CardBack;
	[HideInInspector] public bool Flipped;

	private Image _image;
	
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
		Flipped = !Flipped;
		_image.sprite = Flipped ? CardBack : CardFront;
		
		// TODO: Activate card ability
	}
}
