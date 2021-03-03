// This class defines the cards of the game
// A card is made up of an image of the card, an ID, and an array of numerical values representing shape, colour, shading and number
// This class also keeps track of the cards that have been selected by the user using a static list of cards. 
// This class is also responsible for updating the number of selected cards displayed in the GUI and changing the prompt in some cases

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Card : MonoBehaviour
{
    static int totNum = 15; // gotten from title selection
    static List<Card> selectedCards = new List<Card>(); // holds the cards that the user has selected
    static List<GameObject> allCards = new List<GameObject>(); // holds all the cards in the game
    
    int ID; // unique ID which identifies a card, the ID is based off of its location on the display screen
    int[] attributes ; // shape, colour, shading, number

    Image thisImage; // holds the image attribute of the card so that it is able to change its color

    // objects used for accessing and display 
    static GameObject numDisplay;
    static TextMeshProUGUI selectedNum;
    static GameObject promptDisplay;
    static TextMeshProUGUI prompt;

    // colors used for indicating if a card has been selected or is part of a set
    Color normalColor = Color.white;
    Color clickedColor = new Color(0.5f, 0.5f, 0.5f, 0.75f);
    Color setColor = new Color(154f/255f, 206f/255f, 230f/255f, 0.8f);

    // keep track of if the button has been pressed or not
    bool clicked = false;
   
    // default constructor for the Card class which instantiates its attributes array
    private Card()
    {
        attributes = new int[4];
        ID = 0;
    }
    // on start create a listener to listen for clicks and initialize the image, numDisplay and prompt variables
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(TaskOnClick);
        thisImage = this.GetComponent<Image>();
        numDisplay = GameObject.Find("NumSelected/NumSelectedText");
        selectedNum = numDisplay.GetComponent<TextMeshProUGUI>();
        promptDisplay = GameObject.Find("Prompt");
        prompt = promptDisplay.GetComponent<TextMeshProUGUI>();
    }

    // function to handle the cards on click behaviour
    public void TaskOnClick()
    {
        // checks if the button has been clicked already or not
        //
        // if it hasn't add this card to the selected cards and change its color to the selected card color
        // but only if the selected cards list isn't full
        //
        // if the card was already clicked, take it out of the list and return it to the normal color
        if (clicked == false)
        {
            if (selectedCards.Count < totNum)
            {
                selectedCards.Add(this);
                thisImage.color = clickedColor;
                clicked = true;
            }
            else
            {
                prompt.text = "The list of selected cards is already full!";
            }
        }
        else
        {
            selectedCards.Remove(this);
            thisImage.color = normalColor;
            clicked = false;
        }

        // display the count of selected cards
        // the conditional handles formatting so that the number is centered whether it has 1 or 2 digits
        if (selectedCards.Count < 10)
        {
            selectedNum.text = " " + selectedCards.Count.ToString();
        }
        else
        {
            selectedNum.text = selectedCards.Count.ToString();
        }
    }
    
    // various methods for modifying the values of individual cards
    public void unclick()
    {
        this.clicked = false;
    }
    
    // functions for changing the color of the card
    public void clickedMe()
    {
        thisImage.color = clickedColor;
    }
    public void select()
    {
        thisImage.color = setColor;
    }

    public void deselect()
    {
        thisImage.color = normalColor;
    }
    
    // getters and setters for individual Card variables
    public int[] getAttributes()
    {
        return this.attributes;
    }

    public int getID()
    {
        return this.ID;
    }

    public void setID(int ID)
    {
        this.ID = ID;
    }

    // functions for enabling or disabling the cards
    // used to stop users from selecting cards while viewing sets
    public void disableMe()
    {
        this.GetComponent<Button>().enabled = false;
    }
    public void enableMe()
    {
        this.GetComponent<Button>().enabled = true;
    }

    // various functions for accessing and modifying the classes static variables
    // function for getting the selected cards 
    public static List<Card> getSelectedCards()
    {
        return selectedCards;
    }


    // function for maniputlating the list of allCards
    public static void addToAllCards(GameObject newCard)
    {
        allCards.Add(newCard);
    }

    public static List<GameObject> getAllCards()
    {
        return allCards;
    }

    public static GameObject getCardAtIndex(int index)
    {
        return allCards[index];
    }


    // function for clearing out the list of selected cards, removes each card from the list
    // and then changes its color back to normal
    public static void clearSelectedCards()
    {
        for(int i = selectedCards.Count-1; i >= 0; i--)
        {
            selectedCards[i].deselect();
            selectedCards.RemoveAt(i);
        }

    } 
}
