using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto : MonoBehaviour {

    public GameObject cubo;
	
	// Update is called once per frame
	void Update () {
		if (cubo.transform.position.z > transform.position.z + 30)
        {
            Destroy(this);
        }
	}
}
