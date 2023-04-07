using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelNav : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    [SerializeField] public string gotoscene;
    public void LoadScene()
    {
        SceneManager.LoadScene(gotoscene);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
