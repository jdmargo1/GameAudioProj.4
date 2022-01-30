public partial class AkBuildPreprocessor : UnityEditor.Build.IPreprocessBuildWithReport, UnityEditor.Build.IPostprocessBuildWithReport
{
	static partial void GetCustomPlatformName(ref string platformName, UnityEditor.BuildTarget target)
	{
		if(target == UnityEditor.BuildTarget.Android)
		{
			platformName = "Android_High";
		}
	}

}
