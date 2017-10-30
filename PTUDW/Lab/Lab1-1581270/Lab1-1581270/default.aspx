<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Lab1_1581270._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lab01 - 1581270</title>
    <style>
        .name-card {
            background: white;
            width: 200px;
            border: 1px solid #DDDDDD;
            position:absolute;
            left: 45%;
            top: 30%;
        }

        .avatar {
            margin: 0 auto;
            padding: 30px;
            padding-bottom: 10px;
        }

            .avatar img {
                width: 140px;
                height: 140px;
                border-radius: 50%;
            }

        .name-email {
            padding: 10px;
        }

        .name-card h1 {
            text-align: center;
            color: #536378;
            font-weight: normal;
            font-size: 140%;
            margin: 0;
        }

        .name-card .email {
            color: #BAC1C9;
            text-align: center;
            font-size: 80%;
            overflow: hidden;
        }

        .fllower-following a {
            display: block;
            float: left;
            padding: 10px 0;
            width: 100px;
            margin: 0;
            text-decoration: none;
            text-align: center;
            color: white;
        }

        .follower a {
            background: #14B9D6;
        }

            .follower a:hover {
                background: #2980b9;
            }

        .following a {
            background: #F27935;
        }

            .following a:hover {
                background: #e74c3c;
            }
        body {
            background: #EAEDF1;
            font-family: "HelveticaNeue-CondensedBold", "HelveticaNeue-Light", "Helvetica Neue Light", "Helvetica Neue", Helvetica, Arial, "Lucida Grande", Sans-Serif;
        }
    </style>
</head>
<body>
    <div class="name-card">
        <div class="name-avatar-email">
            <div class="avatar">
                <img src="https://scontent.fsgn4-1.fna.fbcdn.net/v/t1.0-9/12510459_1032025626835705_8247419978438829505_n.jpg?oh=e5ad889887e3c422606ac42c58355985&oe=59D7AE71" alt="avatar" />
            </div>
            <div class="name-email">
                <h1 class="name">Nguyen Duc Trung</h1>
                <div class="email">giatrangrua@gmail.com</div>
            </div>
        </div>
        <div class="fllower-following">
            <div class="follower">
                <a href="#">Credits Passed<br>
                    40</a>
            </div>
            <div class="following">
                <a href="#">Credits Remain<br>
                    84</a>
            </div>
        </div>
    </div>
</body>
</html>
