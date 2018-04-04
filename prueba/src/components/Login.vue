<template>
<div class="container">
    <div class="row">
        <div class="col-sm-6 col-md-4 col-md-offset-4" >
            <h1 class="text-center login-title">Login</h1>
            <div class="account-wall">
                <img class="profile-img" src="https://lh5.googleusercontent.com/-b0-k99FZlyE/AAAAAAAAAAI/AAAAAAAAAAA/eu7opA4byxI/photo.jpg?sz=120"
                    alt="">
                <form v-on:submit.prevent="Verificar">
                <input type="text" class="form-control" placeholder="Cedula" required autofocus v-model="Usuario.Cedula">
                <input type="password" class="form-control" placeholder="Password" required v-model="Usuario.Pass">
                <div>
                <select class="form-control" data-style="btn-primary" v-model="Selecciona">
                  <option value="Paciente">Paciente</option>
                  <option value="Medico">Medico</option>
                </select>
                </div>
                <br>
                <button class="btn btn-lg btn-primary btn-block" type="submit">
                    Sign in</button>
                </form>
            </div>
            <center>
          <router-link to="/RegistroMedico">Registrar Cuenta</router-link>
            </center>
        </div>
    </div>
</div>

</template>

<script>
import axios from "axios";
export default {
  name: "Login",

  data: function(){
        return{
        Usuario: {Cedula:'',Pass:''},
        Selecciona:'',
        }
       
},
  methods:{
      Verificar: function(){
      if(this.Selecciona == "Paciente"){
          axios.post('http://localhost:55313/api/Pacientes/Login',this.Usuario )
          .then(response =>{
              if (response.data !=null){
                  swal("Bienvenido " + response.data.nombre +' '+ response.data.apellidos,'', 'success');
                 this.Paciente = response.data;

                  this.$session.start(),
                  this.$session.set('id',response.data.pacienteID)
                  this.$session.set('Cedula',response.data.cedula)
                  this.$session.set('Nombre',response.data.nombre)
                  this.$session.set('Apellidos',response.data.apellidos)
                  this.$session.set('Fecha',response.data.fecha)
                  this.$session.set('Pass',response.data.pass) 
                  this.$session.set('Email1',response.data.email) 
                  this.$session.set('sexo',response.data.sexo)
                  this.$session.set('Telefono',response.data.telefono)
                  this.$session.set('Direccion',response.data.direccion)
                  this.$session.set('Seguro',response.data.seguro)
                  this.$session.set('Sintomas',response.data.sintomas)
                  this.$session.set('Foto',response.data.foto)
                  this.$session.set('usuario',response.data.usuario)
                  
                  
                  this.$router.push('/')
              }else{
                  swal("Cedula o Password incorrectos", '', 'error');
              }
          } )
      
    }
    else{
     
          axios.post('http://localhost:55313/api/Medicos/Login',this.Usuario )
          .then(response =>{
              if (response.data !=null){
                  swal("Bienvenido " + response.data.nombre +' '+ response.data.apellidos,'', 'success');
                 this.Medico = response.data;

                  this.$session.start(),
                  this.$session.set('id',response.data.medicoID)
                  this.$session.set('Cedula',response.data.cedula)
                  this.$session.set('Nombre',response.data.nombre)
                  this.$session.set('Apellidos',response.data.apellidos)
                  this.$session.set('Fecha',response.data.fecha)
                  this.$session.set('Pass',response.data.pass) 
                  this.$session.set('Email1',response.data.email) 
                  this.$session.set('sexo',response.data.sexo)
                  this.$session.set('tipo',response.data.tipo)
                  this.$session.set('Especializaciones',response.data.especializaciones)
                  this.$session.set('Telefono',response.data.telefono)
                  this.$session.set('Celular',response.data.celular)
                  this.$session.set('Direccion',response.data.direccion)
                  this.$session.set('Seguro',response.data.seguro)
                  this.$session.set('Sintomas',response.data.sintomas)
                  this.$session.set('Foto',response.data.foto)
                  this.$session.set('usuario',response.data.usuario)
                  
                  
                  this.$router.push('/')
              }else{
                  swal("Cedula o Password incorrectos", '', 'error');
              }
          } )
      
    }
      
    }
  }

}
 
</script>


<style scoped>

.form-signin
{
    max-width: 330px;
    padding: 15px;
    margin: 0 auto;
}
.form-signin .form-signin-heading, .form-signin .checkbox
{
    margin-bottom: 10px;
}
.form-signin .checkbox
{
    font-weight: normal;
}
.form-signin .form-control
{
    position: relative;
    font-size: 16px;
    height: auto;
    padding: 10px;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}
.form-signin .form-control:focus
{
    z-index: 2;
}
.form-signin input[type="text"]
{
    margin-bottom: -1px;
    border-bottom-left-radius: 0;
    border-bottom-right-radius: 0;
}
.form-signin input[type="password"]
{
    margin-bottom: 10px;
    border-top-left-radius: 0;
    border-top-right-radius: 0;
}
.account-wall
{
    margin-top: 20px;
    padding: 40px 0px 20px 0px;
    background-color: #f7f7f7;
    -moz-box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
    -webkit-box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
    box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
}
.login-title
{
    color: #555;
    font-size: 18px;
    font-weight: 400;
    display: block;
}
.profile-img
{
    width: 96px;
    height: 96px;
    margin: 0 auto 10px;
    display: block;
    -moz-border-radius: 50%;
    -webkit-border-radius: 50%;
    border-radius: 50%;
}
.need-help
{
    margin-top: 10px;
}
.new-account
{
    display: block;
    margin-top: 10px;
}
</style>