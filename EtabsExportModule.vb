Imports System.IO
Imports Microsoft.Office.Interop.Excel

Module EtabsModule

    'Grid systems

    Dim NumberNames As Long
    Dim MyName() As String

    'Grids of said systems

    Dim Xo As Double
    Dim Yo As Double
    Dim RZ As Double
    Dim StoryRangeIsDefault As Boolean
    Dim TopStory As String
    Dim BottomStory As String
    Dim BubbleSize As Double
    Dim GridColor As Long
    Dim NumXLines As Long
    Dim GridLineIDX() As String
    Dim OrdinateX() As Double
    Dim VisibleX() As Boolean
    Dim BubbleLocX() As String
    Dim NumYLines As Long
    Dim GridLineIDY() As String
    Dim OrdinateY() As Double
    Dim VisibleY() As Boolean
    Dim BubbleLocY() As String
    Dim NumGenLines As Long
    Dim GridLineIDGen() As String
    Dim GenOrdX1() As Double
    Dim GenOrdY1() As Double
    Dim GenOrdX2() As Double
    Dim GenOrdY2() As Double
    Dim VisibleGen() As Boolean
    Dim BubbleLocGen() As String

    'Story

    Dim NumberStories As Long
    Dim StoryNames() As String
    Dim StoryHeights() As Double
    Dim StoryElevations() As Double
    Dim IsMasterStory() As Boolean
    Dim SimilarToStory() As String
    Dim SpliceAbove() As Boolean
    Dim SpliceHeight() As Double

    'Frame

    Dim NumberNames2 As Long
    Dim MyName2() As String
    Dim PropName() As String
    Dim PointName1() As String
    Dim PointName2() As String
    Dim Point1X() As Double
    Dim Point1Y() As Double
    Dim Point1Z() As Double
    Dim Point2X() As Double
    Dim Point2Y() As Double
    Dim Point2Z() As Double
    Dim Angle() As Double
    Dim Offset1X() As Double
    Dim Offset1Y() As Double
    Dim Offset1Z() As Double
    Dim Offset2X() As Double
    Dim Offset2Y() As Double
    Dim Offset2Z() As Double
    Dim CardinalPoint() As Integer
    Dim StoryNames2() As String

    'Areas

    Dim NumberNames3 As Long
    Dim Myname3() As String
    Dim DesignOrientation() As ETABSv17.eAreaDesignOrientation 'ETABS2016.eAreaDesignOrientation 
    Dim NumberBoundaryPts As Integer
    Dim PointDelimiter() As Integer
    Dim PointNames() As String
    Dim PointX() As Double
    Dim PointY() As Double
    Dim PointZ() As Double
    Dim PropName2 As String = ""

    'Frame Sections

    Dim NumberNames4 As Long
    Dim MyName4() As String
    Dim PropType() As ETABSv17.eFramePropType 'ETABS2016.eFramePropType
    Dim t3() As Double
    Dim t2() As Double
    Dim tf() As Double
    Dim tw() As Double
    Dim t2b() As Double
    Dim tfb() As Double

    Dim NumberNames5 As Integer
    Dim MyName5() As String

    'Area Sections

    Dim ShellType As ETABSv17.eShellType 'ETABS2016.eShellType
    Dim MatProp As String = ""
    Dim Thickness As Double
    Dim Colors As Integer
    Dim Notes As String = ""
    Dim GUID As String = ""
    Dim DeckType As ETABSv17.eDeckType 'ETABS2016.eDeckType
    Dim WallPropType As ETABSv17.eWallPropType 'ETABS2016.eWallPropType
    Dim SlabType As ETABSv17.eSlabType 'ETABS2016.eSlabType

    'Material Properties

    Dim NumberNames6 As Integer
    Dim MyName6() As String
    Dim MatType As ETABSv17.eMatType 'ETABS2016.eMatType

    Dim Fy As Double
    Dim Fu As Double
    Dim EFy As Double
    Dim EFu As Double
    Dim SSType As Integer
    Dim SSHysType As Integer
    Dim StrainAtHardening As Double
    Dim StrainAtMaxStress As Double
    Dim StrainAtRupture As Double
    Dim FinalSlope As Double

    Dim Fc As Double
    Dim IsLightWeight As Boolean
    Dim FcsFactor As Double
    Dim StrainAtFc As Double
    Dim StrainUltimate As Double
    Dim FrictionAngle As Double
    Dim DilatationalAngle As Double

    Dim UseCaltransSSDefaults As Boolean





    Dim i As Integer
    Dim a As Integer





    Public Sub FillEtabsData()

        'set the following flag to True to attach to a running instance of the program
        'otherwise a new instance of the program will be started
        Dim AttachToInstance As Boolean
        AttachToInstance = False

        'set the following flag to True to manually specify the path to ETABS.exe
        'this allows for a connection to a version of ETABS other than the latest installation
        'otherwise the latest installed version of ETABS will be launched
        Dim SpecifyPath As Boolean
        SpecifyPath = False

        'if the above flag is set to True, specify the path to ETABS below
        Dim ProgramPath As String
        'ProgramPath = "C:\Program Files (x86)\Computers and Structures\ETABS 2016\ETABS.exe"

        'full path to the model

        Dim ModelName As String = Path.GetFileNameWithoutExtension(ModelTransfer.ExportFileLoc.FileName) & ".edb"
        Dim ModelPath As String = ModelTransfer.ExportFileLocBrowse.Text

        'dimension the ETABS Object as cOAPI type
        Dim ETABSObject As ETABSv17.cOAPI = Nothing 'ETABS2016.cOAPI = Nothing

        'Use ret to check if functions return successfully (ret = 0) or fail (ret = nonzero)
        Dim ret As Integer
        Dim ret2 As Integer
        Dim ret3 As Integer

        If AttachToInstance Then
            'attach to a running instance of ETABS
            Try
                'get the active ETABS object
                ETABSObject = DirectCast(System.Runtime.InteropServices.Marshal.GetActiveObject("CSI.ETABS.API.ETABSObject"), ETABSv17.cOAPI) 'ETABS2016.cOAPI)
            Catch ex As Exception
                MsgBox("No running instance of the program found or failed to attach.")
                Return
            End Try
        Else
            'create API helper object
            Dim myHelper As ETABSv17.cHelper 'ETABS2016.cHelper
            Try
                myHelper = New ETABSv17.Helper 'ETABS2016.Helper
            Catch ex As Exception
                MsgBox("Cannot create an instance of the Helper object")
            End Try

            Try
                'create an instance of the ETABS object from the latest installed ETABS
                ETABSObject = myHelper.CreateObjectProgID("CSI.ETABS.API.ETABSObject")
            Catch ex As Exception
                MsgBox("Cannot start a new instance of the program.")
                Return
            End Try


            'start ETABS application
            ret = ETABSObject.ApplicationStart()
        End If

        'Get a reference to cSapModel to access all API classes and functions
        Dim SapModel As ETABSv17.cSapModel 'ETABS2016.cSapModel
        SapModel = ETABSObject.SapModel

        'Open The selected model
        ret = SapModel.File.OpenFile(ModelPath)

        Dim CSVData(53, 5) As String

        'Get Grid Infos

        Dim GridData(10, 50) As String

        Dim NumXlinesCount As Integer = 0
        Dim NumYlinesCount As Integer = 0
        Dim NumGenlinesCount As Integer = 0


        ret = SapModel.GridSys.GetNameList(NumberNames, MyName)

        For a = 0 To NumberNames - 1

            ret = SapModel.GridSys.GetGridSysCartesian(MyName(a), Xo, Yo, RZ, StoryRangeIsDefault, TopStory, BottomStory, BubbleSize,
            GridColor, NumXLines, GridLineIDX, OrdinateX, VisibleX, BubbleLocX, NumYLines, GridLineIDY, OrdinateY, VisibleY,
            BubbleLocY, NumGenLines, GridLineIDGen, GenOrdX1, GenOrdY1, GenOrdX2, GenOrdY2, VisibleGen, BubbleLocGen)


            If Math.Max(Math.Max(NumXlinesCount + NumXLines, NumYlinesCount + NumYLines), NumGenlinesCount + NumGenLines) - 1 > UBound(CSVData, 2) Then
                ReDim Preserve CSVData(53, Math.Max(Math.Max(NumXlinesCount + NumXLines, NumYlinesCount + NumYLines), NumGenlinesCount + NumGenLines) - 1)
                ReDim Preserve GridData(10, Math.Max(Math.Max(NumXlinesCount + NumXLines, NumYlinesCount + NumYLines), NumGenlinesCount + NumGenLines) - 1)
            End If

            For i = 0 To NumXLines - 1

                GridData(0, i + NumXlinesCount) = GridLineIDX(i)
                GridData(1, i + NumXlinesCount) = OrdinateX(i) / 12

                CSVData(0, i + NumXlinesCount) = GridLineIDX(i)
                CSVData(1, i + NumXlinesCount) = OrdinateX(i) / 12

            Next i



            For i = 0 To NumYLines - 1

                GridData(3, i + NumYlinesCount) = GridLineIDY(i)
                GridData(4, i + NumYlinesCount) = OrdinateY(i) / 12

                CSVData(3, i + NumYlinesCount) = GridLineIDY(i)
                CSVData(4, i + NumYlinesCount) = OrdinateY(i) / 12

            Next i

            For i = 0 To NumGenLines - 1

                'MessageBox.Show(i, GridLineIDGen(i))

                GridData(6, i + NumGenlinesCount) = GridLineIDGen(i)
                GridData(7, i + NumGenlinesCount) = GenOrdX1(i) / 12
                GridData(8, i + NumGenlinesCount) = GenOrdY1(i) / 12
                GridData(9, i + NumGenlinesCount) = GenOrdX2(i) / 12
                GridData(10, i + NumGenlinesCount) = GenOrdY2(i) / 12

                CSVData(6, i + NumGenlinesCount) = GridLineIDGen(i)
                CSVData(7, i + NumGenlinesCount) = GenOrdX1(i) / 12
                CSVData(8, i + NumGenlinesCount) = GenOrdY1(i) / 12
                CSVData(9, i + NumGenlinesCount) = GenOrdX2(i) / 12
                CSVData(10, i + NumGenlinesCount) = GenOrdY2(i) / 12

            Next i

            NumXlinesCount = NumXlinesCount + NumXLines
            NumYlinesCount = NumYlinesCount + NumYLines
            NumGenlinesCount = NumGenlinesCount + NumGenLines

        Next a



        'Get Stories Information

        Dim StoryData(2, 30) As String

        ret = SapModel.Story.GetStories(NumberStories, StoryNames, StoryHeights, StoryElevations,
                                   IsMasterStory, SimilarToStory, SpliceAbove, SpliceHeight)

        If NumberStories - 1 > UBound(CSVData, 2) Then
            ReDim Preserve CSVData(53, NumberStories - 1)
        End If


        For i = 0 To NumberStories - 1

            StoryData(0, i) = StoryNames(i)
            StoryData(1, i) = StoryHeights(i) / 12

            CSVData(12, i) = StoryNames(i)
            CSVData(13, i) = StoryHeights(i) / 12

        Next


        'Get All Frames Information

        Dim FrameData(10, 5000) As String
        ret = SapModel.FrameObj.GetAllFrames(NumberNames2, MyName2, PropName, StoryNames2, PointName1, PointName2, Point1X, Point1Y, Point1Z, Point2X, Point2Y, Point2Z,
                                     Angle, Offset1X, Offset2X, Offset1Y, Offset2Y, Offset1Z, Offset2Z, CardinalPoint)
        'MessageBox.Show(NumberNames2)

        If NumberNames2 - 1 > UBound(CSVData, 2) Then
            ReDim Preserve CSVData(53, NumberNames2 - 1)
        End If

        If NumberNames2 - 1 > UBound(FrameData, 2) Then
            ReDim Preserve FrameData(10, NumberNames2 - 1)
        End If

        For i = 0 To NumberNames2 - 1

            FrameData(0, i) = MyName2(i)
            FrameData(1, i) = Point1X(i) / 12
            FrameData(2, i) = Point1Y(i) / 12
            FrameData(3, i) = Point1Z(i) / 12
            FrameData(4, i) = Point2X(i) / 12
            FrameData(5, i) = Point2Y(i) / 12
            FrameData(6, i) = Point2Z(i) / 12

            FrameData(8, i) = Math.Acos((FrameData(6, i) - FrameData(3, i)) / ((FrameData(4, i) - FrameData(1, i)) ^ 2 + (FrameData(5, i) - FrameData(2, i)) ^ 2 + (FrameData(6, i) - FrameData(3, i)) ^ 2) ^ 0.5) * 180 / Math.PI
            FrameData(9, i) = PropName(i)
            FrameData(10, i) = Offset1X(i) / 12

            CSVData(35, i) = MyName2(i)
            CSVData(36, i) = Point1X(i) / 12
            CSVData(37, i) = Point1Y(i) / 12
            CSVData(38, i) = Point1Z(i) / 12
            CSVData(39, i) = Point2X(i) / 12
            CSVData(40, i) = Point2Y(i) / 12
            CSVData(41, i) = Point2Z(i) / 12

            CSVData(42, i) = Math.Acos((FrameData(6, i) - FrameData(3, i)) / ((FrameData(4, i) - FrameData(1, i)) ^ 2 + (FrameData(5, i) - FrameData(2, i)) ^ 2 + (FrameData(6, i) - FrameData(3, i)) ^ 2) ^ 0.5) * 180 / Math.PI
            CSVData(43, i) = PropName(i)

        Next


        'Get all Areas Information

        Dim AreaData(7, 10000) As String
        Dim TotalAreaPoints As Integer



        ret = SapModel.AreaObj.GetAllAreas(NumberNames3, Myname3, DesignOrientation, NumberBoundaryPts, PointDelimiter, PointNames, PointX, PointY, PointZ)

        TotalAreaPoints = NumberBoundaryPts

        If Math.Max(NumberNames2, TotalAreaPoints) - 1 > UBound(CSVData, 2) Then
            ReDim Preserve CSVData(53, Math.Max(NumberNames2, TotalAreaPoints) - 1)
        End If

        ret2 = SapModel.AreaObj.GetProperty(Myname3(0), PropName2)

        AreaData(0, 0) = Myname3(0)
        AreaData(1, 0) = DesignOrientation(0)
        AreaData(2, 0) = PointDelimiter(0)
        AreaData(3, 0) = PropName2

        CSVData(46, 0) = Myname3(0)
        If DesignOrientation(0) = 1 Then
            CSVData(47, 0) = "Wall"
        ElseIf DesignOrientation(0) = 2 Then
            CSVData(47, 0) = "Floor"
        End If
        CSVData(48, 0) = PointDelimiter(0) + 1
        CSVData(49, 0) = PropName2

        For i = 1 To NumberNames3 - 1

            ret2 = SapModel.AreaObj.GetProperty(Myname3(i), PropName2)

            AreaData(0, PointDelimiter(i - 1) + 1) = Myname3(i)
            AreaData(1, PointDelimiter(i - 1) + 1) = DesignOrientation(i)
            AreaData(2, PointDelimiter(i - 1) + 1) = PointDelimiter(i) - PointDelimiter(i - 1)
            AreaData(3, PointDelimiter(i - 1) + 1) = PropName2

            CSVData(46, PointDelimiter(i - 1) + 1) = Myname3(i)
            If DesignOrientation(i) = 1 Then
                CSVData(47, PointDelimiter(i - 1) + 1) = "Wall"
            ElseIf DesignOrientation(i) = 2 Then
                CSVData(47, PointDelimiter(i - 1) + 1) = "Floor"
            End If
            CSVData(48, PointDelimiter(i - 1) + 1) = PointDelimiter(i) - PointDelimiter(i - 1)
            CSVData(49, PointDelimiter(i - 1) + 1) = PropName2

        Next

        For i = 0 To NumberBoundaryPts - 1

            AreaData(4, i) = PointNames(i)
            AreaData(5, i) = PointX(i) / 12
            AreaData(6, i) = PointY(i) / 12
            AreaData(7, i) = PointZ(i) / 12

            CSVData(50, i) = PointNames(i)
            CSVData(51, i) = PointX(i) / 12
            CSVData(52, i) = PointY(i) / 12
            CSVData(53, i) = PointZ(i) / 12

        Next


        'Get all Frame Sections Information

        Dim FrameSectionData(7, 1000) As String
        Dim SectionShape(1000) As String



        ret = SapModel.PropFrame.GetAllFrameProperties(NumberNames4, MyName4, PropType, t3, t2, tf, tw, t2b, tfb)


        If NumberNames4 - 1 > UBound(CSVData, 2) Then
            ReDim Preserve CSVData(53, NumberNames4 - 1)
        End If

        For i = 0 To NumberNames4 - 1

            If PropType(i) = 1 Then
                SectionShape(i) = "I-Shape"
            ElseIf PropType(i) = 2 Then
                SectionShape(i) = "Channel"
            ElseIf PropType(i) = 3 Then
                SectionShape(i) = "T"
            ElseIf PropType(i) = 4 Then
                SectionShape(i) = "Angle"
            ElseIf PropType(i) = 5 Then
                SectionShape(i) = "DblAngle"
            ElseIf PropType(i) = 6 Then
                SectionShape(i) = "Box"
            ElseIf PropType(i) = 7 Then
                SectionShape(i) = "Pipe"
            ElseIf PropType(i) = 8 Then
                SectionShape(i) = "Rectangular"
            ElseIf PropType(i) = 9 Then
                SectionShape(i) = "Circle"
            ElseIf PropType(i) = 11 Then
                SectionShape(i) = "DbChannel"
            Else SectionShape(i) = "Other"
            End If

            FrameSectionData(0, i) = MyName4(i)
            FrameSectionData(1, i) = SectionShape(i)
            FrameSectionData(2, i) = t3(i)
            FrameSectionData(3, i) = t2(i)
            FrameSectionData(4, i) = tf(i)
            FrameSectionData(5, i) = tw(i)
            FrameSectionData(6, i) = t2b(i)
            FrameSectionData(7, i) = tfb(i)

            CSVData(20, i) = MyName4(i)
            CSVData(21, i) = SectionShape(i)
            CSVData(22, i) = t3(i)
            CSVData(23, i) = t2(i)
            CSVData(24, i) = tf(i)
            CSVData(25, i) = tw(i)
            CSVData(26, i) = t2b(i)
            CSVData(27, i) = tfb(i)

        Next


        'Get all Area Section Data

        Dim AreaSectionData(4, 500) As String

        Dim Shell As String = ""


        ret = SapModel.PropArea.GetNameList(NumberNames5, MyName5)


        If NumberNames5 - 1 > UBound(CSVData, 2) Then
            ReDim Preserve CSVData(53, NumberNames5 - 1)
        End If

        For i = 0 To NumberNames5 - 1

            Shell = Nothing
            ShellType = Nothing
            MatProp = ""
            Thickness = Nothing
            WallPropType = Nothing

            ret2 = SapModel.PropArea.GetWall(MyName5(i), WallPropType, ShellType, MatProp, Thickness, Colors, Notes, GUID)

            If ShellType = 1 Then
                Shell = "ShellThin"
            ElseIf ShellType = 2 Then
                Shell = "ShellThick"
            ElseIf ShellType = 2 Then
                Shell = "Membrane"
            End If

            If Thickness <> 0 Then

                AreaSectionData(0, i) = MyName5(i)
                AreaSectionData(1, i) = Shell
                AreaSectionData(2, i) = MatProp
                AreaSectionData(3, i) = Thickness
                If WallPropType = 1 Then
                    AreaSectionData(4, i) = "Wall"
                End If

                CSVData(29, i) = MyName5(i)
                CSVData(30, i) = Shell
                CSVData(31, i) = MatProp
                CSVData(32, i) = Thickness
                If WallPropType = 1 Then
                    CSVData(33, i) = "Wall"
                End If

            End If

            Shell = Nothing
            ShellType = Nothing
            MatProp = ""
            Thickness = Nothing
            DeckType = Nothing

            ret2 = SapModel.PropArea.GetDeck(MyName5(i), DeckType, ShellType, MatProp, Thickness, Colors, Notes, GUID)

            If ShellType = 1 Then
                Shell = "ShellThin"
            ElseIf ShellType = 2 Then
                Shell = "ShellThick"
            ElseIf ShellType = 2 Then
                Shell = "Membrane"
            End If

            If Thickness <> 0 Then

                AreaSectionData(0, i) = MyName5(i)
                AreaSectionData(1, i) = Shell
                AreaSectionData(2, i) = MatProp
                AreaSectionData(3, i) = Thickness
                If DeckType = 1 Then
                    AreaSectionData(4, i) = "Filled Deck"
                ElseIf DeckType = 2 Then
                    AreaSectionData(4, i) = "Unfilled Deck"
                ElseIf DeckType = 3 Then
                    AreaSectionData(4, i) = "SolidSlab"
                End If

                CSVData(29, i) = MyName5(i)
                CSVData(30, i) = Shell
                CSVData(31, i) = MatProp
                CSVData(32, i) = Thickness
                If DeckType = 1 Then
                    CSVData(33, i) = "Filled Deck"
                ElseIf DeckType = 2 Then
                    CSVData(33, i) = "Unfilled Deck"
                ElseIf DeckType = 3 Then
                    CSVData(33, i) = "SolidSlab"
                End If

            End If

            Shell = Nothing
            ShellType = Nothing
            MatProp = ""
            Thickness = Nothing
            DeckType = Nothing

            ret2 = SapModel.PropArea.GetSlab(MyName5(i), SlabType, ShellType, MatProp, Thickness, Colors, Notes, GUID)

            If ShellType = 1 Then
                Shell = "ShellThin"
            ElseIf ShellType = 2 Then
                Shell = "ShellThick"
            ElseIf ShellType = 2 Then
                Shell = "Membrane"
            End If

            If Thickness <> 0 Then

                AreaSectionData(0, i) = MyName5(i)
                AreaSectionData(1, i) = Shell
                AreaSectionData(2, i) = MatProp
                AreaSectionData(3, i) = Thickness
                If SlabType = 0 Then
                    AreaSectionData(4, i) = "Slab"
                ElseIf SlabType = 2 Then
                    AreaSectionData(4, i) = "Drop Slab"
                ElseIf SlabType = 3 Then
                    AreaSectionData(4, i) = "Ribbed Slab"
                ElseIf SlabType = 4 Then
                    AreaSectionData(4, i) = "Waffle Slab"
                End If

                CSVData(29, i) = MyName5(i)
                CSVData(30, i) = Shell
                CSVData(31, i) = MatProp
                CSVData(32, i) = Thickness
                If SlabType = 0 Then
                    CSVData(33, i) = "Slab"
                ElseIf SlabType = 2 Then
                    CSVData(33, i) = "Drop Slab"
                ElseIf SlabType = 3 Then
                    CSVData(33, i) = "Ribbed Slab"
                ElseIf SlabType = 4 Then
                    CSVData(33, i) = "Waffle Slab"
                End If


            End If

        Next

        'Get Material Properties

        Dim MaterialData(3, 500) As String

        ret = SapModel.PropMaterial.GetNameList(NumberNames6, MyName6)


        If NumberNames6 - 1 > UBound(CSVData, 2) Then
            ReDim Preserve CSVData(53, NumberNames6 - 1)
        End If

        For i = 0 To NumberNames6 - 1

            MatType = Nothing

            ret = SapModel.PropMaterial.GetMaterial(MyName6(i), MatType, Colors, Notes, GUID)

            MaterialData(0, i) = MyName6(i)
            CSVData(15, i) = MyName6(i)

            If MatType = 1 Then
                ret2 = SapModel.PropMaterial.GetOSteel_1(MyName6(i), Fy, Fu, EFy, EFu, SSType, SSHysType, StrainAtHardening, StrainAtMaxStress, StrainAtRupture, FinalSlope)
                MaterialData(1, i) = "Steel"
                MaterialData(2, i) = Fy
                MaterialData(3, i) = Fu

                CSVData(16, i) = "Steel"
                CSVData(17, i) = Fy
                CSVData(18, i) = Fu

            ElseIf MatType = 2 Then
                ret2 = SapModel.PropMaterial.GetOConcrete_1(MyName6(i), Fc, IsLightWeight, FcsFactor, SSType, SSHysType, StrainAtFc, StrainUltimate, FinalSlope, FrictionAngle, DilatationalAngle)
                MaterialData(1, i) = "Concrete"
                MaterialData(2, i) = Fc
                If IsLightWeight = True Then
                    MaterialData(3, i) = "LightWeight"
                Else MaterialData(3, i) = "Normal Weight"
                End If

                CSVData(16, i) = "Concrete"
                CSVData(17, i) = Fc
                If IsLightWeight = True Then
                    CSVData(18, i) = "LightWeight"
                Else CSVData(18, i) = "Normal Weight"
                End If


            ElseIf MatType = 5 Then
                MaterialData(1, i) = "Cold-Formed"
                CSVData(16, i) = "Cold-Formed"

            ElseIf MatType = 6 Then
                ret2 = SapModel.PropMaterial.GetORebar_1(MyName6(i), Fy, Fu, EFy, EFu, SSType, SSHysType, StrainAtHardening, StrainUltimate, FinalSlope, UseCaltransSSDefaults)
                MaterialData(1, i) = "Rebar"
                MaterialData(2, i) = Fy
                MaterialData(3, i) = Fu

                CSVData(16, i) = "Rebar"
                CSVData(17, i) = Fy
                CSVData(18, i) = Fu

            ElseIf MatType = 7 Then
                ret2 = SapModel.PropMaterial.GetOTendon_1(MyName6(i), Fy, Fu, SSType, SSHysType, FinalSlope)
                MaterialData(1, i) = "Tendon"
                MaterialData(2, i) = Fy
                MaterialData(3, i) = Fu

                CSVData(16, i) = "Tendon"
                CSVData(17, i) = Fy
                CSVData(18, i) = Fu

            ElseIf MatType = 8 Then
                MaterialData(1, i) = "Masonry"
                CSVData(16, i) = "Masonry"
            End If

        Next


        Dim sw As System.IO.StreamWriter = New System.IO.StreamWriter(ModelTransfer.CsvFileLocBrowse.Text)
        Dim StrLine As String = ""


        sw.WriteLine("ETABS,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.")
        sw.WriteLine(NumXLines.ToString + ",.,.," + NumYLines.ToString + ",.,.," + NumGenLines.ToString + ",.,.,.,.,.," + NumberStories.ToString + ",.,.," + NumberNames6.ToString + ",.,.,.,.," + NumberNames4.ToString + ",.,.,.,.,.,.,.,.," + NumberNames5.ToString + ",.,.,.,.,.," + NumberNames2.ToString + ",.,.,.,.,.,.,.,.,.,.," + NumberNames3.ToString + ",.,.,.," + NumberBoundaryPts.ToString + ",.,.,.")
        sw.WriteLine("GridX,X(ft),,GridY,Y(ft),,GridGen,X1(ft),Y1(ft),X2(ft),Y2(ft),,Level,El.(ft),,MatName,Material,Fy/f'c,Fu/Wt,,ShapeName,Type,t3(in),t2(in),tf(in),tw(in),t2b(in),tfb(in),,AreaName,ShellType,Material,Thickness(in),Prop,,FrameName,X1(ft),Y1(ft),Z1(ft),X2(ft),Y2(ft),Z2(ft),Angle,Shape,,,AreaName,Wall/Floor,PtNumber,MatProp,PointName,X(ft),Y(ft),Z(ft)")

        'ReDim Preserve CSVData(53, 5000)

        For i = 0 To UBound(CSVData, 2) 'Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(NumYLines, NumXLines), NumGenLines), NumberStories), NumberNames6), NumberNames4), NumberNames5), NumberNames2), NumberNames3), TotalAreaPoints) - 1

            For a = 0 To UBound(CSVData, 1)
                If IsNumeric(CSVData(a, i)) Then
                    StrLine += Math.Round(CDbl(CSVData(a, i)), 2).ToString + ","
                Else StrLine += CSVData(a, i) + ","
                End If
            Next a

            sw.WriteLine(StrLine)
            StrLine = ""
        Next i

        sw.Flush()
        sw.Close()



        'Dim sb As New Text.StringBuilder

        'sb.Append()

        'For i = 0 To UBound(CSVData) 'Math.Max(Math.Max(NumYLines - 1, NumXLines - 1), NumGenLines - 1)

        '    For a = 0 To 53
        '        sb.Append(CSVData(a, i) + ",")
        '    Next a

        '    sb.Remove(sb.Length - 1, 1) 'Remove trailing ","
        '    sb.Append(Environment.NewLine) 'Finish the current line

        'Next i

        ''Write the file
        'My.Computer.FileSystem.WriteAllText(ModelTransfer.CsvFileLoc.Text, sb.ToString(), False)










        'Close ETABS
        ETABSObject.ApplicationExit(False)

        'Clean up variables
        SapModel = Nothing
        ETABSObject = Nothing

        'Open csv file

        Dim Excel As New Microsoft.Office.Interop.Excel.Application
        Dim CSVFile As Workbook
        CSVFile = Excel.Workbooks.Open(ModelTransfer.CsvFileLocBrowse.Text)
        Excel.Visible = True




        'Check ret value
        'If ret = 0 Then
        '    MsgBox("API script completed successfully.")
        'Else
        '    MsgBox("API script FAILED to complete.")
        'End If


    End Sub


End Module
