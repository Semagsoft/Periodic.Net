Public Class AboutDialog

    Private Sub AboutDialog_Loaded(sender As Object, e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        If My.Computer.Info.OSVersion >= "6.0" Then
            AppHelper.ExtendGlassFrame(Me, New Thickness(-1, -1, -1, -1))
        End If
        NameTextBlock.Text = My.Application.Info.ProductName
        VersionTextBlock.Text = "Version: " + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
        CopyrightTextBlock.Text = My.Application.Info.Copyright
    End Sub
End Class