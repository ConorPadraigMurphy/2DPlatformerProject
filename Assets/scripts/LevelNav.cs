using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelNav : MonoBehaviour
{
    [SerializeField] public string gotoscene;
    public void LoadScene()
    {
        SceneManager.LoadScene(gotoscene);
    }
}
