using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEvent : MonoBehaviour
{   
    [SerializeField] private int targetscore;
    [SerializeField] ScoreText ST;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponentInChildren<BoxCollider>().gameObject.tag == "Blade")
        {
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            collision.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
            collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            /*Debug.Log("������");*/

            if (collision.gameObject.GetComponentInChildren<BoxCollider>().gameObject.tag == "Blade")
            {
                ST.getScore += targetscore;
                ST.UpdateScore();
            }
            Debug.Log(ST.getScore);
        }

        else
            Debug.Log("�ĳ´�");
    }

}