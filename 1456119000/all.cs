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
                OriginalItem = ModAPI.FindSpawnable("M1 Garand"),
                NameOverride = "AK-74",
                DescriptionOverride = "5,45mm AK-74",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/ak74.png"),
                AfterSpawn = (Instance) =>
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/ak74.png", 17f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.82f, 0.10f);
                    foreach (var c in Instance.GetComponents<Collider2D>())
                    {
                        GameObject.Destroy(c);
                    }
                    Instance.FixColliders();
                    Instance.GetComponent<FirearmBehaviour>().BulletsPerShot = 1;

                    var firearm = Instance.GetComponent<FirearmBehaviour>();
                    Instance.GetComponent<FirearmBehaviour>().Automatic = true;
                    Instance.GetComponent<FirearmBehaviour>().AutomaticFireInterval = 0.1f;

                    firearm.ShotSounds = new AudioClip[]
              {
            ModAPI.LoadSound("sound/545.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("5,45x39mm");
                    customCartridge.name = "5,45x39mm";
                    customCartridge.Damage *= 5f;
                    customCartridge.Recoil = 3f;
                    customCartridge.ImpactForce = 1.5f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
			ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("M1 Garand"),
                NameOverride = "AK-74 Tactical",
                DescriptionOverride = "5,45mm AK-74 Tactical",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/ak74-tactical.png"),
                AfterSpawn = (Instance) =>
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/ak74-tactical.png", 17f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.82f, 0.10f);
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
            ModAPI.LoadSound("sound/545.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("5,45x39mm");
                    customCartridge.name = "5,45x39mm";
                    customCartridge.Damage *= 5f;
                    customCartridge.Recoil = 3f;
                    customCartridge.ImpactForce = 1.5f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
			ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("M1 Garand"),
                NameOverride = "VPO-911",
                DescriptionOverride = "Semi-Auto 7,62mm carabine VPO-911",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/762.png"),
                AfterSpawn = (Instance) =>
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/762.png", 17f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.82f, 0.10f);
                    foreach (var c in Instance.GetComponents<Collider2D>())
                    {
                        GameObject.Destroy(c);
                    }
                    Instance.FixColliders();
                    Instance.GetComponent<FirearmBehaviour>().BulletsPerShot = 1;

                    var firearm = Instance.GetComponent<FirearmBehaviour>();
                    Instance.GetComponent<FirearmBehaviour>().Automatic = false;
                    Instance.GetComponent<FirearmBehaviour>().AutomaticFireInterval = 0.11f;

                    firearm.ShotSounds = new AudioClip[]
              {
            ModAPI.LoadSound("sound/762.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("7,62x39mm");
                    customCartridge.name = "7,62x39mm";
                    customCartridge.Damage *= 7f;
                    customCartridge.Recoil = 5f;
                    customCartridge.ImpactForce = 1.7f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
			ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("M1 Garand"),
                NameOverride = "VPO-911-S",
                DescriptionOverride = "Semi-Auto 7,62mm carabine VPO-911 Supressed",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/762s.png"),
                AfterSpawn = (Instance) =>
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/762s.png", 17f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(1.0f, 0.10f);
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
            ModAPI.LoadSound("sound/762s.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("7,62x39mm");
                    customCartridge.name = "7,62x39mm";
                    customCartridge.Damage *= 7f;
                    customCartridge.Recoil = 5f;
                    customCartridge.ImpactForce = 1.7f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
			ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Pistol"),
                NameOverride = "TT-33",
                DescriptionOverride = "7,62mm Tula Tokarev",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/tt.png"),
                AfterSpawn = (Instance) =>
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/tt.png", 30f);
                    Instance.GetComponent<FirearmBehaviour>().barrelPosition = new Vector2(0.25f, 0.12f);
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
            ModAPI.LoadSound("sound/762p.wav"),
                };

                    Cartridge customCartridge = ModAPI.FindCartridge("7,62x25mm");
                    customCartridge.name = "7,62x25mm";
                    customCartridge.Damage *= 5f;
                    customCartridge.Recoil = 4.7f;
                    customCartridge.ImpactForce = 0.5f;
                    firearm.Cartridge = customCartridge;
                }
            }
            );
			
			ModAPI.Register(
            new Modification()
            {
                OriginalItem = ModAPI.FindSpawnable("Pistol"),
                NameOverride = "PM",
                DescriptionOverride = "9x18mm Makarov Pistol",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/pm.png"),
                AfterSpawn = (Instance) =>
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/pm.png", 28f);
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

                    Cartridge customCartridge = ModAPI.FindCartridge("9x18mm");
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
                OriginalItem = ModAPI.FindSpawnable("M1 Garand"),
                NameOverride = "VPO-911 Tactical",
                DescriptionOverride = "Automatic 7,62mm carabine VPO-911 Tactical",
                CategoryOverride = ModAPI.FindCategory("S6"),
                ThumbnailOverride = ModAPI.LoadSprite("icons/762ta.png"),
                AfterSpawn = (Instance) =>
                {
                    Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("models/762ta.png", 17f);
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
                    customCartridge.Recoil = 5f;
                    customCartridge.ImpactForce = 1.7f;
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
