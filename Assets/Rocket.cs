using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody _rigidBody;
    AudioSource _audioSource;

	// Use this for initialization
	void Start () {
        _rigidBody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space)) //Able to thrust while rotating
        {
            _rigidBody.AddRelativeForce(Vector3.up * 7);
            if(!_audioSource.isPlaying) //Prevent layered sounds
                _audioSource.Play();
        }
        else
        {
            _audioSource.Stop();
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward );
        }
    }
}
