using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
	[HideInInspector]
	public int WinCounter = 0;
	private ParticleSystem _ps;
	
    // Start is called before the first frame update
    void Start()
    {
    _ps = GetComponent<ParticleSystem>();    
    }

    // Update is called once per frame
    void Update()
    {
    if (WinCounter >= 15) 
	{
	 for(int i = 0; i < gameObject.transform.childCount; i++) 
	 {
	 Destroy(gameObject.transform.GetChild(i));
	 }
	_ps.Play(true);
	WinCounter = -1;
	
	}
	
	if ((_ps.isPlaying == false) && (WinCounter == -1))
	{
	Application.Quit();	
	}
	
    }
}
