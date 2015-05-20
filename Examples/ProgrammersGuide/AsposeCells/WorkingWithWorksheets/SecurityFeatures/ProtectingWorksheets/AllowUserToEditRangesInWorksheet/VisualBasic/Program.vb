'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace AllowUserToEditRangesInWorksheet
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Instantiate a new Workbook
			Dim book As New Workbook()

			'Get the first (default) worksheet
			Dim sheet As Worksheet = book.Worksheets(0)

			'Get the Allow Edit Ranges
			Dim allowRanges As ProtectedRangeCollection = sheet.AllowEditRanges

			'Define ProtectedRange
			Dim proteced_range As ProtectedRange

			'Create the range
			Dim idx As Integer = allowRanges.Add("r2", 1, 1, 3, 3)
			proteced_range = allowRanges(idx)

			'Specify the passoword
			proteced_range.Password = "123"

			'Protect the sheet
			sheet.Protect(ProtectionType.All)

			'Save the Excel file
			book.Save(dataDir & "protectedrange.xls")

		End Sub
	End Class
End Namespace