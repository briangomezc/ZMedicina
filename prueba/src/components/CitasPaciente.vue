<template>

  <div>
       <div id="app" class="container">
            <h1>Citas</h1>
            
            <div class="form-group">
                
                    <label for="nombre">Fecha:</label>
                    <input type="datetime-local" name="fecha" id="fecha" class="form-control" v-model="cita.Fecha">

                
                <br><label for="nombre">Tipo de cita:</label>
                    <input type="text" name="tipo" id="tipo" class="form-control" v-model="cita.Tipo">

                <br>

                <label for="nombre">Medico:</label>
                <select class="form-control" data-style="btn-primary" v-model="cita.MedicoID">
                  <option :value="medico.medicoID" v-for="medico in medicos" v-bind:key="medico.medicoID">{{medico.nombre}}</option>
                </select>

                <br/>
                <br/>

                <label for="nombre">Paciente:</label>
                <select class="form-control" data-style="btn-primary" v-model="cita.PacienteID">
                  <option v-bind:value="this.$session.get('id')">{{this.$session.get('Nombre')}}</option>
                </select>
                
                <br>
                <br>

                <br/>
                    <button type="button" class="btn" v-bind:class="[agregando ? 'btn-primary' : 'btn-warning']" v-on:click="agregar">{{textoBoton}}</button>
                <br>
                <br>
                <br>

              <table class="table mt-5">
                <thead class="thead-dark">
                    <tr>
                        
                        <th>Fecha</th>
                        <th>Tipo de Cita</th>
                        <th>Acción</th>

                    </tr>
                </thead>
                <tbody>
                    <tr v-for="cita in citas" v-bind:key='cita.citaID'>
                        
                       
                        <td>{{cita.fecha}}</td>
                        <td>{{cita.tipo}}</td>

                        <td>
                            <button class="btn btn-info" v-on:click="ver(cita.citaID)">Ver</button>
                            <button class="btn btn-danger" v-on:click="borrar(cita.citaID)">Borrar</button>
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



export default {
  name: "CitasPaciente",
  created: function() {
    this.cargar();
    this.cargarMedicos();
    this.cargarPacientes();
  },

  data: function() {
    return {
      citas: [],

      cita: {
        Fecha: "",
        Tipo:"",
        MedicoID: "",
        PacienteID: ""
      },
      textoBoton: "Agregar",
      agregando: true,
      citaID: "",

      medicos: [],
      pacientes: []
    }
  },

  methods: {
    agregar: function() {
      if (this.citaID == "") {
        axios
          .post("http://localhost:55313/api/Citas/Post", this.cita)
          .then(response => {
            this.cargar();
            this.cita.Fecha = "";
            this.cita.Tipo = "";
            this.cita.MedicoID = "";
            this.cita.PacienteID = "";
          })
          .catch(error => {
            alert("Error interno: " + error.toString());
          });
      } else {
        axios
          .put("http://localhost:55313/api/Citas/Put/"+this.citaID, this.cita)
          .then(response => {
            this.cargar();
            this.citaID = "";
            this.cita.Fecha = "";
            this.cita.Tipo = "";
            this.cita.MedicoID = "";
            this.cita.PacienteID = "";
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
        .get("http://localhost:55313/api/Citas/CitaPaciente/" +  this.$session.get('id'))
        .then(response => {
          this.citas = response.data;
        })
        .catch(error => {
          alert("Error interno: " + error.toString());
        });
    },

    borrar: function(id) {
      axios
        .delete("http://localhost:55313/api/Citas/Delete/" + id)
        .then(response => {
          this.cargar();
          this.citaID = "";
          this.cita.Fecha = "";
          this.cita.Tipo = "";
          this.cita.MedicoID ="";
          this.cita.PacienteID = "";
          this.textoBoton = "Agregar";
          this.agregando = true;
        })
        .catch(error => {
          alert("Error interno: " + error.toString());
        });
    },

    ver: function(id) {
      axios
        .get("http://localhost:55313/api/Citas/Get/" + id)
        .then(response => {
          this.citaID = id;
          this.cita.Fecha = response.data.fecha;
          this.cita.Tipo = response.data.tipo;
          this.cita.MedicoID = response.data.medicoID;
          this.cita.PacienteID = response.data.pacienteID;
          this.textoBoton = "Editar";
          this.agregando = false;
        })
        .catch(error => {
          alert("Error interno: " + error.toString());
        });
    },

    cargarMedicos: function() {
      axios
        .get("http://localhost:55313/api/Medicos/Get")
        .then(response => {
          this.medicos = response.data;
        })
        .catch(error => {
          alert("Error interno: " + error.toString());
        });
    },

    cargarPacientes: function() {
      axios
        .get("http://localhost:55313/api/Pacientes/Get")
        .then(response => {
          this.pacientes = response.data;
        })
        .catch(error => {
          alert("Error interno: " + error.toString());
        });
    }
  }
}
</script>

<style-scope>
h1,
h2 {
  font-weight: normal;
}
</style>
