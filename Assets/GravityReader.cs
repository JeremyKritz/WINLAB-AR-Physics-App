using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GravityReader : MonoBehaviour
{

    [SerializeField]
    private Text gravity = null;
    private bool alpha = true;

    // Use this for initialization
    void Start()
    {
        Vector3 gravityHere = Physics.gravity;
        gravity.text = "Gravity is: " + -9.81;
    }
    void Update()
    {
        Vector3 gravityHere = Physics.gravity;
        gravity.text = "Gravity is: " + gravityHere.y;
    }




}