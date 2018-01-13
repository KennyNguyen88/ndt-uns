<!DOCTYPE html>
<html>
<head>
	<title>LTW02 - Bài tập lớn 02</title>
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
		#Xuất ra thông tin Sinh viên: MSSV, họ tên, Email, hình avatar
		$mssv = '1581270';
		$fullName = 'Nguyễn Đức Trung';
		$email = 'giatrangrua@gmail.com';

		function isChan($num){
			return ($num % 2 == 0) ? true : false;
		}

	?>
	<div class="container">
		<div class="row">
			<div class="col-lg-3 col-sm-6">
	            <div class="card hovercard">
	                <div class="cardheader">
	                </div>
	                <div class="avatar">
	                    <img alt="" src="./Trung_Port.png">
	                </div>
	                <div class="info">
	                    <div class="title">
	                        <a href="#"><?php echo $fullName; ?></a>
	                    </div>
	                    <div class="desc"><?php echo 'MSSV: '.$mssv; ?></div>
	                    <div class="desc"><?php echo 'Email: '.$email; ?></div>
	                </div>
	            </div>

	        </div>
        	<div class="col-lg-9 col-sm-6">
        		<?php
					#Xuất ra ngày & giờ hiện hành của hệ thống web server.
    				$currentTime = date("d/m/Y h:i:s");
    				
					#Tạo một số ngẫu nhiên N (từ 2-20). Lưu ý, gieo hạt giống random seed trước khi chạy hàm Rand. 
					$ranmin = 2;
					$ranmax = 20;
					$n = rand($ranmin,$ranmax);
				?>
				<p><span>Ngày giờ hiện hành:</span> <?php echo " $currentTime"; ?></p>
				<p><span><?php echo "Số ngẫu nhiên từ $ranmin ~ $ranmax :"?></span> <?php echo " $n"; ?></p>
				<?php 
					if (!isChan($n)){
						#Nếu N là số lẻ, thông báo ra màn hình "Không có nội dung, hãy thử lại lần nữa"
						echo "<p>Không có nội dung, hãy thử lại lần nữa</p>";
					}
					else{
						$m = date("d") + 0;
						echo "<p> <span>Số ngày: </span> $m</p>";
						#Nếu N là số chẵn, xuất ra N x M dòng dữ liệu. Với M là ngày hiện hành của server. Dòng chẵn sẽ là 1 hình bất kỳ vói kích thước 100x150px. Dòng lẻ là 1 clip ngắn.
						#Điểm cộng: hình và clip ở mỗi dòng khác nhau. 
						
						$nm = $n * $m;
						for($i = 1; $i <= $nm; $i++){
							if (isChan($i)){
								echo "<p><img src='https://picsum.photos/200/300/?image=$i' class='cimg' /></p>";
							}
							else {
								echo "<p><iframe width='560' height='315' src='https://www.youtube.com/embed/aVS4W7GZSq0' frameborder='0' gesture='media' allow='encrypted-media' allowfullscreen></iframe></p>";
							}
						}
					}

				?>

        	</div>
		</div>
	</div>
	


	<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.3/js/bootstrap.min.js" integrity="sha384-a5N7Y/aK3qNeh15eJKGWxsqtnX/wWdSZSKp+81YjTmS15nvnvxKHuzaWwXHDli+4" crossorigin="anonymous"></script>
</body>
