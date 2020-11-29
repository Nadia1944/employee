Imports System


    Module Module1
    Dim Budi As New Employee("Susilo Budiyudoyono")
    Dim Ani As New Employee("Ani Yudoyono")
    Dim Paijo As New Employee("Paijo Saputra")
    Sub Main()
        'Isi Attribut tanpa melalui method
        Budi.nama = "Budi Setyo Nugroho"
        Budi.jeniskelamin = "Laki - Laki"
            Budi.NIP = 10000000
            Budi.jabatan = "Manager"
        Budi.gajian = 1200000000
        'isi atribut tanpa melalui method
        Ani.nama = "Ani Widodo"
        Ani.jeniskelamin = "Perempuan"
            Ani.NIP = 10000000
            Ani.jabatan = "Istrinya Budi"
        Ani.gajian = 1200000000
        'isi atribut melalui method
        Budi.InputData1()
        Budi.TampilkanData()
        Ani.InputData1()
        Ani.TampilkanData()
        Paijo.InputData1()
        Paijo.TampilkanData()
    End Sub
    End Module


