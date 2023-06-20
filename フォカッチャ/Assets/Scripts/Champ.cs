using UnityEngine;
using UnityEngine.SceneManagement;  //「2」

public class Champ : MonoBehaviour
{

    void Update()
    {
         if (Input.GetKey(KeyCode.Return))
            {
            SceneManager.LoadScene("ChampScene");    //「3」
        }
    }
}