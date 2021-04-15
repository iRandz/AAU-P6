using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectManager : MonoBehaviour {

    [SerializeField] private ParticleSystem myParticleSystem;
    [SerializeField] private AudioSource particleSound;

    void Awake() {
        //particleSystem = GetComponent<ParticleSystem>();
        StopParticle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartParticle() {
        if (!myParticleSystem.isPlaying) {
            myParticleSystem.Play();
            particleSound.Play();
        }
    }

    public void StopParticle() {
        if (myParticleSystem.isPlaying)
        {
            myParticleSystem.Stop();
            particleSound.Stop();
        }
    }
}
