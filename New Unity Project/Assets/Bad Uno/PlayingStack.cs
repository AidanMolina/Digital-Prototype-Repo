using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayingStack : MonoBehaviour
{
    [SerializeField] Deck deck;
    [SerializeField] GameObject playedText;
    public Stack<Card> played = new Stack<Card>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(deck.size() <= 0 && played.Count >= 2){
            flush();
        }
    }

    public void addCard(Card selectedCard){
        played.Push(selectedCard);
        playedText.GetComponent<Text>().text = selectedCard.toString() + " " + selectedCard.number;
    }

    public void flush(){
        Stack<Card> newPlayed = new Stack<Card>();
        newPlayed.Push(played.Pop());

        List<Card> newDeck = new List<Card>();
        while(played.Count > 0){
            newDeck.Add(played.Pop());
        }

        while(newDeck.Count > 0){
            int rand = Random.Range(0, newDeck.Count);
            deck.pushCard(newDeck[rand]);
            newDeck.Remove(newDeck[rand]);
        }
        played = newPlayed;
    }
}
