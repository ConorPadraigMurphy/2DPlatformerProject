using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D enterPortal)
    {
        if (enterPortal.gameObject.tag == "Player")
        {
            Debug.Log("portal");
            SceneManager.LoadSceneAsync(1);

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
