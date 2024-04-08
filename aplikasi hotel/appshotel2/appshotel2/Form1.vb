Public Class Form1

    Private Sub cbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        Select Case cbJenis.Text
            Case "Vip"
                txtHarga.Text = 750000
            Case "Kelas I"
                txtHarga.Text = 500000
            Case "Kelas II"
                txtHarga.Text = 300000
            Case "kelas III"
                txtHarga.Text = 140000
        End Select
    End Sub

    Private Sub txtLama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLama.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtBiaya.Focus()

            Dim A, B, C As New Long
            A = Val(txtHarga.Text)
            B = Val(txtLama.Text)

            C = A * B
            txtBiaya.Text = C
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtKembali.Focus()

            Dim D, C, F As New Long
            D = Val(txtJumlah.Text)
            C = Val(txtBiaya.Text)

            F = D - C
            txtKembali.Text = F
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtLama.Focus()

        End If
    End Sub

    Private Sub txtBiaya_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBiaya.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtJumlah.Focus()

        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtNomor.Focus()

        End If
    End Sub

    Private Sub txtNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtAlamat.Focus()

        End If
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub btNew_Click(sender As Object, e As EventArgs) Handles btNew.Click
        Me.txtNama.Text = ""
        Me.txtNomor.Text = ""
        Me.txtAlamat.Text = ""
        Me.cbJenis.Text = ""
        Me.txtHarga.Text = ""
        Me.txtLama.Text = ""
        Me.txtBiaya.Text = ""
        Me.txtJumlah.Text = ""
        Me.txtKembali.Text = ""
        Me.txtNama.Focus()
    End Sub
End Class
