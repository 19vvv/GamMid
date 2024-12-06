using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioscripy : MonoBehaviour
{public AudioSource sound;
    // Start is called before the first frame update
public void Playsound(){
    sound.Play();
}

public void Stopsound(){
    sound.Stop();
}
}

