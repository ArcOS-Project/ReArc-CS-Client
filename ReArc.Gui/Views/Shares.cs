using Microsoft.VisualBasic.ApplicationServices;
using ReArc.ApiHandler.Controllers;
using ReArc.Shared;
using ReArc.Shared.Records.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReArc.Gui.Views;

public partial class Shares : Page
{
    private List<SharedDrive> _shares = [];

    public Shares()
    {
        InitializeComponent();
    }

    public override async Task<CommandResult<bool>> LoadData(Dictionary<string, object>? props = null)
    {
        var response = await AdminController.GetAllShares();
        if (!response.Success) return CommandResult<bool>.Error(response.ErrorMessage);

        _shares = response.Result!;
        return CommandResult<bool>.Ok(true);
    }
}
