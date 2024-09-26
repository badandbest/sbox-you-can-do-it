using Sandbox;
using System.Linq;
using static Sandbox.ResourceLibrary;
namespace Editor;

public class MotivationNotice : NoticeWidget
{
	public string Portrait { get; init; }
	public string Message { get; init; }

	public string Bubble => FileSystem.Mounted.GetFullPath( "portraits/bubble.png" );

	protected override Vector2 SizeHint() => new( 512, 384 );

	public MotivationNotice()
	{
		var personality = Game.Random.FromArray( GetAll<MotivationResource>().ToArray() );

		Portrait = personality.GetPortrait();
		Message = personality.GetMessage();
	}

	protected override void OnPaint()
	{
		Paint.SetPen( Theme.Black );
		Paint.SetDefaultFont( 16 );

		var rect = LocalRect.Align( 350, TextFlag.LeftBottom );
		Paint.Draw( rect, Portrait );

		rect = LocalRect.Align( 250, TextFlag.RightTop );
		Paint.Draw( rect, Bubble );

		rect = rect.Shrink( 0, 0, 0, 55 );
		Paint.DrawText( rect, Message );
	}
}
