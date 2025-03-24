Imports Inventor


Public Class frmInstrumentRotate

    Public oldPartAngle As Double
    Public newPartAngle As Double
    Public oEnterclick As Boolean = False
    Dim pi = Math.Acos(-1)
    Dim oRotateByAngle


    Private Sub frmInstrumentRotate_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        TopMost = True
        oldPartAngle = frmInstrument.oInstrumentAngle
        cbxInstrumentTurnByAngle.SelectedIndex = 5
        oRotateByAngle = 45

    End Sub




    Private Sub RotateInstrumentByNewValues()


        If frmInstrument.oOrient = "XYaxis" Then

            Dim asmDoc As Inventor.AssemblyDocument
            Dim oInstrumentInsertAngle As Double
            oInstrumentInsertAngle = newPartAngle
            asmDoc = frmInstrument.oInvApp.ActiveDocument
            Try
                frmInstrument.oInstrumOcc.Constraints.Item(1).Delete()
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(3), frmInstrument.oInstrumentAglePlaneProxy, oInstrumentInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oInstrumentInsertAngle
        End If

        If frmInstrument.oOrient = "XZaxis" Then

            Dim asmDoc As Inventor.AssemblyDocument
            Dim oInstrumentInsertAngle As Double
            oInstrumentInsertAngle = newPartAngle
            asmDoc = frmInstrument.oInvApp.ActiveDocument
            Try
                frmInstrument.oInstrumOcc.Constraints.Item(1).Delete()
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(2), frmInstrument.oInstrumentAglePlaneProxy, oInstrumentInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try
            oldPartAngle = oInstrumentInsertAngle
        End If

        If frmInstrument.oOrient = "YZaxis" Then

            Dim asmDoc As Inventor.AssemblyDocument
            Dim oInstrumentInsertAngle As Double
            oInstrumentInsertAngle = newPartAngle
            asmDoc = frmInstrument.oInvApp.ActiveDocument
            Try
                frmInstrument.oInstrumOcc.Constraints.Item(1).Delete()
                Call asmDoc.ComponentDefinition.Constraints.AddAngleConstraint(asmDoc.ComponentDefinition.WorkPlanes(1), frmInstrument.oInstrumentAglePlaneProxy, oInstrumentInsertAngle, AngleConstraintSolutionTypeEnum.kDirectedSolution)
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
        RotateElbowByNewValues()
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
        RotateElbowByNewValues()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAcceptValveAngle.Click
        oEnterclick = True
        Close()
    End Sub

    Private Sub CbxTurnByAngle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxValveTurnByAngle.SelectedIndexChanged
        oRotateByAngle = cbxValveTurnByAngle.Text
    End Sub
End Class