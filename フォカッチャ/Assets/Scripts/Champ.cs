using UnityEngine;
using UnityEngine.SceneManagement;  //�u2�v

public class Champ : MonoBehaviour
{

    void Update()
    {
         if (Input.GetKey(KeyCode.Return))
            {
            SceneManager.LoadScene("ChampScene");    //�u3�v
        }
    }
}