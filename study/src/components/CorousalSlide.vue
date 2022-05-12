<template>
    <div class="pt-5" style="text-align: center;background-color:white">
        <div class="container-fluid" style="padding-left:50px;padding-right:50px">
            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <div class="d-block w-100">
                        <img src="image/Group 9455.png" width="100%">
                    </div>
                </div>
                <div class="carousel-item">
                    <div class="d-block w-100">
                        <img src="image/Group 9455.png" width="100%">
                    </div>
                </div>
                <div class="carousel-item">
                    <div class="d-block w-100">
                        <img src="image/Group 9455.png" width="100%">
                    </div>
                </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container-fluid mt-2" style="padding:0px 50px">
    <div class="row">
        <div
        v-for="slide in slides.slice(0,3)" :key="slide"
        class="col-sm-4 mt-2" >
            <a href="">
                <div
                id="carouselExampleIndicators"
                class="carousel slide"
                data-ride="carousel">
                    <div class="carousel-inner" style="border-radius:10px">
                        <div class="carousel-item active">
                            <div class="d-block w-100">
                                <img :src="slide.cover" class="w-100">
                            </div>
                        </div>
                        <div class="carousel-item">
                            <div class="d-block w-100">
                                <img :src="slide.cover" class="w-100" >
                            </div>
                        </div>
                        <div class="carousel-item">
                            <div class="d-block w-100">
                                <img :src="slide.cover" class="w-100">
                            </div>
                        </div>
                    </div>
                </div>
            </a>
        </div>
    </div>
    </div>
</template>
<script>
  export default {
      props: ['slides']
}
</script>
