<template>  
      <div class="docs-content">
        <div id="general">
      
          <div id="app">
    
      <div class="docs-wrapper">
            <!--Sidebar item function-->
            <!--Sidebar sub-item function-->
            <!--Here goes the sidebar structure-->
            <div id="left-navbar" data-spy="affix" data-offset-top="0" class="left-sidebar">
              <!--Sidebar top content-->
              <div class="left-sidebar__logo"><img src="./assets/img/logo2.png" height="100px" width="100px"></div>
              
              <ul>
                  <h3 id= LetraRoja>Zmedicina</h3>
                
                 
                  <li type="circle">    
                     <router-link to="/" id= Letra>Home</router-link>
                  </li>

                  <li type="circle" v-if=" this.$session.get('usuario') == 'admin'">   
                     <router-link to="/CrudPaciente" id= Letra>Paciente</router-link>
                  </li>

                  <li type="circle" v-if=" this.$session.get('usuario') == 'admin'">
                      <router-link to="/CrudMedico" id= Letra>Medico</router-link>
                  </li>

                   <li type="circle" v-if="this.$session.get('usuario') == 'admin'">
                      <router-link to="/HistorialMedico" id= Letra>Historial Medico</router-link>
                  </li>

                  <li type="circle" v-if=" this.$session.get('usuario') == 'medico' || this.$session.get('usuario') == 'admin'">
                      <router-link to="/Historial" id= Letra>Historial</router-link>
                  </li>

                  <li type="circle" v-if=" this.$session.get('usuario') == 'admin'">
                      <router-link to="/RegistroMedico" id= Letra>Registro Medico</router-link>
                  </li>

                  <li type="circle" v-if=" this.$session.get('usuario') == 'paciente' || this.$session.get('usuario') == 'admin'"> 
                      <router-link to="/EditarRegistro" id= Letra>Editar Registro</router-link>
                  </li>
                  
                  <li type="circle" v-if="this.$session.get('usuario') == 'admin'"> 
                      <router-link to="/Citas" id= Letra>Citas del Paciente</router-link>
                  </li>

                  <li type="circle" v-if=" this.$session.get('usuario') == 'medico' || this.$session.get('usuario') == 'admin'"> 
                      <router-link to="/CitasMedico" id= Letra>Citas del Medico</router-link>
                  </li>

                   <li type="circle" v-if=" this.$session.get('usuario') == 'paciente' || this.$session.get('usuario') == 'admin'"> 
                      <router-link to="/CitasPaciente" id= Letra>Citas</router-link>
                  </li>
                  
                  <li type="circle" v-if=" ! this.$session.exists()" >
                     <router-link to="/Login" id= Letra>Login</router-link> 
                  </li>

                  <div id="Letra"  v-if=" this.$session.exists()">
                     
                      <img  v-bind:src="this.$session.get('Foto')"  width="50px" alt="" style="border-radius: 100%;">
                      
                    {{ this.$session.get('Nombre') }} 
                    {{ this.$session.get('Apellidos') }}
                    
                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">

                    
  
                  <button type="button" class="btn btn-danger" v-on:click="cerrarSesion()">cerrar Sesion</button> 
                  </a>
                  </div>

              </ul>
              <!--Sidebar bottom content-->
            </div>

         <router-view></router-view>

      </div>
    </div>

  </div>
  </div>
</template>


<script>

export default {
  name: "App",
  data: function() {
    return {
      
    };
  },
  methods: {
   
    cerrarSesion: function() {
      this.$session.destroy();
      this.$router.push("/login");
    }
  },
  mounted: function() {
    this.fetchArticles();
  }
};
</script>

<style>
input[type=text], input[type=password] {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
}
#Letra{
    color:white;
}
#LetraRoja{
    color:rgb(248, 8, 8);
}

::-webkit-scrollbar-track
{
	-webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.3);
	border-radius: 10px;
	background-color: #F5F5F5;
}

::-webkit-scrollbar
{
	width: 12px;
	background-color: #F5F5F5;
}

::-webkit-scrollbar-thumb
{
	border-radius: 10px;
	-webkit-box-shadow: inset 0 0 6px rgba(0,0,0,.3);
	background-color: rgb(17, 17, 17);
}
</style>