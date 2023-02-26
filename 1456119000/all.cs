using UnityEngine;

namespace Mod
{
    public class Mod
    {
        public static void Main()
        {
            CategoryBuilder.Create("S6", "carabine pack", ModAPI.LoadSprite("S6.png"));			
			ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Pistol"),
                NameOverride = "М-918",
                DescriptionOverride = "9x18мм самозарядный пистолет",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/pm.png"),
                AfterSpawn = (Instance) =>
                {
					ModAPI.KeepExtraObjects();
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/pm.png", 28f);
					var ThompsonSlide = Instance.transform.Find("Slide");
                    ThompsonSlide.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/pm_sl.png", 28f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.25f, 0.10f);
                    foreach (var c in Instance.GetComponents<Collider2D>())
                    {
                        GameObject.Destroy(c);
                    }
                    Instance.FixColliders();
                    Instance.GetComponent<FirearmBehaviour>().BulletsPerShot = 1;

                    var firearm = Instance.GetComponent<FirearmBehaviour>();
                    Instance.GetComponent<FirearmBehaviour>().Automatic = false;
                    Instance.GetComponent<FirearmBehaviour>().AutomaticFireInterval = 0.08f;

                    firearm.ShotSounds = new AudioClip[]
              {
            ModAPI.LoadSound("sound/9.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                    customCartridge.name = "9x18mm";
                    customCartridge.Damage *= 0.1f;
                    customCartridge.Recoil = 3.2f;
                    customCartridge.ImpactForce = 0.3f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
						ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Pistol"),
                NameOverride = "М-921",
                DescriptionOverride = "9x21мм самозарядный пистолет",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/921.png"),
                AfterSpawn = (Instance) =>
                {
					ModAPI.KeepExtraObjects();
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/921.png", 25f);
					var ThompsonSlide = Instance.transform.Find("Slide");
                    ThompsonSlide.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/921_sl.png", 25f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.25f, 0.10f);
                    foreach (var c in Instance.GetComponents<Collider2D>())
                    {
                        GameObject.Destroy(c);
                    }
                    Instance.FixColliders();
                    Instance.GetComponent<FirearmBehaviour>().BulletsPerShot = 1;

                    var firearm = Instance.GetComponent<FirearmBehaviour>();
                    Instance.GetComponent<FirearmBehaviour>().Automatic = false;
                    Instance.GetComponent<FirearmBehaviour>().AutomaticFireInterval = 0.08f;

                    firearm.ShotSounds = new AudioClip[]
              {
            ModAPI.LoadSound("sound/921.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                    customCartridge.name = "9x21mm";
                    customCartridge.Damage *= 0.1f;
                    customCartridge.Recoil = 3.2f;
                    customCartridge.ImpactForce = 0.3f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
			ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Pistol"),
                NameOverride = "М-919",
                DescriptionOverride = "9x19мм самозарядный пистолет",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/919.png"),
                AfterSpawn = (Instance) =>
                {
					ModAPI.KeepExtraObjects();
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/919.png", 25f);
					var ThompsonSlide = Instance.transform.Find("Slide");
                    ThompsonSlide.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/919_sl.png", 25f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.25f, 0.10f);
                    foreach (var c in Instance.GetComponents<Collider2D>())
                    {
                        GameObject.Destroy(c);
                    }
                    Instance.FixColliders();
                    Instance.GetComponent<FirearmBehaviour>().BulletsPerShot = 1;

                    var firearm = Instance.GetComponent<FirearmBehaviour>();
                    Instance.GetComponent<FirearmBehaviour>().Automatic = false;
                    Instance.GetComponent<FirearmBehaviour>().AutomaticFireInterval = 0.08f;

                    firearm.ShotSounds = new AudioClip[]
              {
            ModAPI.LoadSound("sound/919.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                    customCartridge.name = "9x19mm";
                    customCartridge.Damage *= 0.1f;
                    customCartridge.Recoil = 3.2f;
                    customCartridge.ImpactForce = 0.3f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
			ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("M1 Garand"),
                NameOverride = "M-762",
                DescriptionOverride = "7.62мм автоматический карабин",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/762.png"),
                AfterSpawn = (Instance) =>
                {
					ModAPI.KeepExtraObjects();
        
					var ThompsonSlide = Instance.transform.Find("Slide");
                    ThompsonSlide.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/762_sl.png", 19f);
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/762.png", 17f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.82f, 0.10f);
                    foreach (var c in Instance.GetComponents<Collider2D>())
                    {
                        GameObject.Destroy(c);
                    }
                    Instance.FixColliders();
                    Instance.GetComponent<FirearmBehaviour>().BulletsPerShot = 1;

                    var firearm = Instance.GetComponent<FirearmBehaviour>();
                    Instance.GetComponent<FirearmBehaviour>().Automatic = true;
                    Instance.GetComponent<FirearmBehaviour>().AutomaticFireInterval = 0.11f;

                    firearm.ShotSounds = new AudioClip[]
              {
            ModAPI.LoadSound("sound/762.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("7,62x39mm");
                    customCartridge.name = "7,62x39mm";
                    customCartridge.Damage *= 7f;
                    customCartridge.Recoil = 7f;
                    customCartridge.ImpactForce = 1.7f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
			ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("M1 Garand"),
                NameOverride = "M-939",
                DescriptionOverride = "9x39мм малогабаритный автомат",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/939.png"),
                AfterSpawn = (Instance) =>
                {
					ModAPI.KeepExtraObjects();
        
					var ThompsonSlide = Instance.transform.Find("Slide");
                    ThompsonSlide.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/939_sl.png", 17f);
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/939.png", 16f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.32f, 0.10f);
                    foreach (var c in Instance.GetComponents<Collider2D>())
                    {
                        GameObject.Destroy(c);
                    }
                    Instance.FixColliders();
                    Instance.GetComponent<FirearmBehaviour>().BulletsPerShot = 1;

                    var firearm = Instance.GetComponent<FirearmBehaviour>();
                    Instance.GetComponent<FirearmBehaviour>().Automatic = true;
                    Instance.GetComponent<FirearmBehaviour>().AutomaticFireInterval = 0.08f;

                    firearm.ShotSounds = new AudioClip[]
              {
            ModAPI.LoadSound("sound/939.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("9mm");
                    customCartridge.name = "9x39mm";
                    customCartridge.Damage *= 1f;
                    customCartridge.Recoil = 1f;
                    customCartridge.ImpactForce = 0.7f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
		}
	}
	}
public class MultipleSpriteHumanBehaviour : MonoBehaviour
{
    public Texture2D[] Textures = new Texture2D[0];
    public PersonBehaviour person;
    public int CurrentTexture = -2;
    public int Scale = 3;

    void Start()
    {
        SetTexture();
    }

    public void SetTexture()
    {
        if (Textures.Length == 0)
            return;

        if (CurrentTexture == -2)
        {
            CurrentTexture = UnityEngine.Random.Range(0, Textures.Length);
        }
        person.SetBodyTextures(Textures[CurrentTexture], null, null, Scale);
        for (int i = 0; i < person.Limbs.Length; i++)
        {
            person.Limbs[i].gameObject.GetComponent<PhysicalBehaviour>().RefreshOutline();

        }
    }
}
