   M S B A M L   `   `   `  ����A  =Proton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Proton.PagesProton.Pages  5          Proton.Pages.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Proton.Pages     5      b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  60   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Cie:http://schemas.microsoft.com/expression/2010/interactivity  6y     N� Title$  MainPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��23* �6    � ColumnDefinitions 5   
   �� 5      $	��11* �6   �� 5      $	��29* �6   .+�5   
   � $��0��6   $��1��6   
�������.+�5      �� -   5         ��Name$ searchControl��5       !  MaterialDesignOutlinedTextBox#��[  5      
�������
�������)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5      $��	16,7,12,0q�6B   $/��)/Proton;component/Assets/Fonts/#Open Sans)�6V      
IsFloating .  $��	40,2,10,2q�5   G   $��32��6Z   �� 5      $��Button��6   $��Right=�6&   $��0,2,0,0q�6B   $	��Top=�6S   $��0��6k    �� 	IsDefault . ��6u   ��  �� Path$ SearchCommand���6�   ��  �� ElementName$ searchControl��6�   5      � 5   
   $��1��6   
�������.+�5      �� ��6   �� $ Items�	 �� SelectedItem	 69   �� $ SelectedItem�.  (System.Windows.Interactivity.Interaction
   Triggers
 5      /  )System.Windows.Interactivity.EventTrigger  5          	EventName$ SelectionChanged��6&   .  (System.Windows.Interactivity.TriggerBase   Actions. 5!      6  0System.Windows.Interactivity.InvokeCommandAction  -   5        	myListBox��   Command 5!   D   �� *SelectedItemChangedCommand+   CommandParameter 6t   �� $ 	myListBox��$ SelectedItem�5"      5$      5%      � 5'   
   
�������$��1��6'   $��2��67   .+�5(       � ��6   �� $ CurrentDialog�6=   5)       � 5*   
   -   5          �Name$ 
FrontFrame��5*      $��2��6$   $��2��65   6K   �� 5+   
   -   5         ��Name$ settingsButton��5+      $��0��6)   $��1��66     MaterialDesignFlatButton#��[ 6G   $��0q�6y   $��32��6�   $
��Left=�6�   $��32��6�   $��3,3,0,2q�6�   .��5,      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Settings=�6&   68   5-      5.      5/      