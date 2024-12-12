
  <h1>Attributes</h1>
    <p>
      Attribute, C#-da proqramlaşdırma dilində proqramlama elementlərinin (class, struct, metod və.s.) davranışına, strukturuna və ya görünüşünə müdaxilə etmək üçün istifadə edilən bir özəllikdir. Davranışların yönləndirilməsi üçün atributlardan istifadə edilir. <br>
      Yəni proqramatik strukturlar üçün metadataları təmsil edən strukturlardır.
    </p>

  <h3><strong>Metadata nədir?</strong></h3>
    <p>
      Metadata, kod içərisində bir data, struktur haqqında bilgi saxlayan extra datalardır. Bu bilgilər proqramın çalışması, yaxud istifadə edilməsi ilə əlaqəli bilgiləri saxlaya bilər. <br>
      Məsələn, proqramın versiyası, qurucusu, lisansı, əməliyyat sistemləri, dəstəklənən dilləri və.s. kimi dataları ola biləcəyi kimi əlaqəli strukturun ortaya qoya biləcəyi davranışlarını yönləndirməsi ilə əlaqəli bilgiləri də ola bilər. Yəni  proqram haqqında açıqlayıcı və tanıdan bilgilər saxlaya bilər. Bu bilgilər user-lərin və ya developer-lərin proqrama aid məlumatları başa düşmələrinə yaxud istifadə etmələrinə kömək edər. <br>
      Uzun sözün qısası atributlar sayəsində metadatalar təmsil edilir və compiler və run time-da bu metadatalar əldə edilərək yönləndirmələr edilir.
    </p>

  <h3><strong>Bəs bu attributlar hansı hallarda lazım olacaq?</strong></h3>
    <br>
    <br>
    <ul>
      <strong>Reflection</strong>
      <li>
        Atributlar, reflection istifadə edərkən run time-da tipin və ya member-ın özəlliklərinə dinamik olaraq əldə etmək və üçün yaxud digər strukturlardan ayrı edilə bilənlik qazandırmaq üçün istifadə edilə bilər. Yəni bir proyektin içərisində elə class-lar olacaq ki, bu class-lar sadəcə müəyyən davranışlar üçün çalışacaq. 
      </li>
      <strong>Kod Analizi</strong>
      <li>
        Atributlar, statik olaraq kod analizi tool-larında da istifadə edilir. Bu tool-lar kodumuzu incələdikdə müəyyən kriteriyalara uyğunlaşan və ya uyğunlaşmayan kod parçalarını müəyyən etməyə attributlar vasitəsilə köməkçi ola bilər.
      </li>
      <strong>Contract</strong>
      <li>
        Attributlar, obyektlərin və ya metodların müəyyən bir şərti həyata keçirməsi lazım olduğu təqdirdə bunu bildirmək, yəni bir kontrakt məntiqində iş orataya qoymaq üçün istifadə edilə bilər.
      </li>
    </ul>

  <h1>Custom Attribute Yaratma</h1>

  <p>
      Attributlar, özündə bir class-dırlar, bu səbəbdən attribute yaradarkən aşağıdakı qanunlara uyğun bir şəkiləd yaratmaq lazımdır. <br>
      Bir class-ın attribute ola bilməsi üçün, həmin class-ın Attribute classında miras almalıdır. Həmçinin yaratdığımız attributun harada istifadə edə biləcəyimizi “AttributeUseage” ilə müəyyən edirik. Məsələn, bu attribut metodlar və ya class-larda istifadə ediləcək/
    </p>

  <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/0a2c268f-9b19-4f3c-b74d-2c4109eaa5a8" style="width: 600px;" alt="">

  </div>

  <p>
      Həmçinin attributte class-lar yaradarkən class-ların adının sonuna “Attribute” yazılması məsləhət görüləndir, amma məcburi deyil.
  </p>

  <h1>Yaradılmış Bir Attributu Necə İstifadəsi</h1>
    <p>
      Yaratdığımız attributu istifadə edə bilmək üçün uyğun yerlərdə, yəni biz attributu yaradarkən istifadə yerlərini bəyan etdiyimiz yerlərdə, çağırmalıyıq.
    </p>

  <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/6054da97-5605-415b-8c5a-1c9930eb7745" style="width: 600px;" alt="">

  </div>

  <p>
      Bu şəkildə çağırıb istifadə edə bilərik. Həmçinin Attribute yazısını da atıb istifadə edə bilərik. 
      <br>
      Görüldüyü kimi attributları [] mötərizə vasitəsilə istifadə edirik. Bəs attributun içərisinədki member-ları necə əldə etməli?
      <br>
      Attribute, bir class olduğu üçün strukturuna əsasən içərisində property, method member-ları saxlaya bilər. <strong>Bizlər attributların istifadəsində sadəcə propertyləri istifadə edə bilirik.</strong>
      <br>
      Əgər attribut class-ının constructor-u yoxdursa, bu halda attributu bəyan edərkən () (mötərizə) qoymağımıza ehtiyac yoxdur, əks təqdirdə isə lazımdır.
      <br>
      Bu property-ləri də aşağıdakı kimi əldə edirik.
    </p>


   <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/f6b4c9c3-ff07-45fe-9eda-48606af2adbe" style="width: 600px;" alt="">
    </div>

  <p>Bu şəkildə bəyan edə bilirik. Yaxud attributun constructor-undan da dəyər ötürə bilərik.</p>

  <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/f8dc64bc-a9f5-4120-b73e-488ba181da89" style="width: 600px;" alt="">
    </div>
    <p>Bu şəkildə bir istifadə edə bilərik.</p>


  <h1>Attributların Əhatə Dairəsi və Dəyər Vermə</h1>

  <p>
      Attributlar, sadəcə bəyan edildikləri əhatə dairəsi içərisində çalışırlar. Məsələn, bir attribute bir class-ın strukturuna təsir edə bilər, lakin bir metoda təsir edə bilməz. Təbii ki, biz bu attributla işarələnmiş class içərisindəki metodlara reflection ilə gedib xüsusi bir əməliyyat etmiriksə.
      <br>
      Həmçinin class səviyyəsində istifadə edilən attributlar, o class-ın içərisində sadəcə constant struktulara daxil ola bilər.
      <br>
      <strong>
        Attributun property-lərinə dəyəri, bu attributun istifadə ediləcəyi classın içərisindən göndərmək istərsək, bu zaman class-ın içərisindəki memebr “const” bir member olmalıdır.
      </strong>
    </p>


  <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/ad2ed719-bc02-4720-8dae-54a333539104" style="width: 600px;" alt="">
    </div>

  <h1>Assembly Level Attributes | ‘assembly: n’</h1>

  <p>
      Attributları istifadə edərkən compile səviyyəsində də çalışmalar edə bilərik. Attributlar runtime-da çalışan struktulardır. Bizlər bir strukturun attributla işarələnib işarələnmədiyini run time-da kontrol edərik. Bizlər attributları istifadə edərək compile timde-da da müəyyən əməliyyatlar edə bilərik. Bunun üçün Assembly.cs faylında 
      <br>
      <strong>[assembly: … attribute…] </strong> şəklində bir şey yazmaq kifayyətdir.
    </p>
    <p>
      Bu tərzdə bir istifadə nəticəsində adətən compile və deploy zamanı təsirli olacaq ümumi ayarları və özəllikləri müəyyən edə bilər və compile zamanına aid metadatalara müdaxilə edə bilərik.
      <br>
      <strong>Bəs Compile zamanı bu tərzdə müdaxiləyə niyə ehtiyacımız olsun?</strong>
      <br>
      Yazdığımız kodun compile zamanı Assembly versiyasını, ad və açıqlamasını, uyğun olacaq əməliyyat sistemi versiyasını, culture-ini və.s. kimi metadata məlumatlarını özəlləşdirmək və özümüzə görə müəyyən etmək istəyə bilərik. Məzh belə hallarda belə bir bəyanatdan istifadə edə bilərik.
    </p>


  <h1>Bir Attribute İlə İşarələnmiş Class-ların Reflection İlə Əldə Edilməsi</h1>


   <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/51fe4184-4c44-487a-b050-ebc983d1e880" style="width: 600px;" alt="">
    </div>

  <p>
      Yuxarıdakı koda nəzər salsaq, mən istəyirəm ki, “TestAttribute” ilə işarələnmiş class-ları əldə edim və bu attributda bu class-lar üzərindən verilmiş dəyəri konsola yazıdırım.
      <br>
      Bu zaman aşağıdakı kimi bir Assembly kodu yazıram
    </p>

  <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/662c1e71-1a13-4169-8f43-60ba52b53844" style="width: 600px;" alt="">
    
  </div>
    Bu kodun nəticəsi isə aşağıdajı kimidir.
    <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/0e572d27-cb0e-4cbe-8be3-7506988febd6" style="width: 600px;" alt="">    
  </div>

  <p>
      Görüldüyü kimi hansı class-lar “TestAttribute” ilə işarələnibsə o class-ları mənə döndərdir.
      <br>
