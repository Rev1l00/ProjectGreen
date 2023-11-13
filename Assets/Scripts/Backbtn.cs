using UnityEngine;
using UnityEngine.SceneManagement;

public class Backbtn : MonoBehaviour
{
    // Definerer en funksjon som sender brukeren til scenen som er før den scenen som er i bruk
    public void backbtn()
    {
        SceneManager.LoadScene(1);   // Laster Scenen som er før den som er i bruk
    }
}
