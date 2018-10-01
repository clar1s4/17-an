using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class soal : MonoBehaviour {
	public string[,] arrSoal;
	public int[] kunci;
	public int[] indexSoal;
	public bool isWin = false;
	public bool isLose = false;


	// Use this for initialization
	void Start () {
		
		arrSoal = new string[20,5];
		kunci = new int[20];
		indexSoal = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

		arrSoal [0,0] = "Siapakah presiden Indonesia yang pertama?"; //soal
		arrSoal [0,1] = "a. Joko Widodo"; //1
		arrSoal [0,2] = "b. Megawati Soekarnoputri"; //2
		arrSoal [0,3] = "c. H.M Soeharto"; //3
		arrSoal [0,4] = "d. Ir Soekarno"; //4
		kunci [0] = 4;

		//soal2
		arrSoal [1,0] = "Siapakah yang menjahit bendera merah putih pertama?"; //soal
		arrSoal [1,1] = "a. Haryati"; //1
		arrSoal [1,2] = "b. Fatmawati"; //2
		arrSoal [1,3] = "c. Muhammad Hatta"; //3
		arrSoal [1,4] = "d. Kartini"; //4
		kunci [1] = 2;

		//soal3
		arrSoal [2,0] = "Dimanakah proklamasi dilaksanakan?"; //soal
		arrSoal [2,1] = "a. Jl. Pegangsaan Selatan"; //1
		arrSoal [2,2] = "b. Jl. Pegangsaan Barat"; //2
		arrSoal [2,3] = "c. Jl. Pegangsaan Utara"; //3
		arrSoal [2,4] = "d. Jl. Pegangsaan Timur"; //4
		kunci [2] = 4;

		//soal4
		arrSoal [3,0] = "Siapa pencipta lagu Indonesia Raya?"; //soal
		arrSoal [3,1] = "a. Santoso Budjiono"; //1
		arrSoal [3,2] = "b. Ismail Marzuki"; //2
		arrSoal [3,3] = "c. W.R Soepratman"; //3
		arrSoal [3,4] = "d. Chairul Anwar"; //4
		kunci [3] = 3;

		//soal5
		arrSoal [4,0] = "Siapakah wakil presiden pertama Indonesia?"; //soal
		arrSoal [4,1] = "a. Hattarajasa"; //1
		arrSoal [4,2] = "b. B.J Habibie"; //2
		arrSoal [4,3] = "c. Mohammad Hatta"; //3
		arrSoal [4,4] = "d. Muhammad Jusuf Kalla"; //4
		kunci [4] = 3;

		//soal6
		arrSoal [5,0] = "Monumen Nasional dan Tugu Proklamasi terdapat di kota?"; //soal
		arrSoal [5,1] = "a. Surabaya"; //1
		arrSoal [5,2] = "b. Yogyakarta"; //2
		arrSoal [5,3] = "c. Bandung"; //3
		arrSoal [5,4] = "d. Jakarta"; //4
		kunci [5] = 4;

		//soal7
		arrSoal [6,0] = "Apakah warna bendera Indonesia?"; //soal
		arrSoal [6,1] = "a. Merah Putih"; //1
		arrSoal [6,2] = "b. Putih Merah"; //2
		arrSoal [6,3] = "c. Merah Putih Biru"; //3
		arrSoal [6,4] = "d. Hitam Merah Kuning"; //4
		kunci [6] = 1;

		//soal8
		arrSoal [7,0] = "Apakah bunyi sila pertama?"; //soal
		arrSoal [7,1] = "a. Keadilan Sosial bagi seluruh rakyat Indonesia"; //1
		arrSoal [7,2] = "b. Persatuan Indonesia"; //2
		arrSoal [7,3] = "c. Ketuhanan yang maha esa"; //3
		arrSoal [7,4] = "d. Kemanusian yang adil dan beradab"; //4
		kunci [7] = 3;

		//soal9
		arrSoal [8,0] = "Apakah bunyi sila kedua?"; //soal
		arrSoal [8,1] = "a. Kemanusian yang adil dan beradab"; //1
		arrSoal [8,2] = "b. Keadilan Sosial bagi seluruh rakyat Indonesia"; //2
		arrSoal [8,3] = "c. Ketuhanan yang maha esa"; //3
		arrSoal [8,4] = "d. Persatuan Indonesia\n"; //4
		kunci [8] = 1;

		//soal10
		arrSoal [9,0] = "Apakah bunyi sila ketiga?"; //soal
		arrSoal [9,1] = "a. Kerakyatan yang dipimpin oleh hikmat kebijaksaan dalam permusyawaratan/ perwakilan"; //1
		arrSoal [9,2] = "b. Kemanusian yang adil dan beradab"; //2
		arrSoal [9,3] = "c. Keadilan Sosial bagi seluruh rakyat Indonesia"; //3
		arrSoal [9,4] = "d. Persatuan Indoneisa"; //4
		kunci [9] = 4;


		//soal11
		arrSoal [10,0] = "Apakah bunyi sila keempat?"; //soal
		arrSoal [10,1] = "a. Kemanusiaan yang adil dan beradab"; //1
		arrSoal [10,2] = "b. Ketuhanan yang maha esa"; //2
		arrSoal [10,3] = "c. Kerakyatan yang dipimpin oleh hikmat kebijaksaan dalam permusyawaratan/ perwakilan"; //3
		arrSoal [10,4] = "d. Persatuan Indonesia"; //4
		kunci [10] = 3;

		//soal12
		arrSoal [11,0] = "Apakah bunyi sila kelima?"; //soal
		arrSoal [11,1] = "a. Ketuhanan yang maha esa"; //1
		arrSoal [11,2] = "b. Persatuan Indonesia"; //2
		arrSoal [11,3] = "c. Keadilan Sosial bagi seluruh rakyat Indonesia"; //3
		arrSoal [11,4] = "d. Kemanusiaan yang adil dan beradab"; //4
		kunci [11] = 3;

		//soal13
		arrSoal [12,0] = "Berapa bulu di leher lambang garuda pancasila?"; //soal
		arrSoal [12,1] = "a. 8"; //1
		arrSoal [12,2] = "b. 17"; //2
		arrSoal [12,3] = "c. 45"; //3
		arrSoal [12,4] = "d. 19"; //4
		kunci [12] = 3;

		//soal14
		arrSoal [13,0] = "Berapa lama Indonesia dijajah Jepang?"; //soal
		arrSoal [13,1] = "a. 3,5 Tahun"; //1
		arrSoal [13,2] = "b. 350 Tahun"; //2
		arrSoal [13,3] = "c. 35 Tahun"; //3
		arrSoal [13,4] = "d. 355 Tahun"; //4
		kunci [13] = 1;

		//soal15
		arrSoal [14,0] = "Siapa nama lengkap W.R Soepratman?"; //soal
		arrSoal [14,1] = "a. William Raden Soepratman"; //1
		arrSoal [14,2] = "b. Wage Raden Soepratman"; //2
		arrSoal [14,3] = "c. Wage Rudolf Soepratman"; //3
		arrSoal [14,4] = "d. Wijang Rudolf Soepratman"; //4
		kunci [14] = 3;

		//soal16
		arrSoal [15,0] = "Siapa nama lengkap R.A Kartini?"; //soal
		arrSoal [15,1] = "a. Raden Ayu Kartini"; //1
		arrSoal [15,2] = "b. Raden Ajeng Kartini"; //2
		arrSoal [15,3] = "c. Rudolf Adjeng Kartini"; //3
		arrSoal [15,4] = "d. Raden Adjeng Kartini"; //4
		kunci [15] = 4;
	
		//soal17
		arrSoal [16,0] = "Siapa pencipta lagu Indonesia Pusaka?"; //soal
		arrSoal [16,1] = "a. Ismail Marzuki"; //1
		arrSoal [16,2] = "b. W.R Soepratman"; //2
		arrSoal [16,3] = "c. Ibu Soed"; //3
		arrSoal [16,4] = "d. M Syafei"; //4
		kunci [16] = 1;

		//soal18
		arrSoal [17,0] = "Siapakah presiden Indonesia yang ke-dua?"; //soal
		arrSoal [17,1] = "a. H.M Soeharto"; //1
		arrSoal [17,2] = "b. Ir. Soekarno"; //2
		arrSoal [17,3] = "c. Susilo Bambang Yudhoyono"; //3
		arrSoal [17,4] = "d. Megawati Seokarnoputri"; //4
		kunci [17] = 1;

		//soal19
		arrSoal [18,0] = "Siapakah presiden Indonesia yang ke-tiga?"; //soal
		arrSoal [18,1] = "a. B.J Habibie"; //1
		arrSoal [18,2] = "b. Abdurrahman Wahid"; //2
		arrSoal [18,3] = "c. Joko Widodo"; //3
		arrSoal [18,4] = "d. Ir. Soekarno"; //4
		kunci [18] = 1;

		//soal20
		arrSoal [19,0] = "Siapakah presiden Indonesia yang ke-empat?"; //soal
		arrSoal [19,1] = "a. Megawati Soekarnoputri"; //1
		arrSoal [19,2] = "b. Ir. Soekarno"; //2
		arrSoal [19,3] = "c. Susilo Bambang Yudhoyono"; //3
		arrSoal [19,4] = "d. Abdurrahman Wahid"; //4
		kunci [19] = 4;

		randomizer ();
	}
	public void randomizer(){
		int temp;
		System.Random rand = new System.Random ();
		for(int i = 19; i > 0; i--){
			int r = rand.Next (0, i);
			temp = indexSoal [r];
			indexSoal [r] = indexSoal [i];
			indexSoal [i] = temp;
		}
			
	}
}
