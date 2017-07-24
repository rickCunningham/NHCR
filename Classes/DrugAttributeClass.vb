

Public Class DrugAttributeClass
    Public Property ProcedureCode As String
    Public Property DrugID As Integer
    Public Property BenchMarkID As Integer
    Public Property CPTCode As String
    Public Property BillingUnits As Decimal
    Public Property CopayAssist As Boolean
    Public Property CopayPayer As String
    Public Property CopayPaymentCode As String
    Public Property CopayMaximum As Decimal
    Public Property BenefitVerification As Boolean
    Public Property MfgID As Integer
    Public Property SupplierID As Integer
    Public Property OrderCoID As Integer
    Public Property StorageID As Integer
    Public Property CategoryID As Integer
    Public Property AnthemAdminCode As String
    Public Property AcctgCode As String
    Public Property HasAttributes As Integer
    Public Property DrugVials As DataTable
    Private Property DBInputTbl As DataTable


    Public Sub New()
        ProcedureCode = String.Empty
        DrugID = 0
        BenchMarkID = 0
        CPTCode = String.Empty
        BillingUnits = 0.0
        CopayAssist = False
        CopayPayer = String.Empty
        CopayPaymentCode = String.Empty
        CopayMaximum = 0.0
        BenefitVerification = False
        MfgID = 0
        SupplierID = 0
        OrderCoID = 0
        StorageID = 0
        CategoryID = 0
        AnthemAdminCode = String.Empty
        AcctgCode = String.Empty
        HasAttributes = 0
    End Sub


    Public Sub New(ByVal dt As DataTable)

        DBInputTbl = New DataTable
        DBInputTbl = dt.Clone
        Dim AttributeRow As DataRow = dt.Rows(0)
        ProcedureCode = Cast.DbNullStr(AttributeRow("ProcedureCode"))
        DrugID = Cast.DbNullInt(AttributeRow("DrugID"))
        BenchMarkID = Cast.DbNullInt(AttributeRow("BenchMarkID"))
        CPTCode = Cast.DbNullStr(AttributeRow("CPTCode"))
        BillingUnits = Cast.DBNullDec(AttributeRow("BillingUnits"))
        CopayAssist = Cast.DbNullBoolean(AttributeRow("CopayAssist"))
        CopayPayer = Cast.DbNullStr(AttributeRow("CopayPayer"))
        CopayPaymentCode = Cast.DbNullStr(AttributeRow("CopayPaymentCode"))
        CopayMaximum = Cast.DBNullDec(AttributeRow("CopayMaximum"))
        BenefitVerification = Cast.DbNullBoolean(AttributeRow("BenefitVerification"))
        MfgID = Cast.DbNullInt(AttributeRow("MfgID"))
        SupplierID = Cast.DbNullInt(AttributeRow("SupplierID"))
        OrderCoID = Cast.DbNullInt(AttributeRow("OrderCoID"))
        StorageID = Cast.DbNullInt(AttributeRow("StorageID"))
        CategoryID = Cast.DbNullInt(AttributeRow("CategoryID"))
        AnthemAdminCode = Cast.DbNullStr(AttributeRow("AnthemAdminCode"))
        AcctgCode = Cast.DbNullStr(AttributeRow("AcctgCode"))
        HasAttributes = Cast.DbNullInt(AttributeRow("HasAttributes"))
        DrugVials = DBDrugs.GetDrugVials(DrugID)



    End Sub

    Public Sub Save(ByVal NewVials As DataTable)
        DBInputTbl.Columns.Remove("ProcedureCode")
        DBInputTbl.Columns.Remove("HasAttributes")
        Dim AttributeRow As DataRow = DBInputTbl.NewRow
        AttributeRow("DrugID") = DrugID
        AttributeRow("BenchMarkID") = BenchMarkID
        AttributeRow("CPTCode") = CPTCode
        AttributeRow("BillingUnits") = BillingUnits
        AttributeRow("CopayAssist") = CopayAssist
        AttributeRow("CopayPayer") = CopayPayer
        AttributeRow("CopayPaymentCode") = CopayPaymentCode
        AttributeRow("CopayMaximum") = CopayMaximum
        AttributeRow("BenefitVerification") = BenefitVerification
        AttributeRow("MfgID") = MfgID
        AttributeRow("SupplierID") = SupplierID
        AttributeRow("OrderCoID") = OrderCoID
        AttributeRow("StorageID") = StorageID
        AttributeRow("CategoryID") = CategoryID
        AttributeRow("AnthemAdminCode") = AnthemAdminCode
        AttributeRow("AcctgCode") = AcctgCode

        DBInputTbl.Rows.Add(AttributeRow)


        If HasAttributes > 0 Then Update() Else Insert()
        If Not IsNothing(NewVials) Then AddVials(NewVials)
    End Sub

    Public Sub AddVials(ByVal Vials As DataTable)
        DBDrugs.InsertDrugVialLinks(Vials)
    End Sub

    Private Sub Insert()
        DBDrugs.InsertDrugAttributes(DBInputTbl)

    End Sub

    Private Sub Update()
        DBDrugs.UpdateDrugAttributesTbl(DBInputTbl)
    End Sub
End Class
