using UnityEngine;
using UnityEngine.SceneManagement;  //�u2�v

public class BChamp : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("ChampScene");    //�u3�v
        }
    }
}
