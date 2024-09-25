using Sandbox;
namespace Editor;

internal class GokuNotice : NoticeWidget
{
	public GokuNotice()
	{
		var sound = SoundFile.Load( "sounds/editor/prowler.mp3" );
		EditorUtility.PlayAssetSound( sound );
		
		BorderColor = Theme.Grey;
		
		FixedWidth = 300;
		FixedHeight = 76;
	}

	protected override void OnPaint()
	{
		base.OnPaint();

		var rect = LocalRect.Shrink( 4.5f, 4.5f );
		rect.Position += new Vector2( -1f, -1 );

		Paint.Draw( rect, "https://content.imageresizer.com/images/memes/Goku-Staring-meme-7iskwn.jpg" );
	}
}
