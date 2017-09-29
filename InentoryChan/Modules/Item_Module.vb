Module Item_Module
    Dim DAItem As New DSItemTableAdapters.ITEMTableAdapter
    Dim DACategory As New DSItemTableAdapters.CATEGORYTableAdapter
    Dim DAStore As New DSItemTableAdapters.ITEM_STORETableAdapter
    Dim DAUser As New DSItemTableAdapters.USERTableAdapter
    Dim DARate As New DSRevenueTableAdapters.EXCHANGE_RATETableAdapter
    Dim DA_ComProfile As New DSRevenueTableAdapters.COMPANY_PROFILETableAdapter
    Dim UserID As Integer
    Public UserName1 As String
    Dim DAUserRight As New DSItemTableAdapters.USER_RIGHTTableAdapter
    Dim ComProfile As String
    Dim ComAddress As String
    Function VerifyUser(ByVal UserName As String, ByVal Password As String) As Boolean
        Dim Result As Boolean = False
        Dim UserTable As New DataTable
        UserTable = DAUser.VerifyUser(UserName, Password)
        UserName1 = UserName
        If UserTable.Rows.Count >= 1 Then
            UserID = UserTable.Rows(0).Item("USER_ID").ToString
            ' UserName = UserTable.Rows(0).Item("USER_NAME").ToString
            Result = True
        End If
        Return Result
    End Function
    Function GetCategoryNameByID(ByVal ID As Integer) As String
        Dim CateName As String = ""
        Dim DataTable As New DataTable
        DataTable = DACategory.SelectCategoryByID(ID)
        If DataTable.Rows.Count >= 1 Then
            CateName = DataTable.Rows(0).Item("CATE_NAME_CHN")
        Else
            CateName = ""
            GetCurrentUserName()

        End If
        Return CateName
    End Function
    Function GetStoreID(ByVal ITEM_ID As Integer, ByVal UNIT_ID As Integer) As Integer
        Dim StoreID As Integer = 0
        Dim DataTable As New DataTable
        DataTable = DAStore.SelectStoreID(ITEM_ID, UNIT_ID)
        If DataTable.Rows.Count >= 1 Then
            StoreID = DataTable.Rows(0).Item("STOR_ID")
        Else
            StoreID = 0
        End If
        Return StoreID
    End Function
    Function GetStoreBalance(ByVal ITEM_ID As Integer, ByVal UNIT_ID As Integer) As Double
        Dim StoreBalance As Double = 0
        Dim DataTable As New DataTable
        DataTable = DAStore.SelectStoreID(ITEM_ID, UNIT_ID)
        If DataTable.Rows.Count >= 1 Then
            StoreBalance = DataTable.Rows(0).Item("ITEM_BALANCE")
        Else
            StoreBalance = 0
        End If
        Return StoreBalance
    End Function
    Sub LoadingComProfile()
        Dim TblPro As DataTable = DA_ComProfile.GetData
        For Each row As DataRow In TblPro.Rows
            ComProfile = row("PROFILE_NAME")
            ComAddress = row("ADDRESS")
        Next
    End Sub
    Function GetComName() As String
        Return ComProfile
    End Function
    Function GetComAddress() As String
        Return ComAddress
    End Function
    Function GetMainStoreID(ByVal ITEM_ID As Integer) As Integer
        Dim StoreID As Integer = 0
        Dim DataTable As New DataTable
        DataTable = DAStore.SelectMainStoreID(ITEM_ID)
        If DataTable.Rows.Count >= 1 Then
            StoreID = DataTable.Rows(0).Item("STOR_ID")
        Else
            StoreID = 0
        End If
        Return StoreID
    End Function
    Function GetMainStoreQty(ByVal ITEM_ID As Integer) As Decimal
        Dim StoreQty As Decimal = 0
        Dim DataTable As New DataTable
        DataTable = DAStore.SelectMainStoreID(ITEM_ID)
        If DataTable.Rows.Count >= 1 Then
            StoreQty = CDbl(DataTable.Rows(0).Item("ITEM_BALANCE"))
        Else
            StoreQty = 0
        End If
        Return StoreQty
    End Function
    Function getCurrentUserID() As Integer
        Return UserID
    End Function
    Function GetCurrentUserName() As String
        Return UserName1
    End Function
    Function GetExchangeRage() As Double
        Try
            Return DARate.SelectValRate
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Function IsRightOffered(ByVal AccessRight As String) As Boolean
        Dim Result As Boolean = False
        If DAUser.SelectUserByID(getCurrentUserID).Rows(0).Item("USER_GROUP") <> "Administrator" Then
            If DAUserRight.SelectRightByUserID(getCurrentUserID, AccessRight).Rows.Count >= 1 Then
                Result = True
            End If
        Else
            Result = True
        End If
        Return Result
    End Function
    Function GetLocationID(ByVal USER_ID As Integer) As Integer
        Dim LocationID As Integer
        Dim DataTable As New DataTable
        DataTable = DAUser.SelectUserByID(USER_ID)
        LocationID = CInt(DataTable.Rows(0).Item("LOCA_ID"))
        Return LocationID
    End Function
End Module
