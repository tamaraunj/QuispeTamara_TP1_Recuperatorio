using System.Collections;
using UnityEngine;

public class PowerUpBehaviour : MonoBehaviour
{
    [SerializeField] private float duration = 5f;
    [SerializeField] private float cooldown = 10f;
    private PlayerMovement player;
    private bool isAvailable = true;
    private bool initialWaitFinished = false;
    private void Start()
    {
        player = GetComponent<PlayerMovement>();
        StartCoroutine(ShowInitialAvailability());

    }
    private IEnumerator ShowInitialAvailability()
    {
        yield return new WaitForSeconds(5f);
        initialWaitFinished = true;
        Debug.Log("<color=green>POWER-UP DISPONIBLE. Presiona P para duplicar tu velocidad.</color>");

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Activate();
        }
    }
    public void Activate()
    {
        if (!initialWaitFinished)
        {
            Debug.Log("<color=red>POWER-UP TODAVÍA NO DISPONIBLE. Espera 5 segundos.</color>");
            return;
        }
        if (!isAvailable || player == null)
        {
            if (!isAvailable)
            {
                Debug.Log("<color=red>POWER-UP NO DISPONIBLE. Espera a que termine la recarga.</color>");
            }
            return;
        }

        StartCoroutine(PowerUpRoutine());
    }

    private IEnumerator PowerUpRoutine()
    {
        isAvailable = false;

        player.ActivatePowerUp();
        Debug.Log("<color=yellow>¡POWER-UP ACTIVADO! Velocidad duplicada.</color>");

        yield return new WaitForSeconds(duration);

        player.ResetPowerUp();
        Debug.Log("<color=cyan>POWER-UP FINALIZADO. Velocidad normal restaurada.</color>");
        Debug.Log("<color=red>RECARGA INICIADA. Espera 10 segundos.</color>");

        yield return new WaitForSeconds(cooldown);

        isAvailable = true;
        Debug.Log("<color=green>POWER-UP DISPONIBLE. Presiona P para activarlo.</color>");
    }
}
