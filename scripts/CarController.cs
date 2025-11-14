using UnityEngine;

public class CarController : MonoBehaviour
{
    public enum ControlMode
    {
        Keyboard,Buttons
    };

    public ControlMode control;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public WheelCollider frontRightWheelCollider;
    public WheelCollider frontLeftWheelCollider;
    public WheelCollider backRightWheelCollider;
    public WheelCollider backLeftWheelCollider;

    public Transform frontRightWheelTransform;
    public Transform frontLeftWheelTransform;
    public Transform backRightWheelTransform;
    public Transform backLeftWheelTransform;

    public Transform carCentreOfMassTransform;


    public Rigidbody rigidbody;

    public float motorForce = 100f;
    public float steeringAngle = 20f;
    public float brakeForce = 1000f;
    float verticalInput;
    float horizontalInput; 

    void Start()
    {
        
        rigidbody.centerOfMass = carCentreOfMassTransform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MotorForce();
        UpdateWheels();
        GetInput();
        Steering();
        ApplyBrakes();
        PowerSteering();
        Debug.Log(CarSpeed());
    }

    public void MoveInput(float input)
    {
        verticalInput = input;
    }

    public void SteerInput(float input)
    {
        horizontalInput = input;
    }
    void GetInput()
    {
       if(control == ControlMode.Keyboard)
        {
            verticalInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");

        }
    }
    void ApplyBrakes()
    {   if (Input.GetKey(KeyCode.Space))
        {
            frontRightWheelCollider.brakeTorque = brakeForce;
            frontLeftWheelCollider.brakeTorque = brakeForce;
            backLeftWheelCollider.brakeTorque = brakeForce;
            backRightWheelCollider.brakeTorque = brakeForce;
            rigidbody.linearDamping = 1f;
        }
        else
        {
            frontRightWheelCollider.brakeTorque = 0f;
            frontLeftWheelCollider.brakeTorque = 0f;
            backLeftWheelCollider.brakeTorque = 0f;
            backRightWheelCollider.brakeTorque = 0f;
            rigidbody.linearDamping = 0f;
        
        }
       
    }
    void MotorForce()
    {
        frontRightWheelCollider.motorTorque = motorForce * verticalInput;
        frontLeftWheelCollider.motorTorque = motorForce * verticalInput;
    }

    void Steering()
    {
        frontRightWheelCollider.steerAngle = steeringAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = steeringAngle * horizontalInput;
    }
    
    void PowerSteering()
    {
        if (horizontalInput == 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime);
        }
    }
    void UpdateWheels()
    {
        RotateWheel(frontRightWheelCollider, frontRightWheelTransform);
        RotateWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        RotateWheel(backRightWheelCollider, backRightWheelTransform);
        RotateWheel(backLeftWheelCollider, backLeftWheelTransform);
    }
    void RotateWheel(WheelCollider wheelCollider, Transform transform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        transform.position = pos;
        transform.rotation = rot;
    }
    public float CarSpeed()
    {
        float speed = rigidbody.velocity.magnitude * 2.23693629f;
        return speed;
    }
}
