// This class is responsible for the main computation in finding sets from a hand of selected cards
// It also handles displaying sets and reseting the program if the user wants to input a new hand.
// It also handles the displaying of buttons and prompts

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ComputeSets : MonoBehaviour
{
    // variables used to manipulate the prompt and buttons of the GUI
    [SerializeField] TextMeshProUGUI prompt;
    [SerializeField] Button computeButton;
    [SerializeField] Button viewButton;
    [SerializeField] Button againButton;

    // variables that are used to handle the set display and make sure values stay the same between function calls
    List<Card[]> accessSets = new List<Card[]>();
    int totNum = 0;
    int currentView = 0;

    // the main function responsible for computing sets, called when the "SET" button is clicked in the GUI
    // this function also handles multiple errors concerning user input
    public void computeSets()
    {
        // get the list of selected cards for analysis
        List<Card> selectedCards = Card.getSelectedCards();
        totNum = selectedCards.Count;

        // makes sure the input meets the input requirements, needs to be 9, 12 or 15 cards
        if (totNum != 9 && totNum != 12 && totNum != 15)
        {
            prompt.text = "Improper number of cards selected. Please select 9, 12 or 15 cards.";
        }
        else
        {
            // if the right amount of cards have been selected, start computing whether or not sets exist in the hand 
            int[,] comboArray; // holds combinations of numbers based on the number of cards selected
            List<Card[]> sets = new List<Card[]>(); // list to hold arrays of the cards in each set
            int iterations = 0; // a variable to indicate how many combinations of cards need to be checks

            // switch statement for loading the array of combinations from external class, along with the amount of combos
            switch (totNum)
            {
                case 9:
                    comboArray = ComboNine.getComboArray();
                    iterations = 84;
                    break;
                case 12:
                    comboArray = ComboTwelve.getComboArray();
                    iterations = 220;
                    break;
                case 15:
                    comboArray = ComboFifteen.getComboArray();
                    iterations = 455;
                    break;
                default:
                    comboArray = new int[0, 1];
                    break;
            }

            // main loop that checks for sets of cards
            //
            // the loop checks every possible combination of the 9, 12 or 15 cards that the user has selected and then compares card 
            // attributes of the cards in each combo
            //
            // each attribute a value of 1, 2 or 3, indicating the three different possible values for each attribute
            // shape: 1 - diamond, 2 - oval, 3 - squiggle
            // color: 1 - red, 2 - green, 3 - purple
            // shading: 1 - empty, 2 - hatched, 3 - empty
            // number: 1, 2, 3
            //
            // a set is any three cards which on each of these attributes either has all the same value, or all different values
            // to check if three cards meet this criteria. The program adds the numerical values of each cards' attributes individually,
            // if the sum of all the numerical values of a single attribute is 3, or 9 it indicates the cards have  all the same values 
            // for that particular atttribute because the numerical values are either all 1 or 3. If the sum of numerical values of a 
            // single attribute is 6, this indicates that all the values are 2, or the values are 1, 2, 3, so all the same or all different, 
            // this is the criteria for a set on a single attribute. If a set of cards meets this criteria for all four of its attributes
            // it is a set and the loop adds it to the list of sets.
            for (int n = 0; n < iterations; n++)
            {
                // sums all the values for each card on each attribute
                int shapeSum = selectedCards[comboArray[n, 0]].getAttributes()[0]
                    + selectedCards[comboArray[n, 1]].getAttributes()[0]
                    + selectedCards[comboArray[n, 2]].getAttributes()[0];

                int colorSum = selectedCards[comboArray[n, 0]].getAttributes()[1]
                        + selectedCards[comboArray[n, 1]].getAttributes()[1]
                        + selectedCards[comboArray[n, 2]].getAttributes()[1];

                int shadingSum = selectedCards[comboArray[n, 0]].getAttributes()[2]
                            + selectedCards[comboArray[n, 1]].getAttributes()[2]
                            + selectedCards[comboArray[n, 2]].getAttributes()[2];

                int numberSum = selectedCards[comboArray[n, 0]].getAttributes()[3]
                                + selectedCards[comboArray[n, 1]].getAttributes()[3]
                                + selectedCards[comboArray[n, 2]].getAttributes()[3];
                
                // checks if each sum when divided by 3 leaves no remainder, indicating the sum is 3, 6, or 9
                if (shapeSum % 3 == 0)
                {
                    if (colorSum % 3 == 0)
                    {
                        if (shadingSum % 3 == 0)
                        {
                            if (numberSum % 3 == 0)
                            {
                                sets.Add(new Card[] { selectedCards[comboArray[n, 0]], selectedCards[comboArray[n, 1]], selectedCards[comboArray[n, 2]]});
                            }
                        }
                    }
                }
            }

            // checks if no sets were found, and alerts the user if there wasn't
            // if sets were found, add the sets to the classes access sets list and activate the "View"
            // and "Again" button and disable the "SET" button. also disable all the cards so that 
            // the user cannot click on cards while viewing sets
            if (sets.Count == 0)
            {
                prompt.text = "There are no sets in this hand! Feel free to try another combination.";
            }
            else
            {
                prompt.text = "There are " + sets.Count.ToString() + " sets in this hand!";
                for (int i = 0; i < sets.Count; i++)
                {
                    accessSets.Add(sets[i]);
                }
                computeButton.gameObject.SetActive(false);
                viewButton.gameObject.SetActive(true);
                againButton.gameObject.SetActive(true);

                for (int i = 0; i < 81; i++)
                {
                    Card.getCardAtIndex(i).GetComponent<Card>().disableMe();
                }
            }
        }

    }

    // function for displaying sets, called when the "View" button is selected
    public void displaySets()
    {
        // makes sure that the all sets haven't already been displayed
        if(currentView < accessSets.Count)
        {
            // conditional for checking if there is already a set being display
            // if there is, stop displaying those cards as a set
            if(currentView >= 1)
            {
                Card[] previousSet = accessSets[currentView - 1];
                for (int i = 0; i < previousSet.Length; i++)
                {
                    previousSet[i].clickedMe();
                }                
            }

            // gets the cards in the current set and displays them by changing each
            // of their colors
            Card[] currentSet = accessSets[currentView];
            for(int i = 0; i < currentSet.Length; i++)
            {
                currentSet[i].select();
            }

            // increment the current index of viewed sets
            currentView++; ;

        }
    }

    // function for clearing the program and allowing the user to reinput more another hands
    // called when the "Again" button is clicked
    public void goAgain()
    {
        // deactivate the "View" and "Again" button and reactive the "SET" button
        computeButton.gameObject.SetActive(true);
        viewButton.gameObject.SetActive(false);
        againButton.gameObject.SetActive(false);
        // clear the list of selected cards, then number of cards selected and the index of the current set being viewed
        Card.clearSelectedCards();
        currentView = 0;
        totNum = 0;
        
        // if there are sets in accessSets, clear them out
        if (accessSets.Count > 0)
        {
            for (int i = accessSets.Count-1; i >= 0; i--)
            {
                accessSets.RemoveAt(i);
            }
        }

        // enables all cards and sets their colour back to normal
        for (int i = 0; i < 81; i++)
        {
            Card.getCardAtIndex(i).GetComponent<Card>().enableMe();
            Card.getCardAtIndex(i).GetComponent<Card>().unclick();
        }

        // return prompt to original value
        prompt.text = "Select the 9, 12 or 15 cards in the hand and hit SET to check for sets...";

    }
}
