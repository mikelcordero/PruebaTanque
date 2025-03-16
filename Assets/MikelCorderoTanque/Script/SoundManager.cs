using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance; // Singleton para acceso global
    public AudioSource explosionSound; // Sonido de destrucción de obstáculos

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // Evita duplicados
        }
    }

    public void ReproducirSonido()
    {
        if (explosionSound != null)
        {
            explosionSound.Play();
            Debug.Log("Sonido de explosión reproducido."); // Debug para ver si se ejecuta
        }
        else
        {
            Debug.LogError("No hay AudioSource asignado al SoundManager.");
        }
    }
}

