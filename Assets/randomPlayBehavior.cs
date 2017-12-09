using System;
using UnityEngine;


public class randomPlayBehavior : MonoBehaviour {

    private ParticleSystem _geyser;
    private DateTime _lastExplosion;
    // Use this for initialization
    void Start () 
    {
        _lastExplosion = DateTime.UtcNow;
        _geyser = GetComponent<ParticleSystem>();
        _geyser.Stop(true);
    }
	
	// Update is called once per frame
	void Update () 
    {
        var timeDelta = (DateTime.UtcNow - _lastExplosion).TotalSeconds;


        int timeInterval = UnityEngine.Random.Range(20, 40);

        if (timeDelta > timeInterval) 
        {

            _geyser.Play(true);
            _lastExplosion = DateTime.UtcNow;
        }
        
	}
}
