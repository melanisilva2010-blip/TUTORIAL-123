using UnityEngine;

public class Player
{
    public float velocity;
    public float acceleration;
    public float maxSpeed;    
    private float v1;
    private float v2;

    public Player(float v1, float v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public Player(float velocity, float acceleration, float maxSpeed)
    {
        this.velocity = velocity;
        this.acceleration = acceleration;
        this.maxSpeed = maxSpeed;
    }
}
