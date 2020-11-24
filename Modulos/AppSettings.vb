Imports System.Configuration

Public Class AppSettings

    Dim config As Configuration

    Public Sub AppSetting()

        config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    End Sub

    Public Function GetConnectionSring(key As String)

        Return config.ConnectionStrings.ConnectionStrings(key).ConnectionString

    End Function

    Public Sub SaveConnectionString(key As String, value As String)

        config.ConnectionStrings.ConnectionStrings(key).ConnectionString = value
        config.ConnectionStrings.ConnectionStrings(key).ProviderName = "System.Data.OleDb"
        config.Save(ConfigurationSaveMode.Modified)

    End Sub

End Class