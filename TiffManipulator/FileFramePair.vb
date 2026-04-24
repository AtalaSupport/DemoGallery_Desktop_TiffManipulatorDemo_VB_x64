Imports Microsoft.VisualBasic
Imports System
Imports System.IO

Namespace TiffManipulator
	''' <summary>
	''' Summary description for FileFramePair.
	''' </summary>
	Public Structure FileFramePair
		Private _fileName As String
		Private _frame As Integer

'INSTANT VB NOTE: The parameter fileName was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
'INSTANT VB NOTE: The parameter frame was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal fileName_Renamed As String, ByVal frame_Renamed As Integer)
			_fileName = fileName_Renamed
			_frame = frame_Renamed
		End Sub

		Public Property FileName() As String
			Get
				Return _fileName
			End Get
			Set
				_fileName = Value
			End Set
		End Property
		Public Property Frame() As Integer
			Get
				Return _frame
			End Get
			Set
				_frame = Value
			End Set
		End Property
		Public Overrides Function ToString() As String
			Return Path.GetFileName(_fileName)
		End Function

	End Structure
End Namespace
