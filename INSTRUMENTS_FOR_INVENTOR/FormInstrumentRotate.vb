
Imports Inventor


Public Class FormInstrumentRotate

    Public oldPartAngle As Double
    Public newPartAngle As Double
    Public oEnterclick As Boolean = False
    Dim pi = Math.Acos(-1)
    Dim oRotateByAngle


    Private Sub frmInstrumentRotate_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        TopMost = True
        oldPartAngle = formInstrument.POI011I0
        cbxInstrumentTurnByAngle.Items.Clear()
        cbxInstrumentTurnByAngle.Items.AddRange(New Object() {"1", "5", "10", "15", "30", "45", "90"})
        cbxInstrumentTurnByAngle.SelectedIndex = 5
        oRotateByAngle = 45

    End Sub





    Private Sub RotateInstrumentByNewValues()


        If formInstrument.PO1O11IO = "XYaxis" Then

            Dim oAssDoc As AssemblyDocument
            Dim oValveInsertAngle As Double
            oValveInsertAngle = newPartAngle
            oAssDoc = formInstrument.POI1OOII.ActiveDocument
            Try
                formInstrument.PO0O10IO.Constraints.Item(1).Delete()
                Call oAssDoc.ComponentDefinition.Constraints.AddAngleConstraint(oAssDoc.ComponentDefinition.WorkPlanes(3), formInstrument.PO0OOOIO, oValveInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oValveInsertAngle
        End If

        If formInstrument.PO1O11IO = "XZaxis" Then

            Dim oAssDoc As AssemblyDocument
            Dim oValveInsertAngle As Double
            oValveInsertAngle = newPartAngle
            oAssDoc = formInstrument.POI1OOII.ActiveDocument
            Try
                formInstrument.PO0O10IO.Constraints.Item(1).Delete()
                Call oAssDoc.ComponentDefinition.Constraints.AddAngleConstraint(oAssDoc.ComponentDefinition.WorkPlanes(2), formInstrument.PO0OOOIO, oValveInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oValveInsertAngle
        End If

        If formInstrument.PO1O11IO = "YZaxis" Then

            Dim oAssDoc As AssemblyDocument
            Dim oValveInsertAngle As Double
            oValveInsertAngle = newPartAngle
            oAssDoc = formInstrument.POI1OOII.ActiveDocument
            Try
                formInstrument.PO0O10IO.Constraints.Item(1).Delete()
                Call oAssDoc.ComponentDefinition.Constraints.AddAngleConstraint(oAssDoc.ComponentDefinition.WorkPlanes(1), formInstrument.PO0OOOIO, oValveInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oValveInsertAngle
        End If


    End Sub



    Private Sub btnTurnPos_Click(sender As Object, e As EventArgs) Handles btnTurnPos.Click
        oEnterclick = False
        newPartAngle = oldPartAngle + (oRotateByAngle * pi / 180)
        If newPartAngle >= (360 * pi / 180) Then
            newPartAngle = 0
        End If
        If newPartAngle <= (-360 * pi / 180) Then
            newPartAngle = 0
        End If
        RotateInstrumentByNewValues()
    End Sub

    Private Sub btnTurnNeg_Click(sender As Object, e As EventArgs) Handles btnTurnNeg.Click
        oEnterclick = False
        newPartAngle = oldPartAngle - (oRotateByAngle * pi / 180)
        If newPartAngle >= (360 * pi / 180) Then
            newPartAngle = 0
        End If
        If newPartAngle <= (-360 * pi / 180) Then
            newPartAngle = 0
        End If
        RotateInstrumentByNewValues()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAcceptInstrumentAngle.Click
        oEnterclick = True
        Close()
    End Sub

    Private Sub CbxTurnByAngle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxInstrumentTurnByAngle.SelectedIndexChanged
        oRotateByAngle = cbxInstrumentTurnByAngle.Text
    End Sub


End Class
