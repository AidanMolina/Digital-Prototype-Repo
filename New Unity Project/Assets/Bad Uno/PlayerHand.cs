using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHand : MonoBehaviour
{
    List<Card> hand = new List<Card>();
    [SerializeField] Deck deck;
    [SerializeField] PlayingStack playingStack;
    [SerializeField] GameObject handText;

    private int handPointer = 0;

    // Start is called before the first frame update
    void Start()
    {
        makeHand();
        for(int i = 0; i < hand.Count; i++){
            handText.GetComponent<Text>().text += "\n" + hand[i].toString() + " " + hand[i].number;
        }
        Debug.Log("You are currently selecting: " + hand[handPointer].toString() + " " + hand[handPointer].number);
    }

    // Update is called once per frame
    void Update()
    {
        if(!canPlay()){
            draw();
        }

        if(Input.GetKeyDown("down")){
            handPointer++;
            if(handPointer >= hand.Count){
                handPointer = 0;
            }
            Debug.Log("You are currently selecting: " + hand[handPointer].toString() + " " + hand[handPointer].number);
        }

        if(Input.GetKeyDown("up")){
            handPointer--;
            if(handPointer < 0){
                handPointer = hand.Count-1;
            }
            Debug.Log("You are currently selecting: " + hand[handPointer].toString() + " " + hand[handPointer].number);
        }

        if(Input.GetKeyDown("space")){
            play(hand[handPointer]);
        }

        if(handPointer >= hand.Count){
            handPointer = hand.Count - 1;
        }
    }

    private void makeHand(){
        for(int i = 7; i > 0; i--){
            hand.Add(deck.drawCard());
        }
    }

    private void draw(){
        hand.Add(deck.drawCard());
        handText.GetComponent<Text>().text = "Hand:";
        for(int i = 0; i < hand.Count; i++){
            handText.GetComponent<Text>().text += "\n" + hand[i].toString() + " " + hand[i].number;
        }
    }

    private void play(Card selectedCard){
        if(playingStack.played.Count == 0){
            playingStack.addCard(selectedCard);
            hand.Remove(selectedCard);
            handText.GetComponent<Text>().text = "Hand:";
            for(int i = 0; i < hand.Count; i++){
                handText.GetComponent<Text>().text += "\n" + hand[i].toString() + " " + hand[i].number;
            }
        }
        else{
            Card temp = playingStack.played.Peek();
            if(selectedCard.color == temp.color || selectedCard.number == temp.number){
                playingStack.addCard(selectedCard);
                hand.Remove(selectedCard);
                handText.GetComponent<Text>().text = "Hand:";
                for(int i = 0; i < hand.Count; i++){
                    handText.GetComponent<Text>().text += "\n" + hand[i].toString() + " " + hand[i].number;
                }
            }    
        }
        
    }

    private bool canPlay(){
        bool temp = false;

        if(playingStack.played.Count == 0 || hand.Count == 0){
            temp = true;
            return temp;
        }

        Card topOfPlayed = playingStack.played.Peek();
        for(int i = 0; i < hand.Count; i++){
            if(hand[i].color == topOfPlayed.color || hand[i].number == topOfPlayed.number){
                temp = true;
                break;
            }
        }
        return temp;
    }
}
