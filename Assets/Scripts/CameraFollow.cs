using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Transform target,MainCamera; // The object that the camera should follow
	public float smoothSpeed = 0.125f; // The speed at which the camera should follow the target
	public Vector3 offset; // The offset from the target's position that the camera should follow

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		MainCamera = GetComponentInChildren<Camera>().transform;
	}
	void LateUpdate()
	{
		// Calculate the desired position for the camera
		Vector3 desiredPosition = target.position + offset;

		// Smoothly move the camera towards the desired position
		MainCamera.position = Vector3.Lerp(MainCamera.position, desiredPosition, smoothSpeed);
	}
}
