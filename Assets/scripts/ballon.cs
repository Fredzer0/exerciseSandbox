using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon : MonoBehaviour
{

    [SerializeField] GameObject effect;

    void Update()
    {
        
        

    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (LayerMask.LayerToName(collision.gameObject.layer) == "Default")
        {
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }
}
