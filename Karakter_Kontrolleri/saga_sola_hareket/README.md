
GetComponent<>() : ile bileşenlere erişiyoruz

GetAxis("Horizontal") ile sag(1) sol(-1) yonlerini alip yon degiskenine atadik

yon'un degerine gore de karakteri r_spriteRenderer.flipX ile saga sola donduruyoruz.

Unity "Animator" ekraninda "Parameters" olarak float degiskeninde "durmak" adında bir şey tanimladim ve eğer "0.01" den buyukse(greater) kosma animasyonuna eğer "0.01" den kucukse(less) durma animasyonuna gidecek

(34) burada "Mathf.Abs(yon)" dememizinn sebebi yonun mutlak degerini almak istememiz.

(35) artık konumu bu hesapladiklarimizle beraber degistirebiliriz sag sol icin x ekseninde degisim yapmamiz gerekli yol = yon * hiz * zaman gibi dusunulebilir nuradaki hesaplama.
