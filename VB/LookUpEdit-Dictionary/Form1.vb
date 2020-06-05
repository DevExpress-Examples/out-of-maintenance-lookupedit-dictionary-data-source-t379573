Imports DevExpress.XtraEditors.Repository
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace LookUpEdit_Dictionary
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

			gridControl1.DataSource = New List(Of Product) From {
				New Product() With {
					.ProductName="Chang",
					.CategoryID = 0
				},
				New Product() With {
					.ProductName="Ipoh Coffee",
					.CategoryID = 0
				},
				New Product() With {
					.ProductName="Ravioli Angelo",
					.CategoryID = 1
				},
				New Product() With {
					.ProductName="Filo Mix",
					.CategoryID = 1
				},
				New Product() With {
					.ProductName="Tunnbröd",
					.CategoryID = 1
				},
				New Product() With {
					.ProductName="Konbu",
					.CategoryID = 2
				},
				New Product() With {
					.ProductName="Boston Crab Meat",
					.CategoryID = 2
				}
			}

			Dim Categories As New Dictionary(Of Integer, String)()
			Categories.Add(0, "Beverages")
			Categories.Add(1, "Grains")
			Categories.Add(2, "Seafood")

			Dim riLookUp As New RepositoryItemLookUpEdit()
			riLookUp.DataSource = Categories
			' Change the column caption.
			riLookUp.PopulateColumns()
			riLookUp.Columns("Value").Caption = "Name"

			gridControl1.RepositoryItems.Add(riLookUp)

			gridView1.Columns("CategoryID").ColumnEdit = riLookUp
		End Sub
	End Class

	Public Class Product
		Public Property CategoryID() As Integer
		Public Property ProductName() As String
	End Class


End Namespace
