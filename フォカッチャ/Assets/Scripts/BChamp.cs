using UnityEngine;
using UnityEngine.SceneManagement;  //「2」

public class BChamp : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("ChampScene");    //「3」
        }
    }
}
