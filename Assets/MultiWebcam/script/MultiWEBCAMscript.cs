using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MultiWebcamManager : MonoBehaviour
{


    public GameObject webcamTexturePrefab;

    private string[] nameOfCams;
    private List<WebCamTexture> webcamTextures = new List<WebCamTexture>();


    // Use this for initialization
    void Start()
    {

        int numOfCams = WebCamTexture.devices.Length;
        nameOfCams = new string[numOfCams];
        int counter = 0;
        for (int i = 0; i < numOfCams; i++)
        {
            if (WebCamTexture.devices[i].name != "MMP SDK")
            {
                if (WebCamTexture.devices[i].name != "Leap Motion Controller")
                {
                    nameOfCams[i] = WebCamTexture.devices[i].name;
                    Debug.Log(WebCamTexture.devices[i].name, gameObject);
                    GameObject go = Instantiate(webcamTexturePrefab, new Vector3(i * 1, 0, 0), Quaternion.identity) as GameObject;
   
                    go.transform.parent = gameObject.transform;
                    WebCamTexture webcamTexture = new WebCamTexture();


                    webcamTexture.requestedHeight = 720;
                    webcamTexture.requestedWidth = 1280;
                    webcamTexture.requestedFPS = 60;

                    Debug.Log(webcamTexture.height + " " + webcamTexture.requestedHeight   + " " + webcamTexture.requestedFPS);



                    webcamTexture.deviceName = nameOfCams[i];
                    webcamTextures.Add(webcamTexture);

                    go.transform.GetChild(0).GetComponent<Transform>().gameObject.layer = 12 + counter;
                    go.transform.GetChild(0).GetComponent<Renderer>().material.mainTexture = webcamTextures[counter];
                    webcamTexture.filterMode = FilterMode.Trilinear;
                    webcamTextures[counter].Play();
  //                  webcamTexture.set
                    while (webcamTexture.height < 100)
                    {
                        Debug.Log("--");
                    }

                    Debug.Log("IS THIS THE HEIGHT!" + webcamTexture.height + "IS THIS THE WIDTH" + webcamTexture.width + "THE FPS!!!");


                    counter++;
                }
            }
        }
    }

    


}   