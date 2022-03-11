Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialization
        If My.Settings.PathRetrobat <> "" Then rootpathRetrobat.Text = My.Settings.PathRetrobat
        If My.Settings.PathBatocera <> "" Then rootpathbatocera.Text = My.Settings.PathBatocera

        'Fill the Paths
        fillthepaths()

        wherearethefiles()
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
        Dim tailledossierR1 = Len(Retrobatroms.Text)
        Dim tailledossierB1 = Len(batoceraroms.Text)

        If tailledossierR1 > tailledossierB1 Then
            Retrobatroms.BackColor = Color.FromArgb(255, 255, 255)
            Retrobatroms.ForeColor = Color.FromArgb(0, 128, 0)

            batoceraroms.BackColor = Color.FromArgb(172, 172, 172)
            batoceraroms.ForeColor = Color.FromArgb(255, 255, 255)
        Else
            batoceraroms.BackColor = Color.FromArgb(255, 255, 255)
            batoceraroms.ForeColor = Color.FromArgb(0, 128, 0)

            Retrobatroms.BackColor = Color.FromArgb(172, 172, 172)
            Retrobatroms.ForeColor = Color.FromArgb(255, 255, 255)
        End If

        Dim tailledossierR2 = Len(retrobatcollection.Text)
        Dim tailledossierB2 = Len(batoceracollection.Text)

        If tailledossierR2 > tailledossierB2 Then
            retrobatcollection.BackColor = Color.FromArgb(255, 255, 255)
            retrobatcollection.ForeColor = Color.FromArgb(0, 128, 0)

            batoceracollection.BackColor = Color.FromArgb(172, 172, 172)
            batoceracollection.ForeColor = Color.FromArgb(255, 255, 255)
        Else
            batoceracollection.BackColor = Color.FromArgb(255, 255, 255)
            batoceracollection.ForeColor = Color.FromArgb(0, 128, 0)

            retrobatcollection.BackColor = Color.FromArgb(172, 172, 172)
            retrobatcollection.ForeColor = Color.FromArgb(255, 255, 255)
        End If

        Dim tailledossierR3 = Len(retrobatsaves.Text)
        Dim tailledossierB3 = Len(batocerasaves.Text)

        If tailledossierR3 > tailledossierB3 Then
            retrobatsaves.BackColor = Color.FromArgb(255, 255, 255)
            retrobatsaves.ForeColor = Color.FromArgb(0, 128, 0)

            batocerasaves.BackColor = Color.FromArgb(172, 172, 172)
            batocerasaves.ForeColor = Color.FromArgb(255, 255, 255)
        Else
            batocerasaves.BackColor = Color.FromArgb(255, 255, 255)
            batocerasaves.ForeColor = Color.FromArgb(0, 128, 0)

            retrobatsaves.BackColor = Color.FromArgb(172, 172, 172)
            retrobatsaves.ForeColor = Color.FromArgb(255, 255, 255)
        End If

        Dim tailledossierR4 = Len(retrobatthemes.Text)
        Dim tailledossierB4 = Len(batocerathemes.Text)

        If tailledossierR4 > tailledossierB4 Then
            retrobatthemes.BackColor = Color.FromArgb(255, 255, 255)
            retrobatthemes.ForeColor = Color.FromArgb(0, 128, 0)

            batocerathemes.BackColor = Color.FromArgb(172, 172, 172)
            batocerathemes.ForeColor = Color.FromArgb(255, 255, 255)
        Else
            batocerathemes.BackColor = Color.FromArgb(255, 255, 255)
            batocerathemes.ForeColor = Color.FromArgb(0, 128, 0)

            retrobatthemes.BackColor = Color.FromArgb(172, 172, 172)
            retrobatthemes.ForeColor = Color.FromArgb(255, 255, 255)
        End If

        Dim tailledossierR5 = Len(retrobatmusic.Text)
        Dim tailledossierB5 = Len(batoceramusic.Text)

        If tailledossierR5 > tailledossierB5 Then
            retrobatmusic.BackColor = Color.FromArgb(255, 255, 255)
            retrobatmusic.ForeColor = Color.FromArgb(0, 128, 0)

            batoceramusic.BackColor = Color.FromArgb(172, 172, 172)
            batoceramusic.ForeColor = Color.FromArgb(255, 255, 255)
        Else
            batoceramusic.BackColor = Color.FromArgb(255, 255, 255)
            batoceramusic.ForeColor = Color.FromArgb(0, 128, 0)

            retrobatmusic.BackColor = Color.FromArgb(172, 172, 172)
            retrobatmusic.ForeColor = Color.FromArgb(255, 255, 255)
        End If
    End Sub
End Class


