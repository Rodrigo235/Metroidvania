using UnityEngine;

public class TestBoxRotation : MonoBehaviour
{
    [SerializeField] private Transform _target;
    public float rotSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _target.Rotate(new Vector3(0, rotSpeed, 0) * Time.deltaTime);
    }
}
