using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && chosenPowerup) {
            Instantiate(chosenPowerup, new Vector3(transform.position.x + 5, transform.position.y + 5, transform.position.z), transform.rotation);
            chosenPowerup = null;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "itemBoxes") {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
