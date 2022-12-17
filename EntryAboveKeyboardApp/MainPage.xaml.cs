namespace EntryAboveKeyboardApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void Entry_Focused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        // Decete whethe in iOS platform
        if (DeviceInfo.Platform == DevicePlatform.iOS)
        {
            //iphoneX and above
            if (Height > 800)
            {
                if (Height - SendUI.Y - SendUI.Height < 333)
                {
                    SendUI.TranslateTo(0, -313, 50);

                }
            }
            //lower screen size of iOS
            else
            {
                if (Height - SendUI.Y - SendUI.Height < 258)
                {
                    SendUI.TranslateTo(0, -258, 50);
                }
            }
        }
    }

    void Entry_Unfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        if (DeviceInfo.Platform == DevicePlatform.iOS)
        {
            SendUI.TranslateTo(0, 0, 50);
        }
    }
}


