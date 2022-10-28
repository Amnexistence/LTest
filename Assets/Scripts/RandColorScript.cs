using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandColorScript : MonoBehaviour
{
	
	private MeshRenderer _mr;
	private int yellowCounter;
	private int redCounter;
	private int orangeCounter;
	private int currentColor;
	
	List<Color> PColors = new List<Color>()
     {
         new Color(1f, 0f, 0f, 1),
         new Color(1f, 0.5f, 0f, 1),
         new Color(1f, 0.92f, 0.016f, 1)
     };
	 public Transform[] pieces;

	
    // Start is called before the first frame update
    void Start()
    {  
	
	pieces = new Transform[gameObject.transform.childCount];
	 
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown("space"))
		{
			
		 for(int i = 0; i < gameObject.transform.childCount; i++) 
		{
		currentColor = Random.Range(0, PColors.Count);
		pieces[i] = gameObject.transform.GetChild(i);	
			
		_mr = pieces[i].GetComponentInChildren(typeof(MeshRenderer)) as MeshRenderer;
		_mr.material.color = PColors[currentColor];	
		
		if (PColors[currentColor].g == 0f)
		{
		redCounter += 1;	
		}
		else if (PColors[currentColor].g == 0.5f)
		{
		orangeCounter += 1;
		}
		else if (PColors[currentColor].g == 0.92f)
		{
		yellowCounter += 1;	
		}
		
		if (redCounter == 5)
		{
		for(int j = 0; j < PColors.Count; j++) 
		{
		if (PColors[j].g == 0f)
		{
		PColors.RemoveAt(j);
		redCounter = 0;
		}
		} 
		}
		
		if (orangeCounter == 5)
		{
		for(int j = 0; j < PColors.Count; j++) 
		{
		if (PColors[j].g == 0.5f)
		{
		PColors.RemoveAt(j);
		orangeCounter = 0;
		}
		} 
		}
		
		if (yellowCounter == 5)
		{
		for(int j = 0; j < PColors.Count; j++) 
		{
		if (PColors[j].g == 0.92f)
		{
		PColors.RemoveAt(j);
		yellowCounter = 0;
		}
		} 
		}
		
		}	
		
		PColors = new List<Color>()
     {
         new Color(1f, 0f, 0f, 1),
         new Color(1f, 0.5f, 0f, 1),
         new Color(1f, 0.92f, 0.016f, 1)
     };
		
		}
        
    }
}
