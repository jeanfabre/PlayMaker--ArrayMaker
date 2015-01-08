//
// Copyright (c) 2013 Ancient Light Studios
// All Rights Reserved
// 
// http://www.ancientlightstudios.com
//

using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using System.Collections;

[UTDoc(title="View Folder ", description="Open a folder using Finder/Explorer")]
public class UTViewFolder : UTAction
{
	[UTDoc(description="Folder To View")]
	[UTInspectorHint(displayAs=UTInspectorHint.DisplayAs.FolderSelect, caption="Select Folder", required=true)]
	public UTString folder;
	
	public override IEnumerator Execute (UTContext context)
	{
		string realFolder = folder.EvaluateIn (context);
		
		try 
		{
			System.Diagnostics.Process.Start(new FileInfo(realFolder).Directory.FullName);
		}
		catch(Exception e) 
		{
			throw new UTFailBuildException("Opening folder failed. " + e.Message,this);
		}
		
		yield return "";
	}
	
	[MenuItem("Assets/Create/uTomate/View Folder", false, 300)]
	public static void AddAction ()
	{
		Create<UTViewFolder> ();
	}
	
}

