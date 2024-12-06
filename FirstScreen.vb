Public Class FirstScreen

    Public RhinoFile As Boolean = False
    Public EtabsFile As Boolean = False
    Public RAMFile As Boolean = False

    Public Sub EtabsSplash_Click(sender As Object, e As EventArgs) Handles EtabsSplash.Click

        Me.Close()
        EtabsFile = True

    End Sub

    Public Sub RAMSplash_Click(sender As Object, e As EventArgs) Handles RAMSplash.Click

        Me.Close()
        RAMFile = True

    End Sub
    Public Sub RhinoSplash_Click(sender As Object, e As EventArgs) Handles RhinoSplash.Click

        Me.Close()
        RhinoFile = True

    End Sub


End Class