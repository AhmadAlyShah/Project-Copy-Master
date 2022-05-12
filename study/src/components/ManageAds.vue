<template>
    <div class="row">
        <div class="col-md-12">
            <div class="main-card mb-3 card">
                <div class="card-header">Manage your Ads
                    <div class="btn-actions-pane-right">
                    </div>
                </div>
                <div class="table-responsive">
                    <table class="align-middle mb-0 table table-borderless table-striped table-hover">
                    <thead>
                        <tr>
                        <th class="text-center">Date</th>
                        <th class="text-center">Title</th>
                        <th class="text-center">Edit</th>
                        <th class="text-center">Delete</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="s in addata.slice(0,3)" :key="s">
                            <td class="text-center text-muted">{{s.date}}</td>
                            <td class="text-center">{{s.title}}</td>
                            <td class="text-center">
                                <button  type="button" id="PopoverCustomT-1" class="btn btn-primary btn-sm"><i class="fa fa-edit"> </i> Edit</button>
                            </td>
                            <td class="text-center">
                                <button type="button" id="PopoverCustomT-1" class="btn btn-primary btn-sm  bg-danger"><i class="pe-7s-trash"> </i> Delete</button>
                            </td>
                        </tr>
                        
                    </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
//import Ads from './YourAds'
export default {
    props:['toggle','addata'],
    Data () {
        return{
            
        }
        
    },
    components: {
   // Ads        
    },
    
    methods: {
      edit () {
          this.$router.push('/ads')
      }
    }
}
</script>