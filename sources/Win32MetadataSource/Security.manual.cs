using System;
using System.Runtime.InteropServices;
using Windows.Win32.Interop;

namespace Windows.Win32.Security
{
    [Flags]
    public enum CREDUI_FLAGS
    {
        CREDUI_FLAGS_ALWAYS_SHOW_UI = 0x00080,
        CREDUI_FLAGS_COMPLETE_USERNAME = 0x00800,
        CREDUI_FLAGS_DO_NOT_PERSIST = 0x00002,
        CREDUI_FLAGS_EXCLUDE_CERTIFICATES = 0x00008,
        CREDUI_FLAGS_EXPECT_CONFIRMATION = 0x20000,
        CREDUI_FLAGS_GENERIC_CREDENTIALS = 0x40000,
        CREDUI_FLAGS_INCORRECT_PASSWORD = 0x00001,
        CREDUI_FLAGS_KEEP_USERNAME = 0x100000,
        CREDUI_FLAGS_PASSWORD_ONLY_OK = 0x00200,
        CREDUI_FLAGS_PERSIST = 0x01000,
        CREDUI_FLAGS_REQUEST_ADMINISTRATOR = 0x00004,
        CREDUI_FLAGS_REQUIRE_CERTIFICATE = 0x00010,
        CREDUI_FLAGS_REQUIRE_SMARTCARD = 0x00100,
        CREDUI_FLAGS_SERVER_CREDENTIAL = 0x04000,
        CREDUI_FLAGS_SHOW_SAVE_CHECK_BOX = 0x00040,
        CREDUI_FLAGS_USERNAME_TARGET_CREDENTIALS = 0x80000,
        CREDUI_FLAGS_VALIDATE_USERNAME = 0x00400
    }

    [Flags]
    public enum CREDUIWIN
    {
        CREDUIWIN_GENERIC = 0x00000001,
        CREDUIWIN_CHECKBOX = 0x00000002,
        CREDUIWIN_AUTHPACKAGE_ONLY = 0x00000010,
        CREDUIWIN_IN_CRED_ONLY = 0x00000020,
        CREDUIWIN_ENUMERATE_ADMINS = 0x00000100,
        CREDUIWIN_ENUMERATE_CURRENT_USER = 0x00000200,
        CREDUIWIN_SECURE_PROMPT = 0x00001000,
        CREDUIWIN_PREPROMPTING = 0X00002000,
        CREDUIWIN_PACK_32_WOW = 0x10000000
    }
}
