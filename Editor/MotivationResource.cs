using Sandbox;
namespace Editor;

[GameResource( "Motivation", "motivate", "Citizens motivate you every 15-30 minutes.", Icon = "support_agent", Category = "Editor", IconBgColor = "#E4E2E4", IconFgColor = "#93BDDD" )]
public class MotivationResource : GameResource
{
	[ImageAssetPath]
	public string[] Portraits { get; set; }

	public string[] Messages { get; set; }

	/// <summary>
	/// Selects a random citizen portrait from this type.
	/// </summary>
	/// <returns>Portrait file path</returns>
	public string GetPortrait()
	{
		var portraitPath = Game.Random.FromArray( Portraits );

		return FileSystem.Mounted.GetFullPath( portraitPath );
	}

	/// <summary>
	/// Selects a random motivational response from this type.
	/// </summary>
	/// <returns>Response with linebreaks</returns>
	public string GetMessage()
	{
		return Game.Random.FromArray( Messages );
	}
}
