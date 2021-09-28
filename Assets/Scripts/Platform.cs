using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public GameObject heart;

    // Start is called before the first frame update
    void Start()
    {

        int randHeart = Random.Range(0, 10);

        Vector3 heartPos = transform.position;
        heartPos.y += 1f;

        if(randHeart < 1)
        {
            GameObject heartInstance = Instantiate(heart, heartPos, heart.transform.rotation);

            heartInstance.transform.SetParent(gameObject.transform);
        }
        else
        {

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("Fall", 0.2f);
        }
    }

    void Fall()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        Destroy(gameObject, 1f);
    }
}
