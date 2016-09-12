using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    public float Speed;
    protected float v;

	void Start () {
        v = 0f;
	}
	
	void Update () {
        v += Time.deltaTime * Speed;
        gameObject.transform.rotation = Quaternion.Euler(v, v, v);
	}
}
