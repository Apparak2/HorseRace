using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _forwardForce = 10.0f;
    [SerializeField] private float _sidewaysForce = 10.0f;
    [SerializeField] private Rigidbody _rbPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //AddForce stabilise déjà avec Time.FixedDeltaTime
            _rbPlayer.AddForce(0.0f, 0.0f, _forwardForce);

        if (Input.GetKey(KeyCode.Q))
        {
            _rbPlayer.AddForce(-_sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rbPlayer.AddForce(_sidewaysForce, 0.0f, 0.0f, ForceMode.VelocityChange);
        }
    }
}
