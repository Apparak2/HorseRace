using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _speed = 10.2f;
    [SerializeField] private Rigidbody _rbPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rbPlayer.AddForce(0.0f, 0.0f, 300.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
