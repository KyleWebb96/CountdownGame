using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject singlePlayerGameScreen;
    public GameObject gameTitleScreen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void newGame()
    {
        if(singlePlayerGameScreen != null)
        {
            singlePlayerGameScreen.SetActive(true);
            gameTitleScreen.SetActive(false);
        }


    }
}
