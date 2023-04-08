using UnityEngine;
using UnityEngine.SceneManagement;
public class Portal : MonoBehaviour
{
    [SerializeField] public int gotoscene;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D enterPortal)
    {
        if (enterPortal.gameObject.tag == "Player")
        {
            Debug.Log("portal");
            SceneManager.LoadSceneAsync(gotoscene);
        }
    }
}
