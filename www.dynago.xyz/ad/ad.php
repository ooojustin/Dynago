<?php
// In this example we use very convenient library for performing
// REST api calls. Library is hosted at http://code.google.com/p/gam-http/
// Of course you are free to use any other REST client library or even
// write your own.

error_reporting(0);
try {
    include './http.php';
} catch (Exception $e) { }
error_reporting(E_ALL & ~E_NOTICE);

/**
 * Describes two kinds of authentication. Acts as enum.
 */
class AuthType {
	const BASIC = 1;
	const HMAC = 2;
}

class AdflyInst {
	const BASE_HOST = 'api.adf.ly';
	const HMAC_ALGO = 'sha256';

	private $userId = 0;
	private $publicKey = '';
	private $secretKey = '';
	private $connection = null;

	public function __construct($userId, $publicKey, $secretKey) {
		$this->connection = Http::connect(self::BASE_HOST, 443, Http::HTTPS);
		$this->secretKey = $secretKey;
		$this->publicKey = $publicKey;
		$this->userId = $userId;
	}
	public function auth($username, $password) {
		return json_decode($this->connection->doPost('v1/auth',$this->getParams(array('username' => $username, 'password' => $password), null)), 1);
	}

	public function getGroups($page=1) {
		return json_decode($this->connection->doGet('v1/urlGroups',$this->getParams(array('_page' => $page), AuthType::HMAC)),1);
	}
	public function createGroup($name) {
		return $this->connection->doPost('v1/urlGroups',$this->getParams(array('name' => $name), AuthType::HMAC));
	}

	public function getAccountDetails() {
		return json_decode($this->connection->doGet('v1/account',$this->getParams(array(), AuthType::HMAC)), 1);
	}

	public function updateAccountDetails(array $params=[]) {
		return json_decode($this->connection->doPut('v1/account',$this->getParams($params, AuthType::HMAC)), 1);
	}

	public function updatePassword($password, $password1, $password2) {
		return json_decode($this->connection->doPut('v1/password',$this->getParams(array('password' => $password, 'password1' => $password1, 'password2' => $password2), AuthType::HMAC)), 1);
	}

	public function expand(array $urls, array $hashes=array()) {
		$params = array();

		$i = 0;
		foreach ($urls as $url) {
			$params[sprintf('url[%d]', $i++)] = $url;
		}

		$i = 0;
		foreach ($hashes as $hash) {
			$params[sprintf('hash[%d]', $i++)] = $hash;
		}

		return json_decode($this->connection->doGet('v1/expand',$this->getParams($params)),1);
	}

	public function shorten(array $urls, $domain=false, $advertType=false, $groupId=false, $title=false, $customName=false) {
		$params = array();
		if ($domain !== false) $params['domain'] = $domain;
		if ($advertType !== false) $params['advert_type'] = $advertType;
		if ($groupId !== false) $params['group_id'] = $groupId;
		if ($title !== false) $params['title'] = $title;
		if ($customName !== false) $params['custom_name'] = $customName;

		$i = 0;
		foreach ($urls as $url) {
			$params[sprintf('url[%d]', $i++)] = $url;
		}

		return $this->connection->doPost('v1/shorten',$this->getParams($params));
	}

	public function getUrls($page=1, $q=null) {
		$params = array();
		//$params['_page'] = $page;

		if ($q) {
			$params['q'] = $q;
		}

		return json_decode($this->connection->doGet('v1/urls',$this->getParams($params, AuthType::HMAC)),1);
	}

	public function getReferrers($urlId=null, $month='') {
		$params = array();
		if ($urlId) $params['url_id'] = $urlId;
		if ($month) $params['month'] = $month;

		return json_decode($this->connection->doGet('v1/referrers',$this->getParams($params, AuthType::HMAC)),1);
	}

	public function getDomains() {
		$params = array();
		return json_decode($this->connection->doGet('v1/domains',$this->getParams($params, AuthType::HMAC)),1);
	}

	public function getAccountCountries() {
		return json_decode($this->connection->doGet('v1/accountCountries',$this->getParams(array(), AuthType::BASIC)), 1);
	}

	public function getAccountPubReferrals($fromDate='', $toDate='', $page=1, $includeBanned=0) {
		$params = array('fromDate' => $fromDate, 'toDate' => $toDate, '_page' => $page, 'includeBanned' => $includeBanned);
		return json_decode($this->connection->doGet('v1/accountPubReferrals', $this->getParams($params, AuthType::HMAC)), 1);
	}

