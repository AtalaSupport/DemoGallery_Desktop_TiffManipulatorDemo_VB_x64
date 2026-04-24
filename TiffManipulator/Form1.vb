Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports Atalasoft.Imaging
Imports Atalasoft.Imaging.Codec
Imports Atalasoft.Imaging.Codec.Tiff
Imports Atalasoft.Imaging.WinControls

Namespace TiffManipulator
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem

		Private _currentFile As String = Nothing
		Private _instructionForm As Form
		Private WithEvents saveItem As System.Windows.Forms.MenuItem
		Private WithEvents quitItem As System.Windows.Forms.MenuItem
		Private WithEvents addFileItem As System.Windows.Forms.MenuItem
		Private WithEvents fileList As System.Windows.Forms.ListBox
		Private WithEvents thumbnailView1 As Atalasoft.Imaging.WinControls.ThumbnailView
		Private menuItem4 As System.Windows.Forms.MenuItem
		Private menuHelp As System.Windows.Forms.MenuItem
		Private WithEvents menuAbout As System.Windows.Forms.MenuItem
		Private panelBanner As System.Windows.Forms.Panel
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents linkHomePage As System.Windows.Forms.LinkLabel
		Private WithEvents panelEdge As System.Windows.Forms.Panel
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem

		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			Dim frm As Splash = New Splash()
			frm.Show()

			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.mainMenu1 = New System.Windows.Forms.MainMenu()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.addFileItem = New System.Windows.Forms.MenuItem()
			Me.saveItem = New System.Windows.Forms.MenuItem()
			Me.menuItem4 = New System.Windows.Forms.MenuItem()
			Me.quitItem = New System.Windows.Forms.MenuItem()
			Me.menuHelp = New System.Windows.Forms.MenuItem()
			Me.menuAbout = New System.Windows.Forms.MenuItem()
			Me.fileList = New System.Windows.Forms.ListBox()
			Me.thumbnailView1 = New Atalasoft.Imaging.WinControls.ThumbnailView()
			Me.panelBanner = New System.Windows.Forms.Panel()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.linkHomePage = New System.Windows.Forms.LinkLabel()
			Me.panelEdge = New System.Windows.Forms.Panel()
			Me.menuItem2 = New System.Windows.Forms.MenuItem()
			Me.panelBanner.SuspendLayout()
			Me.SuspendLayout()
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1, Me.menuHelp})
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 0
			Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.addFileItem, Me.saveItem, Me.menuItem4, Me.quitItem})
			Me.menuItem1.Text = "&File"
			' 
			' addFileItem
			' 
			Me.addFileItem.Index = 0
			Me.addFileItem.Text = "&Add File..."
'			Me.addFileItem.Click += New System.EventHandler(Me.addFileItem_Click);
			' 
			' saveItem
			' 
			Me.saveItem.Index = 1
			Me.saveItem.Text = "&Save As..."
'			Me.saveItem.Click += New System.EventHandler(Me.saveItem_Click);
			' 
			' menuItem4
			' 
			Me.menuItem4.Index = 2
			Me.menuItem4.Text = "-"
			' 
			' quitItem
			' 
			Me.quitItem.Index = 3
			Me.quitItem.Text = "&Quit"
'			Me.quitItem.Click += New System.EventHandler(Me.quitItem_Click);
			' 
			' menuHelp
			' 
			Me.menuHelp.Index = 1
			Me.menuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem2, Me.menuAbout})
			Me.menuHelp.Text = "&Help"
			' 
			' menuAbout
			' 
			Me.menuAbout.Index = 1
			Me.menuAbout.Text = "&About..."
'			Me.menuAbout.Click += New System.EventHandler(Me.menuAbout_Click);
			' 
			' fileList
			' 
			Me.fileList.Dock = System.Windows.Forms.DockStyle.Right
			Me.fileList.IntegralHeight = False
			Me.fileList.Location = New System.Drawing.Point(400, 43)
			Me.fileList.Name = "fileList"
			Me.fileList.Size = New System.Drawing.Size(208, 438)
			Me.fileList.TabIndex = 1
