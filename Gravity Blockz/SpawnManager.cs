using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject bottom;
    public GameObject top;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBottom());
        StartCoroutine(SpawnTop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnBottom(){
        while(true){
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            UnityEngine.Vector3 pos = new UnityEngine.Vector3(9.47f,-3.2f,0f);
            Instantiate(bottom,pos,bottom.transform.rotation);
        }
    }

    
    IEnumerator SpawnTop(){
        while(true){
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            UnityEngine.Vector3 pos = new UnityEngine.Vector3(8.61f,3.0f,0f);
            Instantiate(top,pos,top.transform.rotation);
        }
    }
}