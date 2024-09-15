using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private Transform _spaceTransform;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Transform _hiddenWeapon;
    [SerializeField] private Material _material;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        _spaceTransform.Translate(new Vector3(horizontalInput, 0, verticalInput) * _moveSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            var mouseX = Input.GetAxis("Mouse X");
            var mouseY = Input.GetAxis("Mouse Y");

            var rot = new Vector3(mouseX, mouseY, 0);
            _spaceTransform.localEulerAngles = _spaceTransform.localEulerAngles + rot * _rotationSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.E))
        {
            _hiddenWeapon.localScale = Vector3.one;
        }
        else
        {
            _hiddenWeapon.localScale = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.F))
        {
            _material.color = Color.red;
        }
        else
        {
            _material.color = Color.white;
        }
    }
}
