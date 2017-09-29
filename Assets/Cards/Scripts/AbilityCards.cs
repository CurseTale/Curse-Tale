using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityCards : MonoBehaviour
{
    [Tooltip("Attach four ability cards to insert into scene.")] public List<GameObject> AbiltyCards = new List<GameObject>();

    private int _prefabIndex;

    private void OnValidate()
    {
        if (AbiltyCards.Count > 4)
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
            GameObject card = Instantiate(AbiltyCards[_prefabIndex], child.transform.position, Quaternion.identity);
            card.transform.SetParent(child);
            _prefabIndex++;
        }
    }
}