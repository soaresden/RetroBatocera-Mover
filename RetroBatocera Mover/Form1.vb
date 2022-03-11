Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialization
        If My.Settings.PathRetrobat <> "" Then rootpathRetrobat.Text = My.Settings.PathRetrobat
        If My.Settings.PathBatocera <> "" Then rootpathbatocera.Text = My.Settings.PathRetrobat

        'Fill the Paths
        fillthepaths()

        'Force creation and check where are the files currently
    End Sub

    Sub checkthefiles()
        If (Directory.Exists(Retrobatroms.Text)) Then

        Else
            Directory.CreateDirectory(Retrobatroms.Text)
        End If
    End Sub
    Private Sub BrowseRetroBat_Click(sender As Object, e As EventArgs) Handles BrowseRetroBat.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.PathRetrobat = FolderBrowserDialog1.SelectedPath.ToString
            My.Settings.Save()
            rootpathRetrobat.Text = FolderBrowserDialog1.SelectedPath.ToString
            fillthepaths()
        End If
    End Sub
    Private Sub Browsebatocera_Click(sender As Object, e As EventArgs) Handles Browsebatocera.Click
        If FolderBrowserDialog2.ShowDialog() = DialogResult.OK Then
            My.Settings.PathBatocera = FolderBrowserDialog2.SelectedPath.ToString
            My.Settings.Save()
            rootpathbatocera.Text = FolderBrowserDialog2.SelectedPath.ToString
            fillthepaths()
        End If
    End Sub
    Private Sub FromRetrobatToBato_Click(sender As Object, e As EventArgs) Handles FromRetrobatToBato.Click

    End Sub

    Private Sub FromBatoToRetrobat_Click(sender As Object, e As EventArgs) Handles FromBatoToRetrobat.Click

    End Sub

    Sub fillthepaths()
        'Fill the full Path
        If rootpathRetrobat.Text <> "" Then
            Retrobatroms.Text = Path.Combine(rootpathRetrobat.Text, "roms")
            retrobatcollection.Text = Path.Combine(rootpathRetrobat.Text, "emulationstation", ".emulationstation", "collections")
            retrobatsaves.Text = Path.Combine(rootpathRetrobat.Text, "saves")
            retrobatthemes.Text = Path.Combine(rootpathRetrobat.Text, "emulationstation", ".emulationstation", "themes")
            retrobatmusic.Text = Path.Combine(rootpathRetrobat.Text, "emulationstation", ".emulationstation", "music")
        End If

        If rootpathbatocera.Text <> "" Then
            batoceraroms.Text = Path.Combine(rootpathbatocera.Text, "roms")
            batoceracollection.Text = Path.Combine(rootpathbatocera.Text, "system", "configs", "emulationstation", "collections")
            batocerasaves.Text = Path.Combine(rootpathbatocera.Text, "saves")
            batocerathemes.Text = Path.Combine(rootpathbatocera.Text, "emulationstation", ".emulationstation", "themes")
            batoceramusic.Text = Path.Combine(rootpathbatocera.Text, "emulationstation", ".emulationstation", "music")
        End If
    End Sub

    Sub wherearethefiles()
        Dim tailledossierR = Len(Retrobatroms.Text)
        Dim tailledossierB = Len(batoceraroms.Text)

    End Sub
End Class


