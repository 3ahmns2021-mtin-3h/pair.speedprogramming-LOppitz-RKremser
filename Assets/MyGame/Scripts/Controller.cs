using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public GameObject blueFlowers;

    private int spacePressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnFlowers();
            spacePressed++;
        }

        //if (spacePressed == 10)
        {
        //    spawnFlowers();
        }


        Debug.Log("Spawn " + spacePressed + " Flowers");

        void spawnFlowers()
        {
            var clones = Instantiate(blueFlowers);
            clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
            clones.GetComponent<Transform>().localRotation = Quaternion.identity;
            clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
