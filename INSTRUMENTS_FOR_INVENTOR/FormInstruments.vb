
Imports Inventor
Imports System.IO

Public Class formInstrument

    Dim PO1OIIO1 As String
    Dim P1O10I11 As String
    Dim PIIII01O As String
    Dim POO10I10 As String
    Dim P01II0OI As String
    Dim PO10I01O As String
    Dim P00OIOII As String
    Dim PI0III00 As Integer
    Dim P00101II As Integer
    Dim POI0110O As Document
    Public PO1O11IO As String
    Public POI011I0 As Integer
    Public POI1OOII As Application
    Public PO0O10IO As ComponentOccurrence
    Public PO00OO0I As AssemblyDocument
    Public PO0OOOIO As WorkPlaneProxy

    Private Sub P0I10010(sender As Object, e As EventArgs) Handles Me.Load

        Dim PII1OOIO As Long
        Dim P0I010O1 = Date.Now.Ticks
        PII1OOIO = 637449696000000000        'Thursday, December 31, 2020

        Try
            Dim epp() As Process
            epp = Process.GetProcessesByName("INSTRUMENTS")
            If epp.Count > 1 Then
                MessageBox.Show("Valve is already started!",
                "Warning !!!", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                Me.Close()
            End If
        Catch ex As Exception
        End Try

        Try
            Dim aip() As Process
            aip = Process.GetProcessesByName("Inventor")
            If aip.Count > 1 Then
                MessageBox.Show("There is more than one Inventor sesion running",
                "Warning !!!", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                Me.Close()
            End If
        Catch ex As Exception

        End Try

        Try
            POI1OOII = GetObject(, "Inventor.Application")
        Catch ex As Exception
            MessageBox.Show("Inventor must be running." & vbCrLf & "Restart Valve after Inventor is completely started.",
            "Warning !!!", MessageBoxButtons.OK,
            MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            btnPlacePart.Enabled = False
            GoTo resumeload
        End Try




        'If their was a crash within a sub and the ScreenUpdate was set false then this will correct it 
        POI1OOII.ScreenUpdating = True

        If POI1OOII.ActiveDocumentType = DocumentTypeEnum.kAssemblyDocumentObject Then
        Else MsgBox("Open, Create or Activate an Assembly !", vbOKOnly + "4064", "Warning")
        End If








resumeload:
        TopMost = True
        POO10I10 = "Cerabar PMC11"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCerabarPMC11.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "CerabarPMC11.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99

    End Sub

    Private Sub PIOI0O11()
        picGroundPlate.Visible = False
        PicCableLadder.Visible = False
        PicCableLadderBend.Visible = False
        PicCableLadderRiser.Visible = False
        PicCableLadderTee.Visible = False
        PicCerabarPMC11.Visible = False
        picCerabarPMP11.Visible = False
        PicCeraphantTPTP31.Visible = False
        PicCleanfitCPA450.Visible = False
        PicCleanfitCPA871.Visible = False
        PicCondumaxCLS21D.Visible = False
        PicFlowfitCCA250.Visible = False
        PicFlowMeterDMF170.Visible = False
        PicStandingElectricalCabinet.Visible = False
        PicHangingElectricalCabinet.Visible = False
        PicIndumaxCLS50D.Visible = False
        PicIndustrialPowerPoint.Visible = False
        PicIndustrialThermometer.Visible = False
        PicJunctionBox.Visible = False
        PicLightingArmature.Visible = False
        PicLiquilineCM444.Visible = False
        PicLiquiphantFTL31.Visible = False
        PicOrbisintCPS11D.Visible = False
        PicOxymaxCOS61D.Visible = False
        PicPowerDisconnect.Visible = False
        PicPowerSwitch.Visible = False
        PicPressureGauge.Visible = False
        PicPromag.Visible = False
        PicStreetLight.Visible = False
        PicThermocouple.Visible = False
        PicTurbimaxCUE21.Visible = False
        PicWireMeshCableTray.Visible = False

    End Sub

    Private Sub P1I1I01I()
        Try
            POI1OOII = GetObject(, "Inventor.Application")

            'PO1OIIO1 = POI1OOII.FileLocations.Workspace

            Dim oLastSlash As Integer
            oLastSlash = POI1OOII.FileLocations.FileLocationsFile.LastIndexOf("\")

            PO1OIIO1 = POI1OOII.FileLocations.FileLocationsFile.Substring(0, oLastSlash) & "\"

            Select Case POO10I10
                Case "Cerabar PMC11", "Cerabar PMP11", "Cleanfit CPA450", "Cleanfit CPA871", "Liquiline CM444", "Liquiphant FTL31", "Orbisint CPS11D", "Promag", "Ceraphant TPTP31", "Condumax CLS21D", "Indumax CLS50D", "Flowfit CCA250", "Flow Meter DMF170", "Turbimax CUE21", "Pressure Gauge", "Industrial Thermometer", "Oxymax COS61D"
                    lblProjectPath.Text = PO1OIIO1 & "\Instruments\"
                Case "Standing Cabinet", "Hanging Cabinet", "Junction Box", "Power Switch", "Power Disconnect", "Lighting Armature", "Street Light", "Industrial Power-Point"
                    lblProjectPath.Text = PO1OIIO1 & "\Electrical\"
                Case "Wire Mesh Cable Tray", "Cable Ladder", "Cable Ladder Bend", "Cable Ladder Riser", "Cable Ladder Tee"
                    lblProjectPath.Text = PO1OIIO1 & "\Electrical\CableTrays\"
            End Select
        Catch ex As Exception
            lblProjectPath.Text = "No Path, Inventor is not active!"
            Exit Sub
        End Try
    End Sub


    Private Sub P1I10I1I(sender As Object, e As EventArgs) Handles rbtCerabarPMC11.CheckedChanged
        POO10I10 = "Cerabar PMC11"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCerabarPMC11.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "CerabarPMC11.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99

    End Sub

    Private Sub P11IOO00(sender As Object, e As EventArgs) Handles rbtCerabarPMP11.CheckedChanged
        POO10I10 = "Cerabar PMP11"
        lblDescription.Text = POO10I10
        PIOI0O11()
        picCerabarPMP11.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "CerabarPMP11.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub PIOIOII0(sender As Object, e As EventArgs) Handles rbtCleanfitCPA450.CheckedChanged
        POO10I10 = "Cleanfit CPA450"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCleanfitCPA450.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "CleanfitCPA450.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub PO110O0I(sender As Object, e As EventArgs) Handles rbtCleanfitCPA871.CheckedChanged
        POO10I10 = "Cleanfit CPA871"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCleanfitCPA871.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "CleanfitCPA871.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub P1IO1I01(sender As Object, e As EventArgs) Handles rbtLiquilineCM444.CheckedChanged
        POO10I10 = "Liquiline CM444"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicLiquilineCM444.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "LiquilineCM444.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 999
    End Sub

    Private Sub P010101I(sender As Object, e As EventArgs) Handles rbtLiquiphantFTL31.CheckedChanged
        POO10I10 = "Liquiphant FTL31"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicLiquiphantFTL31.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "LiquiphantFTL31.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub PI1OO11O(sender As Object, e As EventArgs) Handles rbtOrbisintCPS11D.CheckedChanged
        POO10I10 = "Orbisint CPS11D"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicOrbisintCPS11D.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "OrbisintCPS11D.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub P100110O(sender As Object, e As EventArgs) Handles rbtPromag.CheckedChanged, rbtPromagGroundDisk.CheckedChanged
        POO10I10 = "Promag"
        lblDescription.Text = POO10I10 & " " & cbxSize.Text
        PIOI0O11()
        PicPromag.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        lblLenght.Visible = False
        cbxLenght.Visible = False
        lblSize.Text = "Size"
        cbxSize.Width = 80
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300", "DN350", "DN400", "DN450", "DN500", "DN600"})
        cbxSize.SelectedIndex = 3
        PI0III00 = 4
        P00OIOII = "PromagL400.ipt"
        lblFileName.Text = P00OIOII
    End Sub

    Private Sub PO011IO1(sender As Object, e As EventArgs) Handles rbtPromagGroundDisk.CheckedChanged
        POO10I10 = "Promag Ground Disk"
        lblDescription.Text = POO10I10 & " " & cbxSize.Text
        PIOI0O11()
        picGroundPlate.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        lblLenght.Visible = False
        cbxLenght.Visible = False
        lblSize.Text = "Size"
        cbxSize.Width = 80
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"DN25", "DN32", "DN40", "DN50", "DN65", "DN80", "DN100", "DN125", "DN150", "DN200", "DN250", "DN300", "DN350", "DN400", "DN450", "DN500", "DN600"})
        cbxSize.SelectedIndex = 3
        PI0III00 = 4
        P00OIOII = "PromagGroundDisk.ipt"
        lblFileName.Text = P00OIOII
    End Sub

    Private Sub P0IIOOII()
        Select Case cbxSize.Text
            Case "DN25"
                PI0III00 = 1
            Case "DN32"
                PI0III00 = 2
            Case "DN40"
                PI0III00 = 3
            Case "DN50"
                PI0III00 = 4
            Case "DN65"
                PI0III00 = 5
            Case "DN80"
                PI0III00 = 6
            Case "DN100"
                PI0III00 = 7
            Case "DN125"
                PI0III00 = 8
            Case "DN150"
                PI0III00 = 9
            Case "DN200"
                PI0III00 = 10
            Case "DN250"
                PI0III00 = 11
            Case "DN300"
                PI0III00 = 12
            Case "DN350"
                PI0III00 = 13
            Case "DN400"
                PI0III00 = 14
            Case "DN450"
                PI0III00 = 15
            Case "DN500"
                PI0III00 = 16
        End Select
    End Sub


    Private Sub P1O010IO(sender As Object, e As EventArgs) Handles rbtCeraphantTPTP31.CheckedChanged
        POO10I10 = "Ceraphant TPTP31"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCeraphantTPTP31.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "CeraphantPTP31.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub PIIO1OO0(sender As Object, e As EventArgs) Handles rbtCondumaxCLS21D.CheckedChanged
        POO10I10 = "Condumax CLS21D"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCondumaxCLS21D.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "CondumaxCLS21D.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub rbtIndumaxCLS50D_CheckedChanged(sender As Object, e As EventArgs) Handles rbtIndumaxCLS50D.CheckedChanged
        POO10I10 = "Indumax CLS50D"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicIndumaxCLS50D.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "IndumaxCLS50D.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub rbtFlowfitCCA250_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFlowfitCCA250.CheckedChanged
        POO10I10 = "Flowfit CCA250"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicFlowfitCCA250.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "FlowfitCCA250.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 999
    End Sub

    Private Sub rbtFlowMeterDMF170_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFlowMeterDMF170.CheckedChanged
        POO10I10 = "Rotameter"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicFlowMeterDMF170.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Width = 80
        lblSize.Text = "Size"
        cbxSize.Items.AddRange(New Object() {"DE16", "DE20", "DE25", "DE32", "DE40", "DE50", "DE63", "DE75"})
        cbxSize.SelectedIndex = 3
        PI0III00 = 4
        P00OIOII = "FlowmeterStubbe.ipt"
        lblFileName.Text = P00OIOII

    End Sub



    Private Sub oRotameterIMateItem()
        Select Case cbxSize.Text
            Case "DE16"
                PI0III00 = 1
            Case "DE20"
                PI0III00 = 2
            Case "DE25"
                PI0III00 = 3
            Case "DE32"
                PI0III00 = 4
            Case "DE40"
                PI0III00 = 5
            Case "DE50"
                PI0III00 = 6
            Case "DE63"
                PI0III00 = 7
            Case "DE75"
                PI0III00 = 8
        End Select
    End Sub

    Private Sub rbtTurbimaxCUE21_CheckedChanged(sender As Object, e As EventArgs) Handles rbtTurbimaxCUE21.CheckedChanged
        POO10I10 = "Turbimax CUE21"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicTurbimaxCUE21.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "TurbimaxCUE21.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 999
    End Sub

    Private Sub rbtPressureGauge_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPressureGauge.CheckedChanged
        POO10I10 = "Pressure indicator"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicPressureGauge.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "PressureGauge.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub rbtIndustrialThermometer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtIndustrialThermometer.CheckedChanged
        POO10I10 = "Temperature indicator"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicIndustrialThermometer.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "IndustrialThermometer.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub rbtThermocouple_CheckedChanged(sender As Object, e As EventArgs) Handles rbtThermocouple.CheckedChanged
        POO10I10 = "Thermocouple PT100"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicThermocouple.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "ThermocouplePT100.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub rbtOxymaxCOS61D_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOxymaxCOS61D.CheckedChanged
        POO10I10 = "Oxymax COS61D"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicOxymaxCOS61D.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "OxymaxCOS61D.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 99
    End Sub

    Private Sub rbtStandingElectricalCabinet_CheckedChanged(sender As Object, e As EventArgs) Handles rbtStandingElectricalCabinet.CheckedChanged
        POO10I10 = "Standing Cabinet"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicStandingElectricalCabinet.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 140
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"1800x800x500 2D", "1800x800x600 2D", "1800x1000x400 2D", "2000x1000x400 2D", "2000x1000x500 2D", "2000x1000x600 2D", "1200x1200x500 2D", "1400x1200x500 2D", "1600x1200x500 2D", "1800x1200x400 2D", "1800x1200x500 2D", "1800x1200x600 2D", "2000x1200x400 2D", "2000x1200x500 2D", "2000x1200x600 2D", "2000x1200x800 2D", "1800x400x500 1D", "1800x400x600 1D", "2000x400x500 1D", "2000x400x600 1D", "1200x600x500 1D", "1400x600x500 1D", "1600x600x500 1D", "1800x600x400 1D", "1800x600x500 1D", "2000x600x400 1D", "2000x600x500 1D", "2000x600x600 1D", "2000x600x800 1D", "2200x600x800 1D", "1200x800x500 1D", "1400x800x500 1D", "1600x800x500 1D", "1800x800x400 1D", "1800x800x500 1D", "2000x800x400 1D", "2000x800x500 1D", "2000x800x600 1D", "2000x800x800 1D", "2200x800x800 1D", "1800x1000x400 1D"})
        lblSize.Text = "Height x Width x Depth"
        P00OIOII = "StandingElectricalCabinet.ipt"
        lblFileName.Text = P00OIOII
        cbxSize.SelectedIndex = 6
        PI0III00 = 7

    End Sub

    Private Sub oStandingCabinetIMateItem()
        Select Case cbxSize.Text
            Case "1800x800x500 2D"
                PI0III00 = 1
            Case "1800x800x600 2D"
                PI0III00 = 2
            Case "1800x1000x400 2D"
                PI0III00 = 3
            Case "2000x1000x400 2D"
                PI0III00 = 4
            Case "2000x1000x500 2D"
                PI0III00 = 5
            Case "2000x1000x600 2D"
                PI0III00 = 6
            Case "1200x1200x500 2D"
                PI0III00 = 7
            Case "1400x1200x500 2D"
                PI0III00 = 8
            Case "1600x1200x500 2D"
                PI0III00 = 9
            Case "1800x1200x400 2D"
                PI0III00 = 10
            Case "1800x1200x500 2D"
                PI0III00 = 11
            Case "1800x1200x600 2D"
                PI0III00 = 12
            Case "2000x1200x400 2D"
                PI0III00 = 13
            Case "2000x1200x500 2D"
                PI0III00 = 14
            Case "2000x1200x600 2D"
                PI0III00 = 15
            Case "2000x1200x800 2D"
                PI0III00 = 16
            Case "1800x400x500 1D"
                PI0III00 = 17
            Case "1800x400x600 1D"
                PI0III00 = 18
            Case "2000x400x500 1D"
                PI0III00 = 19
            Case "2000x400x600 1D"
                PI0III00 = 20
            Case "1200x600x500 1D"
                PI0III00 = 21
            Case "1400x600x500 1D"
                PI0III00 = 22
            Case "1600x600x500 1D"
                PI0III00 = 23
            Case "1800x600x400 1D"
                PI0III00 = 24
            Case "1800x600x500 1D"
                PI0III00 = 25
            Case "2000x600x400 1D"
                PI0III00 = 26
            Case "2000x600x500 1D"
                PI0III00 = 27
            Case "2000x600x600 1D"
                PI0III00 = 28
            Case "2000x600x800 1D"
                PI0III00 = 29
            Case "2200x600x800 1D"
                PI0III00 = 30
            Case "1200x800x500 1D"
                PI0III00 = 31
            Case "1400x800x500 1D"
                PI0III00 = 32
            Case "1600x800x500 1D"
                PI0III00 = 33
            Case "1800x800x400 1D"
                PI0III00 = 34
            Case "1800x800x500 1D"
                PI0III00 = 35
            Case "2000x800x400 1D"
                PI0III00 = 36
            Case "2000x800x500 1D"
                PI0III00 = 37
            Case "2000x800x600 1D"
                PI0III00 = 38
            Case "2000x800x800 1D"
                PI0III00 = 39
            Case "2200x800x800 1D"
                PI0III00 = 40
            Case "1800x1000x400 1D"
                PI0III00 = 41
        End Select
    End Sub



    Private Sub rbtHangingElectricalCabinet_CheckedChanged(sender As Object, e As EventArgs) Handles rbtHangingElectricalCabinet.CheckedChanged
        POO10I10 = "Hanging Cabinet"

        PIOI0O11()
        PicHangingElectricalCabinet.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 140
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"300x200x120mm 1D", "300x200x155mm 1D", "300x300x155mm 1D", "300x300x210mm 1D", "380x300x210mm 1D", "400x300x210mm 1D", "300x380x155mm 1D", "300x380x210mm 1D", "380x380x210mm 1D", "600x380x210mm 1D", "600x380x350mm 1D", "500x400x210mm 1D", "800x400x300mm 1D", "500x500x210mm 1D", "500x500x300mm 1D", "700x500x250mm 1D", "380x600x210mm 1D", "380x600x350mm 1D", "600x600x210mm 1D", "600x600x250mm 1D", "600x600x350mm 1D", "760x600x210mm 1D", "760x600x350mm 1D", "800x600x250mm 1D", "1000x600x250mm 1D", "1200x600x300mm 1D", "760x760x210mm 1D", "760x760x300mm 1D", "600x800x300mm 1D", "1000x800x300mm 1D", "1200x800x300mm 1D", "760x1000x210mm 2D", "760x1000x300mm 2D", "1000x1000x300mm 2D", "1200x1000x300mm 2D", "1400x1000x300mm 2D"})
        lblSize.Text = "Height x Width x Depth"
        P00OIOII = "HangingElectricalCabinet.ipt"
        lblFileName.Text = P00OIOII
        cbxSize.SelectedIndex = 5
        PI0III00 = 6
    End Sub


    Private Sub oHangingCabinetIMateItem()
        Select Case cbxSize.Text
            Case "300x200x120mm 1D"
                PI0III00 = 1
            Case "300x200x155mm 1D"
                PI0III00 = 2
            Case "300x300x155mm 1D"
                PI0III00 = 3
            Case "300x300x210mm 1D"
                PI0III00 = 4
            Case "380x300x210mm 1D"
                PI0III00 = 5
            Case "400x300x210mm 1D"
                PI0III00 = 6
            Case "300x380x155mm 1D"
                PI0III00 = 7
            Case "300x380x210mm 1D"
                PI0III00 = 8
            Case "380x380x210mm 1D"
                PI0III00 = 9
            Case "600x380x210mm 1D"
                PI0III00 = 10
            Case "600x380x350mm 1D"
                PI0III00 = 11
            Case "500x400x210mm 1D"
                PI0III00 = 12
            Case "800x400x300mm 1D"
                PI0III00 = 13
            Case "500x500x210mm 1D"
                PI0III00 = 14
            Case "500x500x300mm 1D"
                PI0III00 = 15
            Case "700x500x250mm 1D"
                PI0III00 = 16
            Case "380x600x210mm 1D"
                PI0III00 = 17
            Case "380x600x350mm 1D"
                PI0III00 = 18
            Case "600x600x210mm 1D"
                PI0III00 = 19
            Case "600x600x250mm 1D"
                PI0III00 = 20
            Case "600x600x350mm 1D"
                PI0III00 = 21
            Case "760x600x210mm 1D"
                PI0III00 = 22
            Case "760x600x350mm 1D"
                PI0III00 = 23
            Case "800x600x250mm 1D"
                PI0III00 = 24
            Case "1000x600x250mm 1D"
                PI0III00 = 25
            Case "1200x600x300mm 1D"
                PI0III00 = 26
            Case "760x760x210mm 1D"
                PI0III00 = 27
            Case "760x760x300mm 1D"
                PI0III00 = 28
            Case "600x800x300mm 1D"
                PI0III00 = 29
            Case "1000x800x300mm 1D"
                PI0III00 = 30
            Case "1200x800x300mm 1D"
                PI0III00 = 31
            Case "760x1000x210mm 2D"
                PI0III00 = 32
            Case "760x1000x300mm 2D"
                PI0III00 = 33
            Case "1000x1000x300mm 2D"
                PI0III00 = 34
            Case "1200x1000x300mm 2D"
                PI0III00 = 35
            Case "1400x1000x300mm 2D"
                PI0III00 = 36
        End Select
    End Sub


    Private Sub rbtJunctionBox_CheckedChanged(sender As Object, e As EventArgs) Handles rbtJunctionBox.CheckedChanged
        POO10I10 = "Junction Box"

        PIOI0O11()
        PicJunctionBox.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 140
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"150x150x80mm", "150x150x120mm", "150x200x80mm", "150x200x120mm", "200x200x80mm", "200x200x120mm", "150x300x80mm", "150x300x120mm", "200x300x80mm", "200x300x120mm", "300x300x120mm", "150x400x120mm", "200x400x80mm", "200x400x120mm", "300x400x120mm", "400x400x120mm", "200x500x120mm", "300x500x120mm", "200x600x80mm", "200x600x120mm", "300x600x120mm", "400x600x120mm", "200x800x120mm", "400x800x120mm"})
        lblSize.Text = "Height x Width x Depth"
        P00OIOII = "JuctionBox.ipt"
        lblFileName.Text = P00OIOII
        cbxSize.SelectedIndex = 6
        PI0III00 = 7
    End Sub

    Private Sub oJuctionBoxIMateItem()
        Select Case cbxSize.Text
            Case "150x150x80mm"
                PI0III00 = 1
            Case "150x150x120mm"
                PI0III00 = 2
            Case "150x200x80mm"
                PI0III00 = 3
            Case "150x200x120mm"
                PI0III00 = 4
            Case "200x200x80mm"
                PI0III00 = 5
            Case "200x200x120mm"
                PI0III00 = 6
            Case "150x300x80mm"
                PI0III00 = 7
            Case "150x300x120mm"
                PI0III00 = 8
            Case "200x300x80mm"
                PI0III00 = 9
            Case "200x300x120mm"
                PI0III00 = 10
            Case "300x300x120mm"
                PI0III00 = 11
            Case "150x400x120mm"
                PI0III00 = 12
            Case "200x400x80mm"
                PI0III00 = 13
            Case "200x400x120mm"
                PI0III00 = 14
            Case "300x400x120mm"
                PI0III00 = 15
            Case "400x400x120mm"
                PI0III00 = 16
            Case "200x500x120mm"
                PI0III00 = 17
            Case "300x500x120mm"
                PI0III00 = 18
            Case "200x600x80mm"
                PI0III00 = 19
            Case "200x600x120mm"
                PI0III00 = 20
            Case "300x600x120mm"
                PI0III00 = 21
            Case "400x600x120mm"
                PI0III00 = 22
            Case "200x800x120mm"
                PI0III00 = 23
            Case "400x800x120mm"
                PI0III00 = 24
        End Select
    End Sub




    Private Sub rbtPowerSwitch_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPowerSwitch.CheckedChanged
        POO10I10 = "Power Switch"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicPowerSwitch.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "PowerSwitch.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 999
    End Sub

    Private Sub rbtPowerDisconnect_CheckedChanged(sender As Object, e As EventArgs) Handles rbtPowerDisconnect.CheckedChanged
        POO10I10 = "Power Disconnect"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicPowerDisconnect.Visible = True
        P1I1I01I()
        lblSize.Visible = False
        cbxSize.Visible = False
        lblLenght.Visible = False
        cbxLenght.Visible = False
        P00OIOII = "PowerDisconnect.ipt"
        lblFileName.Text = P00OIOII
        PI0III00 = 999
    End Sub

    Private Sub rbtLightingArmature_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLightingArmature.CheckedChanged
        POO10I10 = "Lighting Armature"
        PIOI0O11()
        PicLightingArmature.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 140
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"670x70", "1260x70", "1560x70", "670x110", "1260x110", "1560x110"})
        lblSize.Text = "Lenght x Width"
        cbxSize.SelectedIndex = 5
        PI0III00 = 6
        P00OIOII = "TLarmatuur.ipt"
        lblFileName.Text = P00OIOII
    End Sub

    Private Sub oLightingArmatureIMateItem()
        Select Case cbxSize.Text
            Case "670x70"
                PI0III00 = 1
            Case "1260x70"
                PI0III00 = 2
            Case "1560x70"
                PI0III00 = 3
            Case "670x110"
                PI0III00 = 4
            Case "1260x110"
                PI0III00 = 5
            Case "1560x110"
                PI0III00 = 6
        End Select
    End Sub

    Private Sub rbtStreetLight_CheckedChanged(sender As Object, e As EventArgs) Handles rbtStreetLight.CheckedChanged
        POO10I10 = "Street Light"
        PIOI0O11()
        PicStreetLight.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 80
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"4000", "5000", "6000"})
        lblSize.Text = "Height"
        cbxSize.SelectedIndex = 0
        PI0III00 = 1
        P00OIOII = "StreetLight.ipt"
        lblFileName.Text = P00OIOII
    End Sub

    Private Sub oStreetLightIMateItem()
        Select Case cbxSize.Text
            Case "4000"
                PI0III00 = 1
            Case "5000"
                PI0III00 = 2
            Case "6000"
                PI0III00 = 3
        End Select
    End Sub


    Private Sub rbtIndustrialPowerPoint_CheckedChanged(sender As Object, e As EventArgs) Handles rbtIndustrialPowerPoint.CheckedChanged
        POO10I10 = "Industrial Power-Point"

        lblDescription.Text = POO10I10
        PIOI0O11()
        PicIndustrialPowerPoint.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 80
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"240V", "400V"})
        lblSize.Text = "Tension"
        cbxSize.SelectedIndex = 0
        PI0III00 = 1
        P00OIOII = "PowerPoint.ipt"
        lblFileName.Text = P00OIOII
    End Sub


    Private Sub oPowerPointIMateItem()
        Select Case cbxSize.Text
            Case "240V"
                PI0III00 = 1
            Case "400V"
                PI0III00 = 2
        End Select
    End Sub

    Private Sub rbtWireMeshCableTray_CheckedChanged(sender As Object, e As EventArgs) Handles rbtWireMeshCableTray.CheckedChanged
        POO10I10 = "Wire Mesh Cable Tray"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicWireMeshCableTray.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 80
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"60x60", "60x100", "60x200", "60x400", "60x600", "100x150", "100x300"})
        lblSize.Text = "Width x Height"
        cbxSize.SelectedIndex = 2
        PI0III00 = 3
        P00OIOII = "WireMeshCableTray.ipt"
        lblFileName.Text = P00OIOII


    End Sub

    Private Sub oWireMeshCableTrayIMateItem()
        Select Case cbxSize.Text
            Case "60x60"
                PI0III00 = 1
            Case "60x100"
                PI0III00 = 2
            Case "60x200"
                PI0III00 = 3
            Case "60x400"
                PI0III00 = 4
            Case "60x600"
                PI0III00 = 5
            Case "100x150"
                PI0III00 = 6
            Case "100x300"
                PI0III00 = 7
        End Select
    End Sub




    Private Sub rbtCableLadder_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCableLadder.CheckedChanged
        POO10I10 = "Cable Ladder"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCableLadder.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 140
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"150 x 3000 mm", "200 x 3000 mm", "300 x 3000 mm", "400 x 3000 mm", "500 x 3000 mm", "600 x 3000 mm", "800 x 3000 mm", "1000 x 3000 mm", "150 x 4000 mm", "200 x 4000 mm", "300 x 4000 mm", "400 x 4000 mm", "500 x 4000 mm", "600 x 4000 mm", "800 x 4000 mm", "1000 x 4000 mm", "150 x 6000 mm", "200 x 6000 mm", "300 x 6000 mm", "400 x 6000 mm", "500 x 6000 mm", "600 x 6000 mm", "800 x 6000 mm", "1000 x 6000 mm"})
        lblSize.Text = "Width x Height x Lenght"
        cbxSize.SelectedIndex = 2
        PI0III00 = 3
        P00OIOII = "CableLadder.ipt"
        lblFileName.Text = P00OIOII

    End Sub

    Private Sub oCableLadderIMateItem()
        Select Case cbxSize.Text

            Case "150 x 3000 mm"
                PI0III00 = 1
            Case "200 x 3000 mm"
                PI0III00 = 2
            Case "300 x 3000 mm"
                PI0III00 = 3
            Case "400 x 3000 mm"
                PI0III00 = 4
            Case "500 x 3000 mm"
                PI0III00 = 5
            Case "600 x 3000 mm"
                PI0III00 = 6
            Case "800 x 3000 mm"
                PI0III00 = 7
            Case "1000 x 3000 mm"
                PI0III00 = 8
            Case "150 x 4000 mm"
                PI0III00 = 9
            Case "200 x 4000 mm"
                PI0III00 = 10
            Case "300 x 4000 mm"
                PI0III00 = 11
            Case "400 x 4000 mm"
                PI0III00 = 12
            Case "500 x 4000 mm"
                PI0III00 = 13
            Case "600 x 4000 mm"
                PI0III00 = 14
            Case "800 x 4000 mm"
                PI0III00 = 15
            Case "1000 x 4000 mm"
                PI0III00 = 16
            Case "150 x 6000 mm"
                PI0III00 = 17
            Case "200 x 6000 mm"
                PI0III00 = 18
            Case "300 x 6000 mm"
                PI0III00 = 19
            Case "400 x 6000 mm"
                PI0III00 = 20
            Case "500 x 6000 mm"
                PI0III00 = 21
            Case "600 x 6000 mm"
                PI0III00 = 22
            Case "800 x 6000 mm"
                PI0III00 = 23
            Case "1000 x 6000 mm"
                PI0III00 = 24

        End Select
    End Sub




    Private Sub rbtCableLadderBend_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCableLadderBend.CheckedChanged
        POO10I10 = "Cable Ladder Bend"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCableLadderBend.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 80
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"150", "200", "300", "400", "500", "600", "800", "1000"})
        lblSize.Text = "Width"
        cbxSize.SelectedIndex = 2
        PI0III00 = 3
        P00OIOII = "CableLadderBend.ipt"
        lblFileName.Text = P00OIOII
    End Sub

    Private Sub oCableLadderBendIMateItem()
        Select Case cbxSize.Text
            Case "150"
                PI0III00 = 1
            Case "200"
                PI0III00 = 2
            Case "300"
                PI0III00 = 3
            Case "400"
                PI0III00 = 4
            Case "500"
                PI0III00 = 5
            Case "600"
                PI0III00 = 6
            Case "800"
                PI0III00 = 7
            Case "1000"
                PI0III00 = 8
        End Select
    End Sub




    Private Sub rbtCableLadderRiser_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCableLadderRiser.CheckedChanged
        POO10I10 = "Cable Ladder Riser"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCableLadderRiser.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 80
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"150", "200", "300", "400", "500", "600", "800", "1000"})
        lblSize.Text = "Width"
        cbxSize.SelectedIndex = 2
        PI0III00 = 3
        P00OIOII = "CableLadderRiser.ipt"
        lblFileName.Text = P00OIOII
    End Sub

    Private Sub oCableLadderRiserIMateItem()
        Select Case cbxSize.Text
            Case "150"
                PI0III00 = 1
            Case "200"
                PI0III00 = 2
            Case "300"
                PI0III00 = 3
            Case "400"
                PI0III00 = 4
            Case "500"
                PI0III00 = 5
            Case "600"
                PI0III00 = 6
            Case "800"
                PI0III00 = 7
            Case "1000"
                PI0III00 = 8
        End Select
    End Sub




    Private Sub rbtCableLadderTee_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCableLadderTee.CheckedChanged
        POO10I10 = "Cable Ladder Tee"
        lblDescription.Text = POO10I10
        PIOI0O11()
        PicCableLadderTee.Visible = True
        P1I1I01I()
        lblSize.Visible = True
        cbxSize.Visible = True
        cbxSize.Width = 80
        lblLenght.Visible = False
        cbxLenght.Visible = False
        cbxSize.Items.Clear()
        cbxSize.Items.AddRange(New Object() {"150", "200", "300", "400", "500", "600", "800", "1000"})
        lblSize.Text = "Width"
        cbxSize.SelectedIndex = 2
        PI0III00 = 3
        P00OIOII = "CableLadderTee.ipt"
        lblFileName.Text = P00OIOII
    End Sub

    Private Sub oCableLadderTeeIMateItem()
        Select Case cbxSize.Text
            Case "150"
                PI0III00 = 1
            Case "200"
                PI0III00 = 2
            Case "300"
                PI0III00 = 3
            Case "400"
                PI0III00 = 4
            Case "500"
                PI0III00 = 5
            Case "600"
                PI0III00 = 6
            Case "800"
                PI0III00 = 7
            Case "1000"
                PI0III00 = 8
        End Select
    End Sub


    Private Sub TabGeneral_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabGeneral.SelectedIndexChanged
        Select Case TabGeneral.SelectedIndex
            Case 0
                rbtCerabarPMC11.Checked = True
                POO10I10 = "Cerabar PMC11"
                PIOI0O11()
                PicCerabarPMC11.Visible = True
                P1I1I01I()
                lblSize.Visible = False
                cbxSize.Visible = False
                lblLenght.Visible = False
                cbxLenght.Visible = False
                lblDescription.Text = POO10I10 & " " & cbxSize.Text
            Case 1
                rbtStandingElectricalCabinet.Checked = True
                POO10I10 = "Standing Cabinet"
                lblDescription.Text = POO10I10
                PIOI0O11()
                PicStandingElectricalCabinet.Visible = True
                P1I1I01I()
                lblSize.Visible = True
                cbxSize.Visible = True
                cbxSize.Width = 140
                lblLenght.Visible = False
                cbxLenght.Visible = False
                cbxSize.Items.Clear()
                cbxSize.Items.AddRange(New Object() {"1800x800x500 2D", "1800x800x600 2D", "1800x1000x400 2D", "2000x1000x400 2D", "2000x1000x500 2D", "2000x1000x600 2D", "1200x1200x500 2D", "1400x1200x500 2D", "1600x1200x500 2D", "1800x1200x400 2D", "1800x1200x500 2D", "1800x1200x600 2D", "2000x1200x400 2D", "2000x1200x500 2D", "2000x1200x600 2D", "2000x1200x800 2D", "1800x400x500 1D", "1800x400x600 1D", "2000x400x500 1D", "2000x400x600 1D", "1200x600x500 1D", "1400x600x500 1D", "1600x600x500 1D", "1800x600x400 1D", "1800x600x500 1D", "2000x600x400 1D", "2000x600x500 1D", "2000x600x600 1D", "2000x600x800 1D", "2200x600x800 1D", "1200x800x500 1D", "1400x800x500 1D", "1600x800x500 1D", "1800x800x400 1D", "1800x800x500 1D", "2000x800x400 1D", "2000x800x500 1D", "2000x800x600 1D", "2000x800x800 1D", "2200x800x800 1D", "1800x1000x400 1D"})
                lblSize.Text = "Height x Width x Depth"
                P00OIOII = "StandingElectricalCabinet.ipt"
                lblFileName.Text = P00OIOII
                cbxSize.SelectedIndex = 6
                PI0III00 = 7

            Case 2
                rbtWireMeshCableTray.Checked = True
                POO10I10 = "Wire Mesh Cable Tray"
                lblDescription.Text = POO10I10
                PIOI0O11()
                PicWireMeshCableTray.Visible = True
                P1I1I01I()
                lblSize.Visible = True
                cbxSize.Visible = True
                cbxSize.Width = 80
                lblLenght.Visible = False
                cbxLenght.Visible = False
                cbxSize.Items.Clear()
                cbxSize.Items.AddRange(New Object() {"60x60", "60x100", "60x200", "60x400", "60x600", "100x150", "100x300"})
                lblSize.Text = "Width x Height"
                cbxSize.SelectedIndex = 2
                PI0III00 = 3
                P00OIOII = "WireMeshCableTray.ipt"
                lblFileName.Text = P00OIOII


        End Select
    End Sub

    Private Sub btnPlacePart_Click(sender As Object, e As EventArgs) Handles btnPlacePart.Click


        If POI1OOII.ActiveDocumentType = Inventor.DocumentTypeEnum.kAssemblyDocumentObject Then
            GoTo BeginRoutine
        Else MsgBox("Open, Create or Activate an Assembly !", vbOKOnly + "4064", "Warning")
            GoTo EndRoutine
        End If
