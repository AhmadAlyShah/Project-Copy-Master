<template>
<div>
    <div class="col-md-12 col-lg-12">
        <div class="main-card mb-3 card">
            <div class="card-body">
                <h5 class="card-title">Search Filter</h5>
                    <div class="row">
                        <div class="col-md-4">
                            <div @change="onChange($event)" :key="key1" class="position-relative form-group"><label for="exampleCustomSelect" class="">FIND STUDENT EDU LEVEL</label><select type="select" id="exampleCustomSelect" name="customSelect" class="custom-select">
                            <option value="">Select</option>
                            <option value="1">Value 1</option>
                            <option value="2">Value 2</option>
                            <option value="3">Value 3</option>
                            <option value="4">Value 4</option>
                            <option value="5">Value 5</option>
                            </select>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div @change="onChangess($event)" :key="key2" class="position-relative form-group"><label for="exampleCustomSelect" class="">LIVING IN</label><select type="select" id="exampleCustomSelect" name="customSelect" class="custom-select">
                            <option value="">Select</option>
                            <option value="1">Value 1</option>
                            <option value="2">Value 2</option>
                            <option value="3">Value 3</option>
                            <option value="4">Value 4</option>
                            <option value="5">Value 5</option>
                            </select>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div @change="onChangesss($event)" :key="key3" class="position-relative form-group"><label for="exampleCustomSelect" class="">INTERESTED IN COUNTRY</label><select type="select" id="exampleCustomSelect" name="customSelect" class="custom-select">
                            <option value="">Select</option>
                            <option value="1">Value 1</option>
                            <option value="2">Value 2</option>
                            <option value="3">Value 3</option>
                            <option value="4">Value 4</option>
                            <option value="5">Value 5</option>
                            </select>
                            </div>
                        </div>
                    </div>
                <div class="text-center mt-2">
                    <button class="mb-2 mr-2 btn btn-success"><i class="pe-7s-search"> </i> Search
                    </button>
                </div>
            </div>
        </div>
    </div>
    <div class="col-md-12 col-lg-12">
        <div class="main-card mb-3 card">
            <div class="card-header">Student Info
            </div>
            <div class="table-responsive">
                <table class="align-middle mb-0 table table-borderless table-striped table-hover">
                    <thead>
                        <tr>
                        <th class="text-center">Date</th>
                        <th>Student Name</th>
                        <th class="text-center">Current Qualification</th>
                        <th class="text-center">Want To Study</th>
                        <th class="text-center">City</th>
                        <th class="text-center">Interested Countries</th>
                        <th class="text-center">Verified</th>
                        <th class="text-center">View</th>
                        <th class="text-center">Delete</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="(lead) in leads" :key="lead.id">
                            <td class="text-center text-muted">{{lead.date}}</td>
                            <td  class="text-center">{{lead.stuname}}</td>
                            <td  class="text-center">{{lead.currentqual}}</td>
                            <td  class="text-center">{{lead.wantstudy}}</td>
                            <td  class="text-center">{{lead.city}}</td>
                            <td  class="text-center"><img class="w-40" :src="lead.interestcountry" alt=""></td>
                            <td class="text-center">
                            <div  class="badge badge-warning">{{lead.verified}}</div>
                            </td>
                            <td class="text-center">
                            <div class="font-icon-wrapper"><i class="pe-7s-search"> </i></div>
                            </td>
                            <td class="text-center">
                            <div class="font-icon-wrapper"><i class="pe-7s-trash"> </i></div>
                            </td>
                        </tr>
                    </tbody>
                </table>        
            </div>
            <nav class="mt-4 ml-4 pb-4" aria-label="Page navigation example">
            <ul class="pagination">
            <li class="page-item"><a href="javascript:void(0);" class="page-link" aria-label="Previous"><span aria-hidden="true">«</span><span class="sr-only">Previous</span></a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link">1</a></li>
            <li class="page-item active"><a href="javascript:void(0);" class="page-link">2</a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link">3</a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link">4</a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link">5</a></li>
            <li class="page-item"><a href="javascript:void(0);" class="page-link" aria-label="Next"><span aria-hidden="true">»</span><span class="sr-only">Next</span></a></li>
            </ul>
            </nav>
        </div>
    </div>
</div>
</template>
<script>
export default {
    props: ['toggle','leads'],
    data () {
        return {
            key1: "",
            key2: "",
            key3: "",
            key1value: "",
            key2value: "",
            key3value: ""   
        }
    },
    methods: {
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
        onChangesss(event) {
            this.key3value=event.target.value
            console.log(event.target.value)
            console.log("key 3:")
            console.log(this.key3value)
        }
    }
}
</script>
