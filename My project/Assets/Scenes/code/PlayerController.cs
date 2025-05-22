using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Animator ani;
	private Rigidbody2D rBody;

	void Start()
	{
        ani = GetComponent<Animator>();
		rBody = GetComponent<Rigidbody2D>();
        foreach (PlayerController fFor in FindObjectsOfType<PlayerController>())
		{
			if (fFor.gameObject != gameObject)
			{
				Destroy(gameObject);
			}
        }
		DontDestroyOnLoad(gameObject);
        

    }

    void Update()
	{
		float horizontal = Input.GetAxisRaw("Horizontal");

		float vertical = Input.GetAxisRaw("Vertical");

		if (horizontal != 0)
		{
			ani.SetFloat("Horizontal", horizontal);
			ani.SetFloat("Vertical", 0);
		}
		if (vertical != 0)
		{
			ani.SetFloat("Horizontal", 0);
			ani.SetFloat("Vertical", vertical);

		}
		Vector2 dir = new Vector2(horizontal, vertical);
		ani.SetFloat("Speed", dir.magnitude);
        rBody.velocity = dir * 5f;
	}
}
