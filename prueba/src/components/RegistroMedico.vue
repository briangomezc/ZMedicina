<template>

  <div>
       <div id="app" class="container">
            <h1>Registro</h1>
            
            <p>Registro de Usuario.</p>
            
            <hr>

            <div class="form-group">
                <label for="nombre">Cedula:</label>
                    <input type="text" name="cedula" id="cedula" class="form-control" v-model="paciente.Cedula">

                <br><label for="nombre">Password:</label>
                    <input type="password" name="pass" id="pass" class="form-control" v-model="paciente.Pass">
                
                <br><p>Registro Medico.</p>

                <hr>

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

    </div>

</template>


<script>
import axios from "axios";


export default {
  name: "CrudPaciente",
  created: function() {
    this.cargar();
  },

  data: function() {
    return {
      pacientes: [],

      paciente: {
        Cedula: "",
        Nombre: "",
        Apellidos: "",
        Fecha: "",
        Pass: "",
        Email: "",
        sexo: "",
        Telefono: "",
        Seguro:"",
        Direccion:"",
        Sintomas:"",
        Foto:"",
        Usuario: "paciente"
      },
      textoBoton: "Agregar",
      agregando: true,
      pacienteID: ""
    }
  },

  methods: {
        agregar : function(){
        let formData = new FormData();

              formData.append('file', this.file);
              formData.append('Cedula', this.paciente.Cedula);
              formData.append('Pass', this.paciente.Pass);
              formData.append('Nombre', this.paciente.Nombre);
              formData.append('Apellidos', this.paciente.Apellidos);
              formData.append('Email', this.paciente.Email);
              formData.append('Fecha', this.paciente.Fecha);
              formData.append('sexo', this.paciente.sexo);
              formData.append('Telefono', this.paciente.Telefono);
              formData.append('Direccion', this.paciente.Direccion);
              formData.append('Seguro', this.paciente.Seguro);
              formData.append('Sintomas', this.paciente.Sintomas);
              formData.append('Usuario', this.paciente.Usuario);       

              axios.post('http://localhost:55313/api/Pacientes/Upload',formData ).then(respose =>{
                  if(respose.data != null){
                    swal("Agregado Correctamente", "", "success");
                      
                this.paciente = {
                      Cedula: "",
                      Pass: "",
                      Nombre: "",
                      Apellidos: "",
                      Email: "",
                      Fecha: "",
                      sexo: "",
                      Telefono: "",
                      Direccion: "",
                      Seguro: "",
                      Sintomas: "",
                      Usuario: "",
                      Foto: "",
                      file: "",
                };

                  }else{
                        swal("Algo salio mal", "", "fail");
                  }
              })
              
        },
    handleFileUpload(){
          this.file = this.$refs.file.files[0];
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

       
