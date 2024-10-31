using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorBilliard : MonoBehaviour
{
    [SerializeField] GameObject doorDestroyed;
    [SerializeField] AudioSource Hit;
    [SerializeField] AudioSource knockingOut;
    int damage = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("axe"))
        {
            damage += 1;
            if (damage <= 4)
            {
                Hit.Play();
            }
            if (damage >= 5) 
            {
                doorDestroyed.SetActive(true);
                knockingOut.Play();
                Destroy(this.gameObject);
            }
        }
    }
}
