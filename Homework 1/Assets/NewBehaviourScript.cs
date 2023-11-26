using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Plushechka;
    public void PressedButton()
    {
        if (Plushechka.active == false)
        {
            Plushechka .SetActive (true);
        }
        else {Plushechka .SetActive (false);}
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
