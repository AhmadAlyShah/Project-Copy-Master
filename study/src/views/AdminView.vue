<template>
<div >
  <div class="container-fluid" style="padding:50px;">
    <div class="row">
		<div class="col-sm-3 mt-2">
        <div class="card" style="padding:20px">
            <div class="app-sidebar__inner">
            <img src="image/Capture-1.PNG" class="center mb-3 h-100 w-100"  style="border-radius:50%;center;">
            <ul>
              <li>{{this.email}}</li>
            </ul>
            <ul class="vertical-nav-menu">
            <li class="app-sidebar__heading text-center">Dashboards</li>
            <li>
            <button @click="togglebar1" class="metismenu-icon fa fa-user">
            My Profile
            </button>
            </li>
            <li>
            <button  @click="togglebar2" class="metismenu-icon fa fa-building-o">
            Company Profile
            </button>
            </li>
            <li>
            <button @click="togglebar3" class="metismenu-icon fa fa-key">
            Change Password
            </button>
            </li>
            <li>
            <button  @click="togglebar4" class="metismenu-icon fa fa-users">
            Student Database
            </button>
            </li>
            <li>
            <button @click="togglebar5" class="metismenu-icon fa fa-plus">
            <i ></i>
            Add Ads Manage Ads
            </button>
            </li>
            <li>
            <button @click="togglebar6" class="metismenu-icon fas fa-edit">
           
            Manage Ads
            </button>
            </li>
            </ul>
		</div>
        </div>
        </div>
    <div class="col-sm-9 mt-2">
    <div class="app-main__inner"> 
      <div>
      <Myprofile 
            v-if="showmy"
             :toggle="togglebar1"
             :leads="leads" />
    <Comprofile
            v-if="showcom"
            :toggle="togglebar2"
            :emailsession="emailsession"  />
    <ChangePas
             v-if="showpass"
            :toggle="togglebar3" />
    <Studentdb
             v-if="showstudb"
            :toggle="togglebar4"
            :leads="leads" />
    <Yourads
             v-if="showads"
            :toggle="togglebar5" />
    <Manageads
             v-if="showmanageads"
            :toggle="togglebar6"
             />
      </div>
      </div>
      </div>
    </div>
    </div>
  </div> 
</template>
<script>
import dataleads from '@/LeadDatabase.json'
import Myprofile from '@/components/MyProfile'
import Comprofile from '@/components/CompanyProfile'
import ChangePas from '@/components/ChangePass'
import Studentdb from '@/components/StudentDatabase'
import Yourads from '@/components/YourAds'
import Manageads from '@/components/ManageAds'
export default {
  props: ['email'],
  data () {
    return {
      showmy: false,
      showcom: true,
      showpass: false,
      showstudb: false,
      showads: false,
      showmanageads: false,
      leads: dataleads,
      emailsession: []
     
    }
  },
  computed: {
  },
	components: {
        Myprofile,
        Comprofile,
        ChangePas,
        Studentdb,
        Yourads,
        Manageads
  },
  mounted () {
    this.axios.get('http://localhost:63616/api/Consultantinfo/GetbyEmail/'+ this.email)
        .then((response) => {
          this.emailsession = response.data
          console.log(this.emailsession.data)
        })

        
  },
  methods: {
    togglebar1 () {
      this.showcom=false
      this.showstudb=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showmy=true
      console.log("my prfile open")
      console.log(this.showmy)
    },
    togglebar2 () {
      this.showmy=false
      this.showstudb=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showcom=true
      console.log("my companyprfile open")
      console.log(this.showmy)
      
    },
    togglebar3 () {
      this.showmy=false
      this.showcom=false
      this.showstudb=false
      this.showads=false
      this.showmanageads=false
      this.showpass=true
      console.log("my changepass open")
      console.log(this.showmy)
      
    },
    togglebar4 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showads=false
      this.showmanageads=false
      this.showstudb=true
      console.log("studb open")
      console.log(this.showmy)
      
    },
    togglebar5 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showmanageads=false
      this.showads=true
      console.log("your adss open")
      console.log(this.showads)
      
    },
    togglebar6 () {
      this.showmy=false
      this.showcom=false
      this.showpass=false
      this.showstudb=false
      this.showads=false
      this.showmanageads=true
      console.log("manage ads open")
      console.log(this.showmanageads)
      
    }
  }
}
</script>
