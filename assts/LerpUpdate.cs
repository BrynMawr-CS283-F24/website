using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpUpdate : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float duration = 3.0F;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            timer = 0;
        }

        if (timer < duration) {

            timer += Time.deltaTime;
            float u = timer / duration;
            transform.position = Vector3.Lerp(start.position, end.position, u);
            transform.rotation = Quaternion.Slerp(start.rotation, end.rotation, u);
        }
    }
}
