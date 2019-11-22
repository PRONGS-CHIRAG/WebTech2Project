<?php
	extract($_GET);
	$chunk=500;
	$pos=$count*$chunk;
	$file=fopen("content2.txt","r");
	fseek($file,$pos);
	$data=fread($file,$chunk);
	echo $data;





?>