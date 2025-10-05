using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Atributos
    private Vector3 fuerzaPorAplicar;
    private float tiempoDesdeUltimaFuerza;
    private float intervaloTiempo;
    private float velocidadLateral;
    private IMovementStrategy strategy;
    private Player player;
    #endregion

    #region Ciclo de vida del script
    void Start()
    {
        fuerzaPorAplicar = new Vector3(0, 0, 0.300f);
        tiempoDesdeUltimaFuerza = 0f;
        intervaloTiempo = 2f;
        velocidadLateral = 2f;
        player = new Player( 5f, 5f );
        //SetStrategy(new MovimientoAcelerado());
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

    public void MovePlayer(float input)
    {
        strategy.Move(transform, velocidadLateral, 0);
    }
    public void SetStrategy(IMovementStrategy strategy)
    {
        this.strategy = strategy;
    }


    #endregion


}

