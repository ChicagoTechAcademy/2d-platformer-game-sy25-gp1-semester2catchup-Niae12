using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{

   [SerializeField]private int playerHealth = 3;
   [SerializeField]private TextMeshProUGUI healthtext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthtext.text = "Health: " + playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
