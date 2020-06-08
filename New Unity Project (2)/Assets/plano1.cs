using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plano1 : MonoBehaviour {
    public GameObject cubo;
    public GameObject ob;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(cubo.transform.position.z > this.transform.position.z+40)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+180);
            

            Instantiate(ob, new Vector3(Random.Range(-6, 7), 2.1f, Random.Range(transform.position.z - 30, transform.position.z + 30)), Quaternion.identity);
            Instantiate(ob, new Vector3(Random.Range(-6, 7), 2.1f, Random.Range(transform.position.z - 30, transform.position.z + 30)), Quaternion.identity);
            Instantiate(ob, new Vector3(Random.Range(-6, 7), 2.1f, Random.Range(transform.position.z - 30, transform.position.z + 30)), Quaternion.identity);
        }
    }
    }

	

