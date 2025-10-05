using UnityEngine;

public class CamaraSeguirJugador : MonoBehaviour
{
    private Vector3 offSet;
    private PlayerMovement playerMovement;

    void Start()
    {
        offSet = new Vector3(0, 1, -5);
        playerMovement = FindObjectOfType<PlayerMovement>(); 
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        gameObject.transform.position = playerMovement.transform.position = offSet;
    }
}
