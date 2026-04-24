Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace TiffManipulator
	Public Class Splash : Inherits System.Windows.Forms.Form
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private components As System.ComponentModel.IContainer

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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Splash))
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 3000
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' Splash
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackgroundImage = (CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image))
			Me.ClientSize = New System.Drawing.Size(347, 280)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Splash"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Splash"
			Me.TopMost = True
'			Me.Click += New System.EventHandler(Me.Splash_Click);
'			Me.Paint += New System.Windows.Forms.PaintEventHandler(Me.Splash_Paint);

		End Sub
		#End Region

		Private Sub Splash_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
			ControlPaint.DrawBorder3D(e.Graphics, 0, 0, Me.ClientSize.Width, Me.ClientSize.Height, Border3DStyle.Raised)
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer1.Tick
			Me.Close()
		End Sub

		Private Sub Splash_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
			Me.Close()
		End Sub
	End Class
End Namespace
