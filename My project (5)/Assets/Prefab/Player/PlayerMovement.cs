using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    private Vector3 fuerzaPorAplicar;
    private float tiempoDesdeUltimaFuerza;
    private float intervaloTiempo;
    #endregion

    #region Ciclo de vida del script
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 0.5f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
    }

    private void FixedUpdate()
    {
        tiempoDesdeUltimaFuerza += Time.fixedDeltaTime;

        if (tiempoDesdeUltimaFuerza >= intervaloTiempo)
        {
            GetComponent<Rigidbody>().AddForce(fuerzaPorAplicar);
            tiempoDesdeUltimaFuerza = 0f;
        }
    }
    #endregion
}

