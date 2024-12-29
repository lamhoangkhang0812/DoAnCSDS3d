using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
   public void PlayGame()
   {
    SceneManager.LoadScene("SampleScene");
   } 
   public void QuitGame()
   {
    Application.Quit();
   }
    public void VeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}