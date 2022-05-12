<template>
    <div class="col-md-12 col-lg-12">
        <div class="main-card mb-3 card">
            <div class="card-body">
                <div class="app-main__inner">
                    <form class="">
                        <div  v-for="d in emailsession" :key="d" >
                    <h3 style="color:Blue"><b>Company Details</b></h3>
                    <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">Company Name:<i style="color:red">*</i></label>
                        <div class="col-sm-10"><input v-model="d.CompanyName" placeholder="Enter Company Name" class="form-control" required></div>
                    </div>
                    <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">Contact Person Name:<i style="color:red">*</i></label>
                        <div class="col-sm-10"><input v-model="d.Personname" placeholder="Enter Contact Person Name" class="form-control" required></div>
                    </div>
                    <div class="position-relative row form-group"><label for="exampleEmail" class="col-sm-2 col-form-label">Email:<i style="color:red">*</i></label>
                        <div class="col-sm-10"><input v-model="d.Email" name="email" id="exampleEmail" placeholder="Enter Email" type="email" class="form-control" required></div>
                    </div>
                    <div class="position-relative row form-group"><label for="examplePassword" class="col-sm-2 col-form-label">City:<i style="color:red">*</i></label>
                        <div class="col-sm-10"><input v-model="d.City" placeholder="Enter City" class="form-control" required></div>
                    </div>
                    <div class="position-relative row form-group"><label for="exampleSelect" class="col-sm-2 col-form-label">address:<i style="color:red">*</i></label>
                        <div class="col-sm-10"><input v-model="d.Address" placeholder="Enter Address" class="form-control" required></div>
                    </div>
                    <div class="position-relative row form-group"><label for="exampleSelectMulti" class="col-sm-2 col-form-label mt-2">Official number:<i style="color:red">*</i></label>
                        <div class="col-sm-10"><input v-model="d.Conatctno" placeholder="Enter official Number"  class="form-control" required>
                        </div>
                    </div>
                    <div class="position-relative row form-group"><label for="exampleSelectMulti" class="col-sm-2 col-form-label mt-2">Mobile#:<i style="color:red">*</i></label>
                        <div class="col-sm-10"><input v-model="d.Phoneno" placeholder="Enter Mobile#"  class="form-control" required>
                        </div>
                    </div>
                    <div class="position-relative row form-group"><label for="exampleSelectMulti" class="col-sm-2 col-form-label mt-2">Website:<i style="color:red">*</i></label>
                        <div class="col-sm-10"><input v-model="d.websitelink" placeholder="Enter Website" class="form-control" required>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-6 mt-2">
                            <h3 style="color:blue">Select countries for which you provide services:</h3>
                        </div>
                        <div class="col-6 mt-2">
                            <h3 style="color:blue ">Select services provided:</h3>
                        </div>
                        <div class="col-6 mt-2">
                            <div @change="onChange($event)" :key="key1" class="multiselect">
                            <label><input type="checkbox" name="option[]" value="1" />Option 1</label>
                            <label><input type="checkbox" name="option[]" value="2" />Option 2</label>
                            <label><input type="checkbox" name="option[]" value="3" />Option 3</label>
                            <label><input type="checkbox" name="option[]" value="4" />Option 4</label>
                            <label><input type="checkbox" name="option[]" value="5" />Option 5</label>
                            <label><input type="checkbox" name="option[]" value="6" />Option 6</label>
                            <label><input type="checkbox" name="option[]" value="7" />Option 7</label>
                            </div>
                        </div>
                        <div class="col-6 mt-2">
                            <div @change="onChangess($event)" :key="key2" class="multiselect">
                            <label><input type="checkbox" name="option[]" value="1" />Option 1</label>
                            <label><input type="checkbox" name="option[]" value="2" />Option 2</label>
                            <label><input type="checkbox" name="option[]" value="3" />Option 3</label>
                            <label><input type="checkbox" name="option[]" value="4" />Option 4</label>
                            <label><input type="checkbox" name="option[]" value="5" />Option 5</label>
                            <label><input type="checkbox" name="option[]" value="6" />Option 6</label>
                            <label><input type="checkbox" name="option[]" value="7" />Option 7</label>
                            </div>
                        </div>
                    </div>
                    <div class="mt-2" >
                        <h3 style="color:blue">Company's Biography:</h3>
                        <textarea v-model="d.Detail" style="width:100%">
                        </textarea>
                    </div>
                    <div class=" mt-2">
                        <div id="gmap-example"></div>
                    </div>
                    <div class="position-relative row form-group mt-2"><label for="exampleFile" class="col-sm-2 col-form-label" style="color:blue">Upload Your Company Logo(Size must not exceed 81px x 81px):</label>
                        <img src="assets/images/avatars/4.jpg" height="100px" width="100px"/>
                        <div class="col-sm-10"><input name="file" ref="fileInput" accept="image/*" @change="onFilePicked" id="exampleFile" type="file" class="form-control-file">
                        </div>
                    </div>
                    <div align="center" class="mt-4 col-sm-12">
                        <button class="btn btn-secondary">Update Data</button>
                    </div>
                    </div>
                    </form>
                </div>
            </div>
        </div>
 </div>
</template>
<script>
export default {
    props: ['toggle','emailsession'],
    data () {
        return {
            companyname: this.emailsession.CompanyName,
            personname: "",
            email: "",
            city: "",
            address: "",
            officenumber: "",
            mobilenumber: "",
            weblink: "",
            text: "",
            key1: "",
            key1value: "",
            key2: "",
            key2value: "",
            image: null
        }
    },
    mounted () {
        console.log(this.emailsession)
    },
    methods: {
        SaveCompanyInfo() {
            console.log("HELLO")    
        },
        onChange(event) {
            this.key1value=event.target.value
            console.log(event.target.value)
            console.log("key 1:")
            console.log(this.key1value)
        },
        onChangess(event) {
            this.key2value=event.target.value
            console.log(event.target.value)
            console.log("key 2:")
            console.log(this.key2value)
        },
        onPickFile () {
                this.$refs.fileInput.click()
        },
        onFilePicked (event) {
        const files = event.target.files
        //let filename = files[0].name
        const fileReader = new FileReader()
        fileReader.addEventListener('load', () => {
            this.imageUrl = fileReader.result
        })
        fileReader.readAsDataURL(files[0])
        this.image = files[0]
        console.log( this.image)
        }
    }
}
</script>