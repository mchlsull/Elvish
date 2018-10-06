/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
	public bool scrolling, paralax;

	public float backgroundSize;
	public float paralaxSpeed;

	public GameObject player;
	
	private Transform[] layers;

	// private float playerTransform;

	private float viewZone = 10;
	private float lastCameraX;
	private float lastCameraZ;

	private int leftIndex;
	private int rightIndex;

	private void Start()
	{
		// playerTransform =
		lastCameraX = player.transform.position.x;
		lastCameraZ = player.transform.position.z;
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
			float deltaX = player.transform.position.x - lastCameraX;
			float deltaZ = player.transform.position.z;

			transform.position += Vector3.right * (deltaX * paralaxSpeed);
			transform.position += Vector3.forward * 0f;
		}

		lastCameraX = player.transform.position.x;
		lastCameraZ = player.transform.position.z;

		if (scrolling)
		{
			if (player.transform.position.x < (layers[leftIndex].transform.position.x + viewZone))
				ScrollLeft();
				

			if (player.transform.position.x > (layers[rightIndex].transform.position.x - viewZone))
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