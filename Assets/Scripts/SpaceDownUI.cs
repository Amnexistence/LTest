using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class SpaceDownUI : MonoBehaviour
{
	private RawImage _ri;
    // Start is called before the first frame update
    void Start()
    {
      _ri = GetComponent<RawImage>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
		{
		_ri.color = new Color(0.5f, 0.5f, 0.5f, 1);
		}
		else
		{
		_ri.color = new Color(1f, 1f, 1f, 1);	
		}
    }
}
