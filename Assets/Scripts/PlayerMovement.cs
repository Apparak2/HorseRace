using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _speed = 10.2f;
    [SerializeField] private Rigidbody _rbPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //AddForce stabilise déjà avec Time.FixedDeltaTime
            _rbPlayer.AddForce(0.0f, 0.0f, _speed);

        if (Input.GetKey(KeyCode.Q))
        {
            _rbPlayer.AddForce(_speed*-1, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rbPlayer.AddForce(_speed, 0.0f, 0.0f);
        }
    }
}
