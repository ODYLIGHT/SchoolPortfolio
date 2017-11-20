<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prototypes.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text4 {
            width: 252px;
        }
        #Text7 {
            width: 252px;
        }
        #Text8 {
            width: 197px;
            margin-left: 3px;
        }
        #Text10 {
            width: 197px;
            margin-left: 3px;
        }
        #Text10 {
            width: 197px;
            margin-left: 3px;
        }
        #Text11 {
            width: 197px;
            margin-left: 3px;
        }
        #Text9 {
            width: 199px;
        }
        #Text12 {
            width: 197px;
            margin-left: 3px;
        }
        #Text13 {
            width: 40px;
            margin-left: 3px;
        }
        #Text14 {
            width: 40px;
            margin-left: 3px;
        }
        #Text15 {
            width: 40px;
            margin-left: 3px;
        }
        #Text18 {
            width: 252px;
        }
        #Text21 {
            width: 252px;
        }
        #Text24 {
            width: 94px;
        }
        #Text27 {
            width: 94px;
            height: 32px;
        }
        #Text30 {
            width: 94px;
            height: 32px;
        }
        #Text31 {
            width: 197px;
            margin-left: 3px;
        }
        #Text32 {
            width: 731px;
            height: 94px;
        }
        #Text35 {
            width: 252px;
        }
        #Text38 {
            width: 252px;
        }
        #Text41 {
            width: 252px;
        }
        #Text41 {
            width: 252px;
        }
        #Text39 {
            width: 65px;
        }
        #Text40 {
            width: 52px;
        }
        #Text41 {
            width: 731px;
            height: 118px;
        }
        #Text42 {
            width: 94px;
        }
        #Text43 {
            width: 94px;
            height: 32px;
        }
        #Text44 {
            width: 94px;
            height: 32px;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 150px;
        }
        #Text57 {
            width: 147px;
        }
        #Text58 {
            width: 144px;
        }
        #Text59 {
            width: 144px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 1925px; width: 829px;">
    
        <strong>Membership Registration
        </strong>
        <br />
        First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
        <input id="Text3" type="text" />&nbsp;&nbsp;&nbsp;
        <br />
        Last Name:&nbsp;&nbsp;&nbsp;<br />
        <input id="Text45" type="text" /><br />
        Social Security Number:<br />
        <input id="Text46" type="text" />&nbsp;
        <br />
        Phone Number:<br />
        <input id="Text31" type="text" /><br />
        <br />
        Street Address
        <input id="Text9" type="text" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; City
        <input id="Text8" type="text" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; State
        <input id="Text10" type="text" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Zip Code
        <input id="Text11" type="text" /><br />
        <br />
        Date of Birth<br />
        <input id="Text13" type="text" /><input id="Text14" type="text" /><input id="Text15" type="text" /><br />
        <br />
        List all current kentucky racing licenses that you have been issued.
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td>Type</td>
                <td>License Number</td>
                <td>Date Issued</td>
            </tr>
            <tr>
                <td>1.<input id="Text1" type="text" /></td>
                <td>
                    <input id="Text47" type="text" /></td>
                <td>
                    <input id="Text48" type="text" /></td>
            </tr>
            <tr>
                <td>2.<input id="Text49" type="text" /></td>
                <td>
                    <input id="Text50" type="text" /></td>
                <td>
                    <input id="Text51" type="text" /></td>
            </tr>
        </table>
        <br />
        <br />
        List the employers for whom you have worked for in the past 90 days.<br />
        <table class="auto-style1">
            <tr>
                <td>Employer</td>
                <td>Track</td>
                <td>Start Date</td>
                <td class="auto-style2">End Date</td>
            </tr>
            <tr>
                <td>1.<input id="Text22" type="text" /></td>
                <td>
                    <input id="Text54" type="text" /></td>
                <td>
                    <input id="Text57" type="text" /></td>
                <td class="auto-style2">
                    <input id="Text60" type="text" /></td>
            </tr>
            <tr>
                <td>2.<input id="Text52" type="text" /></td>
                <td>
                    <input id="Text55" type="text" /></td>
                <td>
                    <input id="Text58" type="text" /></td>
                <td class="auto-style2">
                    <input id="Text61" type="text" /></td>
            </tr>
            <tr>
                <td>3.<input id="Text53" type="text" /></td>
                <td>
                    <input id="Text56" type="text" /></td>
                <td>
                    <input id="Text59" type="text" /></td>
                <td class="auto-style2">
                    <input id="Text62" type="text" /></td>
            </tr>
        </table>
        &nbsp;
        &nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        Are you currently employed?&nbsp;<br />
        <br />
        If no, please explain:<br />
        <input id="Text32" type="text" />
        <br />
        <br />
        List all the income that you currently earn on and off the racetrack.&nbsp;
        <br />
        <table class="auto-style1">
            <tr>
                <td>Employer</td>
                <td>Occupation</td>
                <td>Weekly Salary</td>
            </tr>
            <tr>
                <td>1.<input id="Text63" type="text" /></td>
                <td>
        <input id="Text65" type="text" /></td>
                <td>
        <input id="Text67" type="text" /></td>
            </tr>
            <tr>
                <td>2.<input id="Text64" type="text" /></td>
                <td>
        <input id="Text66" type="text" /></td>
                <td>
        <input id="Text68" type="text" /></td>
            </tr>
        </table>
        <br />
        <br />
        How long have you been employed in the racing industry in Kentucky?<br />
&nbsp;Years&nbsp;&nbsp;&nbsp;and/or&nbsp;&nbsp;&nbsp; Months&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;<input id="Text39" type="text" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Text40" type="text" /> &nbsp;
        <br />
        <br />
        What sort of assistance are you seeking?<br />
        <input id="Text41" type="text" /><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" />
        </div>
    </form>
</body>
</html>
