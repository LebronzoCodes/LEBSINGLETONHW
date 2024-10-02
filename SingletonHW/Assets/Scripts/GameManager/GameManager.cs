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
  

    // Update is called once per frame
    void Update()
    {
       

    }

    //Create Function to load scenes
    public void ChangeScene()
    {
        //Either one will lead to game scene. 
        //SceneManager.LoadScene("Game Scene");
        SceneManager.LoadScene(1);
    }
}
