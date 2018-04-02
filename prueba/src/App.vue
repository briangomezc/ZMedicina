<template>
  <div id="app">
    
      <div class="docs-wrapper">
            <!--Sidebar item function-->
            <!--Sidebar sub-item function-->
            <!--Here goes the sidebar structure-->
            <div id="left-navbar" data-spy="affix" data-offset-top="0" class="left-sidebar">
              <!--Sidebar top content-->
              <div class="left-sidebar__logo"><img src="./assets/img/logo2.png" height="100px" width="100px"></div>
              <ul class="nav left-sidebar__elements">
                      
                  <li>   
                     <router-link to="/">Home</router-link>
                  </li>

                  <li v-if=" this.$session.get('usuario') == 'admin'">   
                     <router-link to="/CrudPaciente">Paciente</router-link>
                  </li>

                  <li v-if=" this.$session.get('usuario') == 'admin'">
                      <router-link to="/CrudMedico">Medico</router-link>
                  </li>

                   <li v-if=" this.$session.get('usuario') == 'medico' || this.$session.get('usuario') == 'admin'">
                      <router-link to="/HistorialMedico">Historial Medico</router-link>
                  </li>

                  <li v-if=" this.$session.get('usuario') == 'admin'">
                      <router-link to="/RegistroMedico">Registro Medico</router-link>
                  </li>

                  <li v-if=" this.$session.get('usuario') == 'paciente' || this.$session.get('usuario') == 'admin'"> 
                      <router-link to="/EditarRegistro">Editar Registro</router-link>
                  </li>
                  
                  <li v-if=" this.$session.get('usuario') == 'paciente' || this.$session.get('usuario') == 'admin'"> 
                      <router-link to="/Citas">Citas</router-link>
                  </li>
                  
                  <li  v-if=" ! this.$session.exists()" >
                     <router-link to="/Login">Login</router-link> 
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
      <div class="docs-content">
        <div id="general">
         
        


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
</style>