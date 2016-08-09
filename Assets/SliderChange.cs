using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.
using UnityEngine;

public class SliderChange : MonoBehaviour
{
    public Slider mainSlider;

    int y = 0;
    //Invoked when a submit button is clicked.
    public void Update()
    {
        if (y == 60) { 
            //Displays the value of the slider in the console.
            Vector3 sup = Physics.gravity;
            mainSlider.value = sup.y;
            y = 0;
        }else
        {
            y++;
        }
    }
}