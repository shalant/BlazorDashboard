using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Dashboard.Components.Layout;

public partial class MainLayout
{    

    bool _drawerOpen = true;
    private bool _IsDarkMode;
    private bool _isDarkMode;

    bool open = true;

    private MudTheme _theme = new();

    void ToggleDrawer()
	{
		open = !open;
	}

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
            Tertiary = Colors.Red.Accent4,
            AppbarBackground = Colors.BlueGrey.Darken3,
            DrawerBackground = "rgba(240,240,240,0.7)",
            
        },
        PaletteDark = new PaletteDark()
        {
            Primary = Colors.Blue.Darken4,
            Secondary = Colors.Green.Accent4,
            Tertiary = Colors.Red.Accent4,
            AppbarBackground = Colors.Grey.Darken3,
            DrawerBackground = "rgba(240,240,240,0.7)"

        },
        LayoutProperties = new LayoutProperties()
        {
            DrawerWidthLeft = "260px",
            DrawerWidthRight = "300px"
        }
    };
}