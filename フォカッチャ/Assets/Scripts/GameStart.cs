using UnityEngine;
using UnityEngine.SceneManagement;  //「2」

public class GameStart : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("SampleScene");    //「3」
        }
    }
}
