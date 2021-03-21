using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class CharacterMoverHelper : MonoBehaviour
{
    private XRRig _XRRig;
    private CharacterController _CharacterController;
    private CharacterControllerDriver driver;

    // Start is called before the first frame update
    void Start()
    {
        _XRRig = GetComponent<XRRig>();
        _CharacterController = GetComponent<CharacterController>();
        driver = GetComponent<CharacterControllerDriver>();

       
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCharacterController();
    }
    /// <summary>
    /// Update the <see cref="CharacterController.height"/> and <see cref="CharacterController.center"/>
    /// based on the camera's position.
    /// </summary>
    protected virtual void UpdateCharacterController()
    {
        if (_XRRig == null || _CharacterController == null)
            return;

        var height = Mathf.Clamp(_XRRig.cameraInRigSpaceHeight, driver.minHeight, driver.maxHeight);

        Vector3 center = _XRRig.cameraInRigSpacePos;
        center.y = height / 2f + _CharacterController.skinWidth;

        _CharacterController.height = height;
        _CharacterController.center = center;
    }

}
