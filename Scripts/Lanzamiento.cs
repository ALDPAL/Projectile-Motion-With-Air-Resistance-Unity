using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzamiento : MonoBehaviour {

    public GameObject particulas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      if(Input.GetMouseButtonDown(0))
        {
            Instantiate(particulas, transform.position, Quaternion.identity);
        }
	}


}
