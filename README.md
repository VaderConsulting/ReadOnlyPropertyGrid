# ReadOnlyPropertyGrid

C# WinForms `PropertyGrid` subclass (`RPropertyGrid`) by Rajeev Ravindranath that can show a selected object as read-only. A `ReadOnly` flag wraps descriptors so the grid displays values without editing. The test project hosts nested sample objects and checkboxes to toggle read-only and swap the selected object. This is Dave Robinson's Historical Dev working copy, not original VaderConsulting code.

**Source last updated:** 2015-06-06  
**Language:** C#  
**Target:** .NET 4.0  
**Output:** class library + WinForms test exe

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `Rajeev.Windows.Forms` | C# | class library (.NET 4.0) | `RPropertyGrid` read-only PropertyGrid |
| `ReadOnlyPropertyGridTest` | C# | WinForms exe (.NET 4.0) | Demo form toggling ReadOnly on nested test objects |

## How to open

Open `ReadOnlyPropertyGridTest/ReadOnlyPropertyGridTest.sln` to run the demo (it references the library). Open `Rajeev.Windows.Forms/Rajeev.Windows.Forms.sln` for the control project alone.

## Requirements

- Visual Studio 2010 to 2013, .NET Framework 4.0

## Attribution and provenance

Working copy from my Historical Dev folder.

From Dave Robinson's Historical Dev archive (OneDrive folder `ReadOnlyPropertyGrid`). Author: Rajeev Ravindranath. See `THIRD_PARTY_NOTICES.md`. Non-commercial custom terms in the source headers; not relicensed as original VaderConsulting code.

## License

Third-party terms as in the source headers. Catalogue/wrapper files MIT License. Copyright (c) 2026 VaderConsulting.
