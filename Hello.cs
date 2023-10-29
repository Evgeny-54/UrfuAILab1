using UnityEngine;

public class Hello : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform test;
    private int direction = 1;
    void Start()
    {
        Debug.Log(" Hello World");
        test = GameObject.CreatePrimitive(PrimitiveType.Sphere).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (test.position.z > 10 && direction == 1)
        {
            direction *= -1;
        }
        else if (test.position.z < 0 && direction == -1)
        {
            direction *= -1;
        }

        test.SetPositionAndRotation(test.position + new Vector3(0, 1, 1) * 0.1f * direction, transform.rotation);

    }
}
