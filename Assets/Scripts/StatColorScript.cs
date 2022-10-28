using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatColorScript : MonoBehaviour
{
	public Color color;
	private MeshRenderer _mr;
	
    // Start is called before the first frame update
    void Start()
    {
	_mr = GetComponent<MeshRenderer>();
	_mr.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

