using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoredPiecesCounter : MonoBehaviour
{
	
	private MeshRenderer _mr;
	private CapsuleCollider _cc;
	
    // Start is called before the first frame update
    void Start()
    {
     _mr = GetComponent<MeshRenderer>();
	 _cc = GetComponent<CapsuleCollider>();
	 
    }


    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown("space"))
		{
		transform.parent.GetComponent<WinScript>().WinCounter = 0;
		GetComponent<CapsuleCollider>().enabled = false;
		}

	if (Input.GetKeyUp("space"))
		{
		GetComponent<CapsuleCollider>().enabled = true;
		} 
	}
	
	void OnTriggerEnter(Collider other)
    {
	if (other.gameObject.GetComponent<MeshRenderer>().material.color == _mr.material.color)
	 {
	transform.parent.GetComponent<WinScript>().WinCounter += 1;
     }	
	}
	
	void OnTriggerExit(Collider other)
    {
	if (other.gameObject.GetComponent<MeshRenderer>().material.color == _mr.material.color)
	 {
	transform.parent.GetComponent<WinScript>().WinCounter -= 1;
     }	
	}
	
	
}
