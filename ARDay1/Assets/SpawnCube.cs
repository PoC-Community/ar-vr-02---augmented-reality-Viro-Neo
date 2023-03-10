using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnCube : MonoBehaviour
{
    public GameObject cube;
    public ARRaycastManager raycastMan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
            List<ARRaycastHit> touches = new List<ARRaycastHit>();
            raycastMan.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);
            if (touches.Count > 0)
                GameObject.Instantiate(cube, touches[0].pose.position, touches[0].pose.rotation);
        }
    }
}