	public function getAccountAdvReferrals($fromDate='', $toDate='', $page=1, $includeBanned=0) {
		$params = array('fromDate' => $fromDate, 'toDate' => $toDate, '_page' => $page, 'includeBanned' => $includeBanned);
		return json_decode($this->connection->doGet('v1/accountAdvReferrals', $this->getParams($params, AuthType::HMAC)), 1);
	}

	public function getAccountPopReferrals($fromDate='', $toDate='', $page=1, $includeBanned=0) {
		$params = array('fromDate' => $fromDate, 'toDate' => $toDate, '_page' => $page, 'includeBanned' => $includeBanned);
		return json_decode($this->connection->doGet('v1/accountPopReferrals', $this->getParams($params, AuthType::HMAC)), 1);
	}

	public function getAccountTotalReferrals($includeBanned=0) {
		$params = array('includeBanned' => $includeBanned);
		return json_decode($this->connection->doGet('v1/accountTotalReferrals', $this->getParams($params, AuthType::HMAC)), 1);
	}

	public function getCountries($urlId=null, $month='') {
		$params = array();
		if ($urlId) $params['url_id'] = $urlId;
		if ($month) $params['month'] = $month;

		return json_decode($this->connection->doGet('v1/countries',$this->getParams($params, AuthType::HMAC)),1);
	}
	public function getAnnouncements($type=null) {
		$params = array();
		if (!empty($type) && in_array($type,array(1,2))) $params['type'] = $type;

		return json_decode($this->connection->doGet('v1/announcements',$this->getParams($params, AuthType::HMAC)),1);
	}


	public function getPublisherReferrals() {
		return json_decode($this->connection->doGet('v1/publisherReferralStats',$this->getParams(array(), AuthType::HMAC)),1);
	}
	public function getAdvertiserReferrals() {
		return json_decode($this->connection->doGet('v1/advertiserReferralStats',$this->getParams(array(), AuthType::HMAC)),1);
	}

	public function getWithdraw() {
		return json_decode($this->connection->doGet('v1/withdraw',$this->getParams(array(), AuthType::HMAC)), 1);
	}
	public function getWithdrawalTransactions() {
		return json_decode($this->connection->doGet('v1/withdrawalTransactions',$this->getParams(array(), AuthType::HMAC)),1);
	}

	public function withdrawRequestInitiate() {
		return json_decode($this->connection->doGet('v1/requestWithdraw',$this->getParams(array(), AuthType::HMAC)), 1);
	}

	public function withdrawRequestCancel() {
		return json_decode($this->connection->doDelete('v1/requestWithdraw',$this->getParams(array(), AuthType::HMAC)), 1);
	}

	public function getPublisherStats($date = null, $urlId = 0){
		$params = array();
		if(!empty($date)) $params['date'] = $date;
		if(!empty($urlId)) $params['urlId'] = $urlId;

		return json_decode($this->connection->doGet('v1/publisherStats',$this->getParams($params, AuthType::HMAC)),1);
	}
	public function getProfile() {
		echo $this->connection->doGet('v1/profile',$this->getParams(array(), AuthType::HMAC));
		die;
	}
	public function getAdvertiserCampaigns( $fromDate = null, $toDate = null,$adType = null, $adFilter = null){
		if(!empty($fromDate)) $params['fromDate'] = $fromDate;
		if(!empty($toDate)) $params['toDate'] = $toDate;
		if(!empty($adType)) $params['adType'] = $adType;
		if(!empty($adFilter)) $params['adFilter'] = $adFilter;

		return json_decode($this->connection->doGet('v1/advertiserCampaigns',$this->getParams(array(), AuthType::HMAC)),1);
	}
	public function getAdvertiserGraph($date = null, $websiteId = 0,$adType = null, $adFilter = null){
		$params = array();
		if(!empty($date)) $params['date'] = $date;
		if(!empty($websiteId)) $params['websiteId'] = $websiteId;
		if(!empty($adType)) $params['adType'] = $adType;
		if(!empty($adFilter)) $params['adFilter'] = $adFilter;

		return json_decode($this->connection->doGet('v1/advertiserGraph',$this->getParams($params, AuthType::HMAC)),1);
	}
	public function getAdvertiserCampaignParts($campaignId, $fromDate = null, $toDate = null, $adType = null, $adFilter = null){
		$params = array('campaignId' => $campaignId);
		if(!empty($fromDate)) $params['fromDate'] = $fromDate;
		if(!empty($toDate)) $params['toDate'] = $toDate;
		if(!empty($adType)) $params['adType'] = $adType;
		if(!empty($adFilter)) $params['adFilter'] = $adFilter;

		return json_decode($this->connection->doGet('v1/advertiserCampaignParts',$this->getParams($params, AuthType::HMAC)),1);
	}

