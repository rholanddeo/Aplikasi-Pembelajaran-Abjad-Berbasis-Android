using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void reset_game(){
        Application.LoadLevel (Application.loadedLevelName);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
