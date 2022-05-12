<template>
		<div class="card" style="padding:10px;height:auto">			
            <h3 class="text-center"><b>Featured Ads</b></h3>
            <div v-for="s in slides.slice(0,3)" :key="s">
            <br>
            <a href="" class="mt-3">
            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">				  
            <div style="border-radius:10px !important" class="carousel-inner">
            <div class="carousel-item active">
                <div class="d-block w-100">
                    <img :src="s.cover" class="w-100" style="height:250px">
                </div>
                </div>
                <div class="carousel-item">
                    <div class="d-block w-100">
                        <img :src="s.cover" class="w-100" style="height:250px">
                    </div>
                </div>
                <div class="carousel-item">
                    <div class="d-block w-100">
                        <img :src="s.cover" class="w-100" style="height:250px">
                    </div>
                </div>
            </div>
            </div>
            </a>
            </div>
		</div>
</template>
<script>
  export default {
      props: ['slides']
}
</script>
