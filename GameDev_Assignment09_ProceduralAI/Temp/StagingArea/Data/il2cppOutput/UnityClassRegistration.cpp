struct ClassRegistrationContext;
void InvokeRegisterStaticallyLinkedModuleClasses(ClassRegistrationContext& context)
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_Physics();
	RegisterModule_Physics();

}

void RegisterAllClasses()
{
	//Total: 56 classes
	//0. AssetBundle
	void RegisterClass_AssetBundle();
	RegisterClass_AssetBundle();

	//1. NamedObject
	void RegisterClass_NamedObject();
	RegisterClass_NamedObject();

	//2. EditorExtension
	void RegisterClass_EditorExtension();
	RegisterClass_EditorExtension();

	//3. GUILayer
	void RegisterClass_GUILayer();
	RegisterClass_GUILayer();

	//4. Behaviour
	void RegisterClass_Behaviour();
	RegisterClass_Behaviour();

	//5. Component
	void RegisterClass_Component();
	RegisterClass_Component();

	//6. RectTransform
	void RegisterClass_RectTransform();
	RegisterClass_RectTransform();

	//7. Transform
	void RegisterClass_Transform();
	RegisterClass_Transform();

	//8. Camera
	void RegisterClass_Camera();
	RegisterClass_Camera();

	//9. MonoBehaviour
	void RegisterClass_MonoBehaviour();
	RegisterClass_MonoBehaviour();

	//10. GameObject
	void RegisterClass_GameObject();
	RegisterClass_GameObject();

	//11. Rigidbody
	void RegisterClass_Rigidbody();
	RegisterClass_Rigidbody();

	//12. Collider
	void RegisterClass_Collider();
	RegisterClass_Collider();

	//13. AudioClip
	void RegisterClass_AudioClip();
	RegisterClass_AudioClip();

	//14. SampleClip
	void RegisterClass_SampleClip();
	RegisterClass_SampleClip();

	//15. AudioSource
	void RegisterClass_AudioSource();
	RegisterClass_AudioSource();

	//16. AudioBehaviour
	void RegisterClass_AudioBehaviour();
	RegisterClass_AudioBehaviour();

	//17. PreloadData
	void RegisterClass_PreloadData();
	RegisterClass_PreloadData();

	//18. Material
	void RegisterClass_Material();
	RegisterClass_Material();

	//19. Cubemap
	void RegisterClass_Cubemap();
	RegisterClass_Cubemap();

	//20. Texture2D
	void RegisterClass_Texture2D();
	RegisterClass_Texture2D();

	//21. Texture
	void RegisterClass_Texture();
	RegisterClass_Texture();

	//22. Texture3D
	void RegisterClass_Texture3D();
	RegisterClass_Texture3D();

	//23. RenderTexture
	void RegisterClass_RenderTexture();
	RegisterClass_RenderTexture();

	//24. Mesh
	void RegisterClass_Mesh();
	RegisterClass_Mesh();

	//25. LevelGameManager
	void RegisterClass_LevelGameManager();
	RegisterClass_LevelGameManager();

	//26. GameManager
	void RegisterClass_GameManager();
	RegisterClass_GameManager();

	//27. TimeManager
	void RegisterClass_TimeManager();
	RegisterClass_TimeManager();

	//28. GlobalGameManager
	void RegisterClass_GlobalGameManager();
	RegisterClass_GlobalGameManager();

	//29. AudioManager
	void RegisterClass_AudioManager();
	RegisterClass_AudioManager();

	//30. InputManager
	void RegisterClass_InputManager();
	RegisterClass_InputManager();

	//31. MeshRenderer
	void RegisterClass_MeshRenderer();
	RegisterClass_MeshRenderer();

	//32. Renderer
	void RegisterClass_Renderer();
	RegisterClass_Renderer();

	//33. GraphicsSettings
	void RegisterClass_GraphicsSettings();
	RegisterClass_GraphicsSettings();

	//34. MeshFilter
	void RegisterClass_MeshFilter();
	RegisterClass_MeshFilter();

	//35. QualitySettings
	void RegisterClass_QualitySettings();
	RegisterClass_QualitySettings();

	//36. Shader
	void RegisterClass_Shader();
	RegisterClass_Shader();

	//37. TextAsset
	void RegisterClass_TextAsset();
	RegisterClass_TextAsset();

	//38. PhysicsManager
	void RegisterClass_PhysicsManager();
	RegisterClass_PhysicsManager();

	//39. BoxCollider
	void RegisterClass_BoxCollider();
	RegisterClass_BoxCollider();

	//40. TagManager
	void RegisterClass_TagManager();
	RegisterClass_TagManager();

	//41. AudioListener
	void RegisterClass_AudioListener();
	RegisterClass_AudioListener();

	//42. ScriptMapper
	void RegisterClass_ScriptMapper();
	RegisterClass_ScriptMapper();

	//43. DelayedCallManager
	void RegisterClass_DelayedCallManager();
	RegisterClass_DelayedCallManager();

	//44. RenderSettings
	void RegisterClass_RenderSettings();
	RegisterClass_RenderSettings();

	//45. Light
	void RegisterClass_Light();
	RegisterClass_Light();

	//46. MonoScript
	void RegisterClass_MonoScript();
	RegisterClass_MonoScript();

	//47. MonoManager
	void RegisterClass_MonoManager();
	RegisterClass_MonoManager();

	//48. FlareLayer
	void RegisterClass_FlareLayer();
	RegisterClass_FlareLayer();

	//49. PlayerSettings
	void RegisterClass_PlayerSettings();
	RegisterClass_PlayerSettings();

	//50. SphereCollider
	void RegisterClass_SphereCollider();
	RegisterClass_SphereCollider();

	//51. BuildSettings
	void RegisterClass_BuildSettings();
	RegisterClass_BuildSettings();

	//52. ResourceManager
	void RegisterClass_ResourceManager();
	RegisterClass_ResourceManager();

	//53. LightmapSettings
	void RegisterClass_LightmapSettings();
	RegisterClass_LightmapSettings();

	//54. LightProbes
	void RegisterClass_LightProbes();
	RegisterClass_LightProbes();

	//55. RuntimeInitializeOnLoadManager
	void RegisterClass_RuntimeInitializeOnLoadManager();
	RegisterClass_RuntimeInitializeOnLoadManager();

}
