using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to be called when the button is clicked
    public void OnButtonClick()
    {
        // Quit the game (only works in standalone builds, not in the Unity Editor)
        Application.Quit();
    }
}