	public function updateUrl($id, $url=false, $advertType=false, $title=false, $groupId=false, $fbDescription=false, $fbImage=false) {
		$params = array();

		if ($url !== false) $params['url'] = $url;
		if ($advertType !== false) $params['advert_type'] = $advertType;
		if ($title !== false) $params['title'] = $title;
		if ($groupId !== false) $params['group_id'] = $groupId;
		if ($fbDescription !== false) $params['fb_description'] = $fbDescription;
		if ($fbImage !== false) $params['fb_image'] = $fbImage;

		return json_decode($this->connection->doPut('v1/urls/' . $id,$this->getParams($params, AuthType::HMAC)),1);
	}

	public function deleteUrl($id) {
		return json_decode($this->connection->doDelete('v1/urls/' . $id,$this->getParams(array(), AuthType::HMAC)),1);
	}

	/**
	 * Populates query parameters with required parameters. Such as
	 * _user_id, _api_key, etc.
	 * @param array $params
	 * @param integer $authType
	 */
	private function getParams(array $params=array(), $authType=AuthType::BASIC) {
		$params['_user_id'] = $this->userId;
		$params['_api_key'] = $this->publicKey;

		if (AuthType::BASIC == $authType) {

		} else if (AuthType::HMAC == $authType) {
			// Get current unix timestamp (UTC time).
			$params['_timestamp'] = time();
			// And calculate hash.
			$params['_hash'] = $this->doHmac($params);
		}

		return $params;
	}

	private function doHmac(array $params) {
		// Built-in 'http_build_query' function which is used
		// to construct query string does not include parameters with null
		// values which is incorrect in our case.
		$params = array_map(function($x) { return is_null($x) ? '' : $x; }, $params);

		// Sort query parameters by names using byte ordering.
		// So 'param[10]' comes before 'param[2]'.
		if (ksort($params)) {
			// Url encode parameters. The encoding should be performed
			// per RFC 1738 (http://www.faqs.org/rfcs/rfc1738)
			// which implies that spaces are encoded as plus (+) signs.
			$queryStr = http_build_query($params);
			// Generate hash value based on encoded query string and
			// secret key.
			return hash_hmac(self::HMAC_ALGO, $queryStr, $this->secretKey);
		} else {
			throw new RuntimeException('Could not ksort data array');
		}
	}

	public function prettyPrint( $json )
	{
		$result = '';
		$level = 0;
		$in_quotes = false;
		$in_escape = false;
		$ends_line_level = NULL;
		$json_length = strlen( $json );

		for( $i = 0; $i < $json_length; $i++ ) {
			$char = $json[$i];
			$new_line_level = NULL;
			$post = "";
			if( $ends_line_level !== NULL ) {
				$new_line_level = $ends_line_level;
				$ends_line_level = NULL;
			}
			if ( $in_escape ) {
				$in_escape = false;
			} else if( $char === '"' ) {
				$in_quotes = !$in_quotes;
			} else if( ! $in_quotes ) {
				switch( $char ) {
					case '}': case ']':
						$level--;
						$ends_line_level = NULL;
						$new_line_level = $level;
						break;

					case '{': case '[':
						$level++;
					case ',':
						$ends_line_level = $level;
						break;

					case ':':
						$post = " ";
						break;

					case " ": case "\t": case "\n": case "\r":
						$char = "";
						$ends_line_level = $new_line_level;
						$new_line_level = NULL;
						break;
				}
			} else if ( $char === '\\' ) {
				$in_escape = true;
			}
			if( $new_line_level !== NULL ) {
				$result .= "\n".str_repeat( "\t", $new_line_level );
			}
			$result .= $char.$post;
		}

		return $result;
	}
}
