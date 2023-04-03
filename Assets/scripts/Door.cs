using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animate;
    private void Awake()
    {
        animate = GetComponent<Animator>();
    }

    public void Open()
    {
        animate.SetTrigger(name: "OpenDoor");
    }
}
