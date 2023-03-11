using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScreen : MonoBehaviour
{

    //public Text playerName;
    public Text playerScore;

    // Start is called before the first frame update
    void Start()
    {
        
        //playerName.text =
        playerScore.text = Score.CurrentScore.ToString();




    }


}
