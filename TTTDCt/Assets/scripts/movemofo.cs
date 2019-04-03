using UnityEngine;
using System.Collections;
//this script can be found in the Component section under the option Character Set Up 
//Character Movement
//This script requires the component Character controller

[RequireComponent(typeof(CharacterController))]
//script needs a CC on this object, to ref later, if dose not ahve a cc one will be made
public class movemofo : MonoBehaviour
{
    #region Variables
    [Header("Characters MoveDirection")]
    [Space(5)]

    //vector3 called moveDirection
    public Vector3 moveDirection;

    //we will use this to apply movement in worldspace
    //private CharacterController (https://docs.unity3d.com/ScriptReference/CharacterController.html) charC
    public CharacterController _characterController;
    [Header("PLAYER MOVEMENT")]
    //[Header("Character Variables")]
    //public float variables jumpSpeed, speed, gravity
    public float jumpSpeed = 10;
    public float speed = 5;
    public float gravity = 20;
    ////// or write itlike public float

    #endregion

    #region Start
    //charc is on this game object we need to get the character controller that is attached to it
    private void Start()
    {
        _characterController = this.GetComponent<CharacterController>();
    }
    #endregion
    #region Update

    private void Update()
    {
        if (_characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //if our character is grounded
            //we are able to move in game scene meaning
            //Input Manager(https://docs.unity3d.com/Manual/class-InputManager.html)
            //Input(https://docs.unity3d.com/ScriptReference/Input.html)
            moveDirection = transform.TransformDirection(moveDirection);
            //moveDir is equal to a new vector3 that is affected by Input.Get Axis.. Horizontal, 0, Vertical
            //moveDir is transformed in the direction of our moveDir
            //our moveDir is then multiplied by our speed
            moveDirection *= speed;

            //we can also jump if we are grounded so
            //in the input button for jump is pressed then
            //our moveDir.y is equal to our jump speed
            if (Input.GetButton("Jump"))
            {

                moveDirection.y = jumpSpeed;
            }

        }
        //regardless of if we are grounded or not the players moveDir.y is always affected by gravity timesed my time.deltaTime to normalize it
        moveDirection.y -= gravity * Time.deltaTime;
        //we then tell the character Controller that it is moving in a direction timesed Time.deltaTime
        _characterController.Move(moveDirection * Time.deltaTime);
        #endregion
    }
}