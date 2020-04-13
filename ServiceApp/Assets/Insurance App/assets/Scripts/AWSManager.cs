using System.Collections;
using System.Collections.Generic;
using Amazon;
using UnityEngine;

namespace ServiceApp
{
	public class AWSManager : MonoBehaviour
	{
		#region Monobehavior Methods
		private void Awake()
		{
			UnityInitializer.AttachToGameObject(this.gameObject);
		}
		#endregion
	}
}
