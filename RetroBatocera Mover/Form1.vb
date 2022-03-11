Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialization
        If My.Settings.PathRetrobat = "" Then
            My.Settings.PathRetrobat = "C:\"
        Else
            rootpathRetrobat.Text = My.Settings.PathRetrobat
        End If

        If My.Settings.PathBatocera = "" Then
            My.Settings.PathBatocera = "C:\"
        Else
            rootpathbatocera.Text = My.Settings.PathBatocera
        End If

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
        'Moving from RetroBat to Batocera
        If chkromsretrobat.Checked = True Then
            If Retrobatroms.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("RetrobatRoms Folder is empty, can't move it")
            Else
                Dim srcfolder = New DirectoryInfo(Retrobatroms.Text)
                Dim destfolder = New DirectoryInfo(batoceraroms.Text)
                Moveallitemsto(srcfolder, destfolder)
                batoceraroms.BackColor = Color.FromArgb(255, 255, 255)
                batoceraroms.ForeColor = Color.FromArgb(0, 128, 0)

                Retrobatroms.BackColor = Color.FromArgb(172, 172, 172)
                Retrobatroms.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If

        If chkcollectionretrobat.Checked = True Then
            If retrobatcollection.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("RetrobatCollection Folder is empty, can't move it")
            Else
                Dim srcfolder = New DirectoryInfo(retrobatcollection.Text)
                Dim destfolder = New DirectoryInfo(batoceracollection.Text)
                Moveallitemsto(srcfolder, destfolder)
                batoceracollection.BackColor = Color.FromArgb(255, 255, 255)
                batoceracollection.ForeColor = Color.FromArgb(0, 128, 0)

                retrobatcollection.BackColor = Color.FromArgb(172, 172, 172)
                retrobatcollection.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If


        If chksavesretrobat.Checked = True Then
            If retrobatsaves.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("RetrobatSaves Folder is empty, can't move it")
            Else
                Dim srcfolder = New DirectoryInfo(retrobatsaves.Text)
                Dim destfolder = New DirectoryInfo(batocerasaves.Text)
                Moveallitemsto(srcfolder, destfolder)
                batocerasaves.BackColor = Color.FromArgb(255, 255, 255)
                batocerasaves.ForeColor = Color.FromArgb(0, 128, 0)

                retrobatsaves.BackColor = Color.FromArgb(172, 172, 172)
                retrobatsaves.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If

        If chkthemesretrobat.Checked = True Then
            If retrobatthemes.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("BatoceraThemes Folder is empty, can't move it")
            Else
                Dim srcfolder = New DirectoryInfo(retrobatthemes.Text)
                Dim destfolder = New DirectoryInfo(batocerathemes.Text)
                Moveallitemsto(srcfolder, destfolder)
                batocerathemes.BackColor = Color.FromArgb(255, 255, 255)
                batocerathemes.ForeColor = Color.FromArgb(0, 128, 0)

                batocerathemes.BackColor = Color.FromArgb(172, 172, 172)
                batocerathemes.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If

        If chkmusicretrobat.Checked = True Then
            If retrobatmusic.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("RetrobatMusic Folder is empty, can't move it")
            Else
                Dim srcfolder = New DirectoryInfo(retrobatmusic.Text)
                Dim destfolder = New DirectoryInfo(batoceramusic.Text)
                Moveallitemsto(srcfolder, destfolder)
                batoceramusic.BackColor = Color.FromArgb(255, 255, 255)
                batoceramusic.ForeColor = Color.FromArgb(0, 128, 0)

                retrobatmusic.BackColor = Color.FromArgb(172, 172, 172)
                retrobatmusic.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If

        MessageBox.Show("Moved OK")
        wherearethefiles()
    End Sub

    Private Sub FromBatoToRetrobat_Click(sender As Object, e As EventArgs) Handles FromBatoToRetrobat.Click
        'Moving from Batocera to RetroBat
        If chkromsbatocera.Checked = True Then
            If batoceraroms.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("BatoceraRoms Folder is empty, can't move it")

            Else
                Dim srcfolder = New DirectoryInfo(batoceraroms.Text)
                Dim destfolder = New DirectoryInfo(retrobatroms.Text)
                Moveallitemsto(srcfolder, destfolder)
                Retrobatroms.BackColor = Color.FromArgb(255, 255, 255)
                Retrobatroms.ForeColor = Color.FromArgb(0, 128, 0)

                batoceraroms.BackColor = Color.FromArgb(172, 172, 172)
                batoceraroms.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If

        If chkcollectionbatocera.Checked = True Then
            If batoceracollection.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("BatoceraCollection Folder is empty, can't move it")
            Else
                Dim srcfolder = New DirectoryInfo(batoceracollection.Text)
                Dim destfolder = New DirectoryInfo(retrobatcollection.Text)
                Moveallitemsto(srcfolder, destfolder)
                retrobatcollection.BackColor = Color.FromArgb(255, 255, 255)
                retrobatcollection.ForeColor = Color.FromArgb(0, 128, 0)

                batoceracollection.BackColor = Color.FromArgb(172, 172, 172)
                batoceracollection.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If


        If chksavesbatocera.Checked = True Then
            If batocerasaves.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("BatoceraSaves Folder is empty, can't move it")
            Else
                Dim srcfolder = New DirectoryInfo(batocerasaves.Text)
                Dim destfolder = New DirectoryInfo(retrobatsaves.Text)
                Moveallitemsto(srcfolder, destfolder)
                retrobatsaves.BackColor = Color.FromArgb(255, 255, 255)
                retrobatsaves.ForeColor = Color.FromArgb(0, 128, 0)

                batocerasaves.BackColor = Color.FromArgb(172, 172, 172)
                batocerasaves.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If

        If chkthemesbatocera.Checked = True Then
            If batocerathemes.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("BatoceraThemes Folder is empty, can't move it")
            Else
                Dim srcfolder = New DirectoryInfo(batocerathemes.Text)
                Dim destfolder = New DirectoryInfo(retrobatthemes.Text)
                Moveallitemsto(srcfolder, destfolder)
                retrobatthemes.BackColor = Color.FromArgb(255, 255, 255)
                retrobatthemes.ForeColor = Color.FromArgb(0, 128, 0)

                batocerathemes.BackColor = Color.FromArgb(172, 172, 172)
                batocerathemes.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If


        If chkmusicbatocera.Checked = True Then
            If batoceramusic.BackColor = Color.FromArgb(172, 172, 172) Then
                MessageBox.Show("BatoceraMusic Folder is empty, can't move it")
            Else
                Dim srcfolder = New DirectoryInfo(batoceramusic.Text)
                Dim destfolder = New DirectoryInfo(retrobatmusic.Text)
                Moveallitemsto(srcfolder, destfolder)
                retrobatmusic.BackColor = Color.FromArgb(255, 255, 255)
                retrobatmusic.ForeColor = Color.FromArgb(0, 128, 0)

                batoceramusic.BackColor = Color.FromArgb(172, 172, 172)
                batoceramusic.ForeColor = Color.FromArgb(255, 255, 255)
            End If
        End If

        MessageBox.Show("Moved OK")
        wherearethefiles()
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
            batocerathemes.Text = Path.Combine(rootpathbatocera.Text, "themes")
            batoceramusic.Text = Path.Combine(rootpathbatocera.Text, "music")
        End If
    End Sub

    Sub wherearethefiles()
        Dim tailledossierR1 = DirSize(New DirectoryInfo(Retrobatroms.Text))
        Dim tailledossierB1 = DirSize(New DirectoryInfo(batoceraroms.Text))

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

        Dim tailledossierR2 = DirSize(New DirectoryInfo(retrobatcollection.Text))
        Dim tailledossierB2 = DirSize(New DirectoryInfo(batoceracollection.Text))

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

        Dim tailledossierR3 = DirSize(New DirectoryInfo(retrobatsaves.Text))
        Dim tailledossierB3 = DirSize(New DirectoryInfo(batocerasaves.Text))

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

        Dim tailledossierR4 = DirSize(New DirectoryInfo(retrobatthemes.Text))
        Dim tailledossierB4 = DirSize(New DirectoryInfo(batocerathemes.Text))

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

        Dim tailledossierR5 = DirSize(New DirectoryInfo(retrobatmusic.Text))
        Dim tailledossierB5 = DirSize(New DirectoryInfo(batoceramusic.Text))

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
    Public Sub Moveallitemsto(sourcePath As DirectoryInfo, destinationPath As DirectoryInfo)

        If (Not destinationPath.Exists) Then
            destinationPath.Create()
        End If

        'Move all Files
        For Each file As FileInfo In sourcePath.GetFiles()
            If file.Name <> "desktop.ini" Then
                file.MoveTo(Path.Combine(destinationPath.FullName, file.Name))
            End If
        Next

        'Move all folders
        For Each dir As DirectoryInfo In sourcePath.GetDirectories()
            Dim ladest = Path.Combine(destinationPath.FullName, dir.Name)

            If Directory.Exists(ladest) = True Then
                Process.Start("explorer.exe", ladest)
                If MessageBox.Show("Already existing " & ladest & Chr(10) & "Delete it ", "Error", CType(vbYesNo, MessageBoxButtons)) = vbYes Then
                    Directory.Delete(ladest, True)
                Else
                    MessageBox.Show("Please clean and delete your destination Folder and try again")
                    Exit Sub
                End If

            End If
            dir.MoveTo(Path.Combine(destinationPath.FullName, dir.Name))
        Next
    End Sub

    Public Shared Function DirSize(ByVal d As DirectoryInfo) As Long
        Dim Size As Long = 0
        Dim fis As FileInfo() = d.GetFiles()
        Dim fi As FileInfo
        For Each fi In fis
            Size += fi.Length
        Next fi

        ' Add subdirectory sizes.
        Dim dis As DirectoryInfo() = d.GetDirectories()
        Dim di As DirectoryInfo
        For Each di In dis
            Size += DirSize(di)
        Next di
        Return Size
    End Function 'DirSize
End Class


