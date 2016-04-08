using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DmseBot.Forms;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace DmseBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog
    {
        public Func<IDialog<RequestInformationForm>> FormDialog { get; set; }

        public RootDialog(Func<IDialog<RequestInformationForm>> formDialog)
        {
            FormDialog = formDialog;
        }

        public async Task StartAsync(IDialogContext context)
        {
            context.Call<RequestInformationForm>(FormDialog(), AfterForm);
        }

        private async Task AfterForm(IDialogContext context, IAwaitable<RequestInformationForm> result)
        {
            var data = await result;
            StringBuilder sb = new StringBuilder(RequestInformationForm.FindResponseForState(data, "en"));
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("Is there anything else you would like to know?");
            context.Call<string>(new TextDialog(sb.ToString()), AfterResponse);
        }

        private async Task AfterResponse(IDialogContext context, IAwaitable<string> result)
        {
            context.Call<RequestInformationForm>(FormDialog(), AfterForm);
        }
    }
}