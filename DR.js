const url = "http://localhost:5164/api/Records"
//const url = "https://anbo-restcarswithmanager.azurewebsites.net/api/cars"

// Change to another REST url to check it's availability (CORS etc)

Vue.createApp({
    data() {
        return {
            records: [],
            title1: null
            
        }
    },
    async created() {
        console.log("created")
        try {
            const response = await axios.get(url)
            this.records = response.data
        } catch (error) {
            this.records = error.records
        }
    },
    methods: {      
      filterByRecords(title1){
        console.log("Title: " + title1)
        this.records = this.records.filter(r => r.title.includes(title1))
        console.log("Records: " + this.records)
      },
      async getAll() {
        try {
            console.log(url)
            const response = await axios.get(url)
            this.records = await response.data
            console.log(this.records)
        } catch (ex) {
            alert(ex.message) // https://www.w3schools.com/js/js_popup.asp
        }}
    }
    
}).mount("#app")