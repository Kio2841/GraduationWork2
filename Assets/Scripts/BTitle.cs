using UnityEngine;
using UnityEngine.SceneManagement;  //「2」

public class BTitle : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");    //「3」
        }
    }
}
