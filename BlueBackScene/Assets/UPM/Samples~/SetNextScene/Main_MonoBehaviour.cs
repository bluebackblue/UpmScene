

/** BlueBack.Scene.Samples.SetNextScene
*/
namespace BlueBack.Scene.Samples.SetNextScene
{
	/** Main_MonoBehaviour
	*/
	public sealed class Main_MonoBehaviour : UnityEngine.MonoBehaviour
	{
		/** Start
		*/
		private void Start()
		{
			UnityEngine.GameObject.DontDestroyOnLoad(UnityEngine.GameObject.Find("Canvas"));
			UnityEngine.GameObject.Find("Image").GetComponent<UnityEngine.UI.Image>().material.SetFloat("visible",1.0f);

			UnityEngine.GameObject.DontDestroyOnLoad(this.gameObject);

			BlueBack.Scene.InitParam t_initparam = BlueBack.Scene.InitParam.CreateDefault();
			{
			}
			BlueBack.Scene.Scene t_scene = new BlueBack.Scene.Scene(in t_initparam);

			t_scene.SetNextScene(
				new SceneA(t_scene,0),
				new ChangeAction.Item_Base[]{
					//シーンロード開始。
					BlueBack.Scene.ChangeAction.SingleLoadRequestNextUnityScene.Create(false),
					//シーンロード待ち。
					BlueBack.Scene.ChangeAction.WaitActivationNextUnityScene.Create(0),
				}
			);
		}
	}
}

