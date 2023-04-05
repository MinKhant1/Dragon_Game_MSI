using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using NaughtyCharacter;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Asset Fields;
    [SerializeField] ParticleSystem _breatheFireParticle;
    [SerializeField] PlayerInputComponent _playerInput;
    [SerializeField] Animator _anim;

 
    

    bool _breatheFireInput;
    
    

   
    void Start()
    {
     
       
    }

    // Update is called once per frame
    void Update()
    {
        OnPlayerUpdate();
    }

    void OnPlayerUpdate()
    {
       
        HandleBreatheFire();

      
    }

    void HandleBreatheFire()
    {
        _breatheFireInput = _playerInput.FireBreatheInput;
        _anim.SetBool("Breathing", _breatheFireInput);
        //if (_breatheFireInput)
        //{

        //    if (!_breatheFireParticle.isPlaying)
        //    {
        //        _anim.SetBool("Breathing", true);
        //        _breatheFireParticle.Play();
        //    }



        //}
        //else
        //{
        //    if (_breatheFireParticle.isPlaying)
        //    {
        //        _anim.SetBool("Breathing", false);
        //        _breatheFireParticle.Stop();

        //    }

        //}
    }
    public void PlayFireBreathingParticle()
    {
       
            if (!_breatheFireParticle.isPlaying)
            {
              
                _breatheFireParticle.Play();
            }
        

    }
    public void StopFireBreathingParticle()
    {
        if (_breatheFireParticle.isPlaying)
        {
        
            _breatheFireParticle.Stop();

        }

    }


}
