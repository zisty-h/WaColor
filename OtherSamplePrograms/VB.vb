Imports System.Drawing

Public Structure WaColor
    Public Structure Macha
        Public Shared Light As Color = Color.FromArgb(67, 178, 67)  ' #43B243
        Public Shared Normal As Color = Color.FromArgb(0, 119, 0)    ' #007700
        Public Shared Deep As Color = Color.FromArgb(0, 64, 0)       ' #004000
    End Structure

    Public Structure Azuki
        Public Shared Light As Color = Color.FromArgb(117, 0, 0)      ' #750000
        Public Shared Normal As Color = Color.FromArgb(135, 51, 51)    ' #873333
        Public Shared Deep As Color = Color.FromArgb(158, 67, 67)      ' #9E4343
    End Structure

    Public Structure Kinako
        Public Shared Light As Color = Color.FromArgb(150, 142, 0)     ' #968E00
        Public Shared Normal As Color = Color.FromArgb(183, 176, 33)    ' #B7B021
        Public Shared Deep As Color = Color.FromArgb(216, 210, 82)      ' #D8D252
    End Structure

    Public Structure Sora
        Public Shared Light As Color = Color.FromArgb(0, 99, 114)       ' #006372
        Public Shared Normal As Color = Color.FromArgb(0, 139, 160)      ' #008BA0
        Public Shared Deep As Color = Color.FromArgb(69, 186, 204)       ' #45BACC
    End Structure
End Structure
