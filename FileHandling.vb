Imports System.IO

Public Module FileHandling
    Dim mainDatabaseFilePath As String = "nomVetAccounts.txt"
    Public Function readData(fileName As String)
        Dim lines() As String
        If File.Exists(fileName) Then
            lines = File.ReadAllLines(fileName)
        Else
            MessageBox.Show("No database file found.")
        End If
        Return lines
    End Function

    Sub createDataBaseFile(filename As String)
        Dim databaseFilePath As String = filename

        If Not File.Exists(databaseFilePath) Then
            File.Create(databaseFilePath).Dispose()
        End If
    End Sub

    Public Function ReadPetOwners() As List(Of String)
        Dim petOwnersList As List(Of String)
        Using reader As New System.IO.StreamReader(mainDatabaseFilePath)
            Dim line As String
            Do While reader.Peek() >= 0
                line = reader.ReadLine()
                petOwnersList.Add(line)
            Loop
        End Using
        Return petOwnersList
    End Function

    Public Sub SaveUser(petOwnerObject As PetOwner)
        createDataBaseFile(petOwnerObject.getUsername & ".txt")
        Using writer As StreamWriter = File.AppendText(mainDatabaseFilePath)
            writer.WriteLine(petOwnerObject.getUsername & "," & petOwnerObject.getPassword & "," & petOwnerObject.strName & "," & petOwnerObject.intAge & "," & petOwnerObject.strSex & "," & petOwnerObject.strAddress)
        End Using
    End Sub

    Public Function parseAsPetOwner(line As String) As PetOwner
        Dim parsedStringsList() As String = line.Split(","c)
        Dim username = parsedStringsList(0)
        Dim password = parsedStringsList(1)
        Dim name = parsedStringsList(2)
        Dim age = parsedStringsList(3)
        Dim sex = parsedStringsList(4)
        Dim address = parsedStringsList(5)
        Dim petOwnerObject As New PetOwner(username, password, name, age, sex, address, Nothing)
        Return petOwnerObject
    End Function
End Module
