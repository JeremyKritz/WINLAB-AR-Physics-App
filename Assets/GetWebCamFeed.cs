using UnityEngine;
using System.Collections.Generic;

public class GetWebCamFeed : MonoBehaviour
{
    public GameObject webcamTexturePrefab;
    private string[] nameOfCams;
    private List<WebCamTexture> webcamTextures = new List<WebCamTexture>();
    // Use this for initialization
    void Start()
    {
        int numCams = WebCamTexture.devices.Length;
        int counter = 0;
        string parent = transform.gameObject.name;
        string cam1 = "USB_Camera";
        string cam2 = "USB_Camera 1";
        for (int i = 0; i < numCams; i++)
        {
            Debug.Log("Cam: " + WebCamTexture.devices[i].name);
            if (parent == "1")
            {
                if (WebCamTexture.devices[i].name == cam1)
                {
                    WebCamTexture webcamTexture = new WebCamTexture();
                    webcamTexture.name = cam1;
                    webcamTexture.deviceName = cam1;
                    webcamTextures.Add(webcamTexture);
                    Renderer renderer = GetComponent<Renderer>();
                    renderer.material.mainTexture = webcamTextures[counter];
                    webcamTextures[counter].Play();
                    counter++;
                }
            }
            else if (parent == "2")
            {
                if (WebCamTexture.devices[i].name == cam2)
                {
                    WebCamTexture webcamTexture = new WebCamTexture();
                    webcamTexture.name = cam2;
                    webcamTexture.deviceName = cam2;
                    webcamTextures.Add(webcamTexture);
                    Renderer renderer = GetComponent<Renderer>();
                    renderer.material.mainTexture = webcamTextures[counter];
                    Debug.Log(webcamTexture.height + " Is the height");

                    Debug.Log(webcamTexture.width + " Is the width");
                    webcamTextures[counter].Play();
                    counter++;

                    Debug.Log(webcamTexture.height + " Is the height");
                    Debug.Log(webcamTexture.width + " Is the width");


                }
            }
        }
    }
    void Update()
    {
    }
}
