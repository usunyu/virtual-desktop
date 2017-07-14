using UnityEngine;
using System.Collections;
using UnityEngine.VR;

namespace VRStandardAssets.Examples
{ 
	public class ExampleRenderScale : MonoBehaviour
	{
		[SerializeField] private float m_RenderScale = 1f;              //The render scale. Higher numbers = better quality, but trades performance

		void Start ()
		{
			VRSettings.renderScale = m_RenderScale;
		}
	}
}