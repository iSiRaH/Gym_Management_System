﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System.pages.user
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        public Panel getUserProfile()
        {
            return pnlUserProfile;
        }
    }
}
