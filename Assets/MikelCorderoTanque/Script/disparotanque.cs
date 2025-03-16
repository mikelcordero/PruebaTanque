using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparotanque : MonoBehaviour
{
    public GameObject proyectilPrefab; 
    public Transform puntoDisparo; 
    public float velocidadProyectil = 20f; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Disparar();
        }
    }

    void Disparar()
    {
        
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDisparo.position, puntoDisparo.rotation);
        
        // Le añadimos velocidad al proyectil
        Rigidbody rb = proyectil.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = puntoDisparo.forward * velocidadProyectil;
        }

        StartCoroutine(DestruirProyectil(proyectil));
    }

    IEnumerator DestruirProyectil(GameObject proyectil)
    {
        yield return new WaitForSeconds(3f);
        Destroy(proyectil);
    }
}