Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace TiffManipulator
	''' <summary>
	''' Summary description for Instructions.
	''' </summary>
	Public Class Instructions : Inherits System.Windows.Forms.Form
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private label1 As System.Windows.Forms.Label
		Private rtfInstructions As System.Windows.Forms.RichTextBox
		Private WithEvents chkShowAtStartup As System.Windows.Forms.CheckBox
		Private WithEvents btnClose As System.Windows.Forms.Button
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
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
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Instructions))
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.rtfInstructions = New System.Windows.Forms.RichTextBox()
			Me.chkShowAtStartup = New System.Windows.Forms.CheckBox()
			Me.btnClose = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(11, 12)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(28, 31)
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' label1
			' 
			Me.label1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(60, 13)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(410, 31)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Tiff Manipulator Instructions"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' rtfInstructions
			' 
			Me.rtfInstructions.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.rtfInstructions.Location = New System.Drawing.Point(21, 55)
			Me.rtfInstructions.Name = "rtfInstructions"
			Me.rtfInstructions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
			Me.rtfInstructions.Size = New System.Drawing.Size(480, 146)
			Me.rtfInstructions.TabIndex = 2
			Me.rtfInstructions.Text = ""
			' 
			' chkShowAtStartup
			' 
			Me.chkShowAtStartup.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.chkShowAtStartup.Checked = True
			Me.chkShowAtStartup.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chkShowAtStartup.Location = New System.Drawing.Point(21, 216)
			Me.chkShowAtStartup.Name = "chkShowAtStartup"
			Me.chkShowAtStartup.Size = New System.Drawing.Size(109, 16)
			Me.chkShowAtStartup.TabIndex = 3
			Me.chkShowAtStartup.Text = "Show at startup"
'			Me.chkShowAtStartup.CheckedChanged += New System.EventHandler(Me.chkShowAtStartup_CheckedChanged);
			' 
			' btnClose
			' 
			Me.btnClose.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.btnClose.Location = New System.Drawing.Point(422, 213)
			Me.btnClose.Name = "btnClose"
			Me.btnClose.Size = New System.Drawing.Size(79, 25)
			Me.btnClose.TabIndex = 4
			Me.btnClose.Text = "Close"
'			Me.btnClose.Click += New System.EventHandler(Me.btnClose_Click);
			' 
			' Instructions
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(527, 249)
			Me.Controls.Add(Me.btnClose)
			Me.Controls.Add(Me.chkShowAtStartup)
			Me.Controls.Add(Me.rtfInstructions)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.pictureBox1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
			Me.MinimumSize = New System.Drawing.Size(375, 275)
			Me.Name = "Instructions"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Instructions"
			Me.TopMost = True
'			Me.Load += New System.EventHandler(Me.Instructions_Load);
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private Sub chkShowAtStartup_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowAtStartup.CheckedChanged
			If _loading Then
			Return
			End If
			Dim settings As String = Application.UserAppDataPath & "\TiffManipulatorSettings.txt"
'INSTANT VB NOTE: The following 'using' block is replaced by its pre-VB.NET 2005 equivalent:
'			using (System.IO.FileStream writer = New System.IO.FileStream(settings, System.IO.FileMode.Create, System.IO.FileAccess.Write))
			Dim writer As System.IO.FileStream = New System.IO.FileStream(settings, System.IO.FileMode.Create, System.IO.FileAccess.Write)
			Try
				If Me.chkShowAtStartup.Checked Then
					writer.WriteByte(CByte(1))
				Else
					writer.WriteByte(CByte(0))
				End If
			Finally
				Dim disp As IDisposable = writer
				disp.Dispose()
			End Try
'INSTANT VB NOTE: End of the original C# 'using' block
		End Sub

		Private _loading As Boolean
		Private Sub Instructions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
			Dim stream As System.IO.Stream = asm.GetManifestResourceStream("Instructions.rtf")
			If Not stream Is Nothing Then
				Me.rtfInstructions.LoadFile(stream, RichTextBoxStreamType.RichText)
				stream.Close()
			End If

			_loading = True
			Dim settings As String = Application.UserAppDataPath & "\TiffManipulatorSettings.txt"
			If System.IO.File.Exists(settings) Then
'INSTANT VB NOTE: The following 'using' block is replaced by its pre-VB.NET 2005 equivalent:
'				using (System.IO.FileStream reader = New System.IO.FileStream(settings, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
				Dim reader As System.IO.FileStream = New System.IO.FileStream(settings, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)
				Try
					Me.chkShowAtStartup.Checked = (reader.ReadByte() = 1)
				Finally
					Dim disp As IDisposable = reader
					disp.Dispose()
				End Try
'INSTANT VB NOTE: End of the original C# 'using' block
			End If
			_loading = False
		End Sub

		Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
			Me.Close()
		End Sub
	End Class
End Namespace
