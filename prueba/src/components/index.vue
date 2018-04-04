<template>

 <div class=slider>
    <ul>
      <li><img src="../assets/img/wallpaper.wiki-HD-Wallpapers-1920x1080-PIC-WPE0014149.jpg" alt=""></li>
      <li><img src="../assets/img/Nv2k6sl.jpg" alt=""></li>
      <li><img src="../assets/img/865109.jpg" alt=""></li>
      <li><img src="../assets/img/perfect-hd-wallpapers-for-desktop-1920x1080-7.jpg" alt=""></li>
      <li><img src="../assets/img/35005.jpg" alt=""></li>
      <li><img src="../assets/img/IMG_186805.jpg" alt=""></li>
      <li><img src="../assets/img/IMG_186793.jpg" alt=""></li>
      <li><img src="../assets/img/IMG_186774.jpg" alt=""></li>
      
    </ul>

    <div id="izquierda">
      <div>
      <h3>Lípidos o grasas</h3>
      <p>
        <img src="../assets/img/comida-sana-vegetales-10245-1024x640.jpg" alt="">
        La grasa se encuentra debajo de la piel, sirviendo como reserva de energía, produciendo más del doble de energía que la liberada por 
        proteínas e hidratos de carbono. También actúa como aislamiento contra el frío y forma un tejido de soporte de muchos órganos, 
        protegiéndolos a la vez de golpes, como ocurre con los riñones.<br><br>
        ¿Quieres seguir leyendo mas de este contenido?<br>
        <a href="https://www.webconsultas.com/dieta-y-nutricion/dieta-equilibrada/macronutrientes/los-lipidos-o-grasas-1808">Ver más</a>
      </p>
      </div>

    </div>

    <div id="derecha">
      <div>
        <h3>La importancia de cuidar la salud</h3>
        <p>
          <img src="../assets/img/ejercicio fisico.jpg" alt="">
          Cuidar nuestra salud debe ser una prioridad durante cualquier etapa de nuestra vida. Esto nos ayudará a tener una calidad de vida excelente en todos los 
          niveles y edades. Por ello, hablaremos de la importancia de cuidar la salud.
        </p>

        <p>
        ¿Quieres seguir leyendo mas de este contenido?<br>
        <a href="https://www.salud.mapfre.es/cuerpo-y-mente/habitos-saludables/la-importancia-de-cuidar-la-salud/">Ver más</a>
      </p>
      </div>

    </div>

    <div id="Iabajo">
      <div>
        <br><h3>¿Sabías que?</h3>
        <p>
          El cuerpo humano es una máquina abrumadora. Contiene tal cantidad de información que solo hemos podido descubrir una ínfima parte. 
          Pero conocerse es la mejor medicina que existe. Por eso, hoy queremos compartir con vosotros unas cuantas curiosidades del cuerpo 
          humano que podrán ayudaros a comprender mejor muchas de las cosas que suceden en vuestro organismo.
            <ol>
            <li>
              ¿Sabías que el cuerpo humano es aproximadamente un 40% de tejido muscular? El 60% restante es tejido adiposo, óseo, piel, órganos y vísceras.
            </li><br>
           
            </ol>
        </p>

      </div>
    </div>
    <div id="Dabajo">
      <h3>Medicina Natural y Tradicional</h3>
      <p>
        <img src="../assets/img/corazon.jpg" alt="">
        La Medicina Natural y Tradicional (MNT), cuyas raíces se nutren de miles de años de conocimiento, es ampliamente reconocida hoy por su efectividad en países 
        desarrollados y en vías de desarrollo, como enorme contribución a la salud humana.<br>
        <a href="http://bohemia.cu/salud/2016/12/medicina-natural-y-tradicional-una-alternativa-verde/">Ver más</a>
      </p>
    </div>

  </div>

 

</template>

<script>
export default {
  name: 'index',
  data () {
    return {
      msg: 'Welcome to Your Vue.js App'
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
div{
  width: 80%;
  height: 150%;
  border: 1px solid white;

}
.slider{
  width: 95%;
  margin: auto;
  overflow: hidden;
}

.slider ul {
  display: flex;
  padding: 0;
  width: 400%;

  animation: cambio 20s infinite;
}

.slider li{
  width: 100%;
  list-style: none;
}
.slider img {
  width: 100%;
}

@keyframes cambio{
  0%{margin-left: 0;}
  20%{margin-left: 0;}

  25%{margin-left: -100%;}
  45%{margin-left: -100%;}

  50%{margin-left: -200%;}
  70%{margin-left: -200%;}

  75%{margin-left:  0;}
  100%{margin-left: 0;}
}
#lista {
  margin: 0;
}
p {
  font-size: 15px;
   font-style: 15px;
}
div#izquierda{
  width: 600px;
  height: 600px;
  float: left;
 
}
div#centro{
  width: 0px;
}
div#derecha{
  width: 600px;
  height: 600px;
  float: left;
}
div#Iabajo{
  width: 600px;
  height: 600px;
  float: left;

}
div#Dabajo{
  width: 600px;
  height: 600px;
  float: left;
}
</style>
