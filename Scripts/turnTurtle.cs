using UnityEngine;

public class turnTurtle : MonoBehaviour
{

    public Transform GO;
    float RotationSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GO.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));
    }
}
