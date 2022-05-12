import { createApp } from 'vue'
import App from './App.vue'
//import App2 from './AppAdmin.vue'
import router from './router'
import axios from 'axios'
import VueRouter from 'vue-router'

const app = createApp(App)
app.use(router)
app.config.globalProperties.axios = axios
app.use(VueRouter)
app.mount('#app')

//const app2 = createApp(App2)
//app2.use(router)
//app2.use(VueRouter)
//app2.mount('#app2')
