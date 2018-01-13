<!DOCTYPE html>
<html>
<head>
    <title>LTW02 - Bài tập 03</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.3/css/bootstrap.min.css" integrity="sha384-Zug+QiDoJOrZ5t4lssLdxGhVrurbmBWopoEl+M6BdEfwnCJZtKxi1KgxUyJq13dy" crossorigin="anonymous">
    <style>
        .cimg {
            width: 100px;
            height: 150px;
        }
        .card {
            padding-top: 20px;
            margin: 10px 0 20px 0;
            background-color: rgba(214, 224, 226, 0.2);
            border-top-width: 0;
            border-bottom-width: 2px;
            -webkit-border-radius: 3px;
            -moz-border-radius: 3px;
            border-radius: 3px;
            -webkit-box-shadow: none;
            -moz-box-shadow: none;
            box-shadow: none;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
        }

        .card .card-heading {
            padding: 0 20px;
            margin: 0;
        }

        .card .card-heading.simple {
            font-size: 20px;
            font-weight: 300;
            color: #777;
            border-bottom: 1px solid #e5e5e5;
        }

        .card .card-heading.image img {
            display: inline-block;
            width: 46px;
            height: 46px;
            margin-right: 15px;
            vertical-align: top;
            border: 0;
            -webkit-border-radius: 50%;
            -moz-border-radius: 50%;
            border-radius: 50%;
        }

        .card .card-heading.image .card-heading-header {
            display: inline-block;
            vertical-align: top;
        }

        .card .card-heading.image .card-heading-header h3 {
            margin: 0;
            font-size: 14px;
            line-height: 16px;
            color: #262626;
        }

        .card .card-heading.image .card-heading-header span {
            font-size: 12px;
            color: #999999;
        }

        .card .card-body {
            padding: 0 20px;
            margin-top: 20px;
        }

        .card .card-media {
            padding: 0 20px;
            margin: 0 -14px;
        }

        .card .card-media img {
            max-width: 100%;
            max-height: 100%;
        }

        .card .card-actions {
            min-height: 30px;
            padding: 0 20px 20px 20px;
            margin: 20px 0 0 0;
        }

        .card .card-comments {
            padding: 20px;
            margin: 0;
            background-color: #f8f8f8;
        }

        .card .card-comments .comments-collapse-toggle {
            padding: 0;
            margin: 0 20px 12px 20px;
        }

        .card .card-comments .comments-collapse-toggle a,
        .card .card-comments .comments-collapse-toggle span {
            padding-right: 5px;
            overflow: hidden;
            font-size: 12px;
            color: #999;
            text-overflow: ellipsis;
            white-space: nowrap;
        }

        .card-comments .media-heading {
            font-size: 13px;
            font-weight: bold;
        }

        .card.people {
            position: relative;
            display: inline-block;
            width: 170px;
            height: 300px;
            padding-top: 0;
            margin-left: 20px;
            overflow: hidden;
            vertical-align: top;
        }

        .card.people:first-child {
            margin-left: 0;
        }

        .card.people .card-top {
            position: absolute;
            top: 0;
            left: 0;
            display: inline-block;
            width: 170px;
            height: 150px;
            background-color: #ffffff;
        }

        .card.people .card-top.green {
            background-color: #53a93f;
        }

        .card.people .card-top.blue {
            background-color: #427fed;
        }

        .card.people .card-info {
            position: absolute;
            top: 150px;
            display: inline-block;
            width: 100%;
            height: 101px;
            overflow: hidden;
            background: #ffffff;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
        }

        .card.people .card-info .title {
            display: block;
            margin: 8px 14px 0 14px;
            overflow: hidden;
            font-size: 16px;
            font-weight: bold;
            line-height: 18px;
            color: #404040;
        }

        .card.people .card-info .desc {
            display: block;
            margin: 8px 14px 0 14px;
            overflow: hidden;
            font-size: 12px;
            line-height: 16px;
            color: #737373;
            text-overflow: ellipsis;
        }

        .card.people .card-bottom {
            position: absolute;
            bottom: 0;
            left: 0;
            display: inline-block;
            width: 100%;
            padding: 10px 20px;
            line-height: 29px;
            text-align: center;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;
        }

        .card.hovercard {
            position: relative;
            padding-top: 0;
            overflow: hidden;
            text-align: center;
            background-color: rgba(214, 224, 226, 0.2);
        }

        .card.hovercard .cardheader {
            background: url("./bg.jpg");
            background-size: cover;
            height: 135px;
        }

        .card.hovercard .avatar {
            position: relative;
            top: -50px;
            margin-bottom: -50px;
        }

        .card.hovercard .avatar img {
            width: 100px;
            height: 100px;
            max-width: 100px;
            max-height: 100px;
            -webkit-border-radius: 50%;
            -moz-border-radius: 50%;
            border-radius: 50%;
            border: 5px solid rgba(255,255,255,0.5);
        }

        .card.hovercard .info {
            padding: 4px 8px 10px;
        }

        .card.hovercard .info .title {
            margin-bottom: 4px;
            font-size: 24px;
            line-height: 1;
            color: #262626;
            vertical-align: middle;
        }

        .card.hovercard .info .desc {
            overflow: hidden;
            font-size: 12px;
            line-height: 20px;
            color: #737373;
            text-overflow: ellipsis;
        }

        .card.hovercard .bottom {
            padding: 0 20px;
            margin-bottom: 17px;
        }

        .btn{ border-radius: 50%; width:32px; height:32px; line-height:18px;  }
    </style>