'			Me.fileList.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.fileList_KeyDown);
			' 
			' thumbnailView1
			' 
			Me.thumbnailView1.AutoDragDrop = True
			Me.thumbnailView1.BackColor = System.Drawing.SystemColors.Window
			Me.thumbnailView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.thumbnailView1.DragSelectionColor = System.Drawing.Color.Red
			Me.thumbnailView1.DropPositionIndicator = Atalasoft.Imaging.WinControls.ThumbnailDropPositionIndicator.IBeam
			Me.thumbnailView1.ForeColor = System.Drawing.SystemColors.WindowText
			Me.thumbnailView1.HighlightBackgroundColor = System.Drawing.SystemColors.Highlight
			Me.thumbnailView1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
			Me.thumbnailView1.LoadErrorMessage = ""
			Me.thumbnailView1.Location = New System.Drawing.Point(0, 43)
			Me.thumbnailView1.Margins = New Atalasoft.Imaging.WinControls.Margin(4, 4, 4, 4)
			Me.thumbnailView1.Name = "thumbnailView1"
			Me.thumbnailView1.SelectionRectangleBackColor = System.Drawing.Color.Transparent
			Me.thumbnailView1.SelectionRectangleDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
			Me.thumbnailView1.SelectionRectangleLineColor = System.Drawing.Color.Black
			Me.thumbnailView1.Size = New System.Drawing.Size(400, 438)
			Me.thumbnailView1.TabIndex = 0
			Me.thumbnailView1.Text = "thumbnailView1"
			Me.thumbnailView1.ThumbnailBackground = Nothing
			Me.thumbnailView1.ThumbnailOffset = New System.Drawing.Point(0, 0)
			Me.thumbnailView1.ThumbnailSize = New System.Drawing.Size(100, 100)
'			Me.thumbnailView1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.thumbnailView1_KeyDown);
			' 
			' panelBanner
			' 
			Me.panelBanner.BackColor = System.Drawing.Color.White
			Me.panelBanner.Controls.Add(Me.linkHomePage)
			Me.panelBanner.Controls.Add(Me.pictureBox2)
			Me.panelBanner.Controls.Add(Me.pictureBox1)
			Me.panelBanner.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelBanner.Location = New System.Drawing.Point(0, 0)
			Me.panelBanner.Name = "panelBanner"
			Me.panelBanner.Size = New System.Drawing.Size(608, 40)
			Me.panelBanner.TabIndex = 2
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(16, -8)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(64, 48)
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' pictureBox2
			' 
			Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
			Me.pictureBox2.Image = (CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image))
			Me.pictureBox2.Location = New System.Drawing.Point(68, 0)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(144, 40)
			Me.pictureBox2.TabIndex = 1
			Me.pictureBox2.TabStop = False
			' 
			' linkHomePage
			' 
			Me.linkHomePage.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.linkHomePage.Location = New System.Drawing.Point(470, 13)
			Me.linkHomePage.Name = "linkHomePage"
			Me.linkHomePage.Size = New System.Drawing.Size(128, 16)
			Me.linkHomePage.TabIndex = 2
			Me.linkHomePage.TabStop = True
			Me.linkHomePage.Text = "http://www.atalasoft.com"
'			Me.linkHomePage.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.linkHomePage_LinkClicked);
			' 
			' panelEdge
			' 
			Me.panelEdge.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelEdge.Location = New System.Drawing.Point(0, 40)
			Me.panelEdge.Name = "panelEdge"
			Me.panelEdge.Size = New System.Drawing.Size(608, 3)
			Me.panelEdge.TabIndex = 3
'			Me.panelEdge.Paint += New System.Windows.Forms.PaintEventHandler(Me.panelEdge_Paint);
			' 
			' menuItem2
			' 
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "&Instructions"
'			Me.menuItem2.Click += New System.EventHandler(Me.menuItem2_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(608, 481)
			Me.Controls.Add(Me.thumbnailView1)
			Me.Controls.Add(Me.fileList)
			Me.Controls.Add(Me.panelEdge)
			Me.Controls.Add(Me.panelBanner)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Menu = Me.mainMenu1
			Me.MinimumSize = New System.Drawing.Size(350, 250)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Atalasoft Tiff Manipulator"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.panelBanner.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.DoEvents()
			Application.Run(New Form1())
		End Sub

		Private Sub addFileItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles addFileItem.Click
			Dim ofd As OpenFileDialog = New OpenFileDialog()
			ofd.Filter = "TIFF Images (*.tif)|*.tif"
			If ofd.ShowDialog() = DialogResult.OK Then
				If CanOpenThisFileAsTiff(ofd.FileName) Then
					If AlreadyAddedFile(ofd.FileName) Then
						MessageBox.Show("This file is already in the collection.")
					Else
						_currentFile = ofd.FileName
						OnFileAdded(ofd.FileName)
					End If
				Else
					MessageBox.Show("Unable to open the file - it might not be a TIFF or it might be damaged.")
				End If
			End If
		End Sub

		Private Function AlreadyAddedFile(ByVal fileName As String) As Boolean
			For Each o As Object In fileList.Items
				Dim pair As FileFramePair = CType(o, FileFramePair)
				If pair.FileName = fileName Then
					Return True
				End If
			Next o
			Return False
		End Function

		Private Function CanOpenThisFileAsTiff(ByVal fname As String) As Boolean
			Try
