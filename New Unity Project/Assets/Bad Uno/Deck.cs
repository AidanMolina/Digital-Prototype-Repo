using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    Stack<Card> deck = new Stack<Card>();

    void Awake(){
        makeDeck();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void makeDeck(){

        List<Card> newDeck = new List<Card>();
        makeColor(CardColor.Red, newDeck);
        makeColor(CardColor.Blue, newDeck);
        makeColor(CardColor.Yellow, newDeck);
        makeColor(CardColor.Green, newDeck);

        while(newDeck.Count > 0){
            int rand = Random.Range(0, newDeck.Count);
            deck.Push(newDeck[rand]);
            newDeck.Remove(newDeck[rand]);
        }
    }

    private void makeColor(CardColor selectedColor, List<Card> selectedList){
        for(int i = 0; i < 10; i++){
            Card card = new Card();
            card.color = selectedColor;
            card.number = (CardNumber) i;
            selectedList.Add(card);
        }
    }

    public Card drawCard(){
        return deck.Pop();
    }

    public int size(){
        return deck.Count;
    }

    public void pushCard(Card selectedCard){
        deck.Push(selectedCard);
    }
}
