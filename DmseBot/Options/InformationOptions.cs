using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.FormFlow;

namespace DmseBot.Options
{
    /// <summary>
    /// Defines a list of values that represent the types of information that a user can request.
    /// </summary>
    public enum InformationOptions
    {
        /// <summary>
        /// Specifies that information about the DMSE program should be retrieved.
        /// </summary>
        [Describe("About DMSE")]
        AboutDmse,

        /// <summary>
        /// Specifies that information on how to apply for DMSE should be retrieved.
        /// </summary>
        [Describe("Apply for DMSE")]
        ApplyForDmse,

        /// <summary>
        /// Specifies that information about employment opportunities for DMSE should be retrieved.
        /// </summary>
        [Describe("Employment Opportunities")]
        EmploymentOpportunities,

        /// <summary>
        /// Specifies that graduate testimonials about DMSE should be retrieved.
        /// </summary>
        [Describe("Graduate Testimonials")]
        GraduateTestimonials,

        /// <summary>
        /// Specifies that industry testimonials about DMSE should be retrieved.
        /// </summary>
        [Describe("Industry Testimonials")]
        IndustryTestimonials,

        /// <summary>
        /// Specifies that student testimonials about DMSE should be retrieved.
        /// </summary>
        [Describe("Student Testimonials")]
        StudentTestimonials,

        /// <summary>
        /// Specifies that information about the faculty (Rick) for DMSE should be retrieved.
        /// </summary>
        [Describe("Faculty")]
        Faculty,

        /// <summary>
        /// Specifies that the contact information for DMSE should be retrieved.
        /// </summary>
        [Describe("Contact")]
        Contact
    }
}