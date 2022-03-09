using GoogleARCore;
using Mapbox.Unity.Map;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetLocation : MonoBehaviour
{
    public Text msg;
    public GameObject map;
    public Camera cam;
    public GameObject place;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                //map.GetComponent<AbstractMap>().Options.locationOptions.latitudeLongitude;
                //msg.text = touch.position.ToString();
                Instantiate(place, place.transform, true);
                msg.text = Input.location.lastData.latitude + ", " + Input.location.lastData.longitude;
                msg.text += " " + cam.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, cam.nearClipPlane)).ToString();
            }
            // Instantiate prefab at the hit pose.
            Instantiate(place, place.transform.position, place.transform.rotation);
            
        }
    }
}
