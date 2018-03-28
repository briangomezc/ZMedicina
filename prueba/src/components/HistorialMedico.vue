<template>

  <div>
       <div id="app" class="container">
            <h1>Historial Medico</h1>
            
            <div class="form-group">

                    <label for="nombre">Nombre:</label>
                    <input type="text" name="nombre" id="nombre" class="form-control" v-model="historial.Nombre">

                <br><label for="nombre">Apellidos:</label>
                    <input type="text" name="apellidos" id="apellidos" class="form-control" v-model="historial.Apellidos">

                <br><label for="nombre">Cedula:</label>
                    <input type="text" name="cedula" id="cedula" class="form-control" v-model="historial.Cedula">

                <br><label for="nombre">Edad:</label>
                    <input type="text" name="edad" id="edad" class="form-control" v-model="historial.Edad">

                <br><label for="nombre">Sexo:</label>
                    <input type="text" name="sexo" id="sexo" class="form-control" v-model="historial.sexo">
                
                <br><label for="nombre">Seguro:</label>
                    <input type="text" name="seguro" id="seguro" class="form-control" v-model="historial.Seguro">
                
                <br><label for="nombre">Ocupacion:</label>
                    <input type="text" name="ocupacion" id="ocupacion" class="form-control" v-model="historial.Ocupacion">

                <br><label for="nombre">Telefono:</label>
                    <input type="text" name="telefono" id="telefono" class="form-control" v-model="historial.Telefono">

                <br><label for="nombre">Celular:</label>
                    <input type="text" name="celular" id="celular" class="form-control" v-model="historial.Celular">

                <br><label for="nombre">Direccion:</label>
                    <input type="text" name="direccion" id="direccion" class="form-control" v-model="historial.Direccion">

                <br><label for="nombre">Sintomas:</label>
                    <input type="text" name="sintomas" id="sintomas" class="form-control" v-model="historial.Sintomas">

                <br><label for="nombre">Antecedentes:</label>
                    <input type="text" name="antecedentes" id="antecedentes" class="form-control" v-model="historial.Antecedentes">
              
                <br/>
                    <button type="button" class="btn" v-bind:class="[agregando ? 'btn-primary' : 'btn-warning']" v-on:click="agregar">{{textoBoton}}</button>
                <br>

                <table class="table mt-5">
                <thead class="thead-dark">
                    <tr>
                        
                        <th>Id</th>
                        <th>Nombre</th>
                        <th>Apellidos</th>
                        <th>Cedula</th>
                        <th>Edad</th>
                        <th>Sexo</th>
                        <th>Seguro</th>
                        <th>Ocupacion</th>
                        <th>Telefono</th>
                        <th>Celular</th>
                        <th>Direccion</th>
                        <th>Sintomas</th>
                        <th>Antecedentes</th>
                        <th>Acción</th>

                    </tr>
                </thead>
                <tbody>
                    <tr v-for="historial in historiales" v-bind:key='historial.historialID'>
                        <td>{{historial.historialID}}</td>
                        <td>{{historial.nombre}}</td>
                        <td>{{historial.apellidos}}</td>
                        <td>{{historial.cedula}}</td>
                        <td>{{historial.edad}}</td>
                        <td>{{historial.sexo}}</td>
                        <td>{{historial.seguro}}</td>
                        <td>{{historial.ocupacion}}</td>
                        <td>{{historial.telefono}}</td>
                        <td>{{historial.celular}}</td>
                        <td>{{historial.direccion}}</td>
                        <td>{{historial.sintomas}}</td>
                        <td>{{historial.antecedentes}}</td>
                        <td>
                            <button class="btn btn-info" v-on:click="ver(historial.historialID)">Ver</button>
                            <button class="btn btn-danger" v-on:click="borrar(historial.historialID)">Borrar</button>
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
  name: "HistorialMedico",
  created: function() {
    this.cargar();
},

data: function() {
    return {
      historiales: [],

      historial: {
        Nombre: "",
        Apellidos: "",
        Cedula: "",
        Edad: "",
        sexo: "",
        Seguro:"",
        Ocupacion:"",
        Telefono: "",
        Celular: "",
        Direccion:"",
        Sintomas:"",
        Antecedentes:""
      },
      textoBoton: "Agregar",
      agregando: true,
      historialID: ""
    }
  },

methods: {
    agregar: function() {
      if (this.historialID == "") {
        axios
          .post("http://localhost:55313/api/Historials/Post", this.historial)
          .then(response => {
            this.cargar();
            this.historial.Nombre = "";
            this.historial.Apellidos = "";
            this.historial.Cedula = "";
            this.historial.Edad = "";
            this.historial.sexo = "";
            this.historial.Seguro = "";
            this.historial.Ocupacion = "";
            this.historial.Telefono = "";
            this.historial.Celular = "";
            this.historial.Direccion = "";
            this.historial.Sintomas = "";
            this.historial.Antecedentes = "";
          })
          .catch(error => {
            alert("Error interno: " + error.toString());
          });
      } else {
        axios
          .put("http://localhost:55313/api/Historials/Put/"+this.historialID, this.historial)
          .then(response => {
            this.cargar();
            this.historial.Nombre = "";
            this.historial.Apellidos = "";
            this.historial.Cedula = "";
            this.historial.Edad = "";
            this.historial.sexo = "";
            this.historial.Seguro = "";
            this.historial.Ocupacion = "";
            this.historial.Telefono = "";
            this.historial.Celular = "";
            this.historial.Direccion = "";
            this.historial.Sintomas = "";
            this.historial.Antecedentes = "";
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
        .get("http://localhost:55313/api/Historials/Get")
        .then(response => {
          this.historiales = response.data;
        })
        .catch(error => {
          alert("Error interno: " + error.toString());
        });
    },

    borrar: function(id) {
      axios
        .delete("http://localhost:55313/api/Historials/Delete/" + id)
        .then(response => {
          this.cargar();
          this.historial.Nombre = "";
          this.historial.Apellidos = "";
          this.historial.Cedula = "";
          this.historial.Edad = "";
          this.historial.sexo = "";
          this.historial.Seguro = "";
          this.historial.Ocupacion = "";
          this.historial.Telefono = "";
          this.historial.Celular = "";
          this.historial.Direccion = "";
          this.historial.Sintomas = "";
          this.historial.Antecedentes = "";
          this.textoBoton = "Agregar";
          this.agregando = true;
        })
        .catch(error => {
          alert("Error interno: " + error.toString());
        });
    },

    ver: function(id) {
      axios
        .get("http://localhost:55313/api/Historials/Get/" + id)
        .then(response => {
          this.historialID = id;
          this.historial.Nombre = response.data.nombre;
          this.historial.Apellidos = response.data.apellidos;
          this.historial.Cedula = response.data.cedula;
          this.historial.Edad = response.data.edad;
          this.historial.sexo = response.data.sexo;
          this.historial.Seguro = response.data.seguro;
          this.historial.Ocupacion = response.data.ocupacion;
          this.historial.Telefono = response.data.telefono;
          this.historial.Celular = response.data.celular;
          this.historial.Direccion = response.data.direccion;
          this.historial.Sintomas = response.data.sintomas;
          this.historial.Antecedentes = response.data.antecedentes;
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
