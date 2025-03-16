using System.Collections;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public float velocidadMovimiento = 5f; 
    public float velocidadRotacion = 100f; 
    public Transform torreta; 

    void Update()
    {
        // Movimiento hacia adelante y atrás
        float movimiento = Input.GetAxis("Vertical") * velocidadMovimiento * Time.deltaTime;
        transform.Translate(Vector3.forward * movimiento);

        // Rotación del tanque
        float rotacion = Input.GetAxis("Horizontal") * velocidadRotacion * Time.deltaTime;
        transform.Rotate(Vector3.up * rotacion);

        // Rotación de la torreta con el ratón
        if (torreta != null)
        {
            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Vector3 lookDir = hit.point - torreta.position;
                lookDir.y = 0; // Mantener la torreta en el mismo plano
                torreta.forward = lookDir;
            }
        }
    }
}
