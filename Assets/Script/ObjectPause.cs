using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Rigidbodyの速度を保存しておくクラス
/// </summary>
public class Rigidbody2DVelocity
{
    public Vector3 velocity;
    public float angularVeloccity;
    public Rigidbody2DVelocity(Rigidbody2D rigidbody)
    {
        velocity = rigidbody.velocity;
        angularVeloccity = rigidbody.angularVelocity;
    }
}

public class ObjectPause : MonoBehaviour {

	// Use this for initialization
	void Start () { 
		
	}

    public bool pausing;

    public GameObject[] ignoreGameObjects;

    bool prevPausing;

    Rigidbody2DVelocity[] rigidbodyVelocities;

    Rigidbody2D[] pausingRigidbodies;

    MonoBehaviour[] pausingMonobehaviours;

    // Update is called once per frame
    void Update()
    {
        if(prevPausing != pausing)
        {
            if (pausing)
            {
                Pause();
            }
            else
            {
                Resume();
            }

            prevPausing = pausing;
        }
    }

    void Pause()
    {
        Predicate<Rigidbody2D> rigidbodyPredicate =
            obj => !obj.IsSleeping()
            &&
            Array.FindIndex(ignoreGameObjects, gameObject => gameObject == obj.gameObject) < 0;

        pausingRigidbodies = Array.FindAll(transform.GetComponentsInChildren<Rigidbody2D>(), rigidbodyPredicate);
        rigidbodyVelocities = new Rigidbody2DVelocity[pausingRigidbodies.Length];
        var ArrayLength = pausingRigidbodies.Length;

        for(int i = 0; i < ArrayLength; i++)
        {
            rigidbodyVelocities[i] = new Rigidbody2DVelocity(pausingRigidbodies[i]);
            pausingRigidbodies[i].Sleep();
        }

        Predicate<MonoBehaviour> monoBehaviourPredicate =
            obj => obj.enabled &&
            obj != this &&
            Array.FindIndex(ignoreGameObjects, gameObject => gameObject == obj.gameObject) < 0;

        pausingMonobehaviours = Array.FindAll(transform.GetComponentsInChildren<MonoBehaviour>(), monoBehaviourPredicate);
        foreach(var monoBehaviour in pausingMonobehaviours)
        {
            monoBehaviour.enabled = false;
        }
    }

    void Resume()
    {

    }
}

