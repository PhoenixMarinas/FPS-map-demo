using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("t"))
        {
            GameReset();
        }
    }

    public void GameReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
