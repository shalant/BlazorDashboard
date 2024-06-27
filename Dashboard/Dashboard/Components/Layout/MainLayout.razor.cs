using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Dashboard.Components.Layout;

public partial class MainLayout
{    

    private bool _drawerOpen = true;
    private bool _IsDarkMode;
    //private MudTheme _theme = new();

    private void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    MudTheme MyCustomTheme = new MudTheme()
    {
        Palette = new PaletteLight()
        {
            Primary = Colors.DeepPurple.Darken2,
            Secondary = Colors.Green.Accent4,
            AppbarBackground = Colors.BlueGrey.Darken3
        },
        PaletteDark = new PaletteDark()
        {
            Primary = Colors.Blue.Darken4,
            Secondary = Colors.Green.Accent4,
            AppbarBackground = Colors.Grey.Darken3
        }
    };
}