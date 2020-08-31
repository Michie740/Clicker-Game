using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSounds : MonoBehaviour
{
    //hahaha getcool mansae mostofme onebday twobday
    public AudioSource HaHaHa;
    public AudioSource getCool;
    public AudioSource Mansae;
    public AudioSource mostOfMe;
    public AudioSource oneBDay;
    public AudioSource twoBDay;
    public int generateTone;

    public void dinoSaur(){
        generateTone = UnityEngine.Random.Range(1,3);
        if (generateTone == 1)
        {
            HaHaHa.Play();
        }
        else
        {
            mostOfMe.Play();
        }
    }

    public void Hamster(){
        getCool.Play();
    }

    public void svtOne(){
        generateTone = UnityEngine.Random.Range(1, 3);
        if (generateTone == 1)
        {
            oneBDay.Play();
        }
        else
        {
            twoBDay.Play();
        }
    }

    public void svtTwo(){
        Mansae.Play();
    }





}
