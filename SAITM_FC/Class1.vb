
'=====================================================================
'
'Developed by Badde Liyanage Don Dilanga. bld@dilanga.com. 
'SAITM VB.NET Project on 2009 /10/02 
'
'=====================================================================

'//Make a library file so you can use this as a reference
'//two datas should be inserted 

'_value : the value need to be converted
'_symbol : the identifer

'and you got FtoC (the answer as return)

Public Class SAITM_FC_BLD_Dilanga

    Dim _getValue As Double

    Public Function FtoC(ByVal _value As Double, ByVal _symbol As String) As Double
        '//symbol is required to identify which procedure should be done
        '//either F to C or C to F 

        'F is Farenheit 
        'C is Celcius

        If (_symbol = "CtoF") Then

            _getValue = Val((_value + 160) / 5)

        ElseIf (_symbol = "FtoC") Then

            _getValue = Val((5 * _value) - 160)

        End If

        Return _getValue

    End Function

End Class
