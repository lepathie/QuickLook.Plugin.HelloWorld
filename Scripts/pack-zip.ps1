Remove-Item ..\QuickLook.Plugin.UrlViewer.qlplugin -ErrorAction SilentlyContinue

$files = Get-ChildItem -Path ..\bin\Release\ -Exclude *.pdb,*.xml
Compress-Archive $files ..\QuickLook.Plugin.UrlViewer.zip
Move-Item ..\QuickLook.Plugin.UrlViewer.zip ..\QuickLook.Plugin.UrlViewer.qlplugin