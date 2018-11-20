template <typename T> void RegisterUnityClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_CloudWebServices();
	RegisterModule_CloudWebServices();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_UnityAnalytics();
	RegisterModule_UnityAnalytics();

	void RegisterModule_CrashReporting();
	RegisterModule_CrashReporting();

	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_TLS();
	RegisterModule_TLS();

	void RegisterModule_WebGL();
	RegisterModule_WebGL();

}

class EditorExtension; template <> void RegisterUnityClass<EditorExtension>(const char*);
namespace Unity { class Component; } template <> void RegisterUnityClass<Unity::Component>(const char*);
class Behaviour; template <> void RegisterUnityClass<Behaviour>(const char*);
class Animation; 
class Animator; 
class AudioBehaviour; template <> void RegisterUnityClass<AudioBehaviour>(const char*);
class AudioListener; template <> void RegisterUnityClass<AudioListener>(const char*);
class AudioSource; 
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterUnityClass<Camera>(const char*);
namespace UI { class Canvas; } template <> void RegisterUnityClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } 
namespace Unity { class Cloth; } 
class Collider2D; template <> void RegisterUnityClass<Collider2D>(const char*);
class BoxCollider2D; template <> void RegisterUnityClass<BoxCollider2D>(const char*);
class CapsuleCollider2D; 
class CircleCollider2D; 
class CompositeCollider2D; 
class EdgeCollider2D; 
class PolygonCollider2D; 
class TilemapCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; 
class GUIElement; template <> void RegisterUnityClass<GUIElement>(const char*);
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterUnityClass<GUILayer>(const char*);
class GridLayout; 
class Grid; 
class Tilemap; 
class Halo; 
class HaloLayer; 
class IConstraint; 
class AimConstraint; 
class LookAtConstraint; 
class ParentConstraint; 
class PositionConstraint; 
class RotationConstraint; 
class ScaleConstraint; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; 
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterUnityClass<MonoBehaviour>(const char*);
class NavMeshAgent; 
class NavMeshObstacle; 
class OffMeshLink; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; 
class Projector; 
class ReflectionProbe; template <> void RegisterUnityClass<ReflectionProbe>(const char*);
class Skybox; 
class SortingGroup; 
class StreamingController; 
class Terrain; 
class VideoPlayer; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterUnityClass<UI::CanvasRenderer>(const char*);
class Collider; 
class BoxCollider; 
class CapsuleCollider; 
class CharacterController; 
class MeshCollider; 
class SphereCollider; 
class TerrainCollider; 
class WheelCollider; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterUnityClass<MeshFilter>(const char*);
class OcclusionArea; 
class OcclusionPortal; 
class ParticleAnimator; 
class ParticleEmitter; 
class EllipsoidParticleEmitter; 
class MeshParticleEmitter; 
class ParticleSystem; 
class Renderer; template <> void RegisterUnityClass<Renderer>(const char*);
class BillboardRenderer; 
class LineRenderer; 
class MeshRenderer; template <> void RegisterUnityClass<MeshRenderer>(const char*);
class ParticleRenderer; 
class ParticleSystemRenderer; 
class SkinnedMeshRenderer; 
class SpriteMask; 
class SpriteRenderer; template <> void RegisterUnityClass<SpriteRenderer>(const char*);
class SpriteShapeRenderer; 
class TilemapRenderer; 
class TrailRenderer; 
class Rigidbody; 
class Rigidbody2D; template <> void RegisterUnityClass<Rigidbody2D>(const char*);
namespace TextRenderingPrivate { class TextMesh; } 
class Transform; template <> void RegisterUnityClass<Transform>(const char*);
namespace UI { class RectTransform; } template <> void RegisterUnityClass<UI::RectTransform>(const char*);
class Tree; 
class WorldParticleCollider; 
class GameObject; template <> void RegisterUnityClass<GameObject>(const char*);
class NamedObject; template <> void RegisterUnityClass<NamedObject>(const char*);
class AssetBundle; 
class AssetBundleManifest; 
class ScriptedImporter; 
class AssetImporterLog; 
class AudioMixer; 
class AudioMixerController; 
class AudioMixerGroup; 
class AudioMixerGroupController; 
class AudioMixerSnapshot; 
class AudioMixerSnapshotController; 
class Avatar; 
class AvatarMask; 
class BillboardAsset; 
class ComputeShader; 
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterUnityClass<TextRendering::Font>(const char*);
class GameObjectRecorder; 
class LightProbes; 
class LocalizationAsset; 
class Material; template <> void RegisterUnityClass<Material>(const char*);
class ProceduralMaterial; 
class Mesh; template <> void RegisterUnityClass<Mesh>(const char*);
class Motion; 
class AnimationClip; 
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterUnityClass<PreloadData>(const char*);
class RuntimeAnimatorController; 
class AnimatorController; 
class AnimatorOverrideController; 
class SampleClip; 
class AudioClip; 
class Shader; template <> void RegisterUnityClass<Shader>(const char*);
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterUnityClass<Sprite>(const char*);
class SpriteAtlas; template <> void RegisterUnityClass<SpriteAtlas>(const char*);
class SubstanceArchive; 
class TerrainData; 
class TextAsset; template <> void RegisterUnityClass<TextAsset>(const char*);
class CGProgram; 
class MonoScript; template <> void RegisterUnityClass<MonoScript>(const char*);
class Texture; template <> void RegisterUnityClass<Texture>(const char*);
class BaseVideoTexture; 
class WebCamTexture; 
class CubemapArray; 
class LowerResBlitTexture; template <> void RegisterUnityClass<LowerResBlitTexture>(const char*);
class ProceduralTexture; 
class RenderTexture; template <> void RegisterUnityClass<RenderTexture>(const char*);
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterUnityClass<Texture2D>(const char*);
class Cubemap; template <> void RegisterUnityClass<Cubemap>(const char*);
class Texture2DArray; template <> void RegisterUnityClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterUnityClass<Texture3D>(const char*);
class VideoClip; 
class GameManager; template <> void RegisterUnityClass<GameManager>(const char*);
class GlobalGameManager; template <> void RegisterUnityClass<GlobalGameManager>(const char*);
class AudioManager; template <> void RegisterUnityClass<AudioManager>(const char*);
class BuildSettings; template <> void RegisterUnityClass<BuildSettings>(const char*);
class CloudWebServicesManager; template <> void RegisterUnityClass<CloudWebServicesManager>(const char*);
class CrashReportManager; template <> void RegisterUnityClass<CrashReportManager>(const char*);
class DelayedCallManager; template <> void RegisterUnityClass<DelayedCallManager>(const char*);
class GraphicsSettings; template <> void RegisterUnityClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterUnityClass<InputManager>(const char*);
class MonoManager; template <> void RegisterUnityClass<MonoManager>(const char*);
class NavMeshProjectSettings; 
class PerformanceReportingManager; 
class Physics2DSettings; template <> void RegisterUnityClass<Physics2DSettings>(const char*);
class PhysicsManager; 
class PlayerSettings; template <> void RegisterUnityClass<PlayerSettings>(const char*);
class QualitySettings; template <> void RegisterUnityClass<QualitySettings>(const char*);
class ResourceManager; template <> void RegisterUnityClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterUnityClass<RuntimeInitializeOnLoadManager>(const char*);
class ScriptMapper; template <> void RegisterUnityClass<ScriptMapper>(const char*);
class StreamingManager; 
class TagManager; template <> void RegisterUnityClass<TagManager>(const char*);
class TimeManager; template <> void RegisterUnityClass<TimeManager>(const char*);
class UnityAnalyticsManager; template <> void RegisterUnityClass<UnityAnalyticsManager>(const char*);
class UnityConnectSettings; template <> void RegisterUnityClass<UnityConnectSettings>(const char*);
class LevelGameManager; template <> void RegisterUnityClass<LevelGameManager>(const char*);
class LightmapSettings; template <> void RegisterUnityClass<LightmapSettings>(const char*);
class NavMeshSettings; 
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterUnityClass<RenderSettings>(const char*);
class RenderPassAttachment; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 62 non stripped classes
	//0. Rigidbody2D
	RegisterUnityClass<Rigidbody2D>("Physics2D");
	//1. Unity::Component
	RegisterUnityClass<Unity::Component>("Core");
	//2. EditorExtension
	RegisterUnityClass<EditorExtension>("Core");
	//3. Behaviour
	RegisterUnityClass<Behaviour>("Core");
	//4. Camera
	RegisterUnityClass<Camera>("Core");
	//5. LowerResBlitTexture
	RegisterUnityClass<LowerResBlitTexture>("Core");
	//6. Texture
	RegisterUnityClass<Texture>("Core");
	//7. NamedObject
	RegisterUnityClass<NamedObject>("Core");
	//8. PreloadData
	RegisterUnityClass<PreloadData>("Core");
	//9. GameObject
	RegisterUnityClass<GameObject>("Core");
	//10. QualitySettings
	RegisterUnityClass<QualitySettings>("Core");
	//11. GlobalGameManager
	RegisterUnityClass<GlobalGameManager>("Core");
	//12. GameManager
	RegisterUnityClass<GameManager>("Core");
	//13. Renderer
	RegisterUnityClass<Renderer>("Core");
	//14. Shader
	RegisterUnityClass<Shader>("Core");
	//15. Material
	RegisterUnityClass<Material>("Core");
	//16. MeshFilter
	RegisterUnityClass<MeshFilter>("Core");
	//17. MeshRenderer
	RegisterUnityClass<MeshRenderer>("Core");
	//18. GUIElement
	RegisterUnityClass<GUIElement>("Core");
	//19. GUILayer
	RegisterUnityClass<GUILayer>("Core");
	//20. Mesh
	RegisterUnityClass<Mesh>("Core");
	//21. MonoBehaviour
	RegisterUnityClass<MonoBehaviour>("Core");
	//22. ReflectionProbe
	RegisterUnityClass<ReflectionProbe>("Core");
	//23. Texture2D
	RegisterUnityClass<Texture2D>("Core");
	//24. Cubemap
	RegisterUnityClass<Cubemap>("Core");
	//25. Texture3D
	RegisterUnityClass<Texture3D>("Core");
	//26. Texture2DArray
	RegisterUnityClass<Texture2DArray>("Core");
	//27. RenderTexture
	RegisterUnityClass<RenderTexture>("Core");
	//28. UI::RectTransform
	RegisterUnityClass<UI::RectTransform>("Core");
	//29. Transform
	RegisterUnityClass<Transform>("Core");
	//30. Sprite
	RegisterUnityClass<Sprite>("Core");
	//31. SpriteAtlas
	RegisterUnityClass<SpriteAtlas>("Core");
	//32. TagManager
	RegisterUnityClass<TagManager>("Core");
	//33. GraphicsSettings
	RegisterUnityClass<GraphicsSettings>("Core");
	//34. DelayedCallManager
	RegisterUnityClass<DelayedCallManager>("Core");
	//35. InputManager
	RegisterUnityClass<InputManager>("Core");
	//36. TimeManager
	RegisterUnityClass<TimeManager>("Core");
	//37. BuildSettings
	RegisterUnityClass<BuildSettings>("Core");
	//38. PlayerSettings
	RegisterUnityClass<PlayerSettings>("Core");
	//39. ResourceManager
	RegisterUnityClass<ResourceManager>("Core");
	//40. RuntimeInitializeOnLoadManager
	RegisterUnityClass<RuntimeInitializeOnLoadManager>("Core");
	//41. ScriptMapper
	RegisterUnityClass<ScriptMapper>("Core");
	//42. MonoManager
	RegisterUnityClass<MonoManager>("Core");
	//43. MonoScript
	RegisterUnityClass<MonoScript>("Core");
	//44. TextAsset
	RegisterUnityClass<TextAsset>("Core");
	//45. AudioManager
	RegisterUnityClass<AudioManager>("Audio");
	//46. UnityConnectSettings
	RegisterUnityClass<UnityConnectSettings>("UnityConnect");
	//47. CloudWebServicesManager
	RegisterUnityClass<CloudWebServicesManager>("CloudWebServices");
	//48. CrashReportManager
	RegisterUnityClass<CrashReportManager>("CrashReporting");
	//49. Physics2DSettings
	RegisterUnityClass<Physics2DSettings>("Physics2D");
	//50. UnityAnalyticsManager
	RegisterUnityClass<UnityAnalyticsManager>("UnityAnalytics");
	//51. UI::Canvas
	RegisterUnityClass<UI::Canvas>("UI");
	//52. LevelGameManager
	RegisterUnityClass<LevelGameManager>("Core");
	//53. LightmapSettings
	RegisterUnityClass<LightmapSettings>("Core");
	//54. RenderSettings
	RegisterUnityClass<RenderSettings>("Core");
	//55. SpriteRenderer
	RegisterUnityClass<SpriteRenderer>("Core");
	//56. BoxCollider2D
	RegisterUnityClass<BoxCollider2D>("Physics2D");
	//57. Collider2D
	RegisterUnityClass<Collider2D>("Physics2D");
	//58. UI::CanvasRenderer
	RegisterUnityClass<UI::CanvasRenderer>("UI");
	//59. TextRendering::Font
	RegisterUnityClass<TextRendering::Font>("TextRendering");
	//60. AudioBehaviour
	RegisterUnityClass<AudioBehaviour>("Audio");
	//61. AudioListener
	RegisterUnityClass<AudioListener>("Audio");

}
