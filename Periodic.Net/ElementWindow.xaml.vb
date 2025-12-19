Public Class ElementWindow
    Public Sub New(title As String, info As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Title = title
        infoTextBlock.Text = info
    End Sub

    Private Sub ElementWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        If My.Computer.Info.OSVersion >= "6.0" Then
            AppHelper.ExtendGlassFrame(Me, New Thickness(-1, -1, -1, -1))
        End If
    End Sub
End Class