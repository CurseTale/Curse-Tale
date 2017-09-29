using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSlots : MonoBehaviour
{
    [Tooltip("Attach number of card prefabs to insert into scene.")]
    public List<GameObject> Cards = new List<GameObject>();

    private int _prefabIndex;

    private void OnValidate()
    {
        if (Cards.Count > 4)
        {
            Debug.LogWarning("Do not load more than four cards.");
        }
    }

    // Use this for initialization
    void Start()
    {
        SpawnCards();
        _prefabIndex = 0;
    }

    /// <summary>
    /// Spawn ability cards into the scene and parent them to the appropriate object. 
    /// </summary>
    private void SpawnCards()
    {
        foreach (Transform child in transform)
        {
            GameObject card = Instantiate(Cards[_prefabIndex], child.transform.position, Quaternion.identity);
            card.transform.SetParent(child);
            _prefabIndex++;
        }
    }
}