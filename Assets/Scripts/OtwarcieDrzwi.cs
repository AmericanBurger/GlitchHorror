using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtwarcieDrzwi : MonoBehaviour {

	void Start() {
		
	}
	
	void Update() {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Drzwi")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Drzwi temp = other.gameObject.GetComponent<Drzwi>();
                temp.otwarte = !temp.otwarte;
            }
        }
    }
}
