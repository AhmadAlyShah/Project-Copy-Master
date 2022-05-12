import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import Ads from '../components/YourAds.vue'
//import MyProfile from '../components/MyProfile.vue'
//import ComProfile from '../components/CompanyProfile.vue'
import Admins from '../views/AdminView.vue'
const routes = [
  {
    path: '/',
    name: '/',
    component: HomeView
  },
  {
    path: '/admin',
    name: '/admin',
    component: Admins
  },
  {
    path: '/ads',
    name: '/ads',
    component: Ads
  }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes,
})

export default router
