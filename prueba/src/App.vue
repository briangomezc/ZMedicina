<template>
  <div id="app">
    
      <div class="docs-wrapper">
            <!--Sidebar item function-->
            <!--Sidebar sub-item function-->
            <!--Here goes the sidebar structure-->
            <div id="left-navbar" data-spy="affix" data-offset-top="0" class="left-sidebar">
              <!--Sidebar top content-->
              <div class="left-sidebar__logo"><img src="/assets/img/logo.png" alt="logo" height="27px" width="102px"></div>
              <ul class="nav left-sidebar__elements">
                      
                  <li>   
                     <router-link to="/CrudPaciente">Paciente</router-link>
                  </li>
                  <li>
                      <a href="#getting_started">Medico</a>
                  </li>
                  <li>
                      <a href="#plugins">Citas</a>
                  </li>
                  <li>
                      <a href="#support">Support</a>
                  </li>
                  <li>
                      <a href="#changelog">Login</a>
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
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
