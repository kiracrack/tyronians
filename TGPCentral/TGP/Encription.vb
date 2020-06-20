Imports System.Security.Cryptography
Imports System.Text

Module Encription
    Public Function Encrypt(ByVal data As String, ByVal key As String) As String
        Dim rijndaelCipher As RijndaelManaged = New RijndaelManaged()
        rijndaelCipher.Mode = CipherMode.CBC
        rijndaelCipher.Padding = PaddingMode.PKCS7
        rijndaelCipher.KeySize = &H80
        rijndaelCipher.BlockSize = &H80
        Dim pwdBytes As Byte() = Encoding.UTF8.GetBytes(key)
        Dim keyBytes As Byte() = New Byte(15) {}
        Dim len As Integer = pwdBytes.Length

        If len > keyBytes.Length Then
            len = keyBytes.Length
        End If

        Array.Copy(pwdBytes, keyBytes, len)
        rijndaelCipher.Key = keyBytes
        rijndaelCipher.IV = keyBytes
        Dim transform As ICryptoTransform = rijndaelCipher.CreateEncryptor()
        Dim plainText As Byte() = Encoding.UTF8.GetBytes(data)
        Return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length))
    End Function

    Public Function Decrypt(ByVal data As String, ByVal key As String) As String
        Dim rijndaelCipher As RijndaelManaged = New RijndaelManaged()
        rijndaelCipher.Mode = CipherMode.CBC
        rijndaelCipher.Padding = PaddingMode.PKCS7
        rijndaelCipher.KeySize = &H80
        rijndaelCipher.BlockSize = &H80
        Dim encryptedData As Byte() = Convert.FromBase64String(data)
        Dim pwdBytes As Byte() = Encoding.UTF8.GetBytes(key)
        Dim keyBytes As Byte() = New Byte(15) {}
        Dim len As Integer = pwdBytes.Length

        If len > keyBytes.Length Then
            len = keyBytes.Length
        End If

        Array.Copy(pwdBytes, keyBytes, len)
        rijndaelCipher.Key = keyBytes
        rijndaelCipher.IV = keyBytes
        Dim plainText As Byte() = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length)
        Return Encoding.UTF8.GetString(plainText)
    End Function
End Module
