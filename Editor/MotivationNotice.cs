using Sandbox;
namespace Editor;

public class MotivationNotice : NoticeWidget
{
	public MotivationNotice()
	{
		FixedSize = new Vector2( 512, 384 );
	}

	protected override void OnPaint()
	{
		var imageTexture = Texture.Load( "images/citizens/chill/terry.png" );
		var bubbleTexture = Texture.Load( "images/speechbubble.vtex" );
		
		var image = Pixmap.FromTexture( imageTexture );
		var bubble = Pixmap.FromTexture( bubbleTexture );

		var imageRect = new Rect( 0, 32,350,350 );
		var bubbleRect = new Rect( 256, 0, 256, 256 );
		var speechRect = bubbleRect.Shrink( 8,8,8,96 );
		
		Paint.Draw( imageRect, image );
		Paint.Draw( bubbleRect, bubble );
		
		Paint.SetPen( Theme.Black, 1 );
		Paint.SetFont( "Poppins", 16, 450 );
		Paint.DrawText( speechRect, "that's amazing!\n(∗•ω•∗)" );
	}
}
