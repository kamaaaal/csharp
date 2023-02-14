using System;

class Eligibility {
    public static void Main() {
        Console.Write("Enter your date of Birth :  ");
        string date = Console.ReadLine();
        string alert = "please enter date of birth"; /// will be the popup alert on load

        if (date != null){ // validating date input
            string[] dateArr = date.Split('-'); 
            int year,month,birthDate;


            if (dateArr.Length == 3){ /// seperating props from  dataes
                birthDate = Convert.ToInt16(dateArr[0]);
                month = Convert.ToInt16(dateArr[1]);
                year = Convert.ToInt16(dateArr[2]);
                DateTime birthDay = new DateTime(year,month,birthDate); ///  creating a DateTime object for easy comparision
                double age = (DateTime.Now - birthDay).TotalHours /  8760; // converting diffrence to years
                Console.WriteLine("Age is {0}",age);
                /// comparing age to eligible age to vote and 
                /// assigin valid message to alert
                if (age <= 0){
                   alert = "Age cant be less than zero, are you from future??"; 
                }
                else if (age > 18){
                    alert= "you are elegible to vote ";
                }
                else if(age <= 18){
                    alert="you are not eligible to vote";
                }
            }
            else {
                alert = "invalid date input";
            }
        }
        else {
            alert ="please enter date of birth";
        }

        Console.WriteLine(alert);
    }

}