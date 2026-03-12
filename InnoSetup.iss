#define MyAppName "ArcOS Admin Toolbox"
#define MyAppVersion "1.0.0.0"
#define MyAppPublisher "Izaak Kuipers"
#define MyAppURL "https://izkuipers.nl"
#define MyAppExeName "ReArc.Gui.exe"

[Setup]
AppId={{143AE830-2D12-4864-A179-CC3F4D9FBF21}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
DisableProgramGroupPage=yes
OutputDir=.\ReArc.Gui\bin\Release\Installer
OutputBaseFilename=AdminToolbox-{#MyAppVersion}
SetupIconFile=.\ReArc.Gui\server 1.ico
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: ".\ReArc.Gui\bin\Release\net10.0-windows\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: ".\ReArc.Gui\bin\Release\net10.0-windows\*.*"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

