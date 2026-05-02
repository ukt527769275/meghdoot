using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AGROMET_COMMON
{
    public class Common
    {
        public static string EmptyValue = "\\N";
        public static string EmptyDate = "\"\"";
        public static string ZeroValue = "\"0\"";//"0\\";
        public enum LanguageName
        {
            Hindi, Kannada, Marathi, Punjabi, Assamese, Gujarati, Oriya, Tamil, English, Malayalam, Telugu, Bengali, Mizoram
        }
        public static string GetLanguageCode(LanguageName language)
        {            
            switch (language)
            {
                case LanguageName.Hindi:
                    return "hi-IN";                
                case LanguageName.Kannada:
                    return "kn-IN";
                case LanguageName.Marathi:
                    return "mr-IN";
                case LanguageName.Punjabi:
                    return "pa-IN";
                case LanguageName.Assamese:
                    return "as-IN";
                case LanguageName.Gujarati:
                    return "gu-IN";
                case LanguageName.Malayalam:
                    return "ml-IN";
                case LanguageName.Oriya:
                    return "or-IN";
                case LanguageName.Tamil:
                    return "ta-IN";
                case LanguageName.Telugu:
                    return "te-IN";
                case LanguageName.Bengali:
                    return "bn-IN";
                case LanguageName.Mizoram:
                    return "en-IN";
                default:
                    return "en";
            }
        }
        
        public static string ClearSky(LanguageName language) 
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "साफ आसमान";
                case LanguageName.Kannada:
                    return "ಶುಭ್ರ ಆಕಾಶ";
                case LanguageName.Marathi:
                    return "स्वच्छ आकाश";
                case LanguageName.Punjabi:
                    return "ਸਾਫ ਅਸਮਾਨ";
                case LanguageName.Assamese:
                    return "পৰিস্কাৰ আকাশ";
                case LanguageName.Gujarati:
                    return "ચોખું આકાશ";
                case LanguageName.Malayalam:
                    return "തെളിഞ്ഞ ആകാശം";
                case LanguageName.Oriya:
                    return "ପରିଷ୍କାର ଆକାଶ ";
                case LanguageName.Tamil:
                    return "தெளிவான வானம்";
                case LanguageName.Telugu:
                    return "స్పష్టమైన ఆకాశం";
                case LanguageName.Bengali:
                    return "পরিষ্কার আকাশ";
                case LanguageName.Mizoram:
                    return "Khawthiang";
                default:
                    return "Clear Sky";
            }            
        }
        public static string MainlyClear(LanguageName language)
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "मुख्य रूप से स्पष्ट";
                case LanguageName.Kannada:
                    return "ಮುಖ್ಯವಾಗಿ ತೆರವಾದ";
                case LanguageName.Marathi:
                    return "मुख्यतः साफ";
                case LanguageName.Punjabi:
                    return "ਜ਼ਿਆਦਾਤਰ ਸਾਫ";
                case LanguageName.Assamese:
                    return " মুখ্য ৰূপে পৰিস্কাৰ";
                case LanguageName.Gujarati:
                    return "મુખ્યત્વે સ્પષ્ટ";
                case LanguageName.Malayalam:
                    return "പ്രധാനമായും തെളിഞ്ഞത്";
                case LanguageName.Oriya:
                    return "ମୁଖ୍ୟତଃ ପରିଷ୍କାର ";
                case LanguageName.Tamil:
                    return "மிகவும் தெளிவு";
                case LanguageName.Telugu:
                    return "ప్రధానంగా మేఘావృతం";
                case LanguageName.Bengali:
                    return "মূলত পরিষ্কার";
                case LanguageName.Mizoram:
                    return "Khawthiang thawkhat";
                default:
                    return "Mainly Clear";
            }
        }
        public static string PartlyCloudy(LanguageName language)
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "आंशिक रूप से बादल रहेंगे";
                case LanguageName.Kannada:
                    return "ಭಾಗಶಃ ಮೋಡ";
                case LanguageName.Marathi:
                    return "अंशतः ढगाळ";
                case LanguageName.Punjabi:
                    return "ਥੋੜੇ ਜਿਹੇ ਬੱਦਲ";
                case LanguageName.Assamese:
                    return "আংশিক ভাবে ডাৱৰীয়া";
                case LanguageName.Gujarati:
                    return "આંશિક વાદળછાયું";
                case LanguageName.Malayalam:
                    return "ഭാഗികമായി മേഘാവൃതം";
                case LanguageName.Oriya:
                    return "ଆଂଶିକ ମେଘାଚ୍ଛନ୍ନ ";
                case LanguageName.Tamil:
                    return "பாதியளவு மேகமூட்டம்";
                case LanguageName.Telugu:
                    return "పాక్షికంగా మేఘావృతం";
                case LanguageName.Bengali:
                    return "আংশিক মেঘলা";
                case LanguageName.Mizoram:
                    return "Chhum zing deuh";
                default:
                    return "Partly Cloudy";
            }            
        }
        public static string GenerallyCloudy(LanguageName language)
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "आमतौर पर बादल रहेंगे";
                case LanguageName.Kannada:
                    return "ಸಾಮಾನ್ಯವಾಗಿ ಮೋಡ ಕವಿದ ವಾತಾವರಣ";
                case LanguageName.Marathi:
                    return "साधारणपणे ढगाळ";
                case LanguageName.Punjabi:
                    return "ਆਮ ਤੌਰ 'ਤੇ ਬੱਦਲ ਹੋਣੇ";
                case LanguageName.Assamese:
                    return " সাধাৰণ ভাবে ডাৱৰীয়া";
                case LanguageName.Gujarati:
                    return "આંશિક વાદળછાયું";
                case LanguageName.Malayalam:
                    return "പൊതുവായി മേഘാവൃതം";
                case LanguageName.Oriya:
                    return "ସାଧାରଣତଃ ମେଘାଚ୍ଛନ୍ନ";
                case LanguageName.Tamil:
                    return "பொதுவாக மேகமுட்டம்";
                case LanguageName.Telugu:
                    return "సాధారణంగా మేఘావృతం";
                case LanguageName.Bengali:
                    return "সাধারণত মেঘলা";
                case LanguageName.Mizoram:
                    return "Chhum zing tlangpui";
                default:
                    return "Generally Cloudy";
            }            
        }
        public static string Cloudy(LanguageName language)
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "बादलों भरा";
                case LanguageName.Kannada:
                    return "ಮೋಡ ಕವಿದ ವಾತಾವರಣ";
                case LanguageName.Marathi:
                    return "ढगाळ";
                case LanguageName.Punjabi:
                    return "ਬੱਦਲ ਹੋਣੇ";
                case LanguageName.Assamese:
                    return "ডাৱৰীয়া";
                case LanguageName.Gujarati:
                    return "વાદળછાયું";
                case LanguageName.Malayalam:
                    return "മേഘാവൃതം";
                case LanguageName.Oriya:
                    return "ମେଘାଚ୍ଛନ୍ନ";
                case LanguageName.Tamil:
                    return "மேகமூட்டம்";
                case LanguageName.Telugu:
                    return "మేఘావృతం";
                case LanguageName.Bengali:
                    return "মেঘলা";
                case LanguageName.Mizoram:
                    return "Chhum zing";
                default:
                    return "Cloudy";
            }            
        }
        /// <summary>
        /// Speed Unit in Kmph
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public static string KMPH(LanguageName language)
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "किमी प्रति घंटे";
                case LanguageName.Kannada:
                    return "ಕ್ಮಫ್";
                case LanguageName.Marathi:
                    return "किमी प्रति तास";
                case LanguageName.Punjabi:
                    return "ਕੇ ਐੱਮ ਪੀ ਐੱਚ";
                case LanguageName.Assamese:
                    return "ಕ್ಮಫ್";
                case LanguageName.Gujarati:
                    return "કિમી પ્રતી કલ્લાક / કિ.મી.પી.એચ";
                case LanguageName.Malayalam:
                    return "കി.മീ.";
                case LanguageName.Oriya:
                    return "କମ୍ଫ";
                case LanguageName.Tamil:
                    return "கே எம்பி எச்";
                case LanguageName.Telugu:
                    return "గంటకు కిలోమీటర్లు";
                case LanguageName.Bengali:
                    return "কিলোমিটার প্রতি ঘন্টায়";
                case LanguageName.Mizoram:
                    return "kmph";

                default:
                    return "kmph";
            }
        }
        /// <summary>
        /// Rain unit in mm
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public static string MM(LanguageName language)
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "मिमी";
                case LanguageName.Kannada:
                    return "ಮಿಮೀ";
                case LanguageName.Marathi:
                    return "मिमी";
                case LanguageName.Punjabi:
                    return "ਐਮ ਐਮ";
                case LanguageName.Assamese:
                    return "ಮ್ಮ್";
                case LanguageName.Gujarati:
                    return "મીમી";
                case LanguageName.Malayalam:
                    return "എം.എം.";
                case LanguageName.Oriya:
                    return "ମମ";
                case LanguageName.Tamil:
                    return "எம் எம்";
                case LanguageName.Telugu:
                    return "మిల్లీ మీటర్";
                case LanguageName.Bengali:
                    return "এম এম";
                case LanguageName.Mizoram:
                    return "mm";

                default:
                    return "mm";
            }
        }


        public static string ValidUpTo(LanguageName language)
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "तक वैध है";
                case LanguageName.Kannada:
                    return "ವರೆಗೆ ಮಾನ್ಯವಾಗಿದೆ";
                case LanguageName.Marathi:
                    return "पर्यंत वैध";
                case LanguageName.Punjabi:
                    return "ਤੱਕ ਵੈਧ";
                case LanguageName.Assamese:
                    return "বৈধ পর্যন্ত";
                case LanguageName.Gujarati:
                    return "સુધી માન્ય";
                case LanguageName.Malayalam:
                    return "വരെ സാധുവാണ്";
                case LanguageName.Oriya:
                    return "ତକ ବୈଧ";
                case LanguageName.Tamil:
                    return "வரை செல்லுபடியாகும்";
                case LanguageName.Telugu:
                    return "వరకు చెల్లుతుంది";
                case LanguageName.Bengali:
                    return "বৈধ পর্যন্ত";
                case LanguageName.Mizoram:
                    return "Valid hunchhung";

                default:
                    return "Valid up to";
            }
        }
        public static string IssueDate(LanguageName language)
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "जारी करने की तिथि";
                case LanguageName.Kannada:
                    return "ಸಂಚಿಕೆ ದಿನಾಂಕ";
                case LanguageName.Marathi:
                    return "जारी तारीख";
                case LanguageName.Punjabi:
                    return "ਜਾਰੀ ਕਰਨ ਦੀ ਮਿਤੀ";
                case LanguageName.Assamese:
                    return "জাৰি কোৰাৰ তাৰিক";
                case LanguageName.Gujarati:
                    return "ઇશ્યુની તારીખ";
                case LanguageName.Malayalam:
                    return "പുറപ്പെടുവിക്കുന്ന തീയതി";
                case LanguageName.Oriya:
                    return "ଜାରି କା ତାରିଖ";
                case LanguageName.Tamil:
                    return "வெளியீட்டு தேதி";
                case LanguageName.Telugu:
                    return "జారి చేయు తేది";
                case LanguageName.Bengali:
                    return "প্রদানের তারিখ";
                case LanguageName.Mizoram:
                    return "Issue ni";
                default:
                    return "Issue date";
            }
        }
        public static string TimeOfIssue(LanguageName language)
        {
            switch (language)
            {
                case LanguageName.Hindi:
                    return "प्रारंभ का समय";
                case LanguageName.Kannada:
                    return "ಪ್ರಾರಂಭದ ಸಮಯ";
                case LanguageName.Marathi:
                    return "प्रारंभ वेळ";
                case LanguageName.Punjabi:
                    return "ਜਾਰੀ ਕਰਨ ਦਾ ਸਮਾਂ";
                case LanguageName.Assamese:
                    return "শুরুর সময়";
                case LanguageName.Gujarati:
                    return "પ્રારંભનો સમય";
                case LanguageName.Malayalam:
                    return "ആരംഭിക്കുന്ന സമയം";
                case LanguageName.Oriya:
                    return "ଆରମ୍ଭ ସମୟ";
                case LanguageName.Tamil:
                    return "தொடக்க நேரம்";
                case LanguageName.Telugu:
                    return "ప్రారంభ సమయం";
                case LanguageName.Bengali:
                    return "টাইম অফআইএসইউ";
                case LanguageName.Mizoram:
                    return "Issue hun";
                default:
                    return "Time of issue";
            }
        }

        public static bool IsValidString(string textvalue)
        {            
            if (Regex.IsMatch(textvalue, @"\p{IsCyrillic}")) return false;
            //if (Regex.IsMatch(textvalue, @"\p{IsBasicLatin}")) return false;
            if (Regex.IsMatch(textvalue, @"\p{IsGreek}")) return false;
            if (Regex.IsMatch(textvalue, @"\p{IsCyrillicSupplement}")) return false;
            if (Regex.IsMatch(textvalue, @"\p{IsLatin-1Supplement}")) return false;
            if (Regex.IsMatch(textvalue, @"\p{IsLatinExtended-A}")) return false;
            if (Regex.IsMatch(textvalue, @"\p{IsLatinExtended-B}")) return false;
            if (Regex.IsMatch(textvalue, @"\p{IsLatinExtendedAdditional}")) return false;
            if (Regex.IsMatch(textvalue, @"\p{IsCyrillicSupplement}")) return false;            
            return true;
        }
        public static string TimeFormat(int time)
        {
            string hr, min, sec = "00";
            min = Convert.ToString(time % 100); 
            hr = Convert.ToString(time / 100);
            if (hr.Length == 1) hr = "0" + hr;
            if (min.Length == 1) min = "0" + min;
            return hr + ":" + min;// + ":" + sec;
        }
        public static string GetColorHashCode(int colorId)
        {
            switch (colorId)
            {
                case 1 :
                  return "#FF0000";//Red
                case 2:
                    return "#FFA500";//Orange
                case 3:
                    return "#FFFF00";//Yellow
                case 4:
                    return "#008000";//Green
                default:
                    return "";//
            }
        }
        public static string GetColorHashCodeForNowCast(int colorId)
        {
            switch (colorId)
            {
                case 4:
                    return "#FF0000";//Red
                case 3:
                    return "#FFA500";//Orange
                case 2:
                    return "#FFFF00";//Yellow
                case 1:
                    return "#008000";//Green
                default:
                    return "";//
            }
        }
        public enum Priority
        {
            Low,
            Normal,
            High
        }
        public static class NotificationTypeConstants
        {
            public const string NowCast_received = "NowCast_received"; 
        }
    }
    public class TransactionDetails
    {
        public bool IsSuccessful { get; set; }
        public string SuccessMessage { get; set; }
        public string ErrorMessage { get; set; }
        public long NewID { get; set; }
        public string FileUrl { get; set; }

    }
    public enum DayNameOfWeek{  
        MONDAY, TUESDAY,WEDNESDAY,THURSDAY,FRIDAY,SATURDAY,SUNDAY
    }
    
}
