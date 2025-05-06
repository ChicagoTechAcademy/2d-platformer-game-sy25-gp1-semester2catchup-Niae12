using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{   

   [SerializeField]private int playerHealth = 3;
   [SerializeField]private TextMeshProUGUI healthtext;
   [SerializeField]private PlayerController player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      UpdateHealthText();
    }

  public void loseHealth(int healthtolose) 
  {
    playerHealth = playerHealth - healthtolose;
      UpdateHealthText();
      HealthCheck();
  }
  public void gainHealth(int healthtoGain) 
  {
    playerHealth = playerHealth + healthtoGain;
          UpdateHealthText();
  }

  private void UpdateHealthText()
  {
    healthtext.text = "Health: " + playerHealth.ToString();
  }

private void HealthCheck()
{ 
  if(playerHealth <= 0)
  {
    player.PlayerDeath();
    healthtext.text = "You Died" ;
  }
}
}
