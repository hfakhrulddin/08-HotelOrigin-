   M S B A M L   `   `   `  ����F  BHotelOrigin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HotelOriginHotelOrigin  5   	   K GHotelOrigin.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullcCclr-namespace:HotelOrigin.Core.Repository;assembly=HotelOrigin.CoreHotelOrigin.Core.Repository 5   	   #    HotelOrigin.AddReservationWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HotelOrigin     5   	   Z
RepositoryCclr-namespace:HotelOrigin.Core.Repository;assembly=HotelOrigin.Core     5   	   -   5          � Title$  AddReservationWin��5	   	   $	��285��6#   $��277.5��60   .��5
      � .+�5   
   �� -   5         ��Name$ SubmitReservation��5      $��Submit��6,   $
��Left=�6=   $��
15,210,0,0q�6X   $	��Top=�6l   $	��245��6�   $��35��6�   6�   �� 5   
   -   5         ��Name$ reservation_id_txb��5      $
��Left=�6.   $��23��6I   $��
109,15,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��150��6�   �� 5   
   -   5         ��Name$ Customer_cbo��5      $
��Left=�6)   $��
109,48,0,0q�6D   $	��Top=�6X   $	��150��6p   5      �� 5   
   -   5        $ Room_cbo��5      $
��Left=�6%   $��
109,88,0,0q�6@   $	��Top=�6T   $	��150��6l   �� 5   
   -   5         ��Name$ label��5      $��
Reserv. ID��6   $
��Left=�64   $��	11,12,0,0q�6O   $	��Top=�6b   �� 5   
   -   5        $ label1��5      $��
Custmer ID��6    $
��Left=�65   $��	12,45,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $ label2��5      $��Room ID��6    $
��Left=�62   $��	12,84,0,0q�6M   $	��Top=�6`   �� 5   
   -	   5        $ label3��5      $��Ckeck In Date��6    $
��Left=�68   $��
12,119,0,0q�6S   $	��Top=�6g   �� 5   
   -
   5        $ label4��5      $��Check Out Date��6    $
��Left=�69   $��
12,157,0,0q�6T   $	��Top=�6h   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ ceckin_databox��5      $
��Left=�6-   $��109,121,0,0q�6H   $	��Top=�6]   $	��150��6u     5   
   -   5        $ ceckout_databox��5      $
��Left=�6.   $��109,160,0,0q�6I   $	��Top=�6^   $	��150��6v   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $��10��6T   $��265,240,0,0q�6`   $	��Top=�6u   $��0��6�   �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��245��6T   $��5,5,0,0q�6a   $	��Top=�6r   $	��260��6�   5      5      