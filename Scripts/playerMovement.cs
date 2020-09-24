using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;


public class playerMovement : MonoBehaviour 
{

	// THis is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	public float jump = 1f;
	//public Text commandLog;
	
	// We marked this a s"Fixed"Update because we
	// are using it to mess with physics
	void FixedUpdate() 
	{
		// Add a forward force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey("d"))
        {
			// Only executed if condition is met
			//rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			Command moveR = new MoveRight(rb, sidewaysForce);
			Invoker invoke = new Invoker();
			invoke.SetCommand(moveR);

			//commandLog.text += moveR.ToString() + "\n";
			invoke.ExeCommand();
		}

		if (Input.GetKey("a"))
		{
			// Only executed if condition is met
			//rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			Command moveL = new MoveLeft(rb, sidewaysForce);
			Invoker invoke = new Invoker();
			invoke.SetCommand(moveL);
			invoke.ExeCommand();
			//commandLog.text += moveL.ToString() + "\n";

		}

		if (rb.position.x < -8f || rb.position.x > 8f)
        {
			FindObjectOfType<gameManager>().endGame(null);
        }



	}

}
