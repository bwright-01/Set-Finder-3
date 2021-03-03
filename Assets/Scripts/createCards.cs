// this class is used to create all of the cards at the beginning of the programming running  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class createCards : MonoBehaviour
{
    // the card prefab to be used to create the cards
    [SerializeField] public GameObject cardPrefab;
    // the gameObject cards will be used as a parent for the newly created cards
    GameObject cards; 

    // Start is called before the first frame update
    void Start()
    {
        
        cards = GameObject.FindGameObjectWithTag("Cards");
        // variables to store the newly created game object
        GameObject tempObject;
        Card tempCard;
        int tempID;

        // create 81 cards using the cardPrefab, setting their ids, location on the screen, and appropriate image
        // also create and set their attribute array based on their number in the sequence
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                tempID = int.Parse(i.ToString() + j.ToString());
                tempObject = 
                    Instantiate(cardPrefab, new Vector3(50 + ((j-1) * 75), 375 - ((i-1) * 42), 5),  Quaternion.identity, cards.transform) as GameObject;
                tempCard = tempObject.GetComponent<Card>();
                tempObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(tempID.ToString());
                tempCard.setID(tempID);
                
                // uses the loops indices to set the appropriate values of each attribute
                // in the layout shape and number vary along the x axis, so j is used to set those values
                // the color and shading vary along the y axis, so i is used to set those values
                if(j <= 3)
                {
                    tempCard.getAttributes()[0] = 1;
                    tempCard.getAttributes()[3] = j;
                }
                else if(j <= 6)
                {
                    tempCard.getAttributes()[0] = 2;
                    tempCard.getAttributes()[3] = j - 3;
                }
                else if(j <= 9)
                {
                    tempCard.getAttributes()[0] = 3;
                    tempCard.getAttributes()[3] = j - 6;
                }

                
                if(i <= 3)
                {
                    tempCard.getAttributes()[1] = 1;
                    tempCard.getAttributes()[2] = i;
                }
                else if(i <= 6)
                {
                    tempCard.getAttributes()[1] = 2;
                    tempCard.getAttributes()[2] = i - 3;
                }
                else if(i <= 9)
                {
                    tempCard.getAttributes()[1] = 3;
                    tempCard.getAttributes()[2] = i - 6;
                }

                // add the newly create gameObject to the array of all cards in the Card class
                Card.addToAllCards(tempObject);
            }
        }
    }
}

