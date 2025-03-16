using UnityEngine;

public class proyectil : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo")) // Si el proyectil golpea un obstáculo
        {
            Debug.Log("¡Impacto con obstáculo detectado!"); // Debug para confirmar la colisión

            if (GameManager.Instance != null)
            {
                GameManager.Instance.SumarPunto(); // Sumar punto
            }
            else
            {
                Debug.LogError("GameManager.Instance no está asignado.");
            }

            if (SoundManager.Instance != null)
            {
                SoundManager.Instance.ReproducirSonido(); // Reproducir sonido
            }
            else
            {
                Debug.LogError("SoundManager.Instance no está asignado.");
            }

            Destroy(collision.gameObject); // Destruir obstáculo
            Destroy(gameObject); // Destruir proyectil
        }
    }
}
