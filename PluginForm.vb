Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms

Friend Class PluginForm
    Private UC As Plugininterface.Entry
    Private port As Integer = 1
    Private plugin As UCCNCplugin

    Public Sub New(plugin As UCCNCplugin)
        Me.plugin = plugin
        ' This call is required by the designer.
        InitializeComponent()

        TextBox1.Text = port
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label13.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    ''' <summary>
    ''' Output Buttons
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles _
        Button1.MouseDown,
        Button2.MouseDown,
        Button3.MouseDown,
        Button4.MouseDown,
        Button5.MouseDown,
        Button6.MouseDown,
        Button7.MouseDown,
        Button8.MouseDown,
        Button9.MouseDown,
        Button14.MouseDown,
        Button16.MouseDown,
        Button17.MouseDown
        '>
        Dim control As Button = TryCast(sender, Button)
        Me.plugin.UC.Setoutpin(port, Integer.Parse(control.Tag))
    End Sub


    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles _
        Button1.MouseUp,
        Button2.MouseUp,
        Button3.MouseUp,
        Button4.MouseUp,
        Button5.MouseUp,
        Button6.MouseUp,
        Button7.MouseUp,
        Button8.MouseUp,
        Button9.MouseUp,
        Button14.MouseUp,
        Button16.MouseUp,
        Button17.MouseUp
        '>
        Dim control As Button = TryCast(sender, Button)
        Me.plugin.UC.Clroutpin(port, Integer.Parse(control.Tag))
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        Dim ret As Integer
        If Integer.TryParse(TextBox1.Text, ret) Then
            port = ret
        Else
            TextBox1.Text = port
            e.Cancel = True
        End If

    End Sub
End Class