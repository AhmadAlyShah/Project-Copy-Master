<template>
  <div id="app">
    <header class="main-header header-2">
      <!-- START TOP AREA -->
      <div class="top-area">
        <div class="auto-container">
          <div class="row">
            
            <div class="col-lg-9 col-md-12 col-sm-12 col-12">
              <div class="info-menu">
                <ul>
                  <li class="social-header"><a href="#"><i style="color:#1ea1f3" class="icofont icofont-social-facebook"></i></a></li>
                  <li class="social-header"><a href="#"><i style="color:#1ea1f3" class="icofont icofont-social-twitter"></i></a></li>
                  <li class="social-header"><a href="#"><i style="color:#1ea1f3" class="icofont icofont-social-youtube"></i></a></li>
                </ul>
              </div>
            </div>
            <!-- end col -->
            <div  class="col-lg-3 col-md-12 col-sm-12 col-12">
              <div class="info-menu">
                <ul>
                  <li><button data-toggle="modal" data-target="#myModal"  style="color:#1ea1f3" class="icofont icofont-login"> Log in </button></li>
                  <li><button data-toggle="modal" data-target="#myModal1" style="color:#1ea1f3" class="icofont icofont-user-alt-5"> Sign Up </button></li>
                </ul>
              </div>
            </div> 
            <!-- end col -->
          </div>
        </div>
      </div>
     
      <!-- END TOP AREA -->
      <!-- START LOGO AREA -->
      <div class="logo-area">
        <div class="auto-container">
          <div class="row">
            <div class="col-lg-4 col-md-3 col-sm-6 col-7 mx-auto pl-0 mb-lg-0 mb-5">
              <div class="logo">
                <a href="index-2.html">
                <img class="img-fluid" src="assets/img/logo.png" alt="">
                </a>
              </div>
            </div>
            <!-- end col -->
            <div class="col-lg-8 col-md-12 col-sm-12 col-12">
              <div class="header-info-box">
                              <div class="header-info-icon">
                  <i style="color:#1ea1f3" class="fa fa-envelope-open"></i>
                </div>
                <p>Email Us</p>
                              <h6>info@yoursite.com</h6>
                          </div>
              <div class="header-info-box">
                              <div class="header-info-icon">
                  <i style="color:#1ea1f3" class="icofont icofont-phone"></i>
                </div>
                <p>Call Us</p>
                              <h6>123-456-0975</h6>
                          </div>
              <div class="header-info-box">
                              <div class="header-info-icon">
                  <i style="color:#1ea1f3" class="icofont icofont-pin"></i>
                </div>
                <p>Door Open</p>
                              <h6>Mon to Sat: 9AM to 5PM</h6>                          
                          </div>
            </div>
            <!-- end col -->
          </div>
        </div>
      </div>
      <!-- END LOGO AREA -->
      <!-- START NAVIGATION AREA -->
      <div class="sticky-menu" style="index:0">
        <div class="mainmenu-area">
          <div class="auto-container">
            <div class="row">
              <div class="col-lg-12 d-none d-lg-block d-md-none">
                <nav class="navbar navbar-expand-lg justify-content-left">
                  <ul class="navbar-nav">
                    <li><router-link to="/" class="nav-link">Home</router-link></li>
                    <li><a href="contact.html" class="nav-link">News</a></li>
                    <li><a href="contact.html" class="nav-link">Scholorship</a></li>
                    <li><a href="contact.html" class="nav-link">Universities</a></li>
                    <li><a href="contact.html" class="nav-link">Consultants</a></li>
                    <li><a href="contact.html" class="nav-link">Guide</a></li>
                    <li><a href="contact.html" class="nav-link">Embassy</a></li>
                    <li><a href="contact.html" class="nav-link">Courses</a></li>
                    <li><a href="contact.html" class="nav-link">Tests</a></li>
                    <li><a href="contact.html" class="nav-link">FAQs</a></li>
                    <li><a href="contact.html" class="nav-link">Study Ads</a></li>
                    <li><a href="contact.html" class="nav-link">Videos</a></li>
                  </ul>
                </nav>
              </div>
            </div>
          </div>
        </div>
      </div>
      <!-- END NAVIGATION AREA -->	
    </header>
    <!--login toggle -->
    <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
      <!-- Modal content-->
      <div class="modal-content" style="padding:10px">
        <div class="modal-header" style="border:none;height:45px">
          <h4 class="modal-title" style="float:left">Sign in / Sign up</h4>
          <button type="button" class="close" data-dismiss="modal">&times;</button>
        </div>
        <div class="modal-body">
		  <h5>Email</h5>
		  					<div class="input-group mb-3 mt-4" style=";box-shadow:0 2px 5px 1px #403c4329;">
						<input type="text"  v-model="email" class="form-control" placeholder="Email Address" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
					</div>
		  <h5>Password</h5>
		  					<div class="input-group mb-3 mt-4" style=";box-shadow:0 2px 5px 1px #403c4329;">
						<input type="password" v-model="password" class="form-control" placeholder="Email Password" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
					</div>
        </div>
        <div class="" style="border:none;"><center>
			<button v-on:click="logedIn" style="background-color: #1EA1F3;color:white;padding:10px 70px;border-radius: 10px;width:70%" class="btn mt-4 mb-4">Continue</button>
        </center></div>
      </div>
      
    </div>
  </div>
  <!--Signup toggle -->
  <div class="modal fade" id="myModal1" role="dialog">
    <div class="modal-dialog">
      <!-- Modal content-->
      <div class="modal-content" style="padding:10px">
          <div class="modal-header" style="border:none;height:45px">
            <h4 class="modal-title" style="float:left"> Sign up</h4>
            <button type="button" class="close" data-dismiss="modal">&times;</button>
          </div>
          <div class="modal-body">
            <div class="row mt-2 mb-2">
            <div v-on:click="Onchange($event)" :key="value" class="col-sm-6 mt-2 mb-2 float-left" >
            <input  type="radio"  id="html" name="fav_language" class="float-left" value="1">
            <label for="Student"><b>Student</b></label>
            </div>
            <div v-on:click="Onchange($event)" :key="value"  class="col-sm-6 mt-2 mb-2 float-left" >
            <input type="radio" id="html"  name="fav_language" class="float-left" value="2">
            <label for="Student"><b>Consultant</b></label>
            </div>
            <div v-on:click="Onchange($event)" :key="value" class="col-sm-12 mt-2 mb-2 float-left" >
            <input type="radio" id="html"  name="fav_language" class="float-left" value="3">
            <label for="Student"><b>University / College</b></label>
            </div>
            </div>
            <h6 class="float-left">Full Name</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input type="text" v-model="fullname" class="form-control" placeholder="Enter Name" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
            <h6 class="float-left">Email</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input type="text" v-model="email" class="form-control" placeholder="Email Address" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
            <h6 class="float-left">Contact Number</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input type="text" v-model="phone" class="form-control" placeholder="Enter Contact" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
            <h6 class="float-left">Password</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input type="text" v-model="password" class="form-control" placeholder="Enter Password" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
            <h6 class="float-left">Confirm Password</h6>
            <div class="input-group mb-3 mt-1" style="box-shadow:0 2px 5px 1px #403c4329;">
              <input  type="text" v-model="confirmpassword" class="form-control" placeholder="Re-enter Password" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
            </div>
          </div>
          <div class="center" style="border:none;">
            <button v-on:click="Signup"  style="background-color: #1EA1F3;color:white;padding:10px 70px;border-radius: 10px;width:70%" class="btn mt-4 mb-4">Continue</button>
          </div>
      </div>
    </div>
  </div>
     
    
    
  </div>
  <router-view :email="email" />
