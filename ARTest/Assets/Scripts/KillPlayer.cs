using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {
     Rigidbody rb;

     void Awake() {
          rb = GetComponent<Rigidbody>();
     }

     void OnTrackingFound() {
          rb.useGravity = true;
     }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Lava")
        {
            Destroy(gameObject);
            GameController.EndGame();
        }
    }

    public void Update() {

    }
}
