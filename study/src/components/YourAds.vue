<template>
<div class="main-card mb-3 card">
    <div class="card-body">
    <h3 class=""><b>Add ADs :</b></h3>
        <form class="">
            <div class="position-relative row form-group">
                <label for="examplePassword" class="col-sm-2 col-form-label">Title:
                    <i style="color:red">*</i></label>
                <div class="col-sm-10"><input name="password" id="examplePassword" placeholder="Confirm New Passowrd" type="password" class="form-control"></div>
            </div>
            <div class="position-relative row form-group"><label for="exampleText" class="col-sm-2 col-form-label">AD Details:</label>
                <div class="col-sm-10"><textarea name="text" id="exampleText" class="form-control"></textarea></div>
            </div>
            
            <div class="row">
                <div class="col-sm-6">
                    <div class="position-relative row form-group">
                    <div class="col-12 mt-2">
                        <label for="exampleFile" class=" col-form-label">Select Countries:</label>
                    </div>
                    </div>
                    <div class="position-relative row form-group">
                        <div class="col-12 mt-2">
                            <div class="multiselect">
                            <label><input type="checkbox" name="option[]" value="1" /> Option 1</label>
                            <label><input type="checkbox" name="option[]" value="2" /> Option 2</label>
                            <label><input type="checkbox" name="option[]" value="3" /> Option 3</label>
                            <label><input type="checkbox" name="option[]" value="4" /> Option 4</label>
                            <label><input type="checkbox" name="option[]" value="5" /> Option 5</label>
                            <label><input type="checkbox" name="option[]" value="6" /> Option 6</label>
                            <label><input type="checkbox" name="option[]" value="7" /> Option 7</label>
                            </div>
                        </div>
                    </div>
                </div>
                
                <div class="col-sm-6">
                    <div class="position-relative row form-group">
                        <div class="col-12 mt-2">
                            <label for="exampleFile" class=" col-form-label">Select Education Levels:</label>
                        </div>
                    </div>
                    <div class="position-relative row form-group">
                        <div class="col-12 mt-2">
                            <div class="multiselect">
                                <label><input type="checkbox" name="option[]" value="1" />Option 1</label>
                                <label><input type="checkbox" name="option[]" value="2" /> Option 2</label>
                                <label><input type="checkbox" name="option[]" value="3" /> Option 3</label>
                                <label><input type="checkbox" name="option[]" value="4" /> Option 4</label>
                                <label><input type="checkbox" name="option[]" value="5" /> Option 5</label>
                                <label><input type="checkbox" name="option[]" value="6" /> Option 6</label>
                                <label><input type="checkbox" name="option[]" value="7" /> Option 7</label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
            <div class="position-relative row form-group">
                <div class="position-relative row form-group col-12 mt-2"><label for="exampleFile" class="col-sm-12 col-form-label">AD Image:</label>
                    <div class="col-12 mt-2"><input name="file" id="exampleFile" type="file" class="form-control-file "> 
                    </div>
                </div>
            </div>
            
            <div class="position-relative row form-group">
            <div align="center" class="col-sm-12 mt-3">
            <button class="btn btn-primary">Submit</button>
            </div>
            </div>
        </form>
         <Manageads
         :addata="addata" />
</div>
</div>
        
 
</template>
<script>
import Manageads from '@/components/ManageAds'
import AdsData from '@/AdsDatabase.json'
export default {
    data () {
        return {
            addata: AdsData
        }
    },
	components: {
        
        Manageads
  },
    mounted () {
      //this.$root.$on('YourAds')  
    },
}
</script>
