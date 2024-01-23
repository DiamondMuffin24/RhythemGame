using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Turn_On : MonoBehaviour
{
    public GameObject Dialogue1;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        { 
         Dialogue1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("Start");
        }
    }
}
