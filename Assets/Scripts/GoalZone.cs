using UnityEngine;

public class GoalZone : MonoBehaviour
{
    private bool hasWon = false;

    private void OnTriggerEnter(Collider other)
    {
        if (hasWon)
        {
            return;
        }
        if (other.CompareTag("Player"))
        {
            Debug.Log("Llegaste a la meta. Todavía tenés que entregar el objeto.");
            return;
        }
        if (other.CompareTag("Item"))
        {
            if (other.transform.parent != null)
            {
                Debug.Log("Debes soltar el objeto dentro de la meta.");
                return;
            }

            hasWon = true;

            Debug.Log("<color=green>¡VICTORIA! Entregaste el objeto correctamente.</color>");

            Renderer zoneRenderer = GetComponent<Renderer>();

            if (zoneRenderer != null)
            {
                zoneRenderer.material.color = Color.yellow;
            }
        }
    }
}
