using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        //scoreText.text = $"position : {Mathf.Floor(transformPlayer.position.z).ToString()}";
        scoreText.text = $"Score : {transformPlayer.position.z.ToString("0")}";
    }
}
