<template>

  <div>
       <div id="app" class="container">
            <h1>Registro</h1>
            
                <label for="nombre">Nombre:</label>
                    <input type="text" name="nombre" id="nombre" class="form-control" v-model="paciente.Nombre">
                          
                <br><label for="nombre">Apellidos:</label>
                    <input type="text" name="apellidos" id="apellidos" class="form-control" v-model="paciente.Apellidos">

                <br><label for="nombre">Fecha de Nacimiento:</label>
                    <input type="date" name="fecha" id="fecha" class="form-control" v-model="paciente.Fecha">

                <br><label for="nombre">Sexo:</label>
                
                <div>
                     <input type="radio" name="season" value="Masculino" v-model="paciente.sexo">Masculino
                     <input type="radio" name="season" value="Femenino" v-model="paciente.sexo">Femenino
                </div>
         
                <br><label for="nombre">Email:</label>
                    <input type="email" name="email" id="email" class="form-control" v-model="paciente.Email">

                <br><label for="nombre">Telefono:</label>
                    <input type="text" name="telefono" id="telefono" class="form-control" v-model="paciente.Telefono">
                
                <br><label for="nombre">Seguro:</label>
                    <input type="text" name="seguro" id="seguro" class="form-control" v-model="paciente.Seguro">
                
                <br><label for="nombre">Direccion:</label>
                    <input type="text" name="direccion" id="direccion" class="form-control" v-model="paciente.Direccion">

                <br><label for="nombre">Sintomas:</label>
                    <input type="text" name="sintomas" id="sintomas" class="form-control" v-model="paciente.Sintomas">

                <br><label for="nombre">Seleccione una Imagen:</label>
                    <input type="file" ref="file" id="imagen" class="file" v-on:change="handleFileUpload()">
        
                    <div>
                    <center> 
                        <button type="button" class="btn" v-bind:class="[agregando ? 'btn-primary' : 'btn-warning']" v-on:click="agregar">{{textoBoton}}</button>
                    </center>
                    </div>
                
            

        </div>

    </div>

</template>

<script>
import axios from "axios";


export default {
  name: "EditarRegistro",
  created: function() {
    this.cargar();
  },

  data: function() {
    return {
      pacientes: [],

      paciente: {
        Cedula: this.$session.get('Cedula'),
        Pass: this.$session.get('Pass'),
        Nombre: this.$session.get('Nombre'),
        Apellidos: this.$session.get('Apellidos'),
        Fecha: this.$session.get('Fecha'),
        Email: this.$session.get('Email1'),
        sexo: this.$session.get('sexo'),
        Telefono: this.$session.get('Telefono'),
        Seguro:this.$session.get('Seguro'),
        Direccion:this.$session.get('Direccion'),
        Sintomas:this.$session.get('Sintomas'),
        Usuario: "paciente"
      },
      textoBoton: "Editar",
      agregando: true,
      pacienteID: this.$session.get('id')
    }
  },

  methods: {
      agregar: function() {
      axios
          .put("http://localhost:55313/api/Pacientes/Put/"+this.pacienteID, this.paciente)
          .then(response => {
            this.cargar();
            this.pacienteID = "";
            this.paciente.Cedula = "";
            this.paciente.Nombre = "";
            this.paciente.Apellidos = "";
            this.paciente.Fecha = "";
            this.paciente.Pass = "";
            this.paciente.Email = "";
            this.paciente.sexo = "";
            this.paciente.Telefono = "";
            this.paciente.Celular = "";
            this.paciente.Seguro = "";
            this.paciente.Direccion = "";
            this.paciente.Sintomas = "";
            this.textoBoton = "Agregar";
            this.agregando = true;
          })
      
          .catch(error => {
            alert("Error interno: " + error.toString());
          });
    },
    handleFileUpload(){
          this.file = this.$refs.file.files[0];
        },

             cargar: function() {
        axios
            .get("http://localhost:55313/api/Medicos/Get")
            .then(response => {
            this.medicos = response.data;
            })
            .catch(error => {
            alert("Error interno: " + error.toString());
            });
        },
  }

}
</script>

<style>
h1,
h2 {
  font-weight: normal;
}

</style>