using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Singleton para acceso global
    public TextMeshProUGUI Puntostexto; // UI de los puntos
    private int puntos = 0; // Contador de puntos

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

    void Start()
    {
        ActualizarPuntos();
    }

    public void SumarPunto()
    {
        puntos++;
        Debug.Log("Punto sumado. Total de puntos: " + puntos); // Debug para ver si realmente se suman
        ActualizarPuntos();
    }

    private void ActualizarPuntos()
    {
        if (Puntostexto != null)
        {
            Puntostexto.text = "Puntos: " + puntos; // Actualiza el texto de la UI
        }
        else
        {
            Debug.LogError("No se ha asignado el UI de puntos en el GameManager.");
        }
    }
}