'INSTANT VB NOTE: The following 'using' block is replaced by its pre-VB.NET 2005 equivalent:
'				using (FileStream stm = New FileStream(fname, FileMode.Open))
				Dim stm As FileStream = New FileStream(fname, FileMode.Open)
				Try
					' if we can get image info, we can probably do something with the file
					Dim decoder As TiffDecoder = New TiffDecoder()
					Dim info As ImageInfo = decoder.GetImageInfo(stm)
					Return True
				Finally
					Dim disp As IDisposable = stm
					disp.Dispose()
				End Try
'INSTANT VB NOTE: End of the original C# 'using' block
			Catch
				Return False
			End Try
		End Function

		Private Sub OnFileAdded(ByVal fileName As String)
			Try
				Dim info As ImageInfo = RegisteredDecoders.GetImageInfo(fileName)
				Dim offset As Integer = thumbnailView1.Items.Count
				Dim i As Integer=0
'ORIGINAL LINE: for (int i=0; i < info.FrameCount; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
				Do While i < info.FrameCount
					Dim pair As FileFramePair = New FileFramePair(fileName, i)
					thumbnailView1.Items.Add(fileName, i, pair.ToString() & Constants.vbLf & "Page " & i)
					thumbnailView1.Items(offset + i).Tag = pair
					i += 1
				Loop
			Catch
			End Try
			fileList.Items.Add(New FileFramePair(fileName, 0))
		End Sub

		Private Sub saveItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles saveItem.Click
			If thumbnailView1.Items.Count > 0 Then
				Dim sfd As SaveFileDialog = New SaveFileDialog()
				sfd.Filter = "TIFF Image (*.tif)|*.tif"
				If sfd.ShowDialog() = DialogResult.OK Then
					If AlreadyAddedFile(sfd.FileName) Then
						MessageBox.Show("Can't save over one of the source files.")
					Else
						SaveTo(sfd.FileName)
					End If
				End If
			End If
		End Sub

		Private Function MakeTiffDocuments() As TiffDocument()
			Dim arr As TiffDocument() = New TiffDocument(fileList.Items.Count - 1) {}
			Dim i As Integer=0
'ORIGINAL LINE: for (int i=0; i < arr.Length; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < arr.Length
				Dim pair As FileFramePair = CType(fileList.Items(i), FileFramePair)
				arr(i) = New TiffDocument(pair.FileName)
				i += 1
			Loop
			Return arr
		End Function

		Private Function GetTiffDocument(ByVal fileName As String, ByVal originals As TiffDocument()) As TiffDocument
			Dim i As Integer=0
'ORIGINAL LINE: for (int i=0; i < fileList.Items.Count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < fileList.Items.Count
				If (CType(fileList.Items(i), FileFramePair)).FileName = fileName Then
					Return originals(i)
				End If
				i += 1
			Loop
			Return Nothing
		End Function

		Private Sub SaveTo(ByVal fileName As String)
			' get a doc for the original
			Dim originals As TiffDocument() = MakeTiffDocuments()
			Dim final As TiffDocument = New TiffDocument()
			Try
				' build final from the thumb's Tag object
				For Each thumb As Thumbnail In thumbnailView1.Items
					Dim fileFrame As FileFramePair = CType(thumb.Tag, FileFramePair)
					Dim original As TiffDocument = GetTiffDocument(fileFrame.FileName, originals)
					If original Is Nothing Then
						MessageBox.Show("Unable to find the original source file " & fileFrame.ToString() & " - this should never happen - skipping file.")
						GoTo Continue1
					End If
					final.Pages.Add(original.Pages(fileFrame.Frame))
					Continue1:
				Next thumb
