using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    [SerializeField] Sprite mutedSprite;
    [SerializeField] Sprite nonmutedSprite;
    [SerializeField] Image buttonImage;

    public void Click()
    {
        AudioManager.Instance.Togglemute();
        AudioManager.Instance.PlayButtonClick();
        AudioManager.Instance.Togglemute();

        if (AudioManager.Instance.muted == true)
        {
            buttonImage.sprite = mutedSprite;
        }
        else
        {
            buttonImage.sprite = nonmutedSprite;
        }
    }
}
