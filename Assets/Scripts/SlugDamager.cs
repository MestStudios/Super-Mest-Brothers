using UnityEngine;
using System.Collections;

public class SlugDamager : MonoBehaviour {

    public void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            // Matar PJ
        }
    }
}
