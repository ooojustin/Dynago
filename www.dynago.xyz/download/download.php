<?php
	$file_name = 'build/Dynago 4.1.exe';
	if (file_exists($file_name)) {
		header("Content-disposition: attachment; filename=" . str_replace("build/", "", $file_name));
		header("Content-type: application/x-msdownload");
		readfile($file_name);
		exit();
	} else {
		output_message('Error', 'That file is currently unavailable.', '#FF0000', true);
	}

	function output_message($title, $message, $title_color, $die) {
		$message_page = file_get_contents('../_message.html');
		$message_page = str_replace('[title]', $title, $message_page);
		$message_page = str_replace('[message]', $message, $message_page);
		$message_page = str_replace('[title_color]', $title_color, $message_page);
		if ($die) {
			die($message_page);
		} else {
			echo $message_page;
		}
	}
?>