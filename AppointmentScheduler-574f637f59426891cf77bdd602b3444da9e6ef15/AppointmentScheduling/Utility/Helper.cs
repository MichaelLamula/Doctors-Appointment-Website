using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Utility
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";
        public static string appointmentAdded = "Appointment added successfully.";
        public static string appointmentUpdated = "Appointment updated successfully.";
        public static string appointmentDeleted = "Appointment deleted successfully.";
        public static string appointmentExists = "Appointment for selected date and time already exists.";
        public static string appointmentNotExists = "Appointment not exists.";
        public static string meetingConfirm = "Appointment confirmed successfully.";
        public static string meetingConfirmError = "Error while confirming meeting.";
        public static string appointmentAddError = "Something went wrong, please try again.";
        public static string appointmentUpdatError = "Something went wrong, please try again.";
        public static string somethingWentWrong = "Something went wrong, please try again.";
        public static int success_code = 1;
        public static int failure_code = 0;

        public static List<SelectListItem> GetRolesForDropDown(bool isAdmin)
        {
            if (isAdmin)
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Helper.Admin,Text=Helper.Admin},
                    new SelectListItem{Value=Helper.Doctor,Text=Helper.Doctor},
                    new SelectListItem{Value=Helper.Patient,Text=Helper.Patient}
                };
            }
            else
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Helper.Patient,Text=Helper.Patient}
                };
            }
        }

        public static List<SelectListItem> GetTimeDropDown()
        {
            int minute = 30;
            List<SelectListItem> duration = new List<SelectListItem>();
            duration.Add(new SelectListItem { Value = minute.ToString(), Text = "30 minutes" });
            minute = minute + 15;
            duration.Add(new SelectListItem { Value = minute.ToString(), Text = "45 minutes" });
            minute = minute + 15;
            duration.Add(new SelectListItem { Value = minute.ToString(), Text = "1 Hour" });
            minute = minute + 15;
            duration.Add(new SelectListItem { Value = minute.ToString(), Text = "1 Hour 15 minutes" });
            minute = minute + 15;
            duration.Add(new SelectListItem { Value = minute.ToString(), Text = "1 Hour 30 minutes" });
            minute = minute + 15;
            duration.Add(new SelectListItem { Value = minute.ToString(), Text = "1 Hour 45 minutes" });
            minute = minute + 15;
            duration.Add(new SelectListItem { Value = minute.ToString(), Text = "2 Hours " });
          


            return duration;
        }
    }
}
