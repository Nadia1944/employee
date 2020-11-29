Public Class Employee
    Public nama, jeniskelamin, jabatan, alamat As String
    Public NIP, NIK As Integer
    Private gaji As Integer
    Sub InputData1()
        Console.WriteLine("Masukan Nama : ")
        nama = Console.ReadLine()
        Console.WriteLine("Masukan Jenis Kelamin : ")
        jeniskelamin = Console.ReadLine()
        Console.WriteLine("Masukan Jabatan : ")
        jabatan = Console.ReadLine()
        Console.WriteLine("Masukan Alamat : ")
        alamat = Console.ReadLine()
        Console.WriteLine("Masukan Gaji : ")
        gaji = Console.ReadLine()
        Console.WriteLine("Masukan NIP : ")
        NIP = Console.ReadLine()
    End Sub
    Sub TampilkanData()
        Console.WriteLine("Nama Employee : " & nama & vbNewLine)
        Console.WriteLine("Jenis Kelamin : " & jeniskelamin & vbNewLine)
        Console.WriteLine("Jabatan : " & jabatan & vbNewLine)
        Console.WriteLine("Alamat : " & alamat & vbNewLine)
        Console.WriteLine("Gaji : " & gaji & vbNewLine)
        Console.WriteLine("NIP : " & NIP & vbNewLine)
        Console.ReadKey()
    End Sub
    Public Property gajian() As Integer
        Set(ByVal value As Integer)
            gaji = value
        End Set
        Get
            Return gaji
        End Get
    End Property
    Sub New(ByVal nm As String)
        nama = nm
    End Sub
    Protected Overrides Sub Finalize()
        Console.WriteLine("Selesai")
        Console.Read()
    End Sub
End Class
