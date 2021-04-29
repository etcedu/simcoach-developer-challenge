using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DozerControl : MonoBehaviour
{
    public int driveSpeed;
    public int turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * driveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.forward* driveSpeed * Time.deltaTime * -1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0) * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0) * turnSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "pushable")
        {
            FindObjectOfType<DozerGameManager>().HitDirt();
            Destroy(collision.gameObject);
        }
    }
}
