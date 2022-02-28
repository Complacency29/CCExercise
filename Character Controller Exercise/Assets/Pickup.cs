using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] GameObject hintTextObj;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < 3f)
        {
            hintTextObj.SetActive(true);
            if(Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("You picked up the McGuffin. Who told you that you could do that? That McGuffin belongs in a  museum!");
                Destroy(gameObject);
            }
        }
        else
        {
            hintTextObj.SetActive(false);
        }
    }
}
