using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public Text dimondText;
    private int dimondCount = 0;
    public int requireDimond = 4;
    public int kill = 0;
    public int reqkill = 2;
    public Material geamMaterial; 
    public AudioClip collisionSound1;
    public AudioClip collectSound; 
    private AudioSource audioSource;
    private int collisionCount = 0;
    public Light[] pointLights; 
    public AudioSource newAudioSource; 

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        foreach (Light light in pointLights)
        {
            if (light != null)
            {
                light.enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("dimond"))
        {
            dimondCount++;
            dimondText.text = "Dimond: " + dimondCount.ToString();

            audioSource.PlayOneShot(collectSound);

            Destroy(other.gameObject);

            if (dimondCount >= requireDimond)
            {
                SceneManager.LoadScene(1);
            }
        }

        if (other.CompareTag("obstacle"))
        {
            kill++;
            Destroy(other.gameObject);

            if (kill >= reqkill)
            {
                SceneManager.LoadScene(2);
            }
        }

        if (other.gameObject.CompareTag("obstacle"))
        {
            collisionCount++;

            if (collisionCount == 1)
            {
                if (newAudioSource != null)
                {
                    newAudioSource.Stop();
                }

                audioSource.clip = collisionSound1;
                audioSource.loop = true;
                audioSource.Play();

                foreach (Light light in pointLights)
                {
                    if (light != null)
                    {
                        light.enabled = true;
                    }
                }
            }

            geamMaterial.color = Color.red;
        }
    }
}

