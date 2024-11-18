# Halo MiHoYo Company!!

Di sini gw tinggalkan pesan. Jadi gw so far udah bikin:

## Main menu 
Main menu yang isinya mulai game atau exit game (walaupun masih prototype). Untuk sekarang dua duanya masih ngereturn doang belum ada konteksnya. Jadi gw mau lu pada bikin apa yang terjadi pas si player pencet mulai di menu itu. 

Gw juga udah bikin kek basis buat Inventory di [Inventory.cs](Inventory.cs), ntar bisa diliat detailnya gmn.

Buat [Encounter.cs](Encounter.cs) sama [FootballZombie.cs](FootballZombie.cs) itu gw masih ngetes doang jadi anggep aja gaada, tapi kalau mau tau itu gw lagi nyoba bikin tipe zombie Football Zombie. Tapi gw masih stuck gmn mau mengkonseptualisasikan itu, dan kalau bisa pake factory pattern.

Jadi idenya habis kita pencet mulai game, kita bakal dinarasiin story dulu sesuai yang di rencana di pdf kemarin. Habis itu, player bakal dibawa ke menu lain. Di menu itu, ada beberapa pilihan yaitu kita pilih stage dan main, cek inventory, atau bisa keluar dari game. Pas ngecek inventory, gw si rencananya mau si player ini bisa ngeliat semua inventory (udah gw terapin), dan bisa milih dia mau nge view tanaman apa. Pas ngeview, mungkin bisa deskripsiin nama, stats (attack, tipe tanaman fire lightning dark dll, HP, exp sekarang, dan level sekarang) sesuai field yang udah gw tulis di [Plants.cs](Plants.cs). Ntar lu bisa isi field tersebut pake Factory Design Pattern yang udah gw tulis di [PlantFactory.cs](PlantFactory.cs). Untuk sekarang baru dikit tanaman yg gw tulis, mungkin nanti bisa ditambahin lagi.

Oke, sedikit recap file-file cs ini apa aja maksudnya:
- `Encounter.cs` : Masih testing, rencananya buat sebagai GameManager untuk ngurus logic encounter di setiap stage.
- `FootballZombie.cs` : Salah satu tipe zombie yang bakal muncul di game. Masih bingung gmn bikinnya pake Factory Pattern. Mungkin bikin kayak plants aja ya yg juga udah pake factory pattern, yah we'll see.
- `Inventory.cs` : Sistem Inventory. Ada 2 tipe inventory yaitu Item Inventory sama Plants Inventory, kegunaannya gw rasa udah self-explanatory.
- `Items.cs` : BUat ngurusin item, kayak nama item, jenis item, kegunaannya, dll. Ini juga masih belum jadi.
- `PlantFactory.cs` : Factory Design Pattern untuk Plants. Rencananya ada sekitar 20 jenis tanaman di game. Tapi kalau kesusahan yaudahlah 10 aj kalau bingung logic tanamannya bakal spawn di stage dimana aja.
- `Plants.cs` : Self-explanatory. Blueprint untuk tanaman. Untuk sekarang masih setengah jadi (kayaknya). Belum diterapin kek gmn kalau dia nerima damage, super effective type (cek table pokemon), masih harus disesuain sama combat systemnya gmn.
- `Program.cs` : Kayak Main.java kalau di java. Ntar programnya di run di situ pake command `dotnet run`.
- `Scientist.cs` : Main char yang gaada gunanya. Diinisialisasikan pake Singleton. Kayaknya si udah jadi soalnya emang ini karakter beban gaada guna lol.
- `Zombie.cs` : Blueprint buat zombie design pattern. Masih dalam testing.

<h1 style="font-size:20vw">OKE jadi,</h1>

Silakan lanjutin, pull aja dari punya gw dan selamat yapping.

    Axel Adrial Pace Kalembang (2306161984)

    Bonifasius Raditya Pandu Hendrianto (2306242350)

    Calvin Wirathama Katoroy (2306242395)

