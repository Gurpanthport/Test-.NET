Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As SqlConnection
        con = New SqlConnection("server=GURPANTH; database=Inventory; integrated security=true")
        Dim str As String = "select * from stock"
        Dim adpt As New SqlDataAdapter(str, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "stock")
        DataGridView1.DataSource = ds.Tables(0)





    End Sub


    Private Sub addInventory_Click(sender As Object, e As EventArgs) Handles addInventory.Click
        Dim con As SqlConnection
        Dim cmd As New SqlCommand

        'Dim string as String
        con = New SqlConnection("server=GURPANTH; database=Inventory; integrated security=true")
        con.Open()
        cmd.Connection = con
        Dim qty, uName As String

        qty = addQty.Text
        uName = addName.Text
        cmd.CommandText = "INSERT INTO stock VALUES ('" & addQty.Text & "','" & addName.Text & "')"
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub conn_Click(sender As Object, e As EventArgs) Handles conn.Click
        Dim con As SqlConnection


        'Dim string as String
        con = New SqlConnection("server=GURPANTH; database=Inventory; integrated security=true")
        con.Open()
        If (con.State = ConnectionState.Open) Then
            MessageBox.Show("Connected")
        End If
        con.Close()


    End Sub
End Class
