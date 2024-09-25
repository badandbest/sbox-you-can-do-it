using Editor;

public static class MyEditorMenu
{
	[Menu( "Editor", "You Can Do It/My Menu Option" )]
	public static void OpenMyMenu()
	{
		//EditorUtility.DisplayDialog( "It worked!", "This is being called from your library's editor code!" );
		new MotivationNotice();
	}
}