BeginRoutine:
        Dim valveAngle As Double = 0
        PO10I01O = lblProjectPath.Text

        Try
            If Not Directory.Exists(PO10I01O) Then
                Directory.CreateDirectory(PO10I01O)
            End If
        Catch ex As Exception
            MsgBox("Could not create the part directory.", vbOKOnly + "4064", "Warning")
            Exit Sub
        End Try

        'MsgBox(PO10I01O & P00OIOII) om te checken


        If Dir(PO10I01O & P00OIOII) = "" Then
            GoTo CopyInstrument
        Else
            GoTo PlaceInstrument
        End If


CopyInstrument:
        Try
            Dim oPartStream As IO.Stream = System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream("INSTRUMENTS." & P00OIOII)
            Dim bytes() As Byte
            Using br As New IO.BinaryReader(oPartStream)
                bytes = br.ReadBytes(oPartStream.Length)
            End Using

            IO.File.WriteAllBytes(PO10I01O & P00OIOII, bytes)

            Try
                POI1OOII.SilentOperation = True
                Dim InvPart As PartDocument
                Dim oFileManager As Inventor.FileManager
                oFileManager = POI1OOII.FileManager
                InvPart = POI1OOII.Documents.Open(PO10I01O & P00OIOII, False)
                InvPart.ComponentDefinition.SetEndOfPartToTopOrBottom(False)
                InvPart.Save()
                InvPart.Close()
                POI1OOII.SilentOperation = False
            Catch ex As Exception
                MsgBox("Something went wrong moving end of part.", vbOKOnly + "4064", "Warning")
                Exit Sub
            End Try

        Catch ex As Exception
            MsgBox("Something went wrong saving this file", vbOKOnly + "4064", "Warning")
            Exit Sub

        End Try



