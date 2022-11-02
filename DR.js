const url = "http://localhost:5164/api/Records"
//const url = "https://anbo-restcarswithmanager.azurewebsites.net/api/cars"

// Change to another REST url to check it's availability (CORS etc)

Vue.createApp({
    data() {
        return {
            records: []
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
    }
}).mount("#app")