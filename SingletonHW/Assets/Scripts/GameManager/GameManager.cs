using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variables

    // Make it a singleton

    public static GameManager instance;

    public TextMeshProUGUI score;
    public TextMeshProUGUI p3score;
    public int sc_num;
    public int p3sc_num;
    public bool sceneChanged = false;

    // Awake is called on spawn of this script before start
    private void Awake()
    {
        /* A singleton must only have one instance, check to make sure this is the only instance
         * If it is the only instance, make sure it's not destroyed. If it's not, destroy this instance.*/ 

        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        

    }
    // Start is called before the first frame update
    void Start()
    {
        //Make the score 0
        sc_num = 0;
        p3sc_num = 0;


    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + sc_num;
        p3score.text = "Score: " + p3sc_num;

    }

    //Create Function to load scenes
    public void StartGame()
    {
        //Either one will lead to game scene. 
        //SceneManager.LoadScene("Game Scene");
        SceneManager.LoadScene(1);
    }
}