</head>
<body>
<?php
    //Tạo ra 1 mảng 2 chiều chứa danh sách sinh viên, mỗi sinh viên gồm các thông tin sau (MSSV, họ tên, DTB, LinkURLAvatar)
    // Nhập sẵn trong mảng khoảng 10-20 sinh viên
    $SinhViens = array(
        array ("MSSV"=>"1588032","Họ Tên"=>"Bùi Thanh Vân","DTB"=>10,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/1"),
        array ("MSSV"=>"1581035","Họ Tên"=>"Đường Anh Minh","DTB"=>9,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/2"),
        array ("MSSV"=>"1481064","Họ Tên"=>"Huỳnh Bá Thành","DTB"=>4,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/3"),
        array ("MSSV"=>"1688058","Họ Tên"=>"Huỳnh Hữu Thiện","DTB"=>7,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/4"),
        array ("MSSV"=>"1581287","Họ Tên"=>"Huỳnh Trang Bình","DTB"=>3,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/5"),
        array ("MSSV"=>"1581271","Họ Tên"=>"Lê Đình Trữ","DTB"=>8,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/6"),
        array ("MSSV"=>"1081124","Họ Tên"=>"Lê Hoàng Phúc","DTB"=>7,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/7"),
        array ("MSSV"=>"1481227","Họ Tên"=>"Ngân Viết Hùng","DTB"=>7,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/8"),
        array ("MSSV"=>"1581270","Họ Tên"=>"Nguyễn Đức Trung","DTB"=>3,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/9"),
        array ("MSSV"=>"08TX0277","Họ Tên"=>"Nguyễn Hoàng Vũ","DTB"=>6,"LinkURLAvatar"=>"http://lorempixel.com/200/200/people/10")
    );

    //Sắp xếp tăng dần theo họ tên
    function cmp($a, $b){
        return strcmp(strtoupper($a["Họ Tên"]),strtoupper($b["Họ Tên"]));
    }
    uasort($SinhViens, 'cmp');

    //Danh sách sinh viên giỏi
    $SinhVienGiois = array();

    foreach ($SinhViens as $sinhVien){
        if ($sinhVien["DTB"] > 8){
            $SinhVienGiois[] = $sinhVien;
        }
    }
?>
<div class="container">
    <div class="row">
        <div class="col-9">
            <h3> Danh Sách Sinh Viên (<?php echo count($SinhViens);?>)</h3>
            <div class="row">

                <?php foreach ($SinhViens as $sinhVien)
                {
                    $MSSV = $sinhVien["MSSV"];
                    $HoTen = $sinhVien["Họ Tên"];
                    $DTB = $sinhVien["DTB"];
                    $UrlA = $sinhVien["LinkURLAvatar"];

                    ?>
                    <div class="col-6">
                        <div class="card hovercard">
                            <div class="cardheader">
                            </div>
                            <div class="avatar">
                                <img alt="" src=<?php echo $UrlA; ?>>
                            </div>
                            <div class="info">
                                <div class="title">
                                    <a href="#"><?php echo $HoTen; ?></a>
                                </div>
                                <div class="desc"><?php echo 'MSSV: '.$MSSV; ?></div>
                                <div class="desc"><?php echo 'Điểm Trung Bình: '.$DTB; ?></div>
                            </div>
                        </div>
                    </div>
                <?php } ?>
            </div>
        </div>
        <div class="col-3">
            <h3> Số lượng sinh viên giỏi là <?php echo count($SinhVienGiois);?> sinh viên. Danh sách gồm: </h3>
            <?php for ($i = 0; $i < count($SinhVienGiois); $i++){ ?>
                <p><?php echo ($i+1).".".$SinhVienGiois[$i]["MSSV"]." - ".$SinhVienGiois[$i]["Họ Tên"]." - ".$SinhVienGiois[$i]["DTB"]; ?></p>

            <?php } ?>
        </div>
    </div>


</div>



<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.3/js/bootstrap.min.js" integrity="sha384-a5N7Y/aK3qNeh15eJKGWxsqtnX/wWdSZSKp+81YjTmS15nvnvxKHuzaWwXHDli+4" crossorigin="anonymous"></script>
</body>
