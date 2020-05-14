# Mökkivarausjärjestelmä 

## Tausta:
Tämä ohjelma on alunperin luotu "Ohjelmistotuotanto 1"- kurssin loppuprojektina. Ohjelma on suunniteltu (kuvitteellisen) Village People Oy:n tarjouspyynnön, vaatimusten, sekä luomamme vaatimus-, ja toiminnallisen määrittelyn pohjalta. Village People Oy tarjoaa asiakkaillensa palvelua, jonka kautta he voivat vuokrata ja asettaa vuokralle mökkejä yrityksen toiminta-alueilla ympäri Suomea.

## Tavoite:
Mökkivarausjärjestelmän tavoitteena on helpottaa toiminta-alueiden, mökkien, asiakkaiden, varausten, palveluiden, sekä laskutuksen hallintaa yrityksen sisällä sähköistämällä nämä palvelut. 

## Käytetyt teknologiat
-  **Päätoiminnallisuus ja logiikka: *C#*** 
-  **Graafinen käyttöliittymä: *Windows forms*** 
-  **Tietokanta: *SQLite***	 
    - Totesimme *SQLite* tietokantajärjestelmän sopivaksi vaihtoehdoksi projektillemme, koska se on kevyt, itsenäinen ja tiedostopohjainen, eikä vaadi erillistä serveriä pyöriäkseen. Tämä myös helpotti huomattavasti projektin toteutusta, koska tietokannan pystyy pakkaamaan mukaan buildiin, eikä sitä tarvitse erikseen hostata. Mikäli kyseessä olisi oikea kaupallinen ohjelmisto, olisimme todennäköisimmin valinneet jonkin tavanomaisemman vaihtoehdon relaatiotietokantajärjestelmäksi. (esimerkiksi *PostgreSQL* tai *MySQL*)
  -  **NuGet paketit**	
      - *System.Data.SQLite.Core* 
          -- Tietokannan projektiin liittäminen.
      - *itext7* 
          -- pdf-tiedostojen luonti.
          
## Ominaisuudet
 - **Toiminta-alueiden hallinta:** 
 Toiminta-alueiden hallinnassa käyttäjä voi tarkastella, lisätä ja poistaa toiminta-alueita, sekä niiden mökkejä tietokannasta. Käyttäjä voi myös siirtyä kyseisen toiminta-alueen raportointiin, missä hän voi tallentaa pdf muodossa raportin toiminta-alueen majoittumisista tai lisäpalveluiden myynnistä valitulla aikavälillä.
 - **Asiakashallinta:** 
 Asiakashallinnassa käyttäjä voi tarkastella, lisätä ja poistaa asiakastietoja tietokannasta, sekä näyttää kyseisen asiakkaan tekemät varaukset.
 - **Varaushallinta:** 
    Varaushallinnassa käyttäjä voi tarkastella, lisätä ja poistaa asiakkaiden varauksia tietokannasta, sekä lisätä valitulle varaukselle lisäpalveluita. Varaushallinnassa käyttäjä voi myös vahvistaa varauksen, jolloin järjestelmä laskee palveluiden, sekä majoittumisen yhteishinnan ja luo automaattisesti laskun.
 - **Palveluhallinta:**
    Palveluhallinnassa käyttäjä voi tarkastella, lisätä sekä poistaa palveluita ja niiden tietoja tietokannasta.
 - **Laskutus:** 
    Laskutuksessa käyttäjä voi tarkastella ja poistaa laskuja tietokannassa. Laskun voi myös tallentaa pdf-muodossa tulostamista varten tai lähettää automaattisesti asiakkaan sähköpostiin.
    
## Kontribuutio
  - Jos haluat osallistua projektin kehitykseen niin forkita repositorio, luo haluamasi lisäykset/korjaukset ja tee pull request.   
  - Mikäli löydät bugin tai muun ongelman ohjelman toiminnasta tee siitä issue, jossa voit antaa pienen kuvauksen ongelmasta.  
  - Voit myös luoda issuen jos on jokin ominaisuus minkä haluaisit nähdä implementoitavan ohjelmaan
Ohjelmasta ja sen koodista löytyy vielä jonkin verran lisättävää, parannettavaa ja bugeja, sillä projekti tehtiin suhteellisen pienessä ja päätavoitteena oli saada tärkeimmät ominaisuudet käyttövalmiiksi.

  - **Mahdollisia parannuksien kohteita**	 
    - Koodin toiston vähentäminen ja muuttaminen uudelleenkäytettäviksi funktioiksi.
    - Virheiden käsittelyä voisi optimoida. 
    - Datagrideihin voisi implementoida tietojen muokkauksen ja päivittämisen tietokantaan.
## Credits
Alkuperäisen projektin on suunnitellut ja toteuttanut "Ohjelmistotuotanto 1"-kurssin projektiryhmämme:
- **Lassi Köykkä, Johannes Tikkanen, Joonas Vaija, Venla Ronkainen, ja Niko Ruotsalainen**
