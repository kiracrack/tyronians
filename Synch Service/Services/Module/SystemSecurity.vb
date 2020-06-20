Imports System.Security.Cryptography
Imports System

Module SystemSecurity

#Region "Encryptor / Decryptor"
    Const sKey As String = "kira"

    Public Function EncryptTripleDES(ByVal sIn As String) As String
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        ' Compute the MD5 hash.
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
        ' Set the cipher mode.
        DES.Mode = CipherMode.ECB
        ' Create the encryptor.
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        ' Get a byte array of the string.
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sIn)
        ' Transform and return the string.
        Return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Function DecryptTripleDES(ByVal sOut As String) As String
        Try
            Dim DES As New TripleDESCryptoServiceProvider()
            Dim hashMD5 As New MD5CryptoServiceProvider()

            ' Compute the MD5 hash.
            DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
            ' Set the cipher mode.
            DES.Mode = CipherMode.ECB
            ' Create the decryptor.
            Dim DESDecrypt As ICryptoTransform = DES.CreateDecryptor()
            Dim Buffer As Byte() = Convert.FromBase64String(sOut)
            ' Transform and return the string.
            Return System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch errMS As Exception

        End Try
    End Function

    Public Function GetProductKey(ByVal dpidDataBlock As Object) As String

        ' This function will retreive the digital product ID from the registry
        ' and decode it into the CD key used to install a Microsoft product.
        ' All that is needed is the registry path to the digital proudct ID block
        ' for the product in question.

        Dim validChars() As String = {"B", "C", "D", "F", "G", "H", "J", "K", "M", _
        "P", "Q", "R", "T", "V", "W", "X", "Y", "2", _
        "3", "4", "6", "7", "8", "9"}

        Dim CDKey As String = ""
        Dim encodedKey(15) As Byte
        Dim digitalProductID As Byte()


        ''Registry Path
        'Const regKey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\"
        '' Get the Digital Product ID data-block from the registry.

        ''############################
        ''ERROR ZONE
        ''This on Win 7 x64 return =0 !!!
        'dpidDataBlock = My.Computer.Registry.GetValue(regKey, "DigitalProductId", 0)
        '############################

        If dpidDataBlock Is Nothing Then Return "Non Available :("

        digitalProductID = DirectCast(dpidDataBlock, Byte())

        ' Extract the encoded CD key (15 bytes) from the digital product ID block.
        For n As Integer = 52 To 67
            encodedKey(n - 52) = digitalProductID(n)
        Next

        ' Decode the CD key.
        ' Note: The actual CD key is not stored in the registry; only the positions
        ' within the validChars() array of the characters that make up the CD key
        ' are stored and encoded.

        For i As Integer = 28 To 0 Step -1
            ' Calculate where the dashes are.
            If ((i + 1) Mod 6) = 0 Then
                CDKey += " - "
            Else
                Dim j As Integer = 0
                For k As Integer = 14 To 0 Step -1
                    Dim Value As Integer = CInt(CLng(j * 2 ^ 8) Or encodedKey(k))
                    encodedKey(k) = CByte(Value \ 24)
                    ' Position within the validChar() array of the character to add to the CD key string.
                    j = Value Mod 24
                Next
                CDKey += validChars(j)
            End If
        Next
        Return StrReverse(CDKey)
    End Function

#End Region

End Module
