# Build Instructions

1. Open the solution.
2. Right click the solution in the Solution Explorer and click Restore NuGet Packages.

-----------------

3. Double click Properties, go to Reference Paths, remove any existing reference paths and add your game folder.

OR

3. Edit Stapler.csproj.user to point to your game folder.

------------------

4. Attempt a build and everything should sort itself out. Don't delete the missing reference to Assembly-CSharp, it's not actually missing. Deploy.bat should have automatically copied a debug version of Stapler into your GameData.