</template>
<script>
  export default {
  components: {
  },
  data () {
    return {
      value: "",
      fullname: "",
      email: "",
      phone: "",
      password: "",
      confirmpassword: "",
      CompanyName: "",
      Conatctno: "",
      institutename: "",
      Contactno: ""
    }
  },
  methods: {
    logedIn () {
      console.log(this.email)
      console.log(this.password)
      //this.$router.push('/admin')
      this.axios.get('http://localhost:63616/api/verify_login/' + this.email + '/' +  this.password)
              .then((response) => {
                if(response.data == "2")
                {
                  
                  this.$router.push({path: '/admin'});
                }
                else if(response.data == "1")
                {
                    this.$router.push({path: '/student'});
                }
                else if(response.data == "3")
                {
                  this.$router.push({path: '/insti'});
                }
                else{
                    alert(response.data)
                }
                 })
    },
    Onchange (event) {
      this.value = event.target.value
      console.log(this.value)
    },
    Signup () {
      if ( this.value == '1') {
          this.axios.post('http://localhost:63616/api/studentinfo/', {
          fullname: this.fullname,
          email: this.email,
          phone: this.phone,
          password: this.password
        })
          .then((response) => {
            alert(response.data)
          })

        this.axios.post('http://localhost:63616/api/verify_login/', {
          value: this.value,
          email: this.email,
          password: this.password
        })
          .then((response) => {
            alert(response.data)
          })

      }
      else if (this.value == '2') {
        this.Conatctno = this.phone
        console.log(this.Conatctno)
        this.axios.post('http://localhost:63616/api/Consultantinfo/', {
        CompanyName: this.fullname,
        email: this.email,
        Conatctno: this.Conatctno,
        password: this.password
      })
        .then((response) => {
          alert(response.data)
        })

      this.axios.post('http://localhost:63616/api/verify_login/', {
        value: this.value,
        email: this.email,
        password: this.password
      })
        .then((response) => {
          alert(response.data)
        })
      }
      else if (this.value == '3') {
        this.institutename = this.fullname
        this.Contactno = this.phone
        console.log(this.Contactno)
        this.axios.post('http://localhost:63616/api/Instituteinfo/', {
        institutename: this.institutename,
        email: this.email,
        Contactno: this.Contactno,
        password: this.password
      })
        .then((response) => {
          alert(response.data)
        })

      this.axios.post('http://localhost:63616/api/verify_login/', {
        value: this.value,
        email: this.email,
        password: this.password
      })
        .then((response) => {
          alert(response.data)
        })
      }
      else {
        console.log("Please Select Something")
      }
    }
  },
  mounted () {
  }
}
</script>
<style>
</style>
