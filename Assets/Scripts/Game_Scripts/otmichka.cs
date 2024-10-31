using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class otmichka : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] AudioSource grabSound;
    public int sh = 0; 

    private void Awake()
    {
        door.SetActive(true);
    }
    private void minusDoor()
    {
        door.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("otmichka"))
        {
            if (sh == 0)
            {
                sh = sh + 1;
                grabSound.Play();
                minusDoor();
            }
        }
    }
}