PlaceInstrument:

        '------------------------------------------------------------------------------------------------
        ' -----Place a normal part by insert and rotate fixed by the first plane.----   See case 99
        ' -----Place a normal part mate to the first plane.----                         See case 999
        ' -----Place an I-part by insert and rotate fixed by the first plane.----       See case else
        '------------------------------------------------------------------------------------------------

        PO00OO0I = POI1OOII.ActiveDocument
        If PO00OO0I.ComponentDefinition.ImmediateReferencedDefinitions.Count < 1 Then
            Dim trans As Inventor.Matrix



            Select Case PI0III00

                Case 99
                    trans = POI1OOII.TransientGeometry.CreateMatrix
                    PO0O10IO = PO00OO0I.ComponentDefinition.Occurrences.Add((PO10I01O & P00OIOII), trans)
                Case 999
                    trans = POI1OOII.TransientGeometry.CreateMatrix
                    PO0O10IO = PO00OO0I.ComponentDefinition.Occurrences.Add((PO10I01O & P00OIOII), trans)
                Case Else
                    trans = POI1OOII.TransientGeometry.CreateMatrix
                    PO0O10IO = PO00OO0I.ComponentDefinition.Occurrences.AddiPartMember((PO10I01O & P00OIOII), trans, PI0III00)

            End Select


            GoTo EndRoutine
        End If

        'Placing an i-part with an insert i-mate 

        Hide()



        Dim oInstrDoc As PartDocument

        Select Case PI0III00

            ' Normal part insert on a circle
            Case 99

                Dim oSelectEdge As Inventor.Edge
                oSelectEdge = POI1OOII.CommandManager.Pick(Inventor.SelectionFilterEnum.kAllCircularEntities, "Select a circular edge.")
                If oSelectEdge Is Nothing Then
                    GoTo EndRoutine
                End If
                Dim trans As Inventor.Matrix
                trans = POI1OOII.TransientGeometry.CreateMatrix
                PO0O10IO = PO00OO0I.ComponentDefinition.Occurrences.Add((PO10I01O & P00OIOII), trans)
                Call PO00OO0I.ComponentDefinition.Constraints.AddInsertConstraint(oSelectEdge, PO0O10IO.iMateDefinitions.Item(1), True, 0)

             ' Normal part insert on a face
            Case 999

                Dim oSelectFace As Inventor.Face
                oSelectFace = POI1OOII.CommandManager.Pick(Inventor.SelectionFilterEnum.kPartFacePlanarFilter, "Select a Face.")
                If oSelectFace Is Nothing Then
                    GoTo EndRoutine
                End If

                Dim trans As Inventor.Matrix
                trans = POI1OOII.TransientGeometry.CreateMatrix
                PO0O10IO = PO00OO0I.ComponentDefinition.Occurrences.Add((PO10I01O & P00OIOII), trans)
                Call PO00OO0I.ComponentDefinition.Constraints.AddMateConstraint(oSelectFace, PO0O10IO.iMateDefinitions.Item(1), 0)
                GoTo EndRoutine

                'i-Parts Insert
            Case Else

                Select Case P00OIOII

                    Case "StandingElectricalCabinet.ipt", "HangingElectricalCabinet.ipt", "JuctionBox.ipt", "TLarmatuur.ipt", "StreetLight.ipt", "PowerPoint.ipt", "CableLadder.ipt", "CableLadderBend.ipt", "CableLadderRiser.ipt", "CableLadderTee.ipt", "WireMeshCableTray.ipt"
                        'Deze niet "LiquilineCM444.ipt", "FlowfitCCA250.ipt", "TurbimaxCUE21.ipt",

                        Dim oSelectFace As Inventor.Face
                        oSelectFace = POI1OOII.CommandManager.Pick(Inventor.SelectionFilterEnum.kPartFacePlanarFilter, "Select a Face.")
                        If oSelectFace Is Nothing Then
                            GoTo EndRoutine
                        End If
                        Dim trans As Inventor.Matrix
                        trans = POI1OOII.TransientGeometry.CreateMatrix
                        PO0O10IO = PO00OO0I.ComponentDefinition.Occurrences.AddiPartMember((PO10I01O & P00OIOII), trans, PI0III00)
                        oInstrDoc = PO0O10IO.Definition.Document
                        Dim a = PO0O10IO.iMateDefinitions.Item(1)
                        'MsgBox(a.Name)
                        Call PO00OO0I.ComponentDefinition.Constraints.AddMateConstraint(oSelectFace, a, 0)
                        GoTo EndRoutine

                    Case Else

                        Dim oSelectEdge As Inventor.Edge
                        oSelectEdge = POI1OOII.CommandManager.Pick(Inventor.SelectionFilterEnum.kAllCircularEntities, "Select a circular edge.")
                        If oSelectEdge Is Nothing Then
                            GoTo EndRoutine
                        End If
                        Dim trans As Inventor.Matrix
                        trans = POI1OOII.TransientGeometry.CreateMatrix
                        PO0O10IO = PO00OO0I.ComponentDefinition.Occurrences.AddiPartMember((PO10I01O & P00OIOII), trans, PI0III00)
                        oInstrDoc = PO0O10IO.Definition.Document
                        Dim a = PO0O10IO.iMateDefinitions.Item(1)
                        ' MsgBox(a.Name)
                        Call PO00OO0I.ComponentDefinition.Constraints.AddInsertConstraint(oSelectEdge, a, True, 0)

                End Select

        End Select



        oInstrDoc = PO0O10IO.Definition.Document




        'MsgBox(oPartPath, vbOKOnly + "4064", "Warning")
        Dim pi As Double
        pi = Math.Acos(-1)





        'Proxyplane maken van het werkvlak paralel met het insertvlak

        Dim oCrossPlane As WorkPlane
        oCrossPlane = Nothing
        Dim oCrossPlaneProxy As WorkPlaneProxy
        oCrossPlaneProxy = Nothing
        oCrossPlane = oInstrDoc.ComponentDefinition.WorkPlanes(2)
        Call PO0O10IO.CreateGeometryProxy(oCrossPlane, oCrossPlaneProxy)

        'bepaal de hoek tussen het insertvlak en één der werkvlakken van de assembly in graden

        Dim oOrientXY As Integer
        Dim oOrientXZ As Integer
        Dim oOrientYZ As Integer

        oOrientXY = (POI1OOII.MeasureTools.GetAngle(PO00OO0I.ComponentDefinition.WorkPlanes(3), oCrossPlaneProxy) / pi * 180)
        oOrientXZ = (POI1OOII.MeasureTools.GetAngle(PO00OO0I.ComponentDefinition.WorkPlanes(2), oCrossPlaneProxy) / pi * 180)
        oOrientYZ = (POI1OOII.MeasureTools.GetAngle(PO00OO0I.ComponentDefinition.WorkPlanes(1), oCrossPlaneProxy) / pi * 180)

        'PO1O11IO is public gedeclareerd zie begin

        PO1O11IO = "Not aligned"

        'Check the orientation of the part

        If oOrientXY = 90 Then
            PO1O11IO = "XYaxis"
        End If
        If oOrientXZ = 90 Then
            PO1O11IO = "XZaxis"
        End If
        If oOrientYZ = 90 Then
            PO1O11IO = "YZaxis"
        End If

        'MsgBox(PO1O11IO)


        'MsgBox(PO1O11IO)


        POI011I0 = 0

        'Afhangkelijk van welk vlak er haaks tov het insertvlak staat wordt er een constraint gemaakt met middenvlak (werkvlak1) van het part

        If PO1O11IO = "XYaxis" Then
            Dim oPartAnglePlane As WorkPlane
            oPartAnglePlane = oInstrDoc.ComponentDefinition.WorkPlanes(1)

            PO0OOOIO = Nothing
            Try
                Call PO0O10IO.CreateGeometryProxy(oPartAnglePlane, PO0OOOIO)
                Call PO00OO0I.ComponentDefinition.Constraints.AddAngleConstraint(PO00OO0I.ComponentDefinition.WorkPlanes(3), PO0OOOIO, POI011I0, Inventor.AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try

            FormInstrumentRotate.ShowDialog()

            If FormInstrumentRotate.oEnterclick = True Then
                GoTo EndRoutine
            End If
            If FormInstrumentRotate.oEnterclick = False Then
                GoTo EnterclickFalse
            End If

        End If

        If PO1O11IO = "XZaxis" Then
            Dim oPartAnglePlane As WorkPlane
            oPartAnglePlane = oInstrDoc.ComponentDefinition.WorkPlanes(1)

            PO0OOOIO = Nothing
            Try
                Call PO0O10IO.CreateGeometryProxy(oPartAnglePlane, PO0OOOIO)
                Call PO00OO0I.ComponentDefinition.Constraints.AddAngleConstraint(PO00OO0I.ComponentDefinition.WorkPlanes(2), PO0OOOIO, POI011I0, Inventor.AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try

            FormInstrumentRotate.ShowDialog()

            If FormInstrumentRotate.oEnterclick = True Then
                GoTo EndRoutine
            End If
            If FormInstrumentRotate.oEnterclick = False Then
                GoTo EnterclickFalse
            End If
        End If

        If PO1O11IO = "YZaxis" Then
            Dim oPartAnglePlane As WorkPlane
            oPartAnglePlane = oInstrDoc.ComponentDefinition.WorkPlanes(1)

            PO0OOOIO = Nothing
            Try
                Call PO0O10IO.CreateGeometryProxy(oPartAnglePlane, PO0OOOIO)
                Call PO00OO0I.ComponentDefinition.Constraints.AddAngleConstraint(PO00OO0I.ComponentDefinition.WorkPlanes(1), PO0OOOIO, POI011I0, Inventor.AngleConstraintSolutionTypeEnum.kDirectedSolution)
            Catch
            End Try

            FormInstrumentRotate.ShowDialog()

            If FormInstrumentRotate.oEnterclick = True Then
                GoTo EndRoutine
            End If
            If FormInstrumentRotate.oEnterclick = False Then
                GoTo EnterclickFalse
            End If
        End If
        If FormInstrumentRotate.oEnterclick = False Then
            GoTo EnterclickFalse
        End If

EnterclickFalse:
        Me.Show()

EndRoutine:
        Me.Show()
    End Sub

    Private Sub cbxSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSize.SelectedIndexChanged
        P0IIOOII()
        oStreetLightIMateItem()
        oPowerPointIMateItem()
        oRotameterIMateItem()
        oStandingCabinetIMateItem()
        oHangingCabinetIMateItem()
        oJuctionBoxIMateItem()
        oLightingArmatureIMateItem()
        oCableLadderTeeIMateItem()
        oCableLadderRiserIMateItem()
        oCableLadderIMateItem()
        oCableLadderBendIMateItem()
        oWireMeshCableTrayIMateItem()
        lblDescription.Text = POO10I10 & " " & cbxSize.Text
    End Sub





End Class