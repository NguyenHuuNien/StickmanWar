using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Look : MonoBehaviour
{
    
    public static Look instance;
    public static bool isLook=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isLook);
        if(Input.GetKeyDown(KeyCode.Space)){
            isLook = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag.Equals("Enemy")){
            isLook = true;
            Debug.Log("HHH");
        }
    }
}