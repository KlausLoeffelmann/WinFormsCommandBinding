﻿namespace WinFormsCommandBinding.Models
{
    // Class implements INotifyPropertyChanged and simplifies it correct
    // handling over BindableBase by using [CallingMemberName]
    public partial class MainFormController
    {
        private static string GetTestText()
        {
            return @"
    Lore Ipsum, generated by 

    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
    incididunt ut labore et dolore magna aliqua. Ullamcorper a lacus vestibulum sed 
    arcu non odio. Nunc mattis enim ut tellus elementum sagittis vitae et leo. Proin 
    sed libero enim sed. A diam maecenas sed enim ut. Eu ultrices vitae auctor eu 
    augue ut lectus arcu bibendum. Urna id volutpat lacus laoreet non curabitur 
    gravida. Fames ac turpis egestas sed tempus. Nulla aliquet enim tortor at auctor 
    urna nunc id. Elit pellentesque habitant morbi tristique senectus et netus et malesuada. 
    Turpis massa tincidunt dui ut ornare lectus. Eleifend donec pretium vulputate 
    sapien nec sagittis aliquam malesuada. Scelerisque eleifend donec pretium vulputate 
    sapien. Sit amet dictum sit amet justo donec.

    Aliquam eleifend mi in nulla posuere. Egestas integer eget aliquet nibh praesent tristique.
    Nulla facilisi etiam dignissim diam. Eu non diam phasellus vestibulum lorem. Viverra 
    mauris in aliquam sem fringilla ut morbi. Sed felis eget velit aliquet sagittis id 
    consectetur purus. Neque convallis a cras semper auctor neque vitae tempus. A erat 
    nam at lectus urna duis convallis convallis. Viverra mauris in aliquam sem fringilla. 
    Enim ut sem viverra aliquet eget. Ullamcorper malesuada proin libero nunc consequat 
    interdum varius sit.

    Urna molestie at elementum eu. Id interdum velit laoreet id donec ultrices. Et ligula 
    ullamcorper malesuada proin libero nunc consequat interdum varius. Quis hendrerit dolor 
    magna eget. Sed viverra ipsum nunc aliquet bibendum enim facilisis gravida. Ornare aenean 
    euismod elementum nisi quis. Commodo elit at imperdiet dui accumsan sit amet nulla. Sed 
    turpis tincidunt id aliquet risus feugiat in. At elementum eu facilisis sed odio morbi 
    quis. Et odio pellentesque diam volutpat commodo. Id ornare arcu odio ut sem nulla 
    pharetra. Donec ac odio tempor orci dapibus ultrices in. Vitae et leo duis ut diam quam 
    nulla porttitor. Lobortis feugiat vivamus at augue eget arcu. Lacus sed turpis tincidunt id.

    Cursus metus aliquam eleifend mi in nulla posuere. Aenean sed adipiscing diam donec. 
    Pellentesque elit eget gravida cum sociis natoque penatibus et magnis. Turpis tincidunt id 
    aliquet risus feugiat in ante metus dictum. Posuere ac ut consequat semper viverra nam libero. 
    Lacinia quis vel eros donec ac odio. Est sit amet facilisis magna etiam tempor. Id aliquet risus 
    feugiat in ante. Sem et tortor consequat id. Egestas quis ipsum suspendisse ultrices gravida 
    dictum fusce. Euismod in pellentesque massa placerat duis ultricies lacus. Sit amet nulla 
    facilisi morbi tempus.

    Bibendum enim facilisis gravida neque convallis a cras semper auctor. Mauris cursus mattis 
    molestie a iaculis at. Amet consectetur adipiscing elit duis. Elementum curabitur vitae nunc 
    sed velit dignissim sodales ut eu. Et ligula ullamcorper malesuada proin libero nunc consequat 
    interdum varius. At elementum eu facilisis sed. Convallis tellus id interdum velit. Duis convallis 
    convallis tellus id interdum velit laoreet. Parturient montes nascetur ridiculus mus. Pulvinar 
    neque laoreet suspendisse interdum consectetur libero. Nibh sed pulvinar proin gravida hendrerit 
    lectus a. Pulvinar mattis nunc sed blandit libero.";

        }
    }
}