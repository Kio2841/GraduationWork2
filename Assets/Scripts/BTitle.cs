using UnityEngine;
using UnityEngine.SceneManagement;  //�u2�v

public class BTitle : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");    //�u3�v
        }
    }
}
