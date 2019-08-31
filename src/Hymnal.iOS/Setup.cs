using Hymnal.Core.Services;
using Hymnal.SharedNatives.Services;
using Hymnal.UI.Services;
using MvvmCross;
using MvvmCross.Forms.Platforms.Ios.Core;
using Xamarin.Forms;

namespace Hymnal.iOS
{
    public class Setup : MvxFormsIosSetup<Core.App, UI.App>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            // Native services register
            Mvx.IoCProvider.RegisterType<IFilesService, FilesService>();
            Mvx.IoCProvider.RegisterType<IDataStorageService, DataStorageService>();
            Mvx.IoCProvider.RegisterType<IDialogService, DialogService>();
            Mvx.IoCProvider.RegisterType<IMultilingualService, MultilingualService>();
            Mvx.IoCProvider.RegisterType<IPreferencesService, PreferencesService>();
            Mvx.IoCProvider.RegisterType<IMediaService, MediaService>();
            Mvx.IoCProvider.RegisterType<IAppInformationService, AppInformationService>();
            Mvx.IoCProvider.RegisterType<IConnectivityService, ConnectivityService>();
        }

        public override void InitializePrimary()
        {
            base.InitializePrimary();
            FormsMaterial.Init();
        }
    }
}
