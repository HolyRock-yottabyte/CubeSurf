using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{

    bool isCollected;
    int index;
    public Collector collector;

    // Start is called before the first frame update
    void Start()
    {
        isCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isCollected == true)
        {
            if(transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    private void OnTrigerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            collector.decreaseHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("Temasta");
        }
        Debug.Log("Temasta");

    }



    public bool GetisCollected()
    {
        return isCollected;
    }

    public void MakeCollected()
    {
        isCollected = true;
    }

    public void ConfigIndex(int index)
    {
        this.index = index;
    }
}
