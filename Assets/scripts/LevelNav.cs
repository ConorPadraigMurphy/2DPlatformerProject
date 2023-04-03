using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelNav : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void LoadScene()
    {

        SceneManager.LoadScene("2ndPlatformerScene");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
