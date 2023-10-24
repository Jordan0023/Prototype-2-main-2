using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{ 
    

    public Slider slider;

    public int hunger = 3;



    // Start is called before the first frame update

    void Start()
    {
        slider.maxValue = hunger;
        slider.value = 0;
       // slider.fillRect.gameObject.SetActive(false);


       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void removeHunger() {
        hunger -= 1;
        slider.value += 1;
        if(hunger <= 0) {
            Destroy(gameObject)
        }
    }

}
