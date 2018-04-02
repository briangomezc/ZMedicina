<template>


 <div class=slider>
   <ul>
     <li><img src="../assets/img/wallpaper.wiki-HD-Wallpapers-1920x1080-PIC-WPE0014149.jpg" alt=""></li>
     <li><img src="../assets/img/Nv2k6sl.jpg" alt=""></li>
     <li><img src="../assets/img/865109.jpg" alt=""></li>
     <li><img src="../assets/img/perfect-hd-wallpapers-for-desktop-1920x1080-7.jpg" alt=""></li>
     
   </ul>

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
.slider{
  width: 95%;
  margin: auto;
  overflow: hidden;
}

.slider ul {
  display: flex;
  padding: 0;
  width: 200%;

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


</style>
