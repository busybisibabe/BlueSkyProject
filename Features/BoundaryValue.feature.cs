﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BlueSkyProject.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Boundary Value Analysis", Description="\tas a user of Coding for kids website\r\n\tI want to navigate to the website\r\n\tso I " +
        "can complete the registration form", SourceFile="Features\\BoundaryValue.feature", SourceLine=0)]
    public partial class BoundaryValueAnalysisFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "BoundaryValue.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Boundary Value Analysis", "\tas a user of Coding for kids website\r\n\tI want to navigate to the website\r\n\tso I " +
                    "can complete the registration form", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void ValidRegistrationUsing5_18Years(string studentFullname, string age, string guardianName, string emailAddress, string phoneNumber, string street, string apartment, string city, string province, string zipCode, string country, string experience, string motivation, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BVA"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Student fullname", studentFullname);
            argumentsOfScenario.Add("Age", age);
            argumentsOfScenario.Add("Guardian name", guardianName);
            argumentsOfScenario.Add("Email address", emailAddress);
            argumentsOfScenario.Add("Phone number", phoneNumber);
            argumentsOfScenario.Add("Street", street);
            argumentsOfScenario.Add("Apartment", apartment);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("Province", province);
            argumentsOfScenario.Add("Zip Code", zipCode);
            argumentsOfScenario.Add("Country", country);
            argumentsOfScenario.Add("Experience", experience);
            argumentsOfScenario.Add("Motivation", motivation);
            argumentsOfScenario.Add("Result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Registration using 5-18years", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("the user navigates to \"https://codingbyk.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.And("the user clicks Accept cookies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.When("the user clicks Application/Registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And(string.Format("the user enter Student full name\'{0}\'", studentFullname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("the user selects student age from the drop-down menu \'{0}\'", age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And(string.Format("the user enter Parent/Guardian name \'{0}\'", guardianName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("the user enter email address \'{0}\'", emailAddress), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And(string.Format("the user enter Parent phone with country code \'{0}\'", phoneNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And(string.Format("the user enter street address \'{0}\'", street), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And(string.Format("the user enter Apartment \'{0}\'", apartment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And(string.Format("the user enter City \'{0}\'", city), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And(string.Format("the user enter Street/Province \'{0}\'", province), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And(string.Format("the user enter Zip/Postal Code \'{0}\'", zipCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And(string.Format("the user select Country from the country drop-down menu \'{0}\'", country), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("the user click on one Course", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And(string.Format("the user enter their experience in coding in the text box \'{0}\'", experience), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And(string.Format("the user enter Motivation in the text box \'{0}\'", motivation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.When("the user clicks Send Message button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("the message \"Thank you for registering with us, please join our Telegram Group he" +
                        "re: https://t.me/codingforkidsbykids to get future notifications\" should be disp" +
                        "layed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valid Registration using 5-18years, Tola kinley", new string[] {
                "BVA"}, SourceLine=30)]
        public virtual void ValidRegistrationUsing5_18Years_TolaKinley()
        {
#line 7
this.ValidRegistrationUsing5_18Years("Tola kinley", "4", "Lola Lee", "lolalee@aol.com", "+2337017567740", "22 Adkan road", "G", "Surjah", "Barjah", "GZ2 123", "Uzbekistan", "learning new things", "Pass", "Fail", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valid Registration using 5-18years, Debbie kinley", new string[] {
                "BVA"}, SourceLine=30)]
        public virtual void ValidRegistrationUsing5_18Years_DebbieKinley()
        {
#line 7
this.ValidRegistrationUsing5_18Years("Debbie kinley", "5", "Debra Lee", "deblee@aol.com", "+2337016767740", "22 Adkan road", "G", "Surjah", "Barjah", "WZ2 123", "Uzbekistan", "basic", "learning new things", "Pass", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valid Registration using 5-18years, Agnes Akiney", new string[] {
                "BVA"}, SourceLine=30)]
        public virtual void ValidRegistrationUsing5_18Years_AgnesAkiney()
        {
#line 7
this.ValidRegistrationUsing5_18Years("Agnes Akiney", "6", "John Brown", "bronlew@aol.com", "+2337016927140", "32 Joeban street", "E", "Surjah", "Barjah", "EN2 T10", "Uzbekistan", "none", "Gaming", "Pass", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valid Registration using 5-18years, Goa Sajid", new string[] {
                "BVA"}, SourceLine=30)]
        public virtual void ValidRegistrationUsing5_18Years_GoaSajid()
        {
#line 7
this.ValidRegistrationUsing5_18Years("Goa Sajid", "17", "Memora Zee", "memora@yahoo.com", "+2337016887040", "34 jebba road", "F", "Surjah", "Barjah", "SE2 D30", "Uzbekistan", "moderate", "artificial", "Pass", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valid Registration using 5-18years, Susan Joe", new string[] {
                "BVA"}, SourceLine=30)]
        public virtual void ValidRegistrationUsing5_18Years_SusanJoe()
        {
#line 7
this.ValidRegistrationUsing5_18Years("Susan Joe", "18", "Emmal Dee", "emma12ee@aol.com", "+2337016767740", "56 Hagge road", "G", "Surjah", "Barjah", "AB2 R23", "Uzbekistan", "none", "Inquisitive", "Pass", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valid Registration using 5-18years, Aduss McKiney", new string[] {
                "BVA"}, SourceLine=30)]
        public virtual void ValidRegistrationUsing5_18Years_AdussMcKiney()
        {
#line 7
this.ValidRegistrationUsing5_18Years("Aduss McKiney", "19", "Kanye Brown", "Kbronlenw@aol.com", "+2337216927140", "38 Joeban street", "E", "Surjah", "Barjah", "YN2 T10", "Uzbekistan", "Gaming", "Newbie", "Fail", ((string[])(null)));
#line hidden
        }
        
        public virtual void InValidRegistrationUsing5_18Years(string studentFullname, string age, string guardianName, string emailAddress, string phoneNumber, string street, string apartment, string city, string province, string zipCode, string country, string experience, string motivation, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BVAInvalid"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Student fullname", studentFullname);
            argumentsOfScenario.Add("Age", age);
            argumentsOfScenario.Add("Guardian name", guardianName);
            argumentsOfScenario.Add("Email address", emailAddress);
            argumentsOfScenario.Add("Phone number", phoneNumber);
            argumentsOfScenario.Add("Street", street);
            argumentsOfScenario.Add("Apartment", apartment);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("Province", province);
            argumentsOfScenario.Add("Zip Code", zipCode);
            argumentsOfScenario.Add("Country", country);
            argumentsOfScenario.Add("Experience", experience);
            argumentsOfScenario.Add("Motivation", motivation);
            argumentsOfScenario.Add("Result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("InValid Registration using 5-18years", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 39
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 40
 testRunner.Given("the user navigates to \"https://codingbyk.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 41
 testRunner.And("the user clicks Accept cookies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.When("the user clicks Application/Registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.And(string.Format("the user enter Student full name\'{0}\'", studentFullname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And(string.Format("the user selects student age from the drop-down menu \'{0}\'", age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And(string.Format("the user enter Parent/Guardian name \'{0}\'", guardianName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And(string.Format("the user enter email address \'{0}\'", emailAddress), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And(string.Format("the user enter Parent phone with country code \'{0}\'", phoneNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And(string.Format("the user enter street address \'{0}\'", street), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And(string.Format("the user enter Apartment \'{0}\'", apartment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And(string.Format("the user enter City \'{0}\'", city), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And(string.Format("the user enter Street/Province \'{0}\'", province), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And(string.Format("the user enter Zip/Postal Code \'{0}\'", zipCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And(string.Format("the user select Country from the country drop-down menu \'{0}\'", country), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user click on one Course", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And(string.Format("the user enter their experience in coding in the text box \'{0}\'", experience), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And(string.Format("the user enter Motivation in the text box \'{0}\'", motivation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.When("the user clicks Send Message button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("InValid Registration using 5-18years, Tola kinley", new string[] {
                "BVAInvalid"}, SourceLine=62)]
        public virtual void InValidRegistrationUsing5_18Years_TolaKinley()
        {
#line 39
 this.InValidRegistrationUsing5_18Years("Tola kinley", "4", "Lola Lee", "lolalee@aol.com", "+2337017567740", "22 Adkan road", "G", "Surjah", "Barjah", "GZ2 123", "Uzbekistan", "basic", "learning new things", "Pass", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("InValid Registration using 5-18years, Aduss McKiney", new string[] {
                "BVAInvalid"}, SourceLine=62)]
        public virtual void InValidRegistrationUsing5_18Years_AdussMcKiney()
        {
#line 39
 this.InValidRegistrationUsing5_18Years("Aduss McKiney", "19", "Kanye Brown", "Kbronlenw@aol.com", "+2337216927140", "38 Joeban street", "E", "Surjah", "Barjah", "YN2 T10", "Uzbekistan", "none", "Gaming", "Pass", ((string[])(null)));
#line hidden
        }
        
        public virtual void ValidRegistrationUsing5_18Years_EP(string studentFullname, string age, string guardianName, string emailAddress, string phoneNumber, string street, string apartment, string city, string province, string zipCode, string country, string experience, string motivation, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "EP"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Student fullname", studentFullname);
            argumentsOfScenario.Add("Age", age);
            argumentsOfScenario.Add("Guardian name", guardianName);
            argumentsOfScenario.Add("Email address", emailAddress);
            argumentsOfScenario.Add("Phone number", phoneNumber);
            argumentsOfScenario.Add("Street", street);
            argumentsOfScenario.Add("Apartment", apartment);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("Province", province);
            argumentsOfScenario.Add("Zip Code", zipCode);
            argumentsOfScenario.Add("Country", country);
            argumentsOfScenario.Add("Experience", experience);
            argumentsOfScenario.Add("Motivation", motivation);
            argumentsOfScenario.Add("Result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Valid Registration using 5-18years - EP", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 69
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 70
 testRunner.Given("the user navigates to \"https://codingbyk.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 71
 testRunner.And("the user clicks Accept cookies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.When("the user clicks Application/Registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.And(string.Format("the user enter Student full name\'{0}\'", studentFullname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And(string.Format("the user selects student age from the drop-down menu \'{0}\'", age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And(string.Format("the user enter Parent/Guardian name \'{0}\'", guardianName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And(string.Format("the user enter email address \'{0}\'", emailAddress), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And(string.Format("the user enter Parent phone with country code \'{0}\'", phoneNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.And(string.Format("the user enter street address \'{0}\'", street), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And(string.Format("the user enter Apartment \'{0}\'", apartment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.And(string.Format("the user enter City \'{0}\'", city), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.And(string.Format("the user enter Street/Province \'{0}\'", province), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.And(string.Format("the user enter Zip/Postal Code \'{0}\'", zipCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.And(string.Format("the user select Country from the country drop-down menu \'{0}\'", country), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
 testRunner.And("the user click on one Course", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And(string.Format("the user enter their experience in coding in the text box \'{0}\'", experience), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And(string.Format("the user enter Motivation in the text box \'{0}\'", motivation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.When("the user clicks Send Message button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valid Registration using 5-18years - EP, Benbie kinler", new string[] {
                "EP"}, SourceLine=92)]
        public virtual void ValidRegistrationUsing5_18Years_EP_BenbieKinler()
        {
#line 69
this.ValidRegistrationUsing5_18Years_EP("Benbie kinler", "8", "Ora Lewis", "omaee@aol.com", "+2337016767743", "2 Adkan road", "G", "Surjah", "Barjah", "WT2 123", "Uzbekistan", "basic", "learning new things", "Pass", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Valid Registration using 5-18years - EP, Bange kiney", new string[] {
                "EP"}, SourceLine=92)]
        public virtual void ValidRegistrationUsing5_18Years_EP_BangeKiney()
        {
#line 69
this.ValidRegistrationUsing5_18Years_EP("Bange kiney", "14", "Jott Brownby", "bronwer@aol.com", "+2337016927147", "6 Joeban street", "E", "Surjah", "Barjah", "WN2 T10", "Uzbekistan", "none", "Gaming", "Pass", ((string[])(null)));
#line hidden
        }
        
        public virtual void InValidRegistrationUsing5_18Years_EP(string studentFullname, string age, string guardianName, string emailAddress, string phoneNumber, string street, string apartment, string city, string province, string zipCode, string country, string experience, string motivation, string result, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "EPInvalid"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Student fullname", studentFullname);
            argumentsOfScenario.Add("Age", age);
            argumentsOfScenario.Add("Guardian name", guardianName);
            argumentsOfScenario.Add("Email address", emailAddress);
            argumentsOfScenario.Add("Phone number", phoneNumber);
            argumentsOfScenario.Add("Street", street);
            argumentsOfScenario.Add("Apartment", apartment);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("Province", province);
            argumentsOfScenario.Add("Zip Code", zipCode);
            argumentsOfScenario.Add("Country", country);
            argumentsOfScenario.Add("Experience", experience);
            argumentsOfScenario.Add("Motivation", motivation);
            argumentsOfScenario.Add("Result", result);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("InValid Registration using 5-18years - EP", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 99
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 100
 testRunner.Given("the user navigates to \"https://codingbyk.com/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 101
 testRunner.And("the user clicks Accept cookies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.When("the user clicks Application/Registration", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 103
 testRunner.And(string.Format("the user enter Student full name\'{0}\'", studentFullname), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.And(string.Format("the user selects student age from the drop-down menu \'{0}\'", age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.And(string.Format("the user enter Parent/Guardian name \'{0}\'", guardianName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.And(string.Format("the user enter email address \'{0}\'", emailAddress), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.And(string.Format("the user enter Parent phone with country code \'{0}\'", phoneNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 108
 testRunner.And(string.Format("the user enter street address \'{0}\'", street), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And(string.Format("the user enter Apartment \'{0}\'", apartment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
 testRunner.And(string.Format("the user enter City \'{0}\'", city), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And(string.Format("the user enter Street/Province \'{0}\'", province), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 112
 testRunner.And(string.Format("the user enter Zip/Postal Code \'{0}\'", zipCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.And(string.Format("the user select Country from the country drop-down menu \'{0}\'", country), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And("the user click on one Course", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And(string.Format("the user enter their experience in coding in the text box \'{0}\'", experience), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.And(string.Format("the user enter Motivation in the text box \'{0}\'", motivation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.When("the user clicks Send Message button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("InValid Registration using 5-18years - EP, Olaby tey", new string[] {
                "EPInvalid"}, SourceLine=122)]
        public virtual void InValidRegistrationUsing5_18Years_EP_OlabyTey()
        {
#line 99
this.InValidRegistrationUsing5_18Years_EP("Olaby tey", "38", "John Yoyo", "yronlew@aol.com", "+2337016927143", "21 oeban street", "E", "Surjah", "Barjah", "EN2 T10", "Uzbekistan", "none", "Gaming", "Pass", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion