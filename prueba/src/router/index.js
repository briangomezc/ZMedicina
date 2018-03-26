import Vue from 'vue'
import Router from 'vue-router'
import Index from '@/components/index'
import CrudPaciente from '@/components/CrudPaciente'
import CrudMedico from '@/components/CrudMedico'
import HistorialMedico from '@/components/HistorialMedico'
import Citas from '@/components/Citas'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'index',
      component: Index
    },
    {
      path: '/CrudPaciente',
      name: 'CrudPaciente',
      component: CrudPaciente
    },
    {
      path: '/CrudMedico',
      name: 'CrudMedico',
      component: CrudMedico
    },
    {
      path: '/HistorialMedico',
      name: 'HistorialMedico',
      component: HistorialMedico
    },
    {
      path: '/Citas',
      name: 'Citas',
      component: Citas
    }
  ]
})
