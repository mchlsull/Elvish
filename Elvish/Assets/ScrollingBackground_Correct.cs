/* 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
	public bool scrolling, paralax;

	public float backgroundSize;
	public float paralaxSpeed;

	private Transform cameraTransform;
	private Transform[] layers;

	private float viewZone = 10;
	private float lastCameraX;
	private float lastCameraZ;

	private int leftIndex;
	private int rightIndex;

	private void Start()
	{
		cameraTransform = Camera.main.transform;
		lastCameraX = cameraTransform.position.x;
		lastCameraZ = cameraTransform.position.z;
		layers = new Transform[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
			layers[i] = transform.GetChild(i);

		leftIndex = 0;
		rightIndex = layers.Length - 1;
	}

	private void Update()
	{
		if(paralax)
		{
			float deltaX = cameraTransform.position.x - lastCameraX;
			float deltaZ = cameraTransform.position.z;

			transform.position += Vector3.right * (deltaX * paralaxSpeed);
			transform.position += Vector3.forward * 0f;
		}

		lastCameraX = cameraTransform.position.x;

		if (scrolling)
		{
			if (cameraTransform.position.x < (layers[leftIndex].transform.position.x + viewZone))
				ScrollLeft();

			if (cameraTransform.position.x > (layers[rightIndex].transform.position.x - viewZone))
				ScrollRight();
		}
	}

	private void ScrollLeft()
	{
		int lastRight = rightIndex;
		layers[rightIndex].position = Vector3.right * (layers[leftIndex].position.x - backgroundSize);
		leftIndex = rightIndex;
		rightIndex--;
		if (rightIndex < 0)
			rightIndex = layers.Length - 1;
	}

	private void ScrollRight()
	{
		int lastLeft = leftIndex;
		layers[leftIndex].position = Vector3.right * (layers[rightIndex].position.x + backgroundSize);
		rightIndex = leftIndex;
		leftIndex++;
		if (leftIndex == layers.Length)
			leftIndex = 0;
	}
}

*/