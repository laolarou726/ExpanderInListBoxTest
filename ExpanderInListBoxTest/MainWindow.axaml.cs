using System;
using System.Collections.Generic;
using Avalonia.Controls;

namespace ExpanderInListBoxTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var source = new List<Guid>();
            for(var i = 0; i < 100; i++)
                source.Add(Guid.NewGuid());

            TestListBox.Items = source;
        }
    }
}