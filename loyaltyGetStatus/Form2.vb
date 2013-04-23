Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports System.Xml


Namespace loayltyGetStatus
    Partial Public Class Form2
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub




        Private Sub Form2_Load(sender As Object, e As EventArgs)

        End Sub
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents button2 As System.Windows.Forms.Button
        Private WithEvents textBox1 As System.Windows.Forms.TextBox
        Private WithEvents textBox3 As System.Windows.Forms.TextBox
        Private WithEvents button4 As System.Windows.Forms.Button
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog






        Private Sub button2_Click_1(sender As System.Object, e As System.EventArgs) Handles button2.Click
            Try

                'A Basic GetStatus()
                Dim url As String = "http://api.cert.mercuryloyalty.com/v3_0/loyalty/GetStatus/?apikey=PAUL&apisecret=f2ee0e69a14c45039c6041b19fd18d88&customeridentifier=4076374996"
                Dim httpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
                httpWebRequest.ContentType = "text/xml"
                httpWebRequest.Method = WebRequestMethods.Http.[Get]
                Dim response = DirectCast(httpWebRequest.GetResponse(), HttpWebResponse)
                Dim responseStream As Stream = response.GetResponseStream()
                Dim responseReader As New StreamReader(responseStream)
                Dim responseString As String = responseReader.ReadToEnd()
                Dim xmlDoc As New XmlDocument()
                xmlDoc.LoadXml(responseString)
                '* Get elements.
                Dim emailAddress As String = xmlDoc.GetElementsByTagName("EmailAddress")(0).InnerText
                Dim firstName As String = xmlDoc.GetElementsByTagName("FirstName")(0).InnerText
                Dim lastName As String = xmlDoc.GetElementsByTagName("LastName")(0).InnerText
                Dim mobileNumber As String = xmlDoc.GetElementsByTagName("MobileNumber")(0).InnerText
                Dim currentCredits As String = xmlDoc.GetElementsByTagName("CurrentCredits")(0).InnerText
                Dim lifeTimeCredits As String = xmlDoc.GetElementsByTagName("LifetimeCredits")(0).InnerText
                Dim lifeTimeRevenue As String = xmlDoc.GetElementsByTagName("LifetimeRevenue")(0).InnerText
                Dim rewardsEarned As String = xmlDoc.GetElementsByTagName("RewardsEarned")(0).InnerText


                textBox1.Text = ""
                textBox1.AppendText("Email: " & emailAddress)
                textBox1.AppendText(Environment.NewLine)

                textBox1.AppendText("First Name: " & firstName)
                textBox1.AppendText(Environment.NewLine)

                textBox1.AppendText("Last Name: " & lastName)
                textBox1.AppendText(Environment.NewLine)

                textBox1.AppendText("Mobile Number: " & mobileNumber)
                textBox1.AppendText(Environment.NewLine)

                textBox1.AppendText("Current Credits: " & currentCredits)
                textBox1.AppendText(Environment.NewLine)

                textBox1.AppendText("Lifetime Credits: " & lifeTimeCredits)
                textBox1.AppendText(Environment.NewLine)


                textBox1.AppendText("Lifetime Revenue: " & lifeTimeRevenue)
                textBox1.AppendText(Environment.NewLine)

                textBox1.AppendText("Rewards Earned: " & rewardsEarned)
                textBox1.AppendText(Environment.NewLine)


                textBox3.Text = url
            Catch ex As Exception
                textBox1.Text = ""
                textBox1.AppendText("An Error has Occured: ")
                textBox1.AppendText(Environment.NewLine)
                textBox1.AppendText(ex.Message)
                textBox1.AppendText(Environment.NewLine)
            End Try
        End Sub



        Private Sub button4_Click(sender As System.Object, e As System.EventArgs) Handles button4.Click
            Try

                Dim url2 As String = "https://api.cert.mercuryloyalty.com/v3_0/loyalty/AddCredits/?apikey=PAUL&apisecret=f2ee0e69a14c45039c6041b19fd18d88&units=10&description=AddCredits&employee_id=1&station_id=1&ticket_id=2012-10-18-10-54-44-101&revenue=10&client=MERCURY&version=1.0.3.822&customeridentifier=4075554997"
                Dim httpWebRequest = DirectCast(WebRequest.Create(url2), HttpWebRequest)
                httpWebRequest.Method = WebRequestMethods.Http.[Get]
                Dim response = DirectCast(httpWebRequest.GetResponse(), HttpWebResponse)
                Dim responseStream As Stream = response.GetResponseStream()
                Dim responseReader As New StreamReader(responseStream)
                Dim responseString As String = responseReader.ReadToEnd()
                Dim xmlDoc As New XmlDocument()
                xmlDoc.LoadXml("<root>" & responseString & "</root>")
                Dim address As XmlNodeList = xmlDoc.GetElementsByTagName("original")
                textBox1.Text = responseString
                textBox3.Text = url2
            Catch ex As Exception


                textBox1.Text = ""
                textBox1.AppendText("An Error has Occured: ")
                textBox1.AppendText(Environment.NewLine)
                textBox1.AppendText(ex.Message)


                textBox1.AppendText(Environment.NewLine)
            End Try


        End Sub

        Private Sub InitializeComponent()
            Me.label3 = New System.Windows.Forms.Label()
            Me.button2 = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.textBox3 = New System.Windows.Forms.TextBox()
            Me.button4 = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(10, 208)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(47, 13)
            Me.label3.TabIndex = 16
            Me.label3.Text = "Request"
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(88, 40)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 1
            Me.button2.Text = "Getstatus"
            Me.button2.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(586, 233)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textBox1.Size = New System.Drawing.Size(440, 232)
            Me.textBox1.TabIndex = 15
            '
            'textBox3
            '
            Me.textBox3.Location = New System.Drawing.Point(10, 233)
            Me.textBox3.Multiline = True
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textBox3.Size = New System.Drawing.Size(474, 219)
            Me.textBox3.TabIndex = 14
            '
            'button4
            '
            Me.button4.Location = New System.Drawing.Point(255, 40)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(75, 23)
            Me.button4.TabIndex = 3
            Me.button4.Text = "AddCredits"
            Me.button4.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.button2)
            Me.groupBox1.Controls.Add(Me.button4)
            Me.groupBox1.Location = New System.Drawing.Point(304, 76)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(394, 91)
            Me.groupBox1.TabIndex = 13
            Me.groupBox1.TabStop = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(583, 208)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(37, 13)
            Me.label1.TabIndex = 12
            Me.label1.Text = "Result"
            '
            'Form2
            '
            Me.ClientSize = New System.Drawing.Size(1037, 541)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.textBox3)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label1)
            Me.Name = "Form2"
            Me.groupBox1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        
    End Class
End Namespace