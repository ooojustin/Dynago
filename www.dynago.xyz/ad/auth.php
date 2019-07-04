<?php
	date_default_timezone_set('US/Eastern'); // Set time zone for logging.
	ini_set('log_errors', 1);
	ini_set('display_errors', 0);

	include 'config.php'; // SQL Server stuff
	$server_server = $config['server'];
	$server_username = $config['username'];
	$server_password = $config['password'];
	$server_dbname = $config['dbname'];

	try
	{
		$conn = new PDO('mysql:host=' . $server_server . ';dbname=' . $server_dbname, $server_username, $server_password,[PDO::ATTR_DEFAULT_FETCH_MODE=>PDO::FETCH_ASSOC]);
	} catch (PDOException $e) {
    	output_message('Error', 'Database connection error.', '#FF0000', true);
	}

	// Successfully connected to the database.
	include './ad.php';

	// $userId, $publicKey, $secretKey
	$adfly = new AdflyInst(0, '', '');

	authAD($_GET['id'], $adfly);

	function authAD($id, $adfly) {
		$conn = $GLOBALS['conn'];
		$checkID = $conn->prepare("SELECT * FROM ad WHERE id=:id");
		$checkID->bindValue(':id', $id);
		$checkID->execute();
		$result = $checkID->fetch();
		if ($checkID->rowCount() < 1)
			output_message('Error', 'Proof of Work ID not found.', '#FF0000', true);
		if ($result['status'] > 0)
			output_message('Error', 'ID already authenticated.<br>Login has already been completed.', '#FF0000', true);
		$updateID = $conn->prepare("UPDATE ad SET status='1' WHERE id=:id");
		$updateID->bindValue(':id', $id);
		if (!$updateID->execute())
			output_message('Error', 'Failed to update ID status.', '#FF0000', true);
		$adfly->deleteUrl($result['link_id']);
		output_message('Success', 'Dynago authentication completed!<br>Thanks for your contribution, have fun :)', '#00FF00', true);
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

	function prepend($string, $orig_filename) {
  		$string .= ("<br>" . PHP_EOL);
  		$context = stream_context_create();
  		$orig_file = fopen($orig_filename, 'r', 1, $context);

  		$temp_filename = tempnam(sys_get_temp_dir(), 'php_prepend_');
  		file_put_contents($temp_filename, $string);
  		file_put_contents($temp_filename, $orig_file, FILE_APPEND);

  		fclose($orig_file);
  		unlink($orig_filename);
  		rename($temp_filename, $orig_filename);
  		chmod($orig_filename, 0777);
	}
?>
