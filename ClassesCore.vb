Imports System.IO

Public Module ClassesCore
    Public Class PetOwner
        Private strUsername As String
        Private strPassword As String
        Public strName As String
        Public intAge As Integer
        Public strSex As String
        Public strAddress As String
        Public petsList As List(Of Pet)

        Public Sub New(ByVal strUsername As String, ByVal strPassword As String, ByVal strName As String, ByVal intAge As Integer, ByVal strSex As String, ByVal strAddress As String, ByVal petsList As List(Of Pet))
            Me.strUsername = strUsername
            Me.strPassword = strPassword
            Me.strName = strName
            Me.intAge = intAge
            Me.strSex = strSex
            Me.strAddress = strAddress
            Me.petsList = petsList
        End Sub

        Public Function getUsername()
            Return strUsername
        End Function

        Public Function getPassword()
            Return strPassword
        End Function

        Public Sub SavePets()
            Using writer As StreamWriter = File.AppendText(strUsername + ".txt")
                For Each pet In petsList
                    writer.WriteLine(pet.strName & "," & pet.intAge & "," & pet.strBirthday & "," & pet.dblWeight & "," & pet.strType & "," & pet.boolVaccinated)
                Next
            End Using
        End Sub

    End Class

    Public Class Pet
        Public strName As String
        Public intAge As Integer
        Public strBirthday As String
        Public dblWeight As Double
        Public strType As String
        Public boolVaccinated As Boolean

        Public Sub New(ByVal strName As String, ByVal intAge As Integer, ByVal strBirthday As String, ByVal dblWeight As Double, ByVal strType As String, boolVaccinated As Boolean)
            Me.strName = strName
            Me.intAge = intAge
            Me.strBirthday = strBirthday
            Me.dblWeight = dblWeight
            Me.strType = strType
            Me.boolVaccinated = boolVaccinated
        End Sub
    End Class
End Module
