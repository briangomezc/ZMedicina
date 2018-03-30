<template>
  <div id="app">
    
      <div class="docs-wrapper">
            <!--Sidebar item function-->
            <!--Sidebar sub-item function-->
            <!--Here goes the sidebar structure-->
            <div id="left-navbar" data-spy="affix" data-offset-top="0" class="left-sidebar">
              <!--Sidebar top content-->
              <div class="left-sidebar__logo"><img src="./assets/img/logo2.png" height="150px" width="150px"></div>
              <ul class="nav left-sidebar__elements">
                      
                  <li>   
                     <router-link to="/index">Home</router-link>
                  </li>

                  <li>   
                     <router-link to="/CrudPaciente">Paciente</router-link>
                  </li>

                  <li>
                      <router-link to="/CrudMedico">Medico</router-link>
                  </li>

                   <li>
                      <router-link to="/HistorialMedico">Historial Medico</router-link>
                  </li>

                  <li>
                      <router-link to="/RegistroMedico">Registro Medico</router-link>
                  </li>
                  
                  <li> 
                      <router-link to="/Citas">Citas</router-link>
                  </li>
                  
                  <br>

                  <li>
                     <router-link to="/Login">Login</router-link> 
                  </li>
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
  name: 'App'
}
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
</style>