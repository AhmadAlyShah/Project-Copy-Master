<template>
<div id="home" >
<!-- START SLIDER SECTION -->
	<div class="tp-banner-container" >
		<div class="tp-banner">
			<ul>
				<!-- SLIDE 1 -->
				<li data-transition="slideup" data-title="Slide One" data-slotamount="1" data-masterspeed="1000" data-delay="10000"  data-saveperformance="off">
					<!-- MAIN IMAGE -->
					<img src="assets/img/bg/slide4.jpg"  alt=""  data-bgposition="center center" data-bgfit="cover" data-bgrepeat="no-repeat">
					<div class="home-slide-overlay"></div> 
					<!-- LAYERS -->
					<!-- LAYER NR. 1 -->
					<div class="tp-caption sft sfb tp-resizeme rs-parallaxlevel-10"
						data-x="left" data-hoffset="0"
						data-y="center" data-voffset="-100"
						data-speed="1000"
						data-start="1000"
						data-endspeed="1200"
						data-easing="easeOutExpo"
						data-splitin="none"
						data-splitout="none"
						data-elementdelay="0.01"
						data-endelementdelay="0.1">
						<div><h2>Our Platform For All Service <br>According To Your Requirement</h2></div>
					</div>
					<!-- LAYER NR. 2 -->
					<div class="tp-caption lfb ltt tp-resizeme rs-parallaxlevel-10"
						data-x="left" data-hoffset="0"
						data-y="center" data-voffset="-10"
						data-speed="1200"
						data-start="1200"
						data-endspeed="1200"
						data-easing="easeOutExpo"
						data-splitin="none"
						data-splitout="none"
						data-elementdelay="0.01"
						data-endelementdelay="0.1">
						<div><p>Providing top-notch services in various locations</p></div>
					</div>
					<!-- LAYER NR. 3 -->
					<div class="tp-caption lfb ltt tp-resizeme rs-parallaxlevel-10"
						data-x="left" data-hoffset="0"
						data-y="center" data-voffset="65"
						data-speed="1400"
						data-start="1400"
						data-endspeed="1200"
						data-easing="easeOutExpo"
						data-splitin="none"
						data-splitout="none"
						data-elementdelay="0.01"
						data-endelementdelay="0.1">
						<div class="search-container3">
							<form class="bar" action="/action_page.php" style="width:auto ">
              <input type="text" placeholder="Search for services" style="height:40px;" name="search2">
              <button type="submit" style="text-align:right; height:40px;"><i class="fa fa-search mr-2"></i></button>
							</form>
						</div>
					</div>
				</li>
				<!-- SLIDE 2 -->
				<li data-transition="slidedown" data-title="Slide One" data-slotamount="1" data-masterspeed="1000" data-delay="10000"  data-saveperformance="off">
					<!-- MAIN IMAGE -->
					<img src="assets/img/bg/slide2.jpg"  alt=""  data-bgposition="center center" data-bgfit="cover" data-bgrepeat="no-repeat">
					<div class="home-slide-overlay"></div> 
					<!-- LAYERS -->
					<!-- LAYER NR. 1 -->
					<div class="tp-caption sft sfb tp-resizeme rs-parallaxlevel-10"
						data-x="left" data-hoffset="0"
						data-y="center" data-voffset="-100"
						data-speed="1000"
						data-start="1000"
						data-endspeed="1200"
						data-easing="easeOutExpo"
						data-splitin="none"
						data-splitout="none"
						data-elementdelay="0.01"
						data-endelementdelay="0.1">
						<div><h2>Bitcoin is better than <br> currency and a big industry</h2></div>
					</div>
					<!-- LAYER NR. 2 -->
					<div class="tp-caption lfb ltt tp-resizeme rs-parallaxlevel-10"
						data-x="left" data-hoffset="0"
						data-y="center" data-voffset="-10"
						data-speed="1200"
						data-start="1200"
						data-endspeed="1200"
						data-easing="easeOutExpo"
						data-splitin="none"
						data-splitout="none"
						data-elementdelay="0.01"
						data-endelementdelay="0.1">
						<div><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod <br> tempor incididunt ut labore et dolore magna aliqua.</p></div>
					</div>
					<!-- LAYER NR. 3 -->
					<div class="tp-caption lfb ltt tp-resizeme rs-parallaxlevel-10"
						data-x="left" data-hoffset="0"
						data-y="center" data-voffset="65"
						data-speed="1400"
						data-start="1400"
						data-endspeed="1200"
						data-easing="easeOutExpo"
						data-splitin="none"
						data-splitout="none"
						data-elementdelay="0.01"
						data-endelementdelay="0.1">
					</div>
				</li>
			</ul>
		</div>
	</div>
	<!-- END SLIDER SECTION  -->
	<Adds :slides="slides" />
	<div class="container-fluid" style="padding:50px">
		<div class="row">
			<div class="col-sm-9" >
				<Form />
			</div>
			<div class="col-sm-3">
			<SideAdds :slides="slides" />
			</div>
		</div>
	</div>
</div>
</template>
<script>
import SliderImg from '@/SliderImages.json'
import Adds from '@/components/CorousalSlide'
import SideAdds from '@/components/SideCorousalSlide'
import Form from '@/components/MainForm'
  export default {
	  props:['toggle'],
	data () {
	return {
		slides: SliderImg
	}
  },
	components: {
	Adds,
	SideAdds,
	Form
	}
}
</script>
