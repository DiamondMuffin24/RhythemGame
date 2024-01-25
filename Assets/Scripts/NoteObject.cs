using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;

    private GameMangar mangar;
    private GameObject mangarObject;

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        mangarObject = GameObject.Find("GameManagar");
        mangar = mangarObject.GetComponent<GameMangar>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);

                GameMangar.instance.NoteHit();
            }
        }
    }

   private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
        if (other.tag == "u_suck")
        {
            gameObject.SetActive(false);
            mangar.currentMultiplier = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator" && gameObject.activeSelf)
            {
            canBePressed = false;

            GameMangar.instance.NoteMissed();

            
        }
    }
}
