using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class key : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] AudioSource soundDoor;
    public int sh = 0;

    private void Awake()
    {
        door.SetActive(true);
    }

    private void OpenDoor()
    {
        door.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("key"))
        {
            if (sh == 0)
            {
                soundDoor.Play();
                OpenDoor();
                sh = sh + 1;
            }
        }
    }
}