'INSTANT VB NOTE: The following 'using' block is replaced by its pre-VB.NET 2005 equivalent:
'				using (FileStream stm = New FileStream(fileName, FileMode.Create))
				Dim stm As FileStream = New FileStream(fileName, FileMode.Create)
				Try
					final.Save(stm)
				Finally
					Dim disp As IDisposable = stm
					disp.Dispose()
				End Try
'INSTANT VB NOTE: End of the original C# 'using' block
			Finally
				' close the original stream
				For Each doc As TiffDocument In originals
					doc.Pages(0).Stream.Close()
				Next doc
			End Try
		End Sub

		Private Sub quitItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles quitItem.Click
			Application.Exit()
		End Sub

		Private Sub thumbnailView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles thumbnailView1.KeyDown
			If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
				DeleteItems(thumbnailView1.SelectedItems)
			End If
		End Sub

		Private Sub DeleteItems(ByVal coll As SelectedThumbnailCollection)
			If coll Is Nothing OrElse coll.Count = 0 Then
				Return
			End If

			Dim thumbs As Thumbnail() = New Thumbnail(coll.Count - 1) {}
			coll.CopyTo(thumbs)
			thumbnailView1.Items.Remove(thumbs)
		End Sub

		Private Sub fileList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fileList.KeyDown
			If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
				DeleteFileItems(fileList.SelectedItems)
			End If
		End Sub

		Private Function GetFileThumbs(ByVal pair As FileFramePair) As Thumbnail()
			Dim list As ArrayList = New ArrayList()
			For Each thumb As Thumbnail In thumbnailView1.Items
				If (CType(thumb.Tag, FileFramePair)).FileName = pair.FileName Then
					list.Add(thumb)
				End If
			Next thumb
			Return CType(list.ToArray(GetType(Thumbnail)), Thumbnail())
		End Function

		Private Sub DeleteFileItems(ByVal coll As System.Windows.Forms.ListBox.SelectedObjectCollection)
			If coll Is Nothing OrElse coll.Count = 0 Then
				Return
			End If

			Dim i As Integer=0
'ORIGINAL LINE: for (int i=0; i < coll.Count; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < coll.Count
				Dim pair As FileFramePair = CType(coll(i), FileFramePair)
				Dim thumbs As Thumbnail() = GetFileThumbs(pair)
				thumbnailView1.Items.Remove(thumbs)
				fileList.Items.Remove(pair)
				i += 1
			Loop
		End Sub

		Private Sub menuAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuAbout.Click
            Dim aboutBox As AtalaDemos.AboutBox.About = New AtalaDemos.AboutBox.About("About Atalasoft TIFF Manipulator Demo", "TIFF Manipulator Demo")
            aboutBox.Description = "Demonstrates page manipulation on TIFF Files including features such as reorder pages, remove pages, combine multiple files, and save the result. This is a Windows Forms application."
            aboutBox.ShowDialog()
		End Sub

		Private Sub panelEdge_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelEdge.Paint
			ControlPaint.DrawBorder3D(e.Graphics, panelEdge.ClientRectangle, Border3DStyle.Etched, Border3DSide.Bottom)
		End Sub

		Private Sub linkHomePage_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkHomePage.LinkClicked
			System.Diagnostics.Process.Start("http://www.atalasoft.com")
		End Sub

		Private Sub ShowInstructions()
			If _instructionForm Is Nothing Then
				_instructionForm = New Instructions()
				AddHandler _instructionForm.Disposed, AddressOf _instructionForm_Disposed
			End If

			_instructionForm.Show()
		End Sub

		Private Sub _instructionForm_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			_instructionForm = Nothing
		End Sub

		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
			ShowInstructions()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			' Add a slight pause.
			System.Threading.Thread.Sleep(500)

			Dim show As Boolean = True
			Dim settings As String = Application.UserAppDataPath & "\TiffManipulatorSettings.txt"
			If System.IO.File.Exists(settings) Then
'INSTANT VB NOTE: The following 'using' block is replaced by its pre-VB.NET 2005 equivalent:
'				using (System.IO.FileStream reader = New System.IO.FileStream(settings, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
				Dim reader As System.IO.FileStream = New System.IO.FileStream(settings, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
				Try
					show = (reader.ReadByte() = 1)
				Finally
					Dim disp As IDisposable = reader
					disp.Dispose()
				End Try
'INSTANT VB NOTE: End of the original C# 'using' block
			End If

			If show Then
			ShowInstructions()
			End If
		End Sub
	End Class
End Namespace
