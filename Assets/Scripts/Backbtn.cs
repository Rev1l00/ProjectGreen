using UnityEngine;
using UnityEngine.SceneManagement;

public class Backbtn : MonoBehaviour
{
    public void backbtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
