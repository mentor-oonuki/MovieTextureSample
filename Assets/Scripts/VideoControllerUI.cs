using UnityEngine;
using System.Collections;

public class VideoControllerUI : MonoBehaviour {

    private VideoTextureUI Component;

    void Start () {
        Component = gameObject.GetComponent<VideoTextureUI>();
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
