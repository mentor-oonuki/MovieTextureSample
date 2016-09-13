using UnityEngine;
using System.Collections;

public class VideoController : MonoBehaviour {

    private VideoTexture Component;

    void Start () {
        Component = gameObject.GetComponent<VideoTexture>();
	}
	
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            if (Component.isPlaying)
            {
                Component.PauseVideo();
            }
            else
            {
                Component.StartVideo();
            }
        }
	}
}
