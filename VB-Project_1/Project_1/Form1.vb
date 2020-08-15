Public Class Form1
    Dim Port As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Port = IO.Ports.SerialPort.GetPortNames()
        ComboBox_Port.Items.AddRange(Port)

        Button_Connet.Enabled = False
        Button_Disconnet.Enabled = False

        ComboBox_Channel.SelectedItem = "9600"

        Timer1.Enabled = True
    End Sub

    Private Sub Button_Connet_Click(sender As Object, e As EventArgs) Handles Button_Connet.Click
        SerialPort1.PortName = ComboBox_Port.Text
        SerialPort1.BaudRate = ComboBox_Channel.Text
        SerialPort1.Open()

        Button_Connet.Enabled = False
        Button_Disconnet.Enabled = True
        Button_Disconnet.BringToFront()

        ComboBox_Port.Enabled = False
        ComboBox_Channel.Enabled = False

    End Sub

    Private Sub Button_Disconnet_Click(sender As Object, e As EventArgs) Handles Button_Disconnet.Click
        SerialPort1.WriteLine("0")
        SerialPort1.Close()

        Button_Connet.Enabled = True
        Button_Connet.BringToFront()
        Button_Disconnet.Enabled = True

        ComboBox_Port.Enabled = True
        ComboBox_Channel.Enabled = True

    End Sub

    Private Sub ComboBox_Port_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Port.SelectedIndexChanged
        If ComboBox_Port.Text <> "" Then
            Button_Connet.Enabled = True
        End If

        If ComboBox_Port.Text = "" Then
            Button_Connet.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = DateTime.Now.ToLongTimeString() & DateTime.Now.ToString(" tt")
    End Sub

    Private Sub Button_Up_Click(sender As Object, e As EventArgs) Handles Button_Up.Click
        If SerialPort1.IsOpen Then
            SerialPort1.WriteLine("U")
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub

    Private Sub Button_Up_Y_Click(sender As Object, e As EventArgs)
        If SerialPort1.IsOpen() Then
            SerialPort1.WriteLine("U")
        End If
    End Sub

    Private Sub ReceivedText(ByVal [text] As String)
        If Me.RichTextBox1.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.RichTextBox1.AppendText(text)
            Me.RichTextBox1.ScrollToCaret()
        End If
    End Sub

    Private Sub Button_Down_Click(sender As Object, e As EventArgs) Handles Button_Down.Click
        If SerialPort1.IsOpen Then
            SerialPort1.WriteLine("D")
        End If
    End Sub

    Private Sub Button8_Down_Y_Click(sender As Object, e As EventArgs)
        If SerialPort1.IsOpen Then
            SerialPort1.WriteLine("D")
        End If
    End Sub

    Private Sub Button_Down_X_Click(sender As Object, e As EventArgs)
        If SerialPort1.IsOpen Then
            SerialPort1.WriteLine("L")
        End If
    End Sub

    Private Sub Button_Up_X_Click(sender As Object, e As EventArgs)
        If SerialPort1.IsOpen Then
            SerialPort1.WriteLine("R")
        End If
    End Sub

    Private Sub Button_Left_Click(sender As Object, e As EventArgs) Handles Button_Left.Click
        If SerialPort1.IsOpen Then
            SerialPort1.WriteLine("L")
        End If
    End Sub

    Private Sub Button_Rigth_Click(sender As Object, e As EventArgs) Handles Button_Rigth.Click
        If SerialPort1.IsOpen Then
            SerialPort1.WriteLine("R")
        End If
    End Sub


End Class
