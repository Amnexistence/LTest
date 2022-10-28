using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;

class TouchScript : MonoBehaviour
{

	[SerializeField]
	private bool Selected = false;
	private bool mouseOut = true;
	private float Speed = 10f;
	private Rigidbody _rb;
	private float PlayerMaxSpeed = 0f;

	
void OnTriggerEnter(Collider other)
    {
	if ((other.gameObject.tag) == "Ray" )
	 {
	 Selected = true;
	mouseOut = false;
     }	
	}
	
	void OnTriggerExit(Collider other)
    {
	if ((other.gameObject.tag) == "Ray" )
	 {
	 mouseOut = true;
     }	
	}


void Start()
    {
        _rb = GetComponent<Rigidbody>();
	}

    void Update()
    {
	   
 if ((Input.GetMouseButton(0)) && (Selected == true))
 {
_rb.velocity = new Vector3(Input.GetAxis("Mouse X") * Speed, Input.GetAxis("Mouse Y") * Speed, _rb.velocity.z);	  
 }
 
 if (!(Input.GetMouseButtonDown(0)) && (mouseOut == true))
	{
	Selected = false; 
	}   
	
	if ((mouseOut == true))
	{
	 if (_rb.velocity.magnitude > PlayerMaxSpeed)   //Если скорость объекта превышает максимальную скорость
        {
            _rb.velocity = _rb.velocity.normalized * PlayerMaxSpeed;  //Задать скорость на уровне максимальной
        }
	}
		
	
    }
}
