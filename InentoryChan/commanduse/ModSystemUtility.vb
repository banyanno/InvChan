Imports System
Imports System.Net.NetworkInformation
Imports System.IO

Module ModSystemUtility
    Private KhmerInput As InputLanguage
    Private EnglishInput As InputLanguage
    Public Sub ChangeInputLanguageBar()
        KhmerInput = InputLanguage.CurrentInputLanguage
        EnglishInput = InputLanguage.CurrentInputLanguage
        Dim count As Integer
        count = InputLanguage.InstalledInputLanguages.Count
        For i As Integer = 0 To count - 1
            If InputLanguage.InstalledInputLanguages(i).Culture.DisplayName.StartsWith("English") = True Then
                'Found an English Keyboard 

                EnglishInput = InputLanguage.InstalledInputLanguages(i)

            Else
                If InputLanguage.InstalledInputLanguages(i).Culture.DisplayName.StartsWith("Khmer") = True Then
                    'Found an Khmer Keyboard  
                    KhmerInput = InputLanguage.InstalledInputLanguages(i)
                End If
            End If
        Next i
    End Sub
    Public Sub SetKhmerLanguage()
        InputLanguage.CurrentInputLanguage = KhmerInput
    End Sub
    Public Sub SetEnglishLanguage()
        InputLanguage.CurrentInputLanguage = EnglishInput
    End Sub
    Public Function ReductImageSize(ByVal Pic As Image) As Image
        Dim origImage As Bitmap = CType(Pic, Bitmap)
        Dim maxHeight As Integer = 340
        Dim maxWidth As Integer = 170
        Dim origWidth As Integer = origImage.Width
        Dim origHeight As Integer = origImage.Height
        Dim newWidth As Integer = origWidth
        Dim newHeight As Integer = origHeight

        If ((origWidth > maxWidth) And (maxWidth > 0)) Or ((origHeight > maxHeight) And (maxHeight > 0)) Then
            Dim factor As Double = 1
            If (maxWidth > 0) Then
                factor = Math.Min(factor, (maxWidth / origWidth))
            End If
            If (maxHeight > 0) Then
                factor = Math.Min(factor, (maxHeight / origHeight))
            End If
            newWidth = CInt(origWidth * factor)
            newHeight = CInt(origHeight * factor)
        End If
        Dim newImage As Bitmap = New Bitmap(newWidth, newHeight)
        Dim gfx As Graphics = Graphics.FromImage(newImage)

        With gfx
            .CompositingMode = Drawing2D.CompositingMode.SourceOver
            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            .PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            .DrawImage(origImage, 0, 0, newWidth, newHeight)
            .Dispose()
        End With

        ' Dim objStream As New MemoryStream


        ' newImage.Save(objStream, Imaging.ImageFormat.Jpeg)


        Return newImage
    End Function

    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        If byteArrayIn Is Nothing Then
            Return Nothing
        Else
            Dim ms As New MemoryStream(byteArrayIn)
            Dim returnImage As Image = Image.FromStream(ms)
            Return returnImage
        End If
       
    End Function


    Public Function ImageToByArray(ByVal imageIn As System.Drawing.Image)
        Dim ms As New MemoryStream
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray
    End Function
    'Open file in to a filestream and read data in a byte array.
    Function ReadFile(ByVal sPath As String) As Byte()
        'Initialize byte array with a null value initially.
        Dim data As Byte() = Nothing

        'Use FileInfo object to get file size.
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length

        'Open FileStream to read file
        Dim fStream As New FileStream(sPath, FileMode.Open, FileAccess.Read)

        'Use BinaryReader to read file stream into byte array.
        Dim br As New BinaryReader(fStream)

        'When you use BinaryReader, you need to supply number of bytes 
        'to read from file.
        'In this case we want to read entire file. 
        'So supplying total number of bytes.
        data = br.ReadBytes(CInt(numBytes))

        Return data
    End Function

End Module
