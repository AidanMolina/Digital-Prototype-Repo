using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardColor{

    Red,
    Blue,
    Yellow,
    Green
}

public enum CardNumber{

    zero,
    one,
    two,
    three,
    four,
    five,
    six,
    seven,
    eight,
    nine
}

public class Card
{
    public CardColor color;
    public CardNumber number;

    public string toString(){
        switch(color){
            case CardColor.Red:
                return "Red";

            case CardColor.Blue:
                return "Blue";

            case CardColor.Yellow:
                return "Yellow";

            case CardColor.Green:
                return "Green";
        }
        return "";
    }
}