Bundan əlavə attribute dəyərini yazacaq olsaq, aşağıdakı kimi edərik.
    </p>

  <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/3f56e875-17d5-4258-8b32-aba90eb67d12" style="width: 600px;" alt="">

  </div>


  <h1>Generic Attributes</h1>
    <p>
      Attributlar C# 11-dən sonra generic olaraq da yazıla bilər. Daha öncə bu problemi type class-ı ilə həll edilirdi. İndi isə generic bir şəkildə yazaraq həll etmək mümkündür.
    </p>

  <div style="width: 600px;">
      <img src="https://github.com/user-attachments/assets/675871f2-70f1-46c0-a15e-af7c87d9a32b" style="width: 600px;" alt="">
    </div>

  <p>Generic attributları istifadə edərkən aşağıdakı sərhədlərə diqqət etməliyik</p>

  <ul>
      <li>Generic parametrə generic tip verilməz!
        <br>
        <div style="width: 300px;">
          <img src="https://github.com/user-attachments/assets/cce435e3-f28f-458c-a616-3c255b3f8121" style="width: 300px;" alt="">

  </div>
  </li>
  <li>
        Dynamic, string?, (int? float? Və.s. kimi deyil) və tuple dəyərlər verə bilmərik. 
  </li>
  </ul>

  </body>
