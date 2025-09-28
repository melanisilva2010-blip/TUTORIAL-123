using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    private Vector3 fuerzaPorAplicar;
    private float tiempoDesdeUltimaFuerza;
    private float intervaloTiempo;
    private float velocidadLateral;
    private IMovementStrategy strategy;
    #endregion

    #region Ciclo de vida del script
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 0.5f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        velocidadLateral = 2f;
        SetStrategy(new MovimientoAcelerado());
    }

    private void Update()
    {
        strategy.Move(transform,velocidadLateral);
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

    #region 
    public void SetStrategy(IMovementStrategy strategy)
    {
        this.strategy = strategy;
    }


    #endregion


}

