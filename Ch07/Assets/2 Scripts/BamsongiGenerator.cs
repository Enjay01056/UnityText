using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsoniPrefab;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsoniPrefab, transform.position, transform.rotation);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;


            //bamsongi.GetComponent<BamsongiController>().Shoot(new Vector3(0, 500, 2000));
            bamsongi.GetComponent<BamsongiController>().Shoot(worldDir * 2000);
        }
        
    }
}
