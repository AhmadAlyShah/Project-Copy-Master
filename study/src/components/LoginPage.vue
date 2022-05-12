<template>
<div class="text-center">
  <span style="font-size:100px"><i class="fa fa-user"></i></span>
  <h1>Sign in</h1>
</div>
  <div class="col-sm-6 offset-3 mt-4" style="padding:10px;center;">
    <div class="card" style="padding:10px;center;">
    <div class="modal-body" >
        <h5>Email</h5>
        <div class="input-group mb-3 mt-4 " style=";box-shadow:0 2px 5px 1px #403c4329;">
        <input type="text" class="form-control" placeholder="Email Address" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
        </div>
        <h5>Password</h5>
        <div class="input-group mb-3 mt-4" style=";box-shadow:0 2px 5px 1px #403c4329;">
        <input type="password" class="form-control" placeholder="Email Password" style="border:none;height:50px" aria-label="Amount (to the nearest dollar)">
        </div>
        </div>
        <div class="" style="border:none;">
        <router-link  to="/admin">
        <div class="text-center">
        <button @click="toggle" style="background-color: #1EA1F3;color:white;padding:10px 70px;border-radius: 10px;width:70%" class="btn mt-4 mb-4">Continue</button>
        </div>
        </router-link>
        </div>
    </div>
  </div>
    <router-view />
</template>
<script>
export default {
  props: ['toggle'],
  data () {
    return {
    }
  },
	methods: {
    
  }
}
</script>