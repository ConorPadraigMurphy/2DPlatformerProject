using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] private AudioSource coinPickup;
    [SerializeField] private AudioSource buttonClick;
    [SerializeField] private AudioSource enemyKill;
    [SerializeField] private AudioSource powerupPickup;
    [SerializeField] private AudioSource springBoost;
    [SerializeField] private AudioSource keyPickup;
    [SerializeField] private AudioSource hurt;
    public static AudioManager Instance;

    public bool muted;

    public void Togglemute()
    {
        muted = !muted;
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void PlaycoinPickup()
    {
        if (muted == false)
        {
            coinPickup.Play();
        }
    }

    public void PlayButtonClick()
    {
        if (muted == false)
        {
            buttonClick.Play();
        }
    }

    public void PlayEnemyKill()
    {
        if (muted == false)
        {
            enemyKill.Play();
        }
    }

    public void PlayPowerUpPickup()
    {
        if (muted == false)
        {
            powerupPickup.Play();
        }
    }

    public void SpringBoost()
    {
        if (muted == false)
        {
            springBoost.Play();
        }
    }

    public void KeyPickup()
    {
        if (muted == false)
        {
            keyPickup.Play();
        }
    }

    public void Hurt()
    {
        if (muted == false)
        {
            hurt.Play();
        }
    }
}

