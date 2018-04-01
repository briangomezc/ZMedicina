<template>
<div>
    <div class="imgcontainer">
    <img src="img_avatar2.png" alt="Avatar" class="avatar">
  </div>

  <div class="container">
    <form v-on:submit.prevent="validacion">
    <label for="uname"><b>Cedula</b></label>
    <input type="text" placeholder="Entre su Cedula" name="uname" required v-model="Paciente.Cedula">

    <label for="psw"><b>Password</b></label>
    <input type="password" placeholder="Entre su Password" name="psw" required v-model="Paciente.Pass">
    <center>
    <input type="submit">
    </center>
    </form>
  </div>

  <center>
  <div class="login-help">
    <router-link to="/RegistroMedico">Registrar</router-link>
  </div>
  </center>

</div>

</template>

<script>
import axios from "axios";
export default {
  name: "Login",

  data: function(){
        return{
        Paciente  :  {Cedula : '', Pass : ''},
        }
},
  methods:{
      validacion : function(){
          axios.post('http://localhost:55313/api/Pacientes/Login',this.Paciente )
          .then(response =>{
              if (response.data !=null){
                  swal("Bienvenido", '', 'success');
                 this.Paciente = response.data;//el metodo me devuelve el usuario logeado , lo guardo aqui

                  //Inicio la sesion y lleno la sesion con los datos del usuario
                  this.$session.start(),
                  this.$session.set('id',response.data.PacienteID)
                  this.$session.set('Nombre',response.data.Nombre)
                  this.$session.set('Cedula',response.data.Cedula)
                  this.$session.set('Pass',response.data.Pass)
                  this.$router.push('/')//redirecciona al index
              }else{
                  swal("Cedula o Password incorrectos", '', 'error');
              }
          } )
      }
  }

}

</script>


<style scoped>

/* Bordered form */
form {
    border: 3px solid #f1f1f1;
}

/* Full-width inputs */
input[type=text], input[type=password] {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
}

/* Set a style for all buttons */
button {
    background-color: rgb(31, 30, 30);
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
}

/* Add a hover effect for buttons */
button:hover {
    opacity: 0.8;
}

/* Extra style for the cancel button (red) */
.cancelbtn {
    width: auto;
    padding: 10px 18px;
    background-color: #f44336;
}

/* Center the avatar image inside this container */
.imgcontainer {
    text-align: center;
    margin: 24px 0 12px 0;
}

/* Avatar image */
img.avatar {
    width: 40%;
    border-radius: 50%;
}

/* Add padding to containers */
.container {
    padding: 16px;
}

/* The "Forgot password" text */
span.psw {
    float: right;
    padding-top: 16px;
}

/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
    span.psw {
        display: block;
        float: none;
    }
    .cancelbtn {
        width: 100%;
    }
}
</style>