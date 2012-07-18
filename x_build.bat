set MSBuild="%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe"
%MSBuild% ENT.sln /tv:4.0 /p:TargetFrameworkVersion=v4.0 /p:Configuration=Release /verbosity:d

pause