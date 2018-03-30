<template>

  <div>
       <div id="app" class="container">
            <h1>Paciente</h1>
            
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
        
                    <br/>
                        <button type="button" class="btn" v-bind:class="[agregando ? 'btn-primary' : 'btn-warning']" v-on:click="agregar">{{textoBoton}}</button>
                    <br>
                
                <table class="table mt-5">
                <thead class="thead-dark">
                    <tr>
                        
                        <th>Id</th>
                        <th>Cedula</th>
                        <th>Nombre</th>
                        <th>Apellidos</th>
                        <th>Fecha</th>
                        <th>Password</th>
                        <th>Email</th>
                        <th>Sexo</th>
                        <th>Telefono</th>
                        <th>Seguro</th>
                        <th>Direccion</th>
                        <th>Sintomas</th>
                        <th>Acción</th>

                    </tr>
                </thead>
                <tbody>
                    <tr v-for="paciente in pacientes" v-bind:key='paciente.pacienteID'>
                        <td>{{paciente.pacienteID}}</td>
                        <td>{{paciente.cedula}}</td>
                        <td>{{paciente.nombre}}</td>
                        <td>{{paciente.apellidos}}</td>
                        <td>{{paciente.fecha}}</td>
                        <td>{{paciente.pass}}</td>
                        <td>{{paciente.email}}</td>
                        <td>{{paciente.sexo}}</td>
                        <td>{{paciente.telefono}}</td>
                        <td>{{paciente.seguro}}</td>
                        <td>{{paciente.direccion}}</td>
                        <td>{{paciente.sintomas}}</td>
                        <td>
                            <button class="btn btn-info" v-on:click="ver(paciente.pacienteID)">Ver</button>
                            <button class="btn btn-danger" v-on:click="borrar(paciente.pacienteID)">Borrar</button>
                        </td>
                    </tr>
                </tbody>
            </table>   

                

            </div>

        </div>

    </div>

</template>


<script>
import axios from "axios";
import Vue from 'vue'
import VueSession from 'vue-session'
Vue.use(VueSession)

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
      },
      textoBoton: "Agregar",
      agregando: true,
      pacienteID: ""
    }
  },
  methods: {
    agregar: function() {
      if (this.pacienteID == "") {
        axios
          .post("http://localhost:55313/api/Pacientes/Post", this.paciente)
          .then(response => {
            this.cargar();
            this.paciente.Cedula = "";
            this.paciente.Nombre = "";
            this.paciente.Apellidos = "";
            this.paciente.Fecha = "";
            this.paciente.Pass = "";
            this.paciente.Email = "";
            this.paciente.sexo = "";
            this.paciente.Telefono = "";
            this.paciente.Seguro = "";
            this.paciente.Direccion = "";
            this.paciente.Sintomas = "";
          })
          .catch(error => {
            alert("Error interno: " + error.toString());
          });
      } else {
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
      }
    },

    cargar: function() {
      axios
        .get("http://localhost:55313/api/Pacientes/Get")
        .then(response => {
          this.pacientes = response.data;
        })
        .catch(error => {
          alert("Error interno: " + error.toString());
        });
    },

    borrar: function(id) {
      axios
        .delete("http://localhost:55313/api/Pacientes/Delete/" + id)
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

    ver: function(id) {
      axios
        .get("http://localhost:55313/api/Pacientes/Get/" + id)
        .then(response => {
          this.pacienteID = id;
          this.paciente.Cedula = response.data.cedula;
          this.paciente.Nombre = response.data.nombre;
          this.paciente.Apellidos = response.data.apellidos;
          this.paciente.Fecha = response.data.fecha;
          this.paciente.Pass = response.data.pass;
          this.paciente.Email = response.data.email;
          this.paciente.sexo = response.data.sexo;
          this.paciente.Telefono = response.data.telefono;
          this.paciente.Seguro = response.data.seguro;
          this.paciente.Direccion = response.data.direccion;
          this.paciente.Sintomas = response.data.sintomas;
          this.textoBoton = "Editar";
          this.agregando = false;
        })
        .catch(error => {
          alert("Error interno: " + error.toString());
        });
    }
  }
};
</script>

<style>
h1,
h2 {
  font-weight: normal;
}
</style>






 
