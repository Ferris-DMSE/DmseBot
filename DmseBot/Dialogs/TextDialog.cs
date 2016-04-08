using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using DmseBot.Forms;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;
using Microsoft.Bot.Connector;

namespace DmseBot.Dialogs
{
    /// <summary>
    /// Defines a class that represents a dialog that sends a message to the user.
    /// </summary>
    [Serializable]
    public class TextDialog : IDialog<string>
    {
        public string Message;

        public TextDialog(string message)
        {
            this.Message = message;
        }

        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync(Message);
            context.Done(Message);
        }
    }
}