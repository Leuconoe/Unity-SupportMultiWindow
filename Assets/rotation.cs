using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    private Vector3 rot;
	// Use this for initialization
	void Start () {
        rot = new Vector3();
        rot.x = Random.Range(-2, 2);
        rot.y = Random.Range(-2, 2);
        rot.z = Random.Range(-2, 2);

    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(rot, Time.deltaTime * 100);
    }
}
