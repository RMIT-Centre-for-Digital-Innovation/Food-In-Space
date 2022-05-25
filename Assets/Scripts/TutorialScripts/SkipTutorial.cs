using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipTutorial : MonoBehaviour
{
    [SerializeField] private GameObject taskActivator;

    public void Skip()
    {
        taskActivator.SetActive(false);
        this.GetComponent<AudioSource>().Play();
        GameObject.FindGameObjectWithTag("VR Origin").transform.position = Vector3.zero;
        GameObject.FindGameObjectWithTag("VR Origin").transform.rotation = Quaternion.Euler(0, 180, 0);


    }
    public void DeactivateTutorial()
    {
        taskActivator.SetActive(false);
        this.GetComponent<AudioSource>().Play();
    }
}
