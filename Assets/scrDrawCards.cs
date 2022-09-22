using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrDrawCards : MonoBehaviour
{
    public GameObject card1;
    public GameObject card2;
    public GameObject playerArea;
    public GameObject opponentArea;

    void Start()
    {
        
    }

    public void onClick() 
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(card1, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(playerArea.transform, false);
        }
    }
}
