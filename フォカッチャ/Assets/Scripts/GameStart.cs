using UnityEngine;
using UnityEngine.SceneManagement;  //�u2�v

public class GameStart : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("SampleScene");    //�u3�v
        }
    }
}
