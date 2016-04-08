using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using DmseBot.Options;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.FormFlow;

namespace DmseBot.Forms
{
    /// <summary>
    /// Defines a basic form that a user is able to use to request information about DMSE.
    /// </summary>
    [Serializable]
    public class RequestInformationForm
    {
        /// <summary>
        /// The information that should be retrieved.
        /// </summary>
        [Prompt("What {&} do you want? {||}")]
        public InformationOptions? Information;

        public static IForm<RequestInformationForm> BuildForm()
        {
            return new FormBuilder<RequestInformationForm>()
                .Message("Welcome to the Digital Media Software Engineering bot! What can I help you out with today?")
                .Field(nameof(RequestInformationForm.Information))
                .Build();
        }

        // TODO: Refactor to separate service
        public static string FindResponseForState(RequestInformationForm state, string language)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);
            switch (state.Information.Value)
            {
                case InformationOptions.AboutDmse:
                    return DmseBot.Information.AboutDmse;
                case InformationOptions.ApplyForDmse:
                    return DmseBot.Information.ApplyForDmse;
                default:
                    return "";
            }
        }
    }
}