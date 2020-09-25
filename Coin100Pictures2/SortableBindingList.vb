Imports System.ComponentModel
Imports System.Runtime
Imports System.Reflection

Friend Class SortableBindingList(Of T)
    Inherits BindingList(Of T)

    Friend Class PropertyComparer
        Inherits Comparer(Of T)

        Private prop As PropertyDescriptor

        Private comparer As IComparer

        Private direction As ListSortDirection

        Private useToString As Boolean

        Friend Sub New(prop As PropertyDescriptor, direction As ListSortDirection)
            'If prop.ComponentType IsNot GetType(T) Then
            '    Throw New MissingMemberException(GetType(T).Name, prop.Name)
            'End If
            Me.prop = prop
            Me.direction = direction
            If SortableBindingList(Of T).PropertyComparer.OkWithIComparable(prop.PropertyType) Then
                Dim type As Type = GetType(Comparer(Of )).MakeGenericType(New Type() {prop.PropertyType})
                Dim [property] As PropertyInfo = type.GetProperty("Default")
                Me.comparer = CType([property].GetValue(Nothing, Nothing), IComparer)
                Me.useToString = False
                Return
            End If
            If SortableBindingList(Of T).PropertyComparer.OkWithToString(prop.PropertyType) Then
                Me.comparer = StringComparer.CurrentCultureIgnoreCase
                Me.useToString = True
            End If
        End Sub

        Public Overrides Function Compare(x As T, y As T) As Integer
            Dim obj As Object = Me.prop.GetValue(x)
            Dim obj2 As Object = Me.prop.GetValue(y)
            If Me.useToString Then
                obj = (If((obj IsNot Nothing), obj.ToString(), Nothing))
                obj2 = (If((obj2 IsNot Nothing), obj2.ToString(), Nothing))
            End If
            If Me.direction = ListSortDirection.Ascending Then
                Return Me.comparer.Compare(obj, obj2)
            End If
            Return Me.comparer.Compare(obj2, obj)
        End Function

        Protected Shared Function OkWithToString(t As Type) As Boolean
            Return t.Equals(GetType(XNode)) OrElse t.IsSubclassOf(GetType(XNode))
        End Function

        Protected Shared Function OkWithIComparable(t As Type) As Boolean
            Return t.GetInterface("IComparable") IsNot Nothing OrElse (t.IsGenericType AndAlso t.GetGenericTypeDefinition() Is GetType(Nullable(Of )))
        End Function

        Public Shared Function IsAllowable(t As Type) As Boolean
            Return SortableBindingList(Of T).PropertyComparer.OkWithToString(t) OrElse SortableBindingList(Of T).PropertyComparer.OkWithIComparable(t)
        End Function
    End Class

    Private isSorted As Boolean
    Private sortProperty As PropertyDescriptor
    Private sortDirection As ListSortDirection

    Protected Overrides ReadOnly Property SortDirectionCore() As ListSortDirection
        <TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")>
        Get
            Return Me.sortDirection
        End Get
    End Property

    Protected Overrides ReadOnly Property SortPropertyCore() As PropertyDescriptor
        <TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")>
        Get
            Return Me.sortProperty
        End Get
    End Property

    Protected Overrides ReadOnly Property IsSortedCore() As Boolean
        <TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")>
        Get
            Return Me.isSorted
        End Get
    End Property

    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    <TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")>
    Friend Sub New(list As IList(Of T))
        MyBase.New(list)
    End Sub

    Protected Overrides Sub RemoveSortCore()
        Me.isSorted = False
        Me.sortProperty = Nothing
    End Sub

    Protected Overrides Sub ApplySortCore(prop As PropertyDescriptor, direction As ListSortDirection)
        Dim propertyType As Type = prop.PropertyType
        If SortableBindingList(Of T).PropertyComparer.IsAllowable(propertyType) Then
            CType(MyBase.Items, List(Of T)).Sort(New SortableBindingList(Of T).PropertyComparer(prop, direction))
            Me.sortDirection = direction
            Me.sortProperty = prop
            Me.isSorted = True
            Me.OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))
        End If
    End Sub
End Class