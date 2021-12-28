using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class ControlRigidbody : MonoBehaviour
    {

        [SerializeField] private Rigidbody _rigidbody;

        [SerializeField] private ControlRigidBodySettings _settings;

        private void Update()
        {
            bool spaceKeydown = Input.GetKeyDown(KeyCode.Space);

            if (spaceKeydown)
            {
                //Debug.Log("space down");
                _rigidbody.AddForce(_settings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}
