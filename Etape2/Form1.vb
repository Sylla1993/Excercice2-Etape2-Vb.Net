Public Class Form1
    Dim affiche As String
    Dim i As Decimal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPrix.Click
        Dim O As Decimal
        Dim P As Decimal
        O = 0
        P = 0
        i = 0
        For Each items In lstproducts.Items

            Afficher(items)

            If (items = "Orange") Then


                O = O + 1
                If O >= 2 Then

                    Afficher(items)
                End If

            ElseIf (items = "pomme") Then
                Afficher(items)
                P = P + 1

            End If


        Next



        lstPrix.Items.Add("[" & affiche & "] =>" & Prix(O, P))
        lstPrix.Items.Add(" ")
        affiche = " "




    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lstproducts.Items.Add("Orange")
    End Sub

    Function Prix(ByVal orange As Decimal, ByVal pomme As Decimal) As Decimal


        i = (orange * 1.25) + (pomme * 0.6)

        Return i

    End Function

    Function Afficher(ByVal liste As String) As String

        affiche += liste + ","

        Return affiche




    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstPrix.Items.Clear()
        lstproducts.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSupProduct.Click
        lstproducts.Items.Remove(lstproducts.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lstproducts.Items.Add("pomme")
    End Sub
End Class
